using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = "c sharp exercise: methods";
            string variable2 = "C sharp exercise: methods";
            string variable3="c sharp";


            //Length
            System.Console.WriteLine(variable.Length);

            //Concat
            System.Console.WriteLine(string.Concat(variable,"addition1"));

            //Compare, CompareTo
            System.Console.WriteLine(variable,variable2); // 1,0,-1
            System.Console.WriteLine(String.Compare(variable,variable2,true)); //ignore case (upper-lower case)
            System.Console.WriteLine(String.Compare(variable,variable2,false)); //dont ignore case

            //Contains
            System.Console.WriteLine(variable.Contains(variable3)); //true-false

            //StartsWith-Endswith
            System.Console.WriteLine(variable.StartsWith("c sharp"));

            //indexOf
            System.Console.WriteLine(variable.IndexOf("exercise:")); //returns index of first letter(in this case 'e'); or -1

            //Insert
            System.Console.WriteLine(variable.Insert(0,"new")); //'new' is added to index 0

            //LastIndexOf
            System.Console.WriteLine(variable.LastIndexOf("e"));

            //PadLeft-PadRight
            System.Console.WriteLine(variable+variable2.PadLeft(20));
            System.Console.WriteLine(variable+variable2.PadLeft(20,'/'));

            //Remove
            System.Console.WriteLine(variable.Remove(15));//deletes after index 15
            System.Console.WriteLine(variable.Remove(0,5));

            //Replace
            System.Console.WriteLine(variable.Replace("methods","features"));
            System.Console.WriteLine(variable.Replace(" ","/"));

            //Split
            System.Console.WriteLine(variable.Split(" " [0]));

            //SubString
            System.Console.WriteLine(variable.Substring(10)); //prints after index 10


        }
    }
}
