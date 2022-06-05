using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("employee number: "+personal.EmployeeNumber);

            personal person1 = new personal("name1","surname1","software");

            System.Console.WriteLine("new employee number: {0}",personal.EmployeeNumber);

            //STATIC CLASS APPLICATION

            System.Console.WriteLine("sum of 2 numbers: {0}",operations.Sum(3,4));
            System.Console.WriteLine("difference of 2 numbers: {0}",operations.Extraction(3,4));         
        }       
    }

    class personal{
        private static int employeeNumber;

        public static int EmployeeNumber{ get => employeeNumber;}

        private string name;
        private string surname;
        private string department;

        static personal(){
            employeeNumber=0;

        }

        public personal(string _name,string _surname, string _department){
            this.name=_name;
            this.surname=_surname;
            this.department=_department;
            employeeNumber++;
        }
    }


    static class operations{
        public static long Sum(int num1,int num2){
            return num1+num2;
        }
        public static long Extraction(int num1,int num2){
            return num1-num2;
        }
    }

}
