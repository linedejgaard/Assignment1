using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_given_one_list_with_3_lists_with_1_2_3_each_return_list_with_1_2_3_1_2_3_1_2_3()
        {
            //Making list with lists
            var outerList = new List<List<int>>();
            var innerList1 = new List<int>();
            innerList1.Add(1);
            innerList1.Add(2);
            innerList1.Add(3);
            var innerList2 = new List<int>();
            innerList2.Add(1);
            innerList2.Add(2);
            innerList2.Add(3);
            var innerList3 = new List<int>();
            innerList3.Add(1);
            innerList3.Add(2);
            innerList3.Add(3);
            outerList.Add(innerList1);
            outerList.Add(innerList2);
            outerList.Add(innerList3);
            
            //Making expected list            
            var expected = new List<int>();
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);

            //Assert
            Assert.Equal(expected, Iterators.Flatten(outerList));
        }

        [Fact]  
        public void Filter_given_1_2_3_4_5_returns_2_4(){
            Predicate<int> even = Iterators.Even;
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            var expected = new List<int>();
            expected.Add(2);
            expected.Add(4);

            Assert.Equal(expected,Iterators.Filter(list, even));

        }
    }
}
