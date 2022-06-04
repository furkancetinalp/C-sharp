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

          
        }
    }

    
}
