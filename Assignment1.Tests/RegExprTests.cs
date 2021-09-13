using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
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
