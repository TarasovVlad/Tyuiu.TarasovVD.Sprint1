﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TarasovVD.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string[] words = value.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            string result = new string(words.Select(word => word.Last()).ToArray());
            return result;
        }
    }
}
