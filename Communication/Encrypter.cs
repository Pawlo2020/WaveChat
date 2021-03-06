﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WaveChat.Communication
{
    public static class Encrypter
    {



        public static string GetConfGuid(string KEY1, string KEY2)
        {

            string mockVal="";
            int i = 0;
            while (i < 12)
            {
                if (KEY1.ToArray()[i] < KEY2.ToArray()[i])
                {
                    mockVal = KEY1.Substring(0, KEY1.Length / 2) + KEY2.Substring(KEY2.Length / 2, KEY2.Length / 2);
                    break;

                }
                else if (KEY1.ToArray()[i] > KEY2.ToArray()[i])
                {
                    mockVal = KEY2.Substring(0, KEY2.Length / 2) + KEY1.Substring(KEY1.Length / 2, KEY1.Length / 2);
                    break;
                }


                i++;
            }
            return GetHashValue(mockVal);
        }

        private static string GetHashValue(string value)
        {
            using (SHA256 generator = SHA256.Create())
            {
                byte[] hashVal = generator.ComputeHash(Encoding.UTF8.GetBytes(value));

                StringBuilder build = new StringBuilder();

                foreach (byte element in hashVal)
                {
                    build.Append(element.ToString("x2"));
                }

                return build.ToString();
            }
        }
    }
}
