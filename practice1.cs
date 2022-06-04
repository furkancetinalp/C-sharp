using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            //PRACTICE 1
            System.Console.WriteLine("Please enter a number");
            int number1= Convert.ToInt32(Console.ReadLine());
            List<int> evens = new List<int>();
            for(int i=0;i<number1;i++){
                System.Console.WriteLine("Please enter number {0}",i+1);
                int number = Convert.ToInt32(Console.ReadLine());
                if(number %2==0){
                    evens.Add(number);

                }

            }

            foreach (int i in evens){
                System.Console.Write(i+" ");
            }
            
            
            //PRACTICE 2
            List<int> list = new List<int>();
            System.Console.WriteLine("Please enter first number");
            int number1= Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Please enter second number");
            int number2= Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<number1;i++){
                System.Console.WriteLine("Please enter number {0}",i+1);
                int number = Convert.ToInt32(Console.ReadLine());
                if(number ==number2 || number%number2==0){
                    list.Add(number);
                }
            }
            foreach (int i in list){
                System.Console.Write(i+" ");
            }

            

            // PRACTICE 3
            string[] words;
            System.Console.WriteLine("Please enter a number");
            int number1= Convert.ToInt32(Console.ReadLine());
            words = new string[number1];
            for(int i=0;i<number1;i++){
                System.Console.WriteLine("Please enter a word {0}",i+1);
                string word = Console.ReadLine();
                words[number1-i-1]=word;
            }

            foreach(string s in words){
                System.Console.Write(s+" ");
            }

            */

            //PRACTICE 4
            System.Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();

            int words=0;
            int letters=0;
            string[] list = sentence.Split(" ");
            words=list.Length;

            foreach(char c in sentence){
                letters++;
            }
            letters -=words;
            letters++;

            System.Console.WriteLine("word count: {0} , letter count: {1}",words,letters);


        
        }
    }
}
