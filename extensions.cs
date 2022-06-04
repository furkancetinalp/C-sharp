using System;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "c# extension practice";

            bool result = sentence.check();

            if(result){
                System.Console.WriteLine(sentence.deletespaces());
            }
            System.Console.WriteLine(sentence.uppercaseVersion());


            int[] arr={13,34,2,44,55,43,12,32,3};

            arr.orderBy();
            arr.printArray();
        }
        
    }
    public static class Extension{
        public static bool check(this string input){
            return input.Contains(" ");
        }

        public static string deletespaces(this string input){

            string[] array = input.Split(" ");


            return string.Join("",array);
        }
        public static string uppercaseVersion(this string input){
            return input.ToUpper();
        }

        public static Array orderBy(this Array input){
            Array.Sort(input);
            return input;
        }

        public static void printArray(this Array input){
            foreach(int i in input){
                System.Console.Write(i+" ");
            }

        }
    }
}
