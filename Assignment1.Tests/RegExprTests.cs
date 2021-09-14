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

        [Fact]
        public void InnerText_given_tag_teksttekst_tag_return_teksttekst(){
            var html = "<tag>teksttekst</tag>";
            var tag = "tag";

            var expected = new List<string>();
            expected.Add("teksttekst");
            Assert.Equal(expected, RegExpr.InnerText(html, tag));
        }

        [Fact]
        public void InnerText_given_example2_from_assignment(){
            var html = "<div><p>The phrase <i>regular expressions</i> (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing <u>patterns</u> that matching <em>text</em> need to conform to.</p></div>";
            var tag = "p";

            var expected = new List<string>();
            expected.Add("The phrase regular expressions (and consequently, regexes) is often used to mean the specific, standard textual syntax for representing patterns that matching text need to conform to.");
            Assert.Equal(expected, RegExpr.InnerText(html, tag));
        }

        [Fact]
        public void InnerText_given_example1_from_assignment(){
            var html = "<div><p>A <b>regular expression</b>, <b>regex</b> or <b>regexp</b> (sometimes called a <b>rational expression</b>) is, in <a href=\"/wiki/Theoretical_computer_science\" title=\"Theoretical computer science\">theoretical computer science</a> and <a href=\"/wiki/Formal_language\" title=\"Formal language\">formal language</a> theory, a sequence of <a href=\"/wiki/Character_(computing)\" title=\"Character (computing)\">characters</a> that define a <i>search <a href=\"/wiki/Pattern_matching\" title=\"Pattern matching\">pattern</a></i>. Usually this pattern is then used by <a href=\"/wiki/String_searching_algorithm\" title=\"String searching algorithm\">string searching algorithms</a> for \"find\" or \"find and replace\" operations on <a href=\"/wiki/String_(computer_science)\" title=\"String (computer science)\">strings</a>.</p></div>";
            var tag = "a";

            var expected = new List<string>();
            expected.Add("theoretical computer science");
            expected.Add("formal language");
            expected.Add("characters");
            expected.Add("pattern");
            expected.Add("string searching algorithms");
            expected.Add("strings");

            Assert.Equal(expected,RegExpr.InnerText(html,tag));


        }

        

    }
}
