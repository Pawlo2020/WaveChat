using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WaveChat.Models
{
    public class MessageModel
    {
        [Display(Name ="Message:")]
        public string Message { get; set; }

        public string Timestamp { get; set; }

        public string GUID { get; set; }

    }
}
