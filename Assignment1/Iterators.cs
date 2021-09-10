using System;
using System.Collections.Generic;

namespace Assignment1
{
    public static class Iterators
    {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
        {
            foreach (var item in items)
                {
                    foreach (var i in item)
                    {
                        yield return i;
                    }
                }
        
        }

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
        {
            //throw new NotImplementedException();
            foreach(var item in items){
                if (predicate(item)){
                    yield return item;
                }
            }
        }

        public static bool Even(int i)
        {
            return i % 2 == 0;
        }
    }
}
