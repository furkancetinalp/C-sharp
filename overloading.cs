using System;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods ex = new Methods();

            ex.sum(2,3,out int final);
            System.Console.WriteLine("SUM OF THE NUMBERS USING 'OUT' METHOD : {0}",final);


            string number1 = "122";
            bool check = int.TryParse(number1, out int result);
            if(check){
                System.Console.WriteLine("success");
            }
            else{
                System.Console.WriteLine("failed");
            }


            //OVERLOADING  
            string check1="121";
            int check2=121;

            ex.print1(check1);

            ex.print1(check2);

            ex.print1("b","c");


        }
        
    }
    class Methods{
        public void sum(int num1,int num2, out int result){
            result=num1+num2;
        }

        public void print1(string a){
            System.Console.WriteLine(a);
        }
        public void print1(int a){
            System.Console.WriteLine(a);
        }
        public void print1(string a, string b){
            System.Console.WriteLine(a+b);
        }
    }
}
