using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
<<<<<<< HEAD
=======


            foreach(var line in lines){

                MatchCollection matches = Regex.Matches(line, @"[A-Za-z0-9]+");
        
                
                foreach (Match word in matches)
                {
                    yield return word.Value;
                }
            }


>>>>>>> 935a6c19d6b02cc640b2a81c602780093f72e4d4
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
            throw new NotImplementedException();
        }
    }
}
