using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Versaler.Model
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text)
        {
            int NumberOfCapitals = 0;
            foreach (char x in text) 
            {
                if(Char.IsUpper(x) == true)
                {
                    NumberOfCapitals++;
                }
            }
            return NumberOfCapitals;
        }
    }
}