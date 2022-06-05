using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine(Days.sunday);
            System.Console.WriteLine((int)Days.sunday);


            int temperature=28;
            if(temperature<=(int)weather.warm){
                System.Console.WriteLine("it is a bit cold");
            } 
            else if(temperature>=(int)weather.extreme){
                System.Console.WriteLine("it is too hot");
            }
            else if(temperature>=(int)weather.warm && temperature<(int)weather.extreme){
                System.Console.WriteLine("it is a good weather to spend time outside");
            }                 
        }       
    }

    enum Days{
        monday=1,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday

    }

    enum weather{
        cold=5,
        warm=20,
        hot=25,
        extreme=30

    }
}
