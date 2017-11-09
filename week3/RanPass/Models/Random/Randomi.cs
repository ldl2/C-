using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace RanPass.Models
{
    public class Randomi

    {
        public string randword;
        

        public Randomi()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[14];

            Random randomy = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[randomy.Next(chars.Length)];
            }
            randword = new string(stringChars);
        }
    }
}
