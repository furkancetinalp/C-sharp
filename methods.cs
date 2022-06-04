using System;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods ex = new Methods();


            int a=2;
            int b=5;
            int result = topla(a,b);
            ex.printing(result.ToString());

        }
        static int topla(int num1,int num2){
            return num1+num2;
        }
    }
    class Methods{
        public void printing(string data){
            System.Console.WriteLine(data);
        }
    }
}
