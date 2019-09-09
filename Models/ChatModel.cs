using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaveChat.Models
{
    public class ChatModel
    {
        public MessageModel MessageModel {get; set;}

        public List<WaveChat.Areas.Identity.Data.WaveChatUser> SearchModel { get; set; }



    }
}
