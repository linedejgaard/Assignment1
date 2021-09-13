using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {


            foreach(var line in lines){

                MatchCollection matches = Regex.Matches(line, @"[A-Za-z0-9]+");
        
                
                foreach (Match word in matches)
                {
                    yield return word.Value;
                }
            }


        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
