using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("string");
            list.Add(21);
            list.Add(true);
            list.Add('E');



            string[] colors={"blue","grey","green","red"};
            List<int> numbers = new List<int>(){1,2,3,4,44};
            
            list.AddRange(colors);
            list.AddRange(numbers);


            Dictionary<int,string> dict = new Dictionary<int, string>();

            dict.Add(1,"dictionaryitem1");
            dict.Add(2,"dictionaryitem2");
            dict.Add(13,"dictionaryitem13");
            dict.Add(4,"dictionaryitem4");


            System.Console.WriteLine(dict[2]);
            foreach(var s in dict){
                System.Console.WriteLine(s);
            }

            System.Console.WriteLine(dict.ContainsKey(13));
            System.Console.WriteLine(dict.ContainsValue("dictionaryitem1"));


            dict.Remove(4);


            foreach(var i in dict){
                System.Console.WriteLine(i.Key);
            }

            
        }
    }

    
}
