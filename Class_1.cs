using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            human example1 = new human();
            example1.name="name1";
            example1.surname="surname1";
            example1.no=12;
            example1.city="city1";

            example1.printInformation(); 
        }       
    }


    class human{
        public string name;
        public string surname;
        public int no;
        public string city;

        public void printInformation(){
            Console.WriteLine("Name: {0}, Surname: {1}, No: {2}, City: {3}",name,surname,no,city);
        }
    }

    
}
