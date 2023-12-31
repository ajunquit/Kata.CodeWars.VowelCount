﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.CodeWars.VowelCount
{
    public class Kata
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            string[] vowels = { "a", "e", "i", "o", "u" };

            vowelCount = str.Where(x => vowels.Contains(x.ToString())).Count();

            return vowelCount;
        }
    }
}
