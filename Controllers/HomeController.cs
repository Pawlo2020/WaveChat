using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WaveChat.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Net.WebSockets;
using Microsoft.AspNetCore.Http;
using System.Threading;
using WaveChat.Communication;
using Newtonsoft.Json;
using System.IO;

namespace WaveChat.Controllers
{
    public class HomeController : Controller
    {
        FirebaseClient firebaseClient = new FirebaseClient("https://wavechat-617f9.firebaseio.com");
        private readonly UserManager<Areas.Identity.Data.WaveChatUser> _userManager;


        private NotificationMessageHandler _notificationsMessageHandler { get; set; }
        private WaveChatContext _context;
        static ChatModel _chat;

        public HomeController(WaveChatContext context,UserManager<WaveChat.Areas.Identity.Data.WaveChatUser> userManager, NotificationMessageHandler notificationsMessageHandler)
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
            catch (Exception e) {

            }

            try
            {
                Last = person.Split(' ')[1];
            }
            catch (Exception e)
            {

            }

            if (!String.IsNullOrEmpty(First))
            {
                SearchList = SearchList.Where(x => x.FirstName.Contains(First));
            }

            if (!String.IsNullOrEmpty(Last))
            {
                SearchList = SearchList.Where(x => x.LastName.Contains(Last));
            }

            foreach (var item in SearchList)
            {
                _chat.SearchModel.Add(new Areas.Identity.Data.WaveChatUser() {FirstName = item.FirstName, LastName = item.LastName });

            }


           return PartialView(_chat);
            
        }

        [HttpGet]
        public async Task SendMessage([FromQueryAttribute]string message)
        {
            await _notificationsMessageHandler.SendMessageToAllAsync(message);

        }

        public void LoadMessages()
        {
            var observable = firebaseClient
               .Child("msgs").AsObservable<WaveChat.Models.MessageModel>()
               .Subscribe(d => InstantiateToast(d.Object));

        }


        [Authorize]
        public IActionResult Index()
        {
            Guid a;
            //Legacy
            //MessageModel msg = new MessageModel();
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

        public async void InstantiateToast(MessageModel model)
        {
            //Serialize
            var first = await firebaseClient.Child("users/" + model.GUID).OrderByKey().LimitToFirst(1).OnceAsync<Areas.Identity.Data.FirebaseNameModel>();
            ToastMessage _initToast = new ToastMessage
            {
                Message = model.Message,
                Timestamp = model.Timestamp,
                FirstName = first.First().Object.FirstName,
                LastName = first.First().Object.LastName
        };
            string output = JsonConvert.SerializeObject(_initToast);
            await _notificationsMessageHandler.SendMessageToFirst(output);
        }
        struct ToastMessage
        {
            public string Message { get; set; }

            public string Timestamp { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }
        }
        

        [HttpPost]
        public void SendMessage(ChatModel msg)
        {
            
            msg.MessageModel.Timestamp = DateTime.Now.ToString();
            Console.WriteLine(msg.MessageModel.Message);
            var user = GetCurrentUserAsync();
            msg.MessageModel.GUID = user.Result.FirebaseGUID;

            var resultDatabase = firebaseClient
                      .Child("msgs/").PostAsync(msg.MessageModel);

        }
            Task<WaveChat.Areas.Identity.Data.WaveChatUser> GetCurrentUserAsync() => _userManager.GetUserAsync(User);


            public void OnPostMessage(MessageModel message){

            try
            {
                var resultDatabase =  firebaseClient
                    .Child("msgs/").PostAsync(message);

                }catch(Exception e){

                }
            }
    }
}
