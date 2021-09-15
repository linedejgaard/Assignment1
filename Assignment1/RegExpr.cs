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

        public static IEnumerable<(int width, int height)> Resolution(IEnumerable<string> resolutions)
        {
            
            foreach (var resolution in resolutions)
            {
                MatchCollection matches = Regex.Matches(resolution, @"(?<witdh>[0-9]+)+x(?<height>[0-9]+)");

                foreach (Match match in matches)
                {
                    yield return (Int32.Parse(match.Groups[1].Value), Int32.Parse(match.Groups[2].Value));
                }

            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
