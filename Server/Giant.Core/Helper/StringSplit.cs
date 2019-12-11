﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Giant.Core
{
    public static class StringSplit
    {
        private static char[] splitChar = new char[] { '|' };

        public static List<int> ToIntList(this string content)
        {
            if (string.IsNullOrEmpty(content)) return new List<int>();

            return content.Split(splitChar, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll<int>(x=>int.Parse(x));
        }
    }
}
