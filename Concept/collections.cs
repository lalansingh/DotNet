using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpConcept
{
    public static class Collections
    {

        public static void DictionaryHashTableTest()
        {
            // does not take duplicate key and order will be the same as stored
            // and data type will be the same as declared.
            // it is value type

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("2", "lalan");
            dic.Add("1", "lalan");
            dic.Add("3", "lalan");

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key);
            }

            // it also does not take duplicate key and order will be sorted by difault and it could be any
            // type of data
            // it is reference type

            Hashtable htbl = new Hashtable();
            htbl.Add("5", "lalan");
            htbl.Add(3, "lalan");
            htbl.Add("3", "lalan");

            foreach(DictionaryEntry item in htbl)
            {
                Console.WriteLine(item.Key);
            }

            HashSet<string> hSet = new HashSet<string>();
            hSet.Add("slfjks");           
        }
    }
}
