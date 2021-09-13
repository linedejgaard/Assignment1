using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            
            foreach (var resolution in resolutions)
            {
                MacthCollection matches = Regex.Match("(?P<witdh>[0-9]+)+x(?P<height>[0-9]+)");
                foreach (Macth resolution in matches)
                {
                    var stitch = "(" + resolution.Groups["width"].value + "," + resolution.Groups["height"] +")"
                    yield stitch;
                }

            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
