using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void Resolution_given_list_of_8_resolutions_returns_correct_format()
        {
        List<string> resolutions = new List<string>();
        resolution.Add("1920x1080");
        resolution.Add("1024x768, 800x600, 640x480");
        resolution.Add("320x200, 320x240, 800x600");
        resolution.Add("1280x960");

        List<string> expected = new List<string>();
        expected.Add("(1920, 1080)");
        expected.Add("(1024, 768)");
        expected.Add("(800, 600)");
        expected.Add("(640, 480)");
        expected.Add("(320, 200)");
        expected.Add("(320, 240)");
        expected.Add("(800, 600)");
        expected.Add("(1280, 960)");

        Assert.Equal(expected, RegExpr.Resolution(resolution));
        
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
