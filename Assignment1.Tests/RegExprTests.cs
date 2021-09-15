using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void Resolution_given_list_of_4_resolutions_returns_8_int_width_pairs()
        {
        List<string> resolutions = new List<string>();
        resolutions.Add("1920x1080");
        resolutions.Add("1024x768, 800x600, 640x480");
        resolutions.Add("320x200, 320x240, 800x600");
        resolutions.Add("1280x960");

        IEnumerable<(int, int)> actual = RegExpr.Resolution(resolutions);
        IEnumerable<(int, int)> expected = new[] {(1920, 1080), (1024, 768), (800, 600), (640, 480), (320, 200), (320, 240), (800, 600), (1280, 960)};

        //, (1024, 768), (800, 600), (640, 480), (320, 200), (320, 240), (800, 600), (1280, 960)

        Assert.Equal(expected, actual);
        
        }

        [Fact]
        public void SplitLine_given_jeg_ER_123_hej_456_DIG_return_jeg_ER_123_hej_456_DIG(){
            var list = new List<string>();
            list.Add("jeg ER 123");
            list.Add("hej 456 DIG");

            var expected = new List<string>();
            expected.Add("jeg");
            expected.Add("ER");
            expected.Add("123");
            expected.Add("hej");
            expected.Add("456");
            expected.Add("DIG");
            Assert.Equal(expected, RegExpr.SplitLine(list));
        }
    }
}
