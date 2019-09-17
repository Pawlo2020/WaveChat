using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WaveChat.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WaveChatUser class
    public class WaveChatUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }

        public string FirebaseGUID { get; set; }

        [NotMapped]
        public bool Status { get; set; }


    }
}
