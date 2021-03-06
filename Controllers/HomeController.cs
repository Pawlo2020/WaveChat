using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WaveChat.Communication;
using WaveChat.Models;

namespace WaveChat.Controllers
{
    public class HomeController : Controller
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://wavechat-617f9.firebaseio.com");
        private readonly UserManager<Areas.Identity.Data.WaveChatUser> _userManager;

        private NotificationMessageHandler _notificationsMessageHandler { get; set; }
        private WaveChatContext _context;
        static ChatModel _chat;
        IDisposable observable;

        public HomeController(WaveChatContext context, UserManager<WaveChat.Areas.Identity.Data.WaveChatUser> userManager, NotificationMessageHandler notificationsMessageHandler)
        {
            _context = context;
            _userManager = userManager;
            _notificationsMessageHandler = notificationsMessageHandler;
        }

        public PartialViewResult SearchContainer(string person)
        {
            _chat.SearchModel.Clear();
            var SearchList = from m in _context.Users select m;
            string First = "";
            string Last = "";
            try
            {
                First = person.Split(' ')[0];
            }
            catch{}

            try
            {
                Last = person.Split(' ')[1];
            }
            catch{}

            if (!string.IsNullOrEmpty(First))
            {
                SearchList = SearchList.Where(x => x.FirstName.Contains(First)).Take(1);
            }

            if (!string.IsNullOrEmpty(Last))
            {
                SearchList = SearchList.Where(x => x.LastName.Contains(Last)).Take(1);
            }

            foreach (var item in SearchList)
            {

                bool status = _notificationsMessageHandler._communicationManager.CheckStatus(item.Id);

                _chat.SearchModel.Add(new Areas.Identity.Data.WaveChatUser() { FirstName = item.FirstName, LastName = item.LastName, Id = item.Id, Status = status });
            }

            return PartialView("SearchContainer", _chat);
        }

        public async void LoadMessages(string ConfGUID, Task<WaveChat.Areas.Identity.Data.WaveChatUser> user)
        {
            _notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).TokenSource = new CancellationTokenSource();

            observable = firebaseClient
               .Child("convs/" + ConfGUID).AsObservable<WaveChat.Models.MessageModel>()
               .Subscribe(d => InstantiateToast(d.Object, user));
            _notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).TokenSource.Token.Register(() => observable.Dispose());

            var messageStack = firebaseClient.Child("convs/" + ConfGUID).OrderByKey().OnceAsync<MessageModel>().Result;
            List<ToastMessage> list = new List<ToastMessage>();

            Stopwatch sw = Stopwatch.StartNew();

            Parallel.ForEach(messageStack, () => new List<ToastMessage>(), (item, pls, localObj) =>
            {
                var first = firebaseClient.Child("users/" + item.Object.GUID).OrderByKey().LimitToFirst(1).OnceAsync<Areas.Identity.Data.FirebaseNameModel>();
                var obj = new ToastMessage
                {
                    Message = item.Object.Message,
                    Timestamp = item.Object.Timestamp,
                    FirstName = first.Result.First().Object.FirstName,
                    LastName = first.Result.First().Object.LastName,
                    //UserID = from m in _context.Users where m.FirebaseGUID.Equals(item.Object.GUID) select m.Id.FirstOrDefault()
                    
                };
                //obj.UserID = _context.Users.Where(x => x.FirebaseGUID.Equals(item.Object.GUID)).AsParallel().Select(m => m.Id).FirstOrDefault();

                var optionsBuilder = new DbContextOptionsBuilder<WaveChatContext>();
                optionsBuilder.UseMySql("server=remotemysql.com;user=jyKYm15Znj;database=jyKYm15Znj;password=EbVGAPF1Wz;port=3306;persistsecurityinfo=True");
                WaveChatContext context = new WaveChatContext(optionsBuilder.Options);
                obj.UserID = context.Users.Where(x => x.FirebaseGUID.Equals(item.Object.GUID)).AsParallel().Select(m => m.Id).FirstOrDefault();

                localObj.Add(obj);
                return localObj;
            },
            localObj =>
            {
                foreach (var result in localObj)
                {
                    list.Add(result);
                }
            });

            var serialized = JsonConvert.SerializeObject(list.AsParallel().OrderBy(d=>d.Timestamp));

            await _notificationsMessageHandler.SendMessageAsync(user.Result.Id, serialized);

            _notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).InstantiateToast = true;
        }
        
        public void SelectConf(string ID)
        {
            var user = GetCurrentUserAsync();
            _notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).InstantiateToast = false;

            if (_notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).TokenSource != null)
            {
                _notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).TokenSource.Cancel();
            }

            var SearchList = from m in _context.Users select m;

            SearchList = SearchList.Where(x => x.Id.Equals(ID)).Take(1);

            string GUIDTwo = SearchList.Select(x => x.FirebaseGUID).FirstOrDefault();

            _notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).ConfGUID = Encrypter.GetConfGuid(user.Result.FirebaseGUID, GUIDTwo);

            LoadMessages(_notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).ConfGUID, user);
        }

        [Authorize]
        public IActionResult Index()
        {
            ChatModel chat = new ChatModel();
            chat.MessageModel = new MessageModel();
            chat.SearchModel = new List<Areas.Identity.Data.WaveChatUser>();
            _chat = chat;
            return View(_chat);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Wave.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async void InstantiateToast(MessageModel model, Task<WaveChat.Areas.Identity.Data.WaveChatUser> user)
        {

            if (_notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).InstantiateToast is true)
            {
                //Serialize
                if (!(model is null))
                {
                    var first = await firebaseClient.Child("users/" + model.GUID).OrderByKey().LimitToFirst(1).OnceAsync<Areas.Identity.Data.FirebaseNameModel>();
                    var optionsBuilder = new DbContextOptionsBuilder<WaveChatContext>();
                    optionsBuilder.UseMySql("server=remotemysql.com;user=jyKYm15Znj;database=jyKYm15Znj;password=EbVGAPF1Wz;port=3306;persistsecurityinfo=True");
                    WaveChatContext context = new WaveChatContext(optionsBuilder.Options);
                    ToastMessage _initToast = new ToastMessage
                    {
                        Message = model.Message,
                        Timestamp = model.Timestamp,
                        FirstName = first.First().Object.FirstName,
                        LastName = first.First().Object.LastName,
                        UserID = context.Users.Where(x => x.FirebaseGUID.Equals(model.GUID)).AsParallel().Select(m => m.Id).FirstOrDefault()
                    };

                    List<ToastMessage> ToastList = new List<ToastMessage>();

                    ToastList.Add(_initToast);

                    string output = JsonConvert.SerializeObject(ToastList);

                    await _notificationsMessageHandler.SendMessageAsync(user.Result.Id, output);
                }
            }
            else if (_notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).InstantiateToast is false)
            {}
        }

        struct ToastMessage
        {
            public string Message { get; set; }

            public string Timestamp { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string UserID { get; set; }
        }

        [HttpPost]
        public void SendMessageT(string value)
        {
            if (!String.IsNullOrWhiteSpace(value))
            {
                MessageModel msg = new MessageModel();
                msg.Message = value;
                msg.Timestamp = DateTime.Now.ToString();
                Console.WriteLine(msg.Message);
                var user = GetCurrentUserAsync();
                msg.GUID = user.Result.FirebaseGUID;

                var resultDatabase = firebaseClient.Child("convs/" + _notificationsMessageHandler._communicationManager.GetSocketById(user.Result.Id).ConfGUID).PostAsync(msg);
            }
        }

        Task<WaveChat.Areas.Identity.Data.WaveChatUser> GetCurrentUserAsync() => _userManager.GetUserAsync(User);

        public void OnPostMessage(MessageModel messageValue)
        {
            try
            {
                var resultDatabase = firebaseClient.Child("msgs/").PostAsync(messageValue);
            }
            catch{}
        }
    }
}
