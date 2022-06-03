using System;

namespace app3
{
    class Result
{

    public static void staircase(int n)
    {
        for(int i=0;i<n;i++){
            
            for(int j=1;j<n-i;j++){
                Console.Write(" ");
            }
            for(int k=0;k<=i;k++){
                Console.Write("#");
            }
            Console.WriteLine();
        }
      
    }

}
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            for(int i=1;i<=10;i++){
                Console.WriteLine("{0} x {1} = {2}",n,i,n*i);
            }

            int m = Convert.ToInt32(Console.ReadLine().Trim());

            Result.staircase(m);
        }
    }
}

