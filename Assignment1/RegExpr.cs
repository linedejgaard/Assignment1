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
            
            foreach (var resolution in resolutions)
            {
                MacthCollection matches = Regex.Match("(?P<witdh>[0-9]+)+x(?P<height>[0-9]+)");
                foreach (Macth resolution in matches)
                {
                    var stitch = "(" + resolution.Groups["width"].value + "," + resolution.Groups["height"] +")"
                    yield return stitch;
                }

            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {


            string strRegex = @$"<({tag})[^>]*>[^(<\/\1>)]*.*?<\/\1>";
            MatchCollection matches = Regex.Matches(html, strRegex);

            string regexOpen = $"<[a-z]+[^>]*>";
            string regexClose = @$"<\/[a-z]+>";
            

            foreach (Match content in matches)
                {
                    string CleanedStringFromOpen = Regex.Replace(content.Value, regexOpen, "");
                    string CleanedString = Regex.Replace(CleanedStringFromOpen, regexClose, "");
                    

                    yield return CleanedString;
                }
            
        }
    }
}
