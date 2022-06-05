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

            System.Console.WriteLine("******************");

            human example2=new human("name2","surname2",45,"city2");

            example2.printInformation();

            System.Console.WriteLine("********************");

            human example3=new human("name3","surname3");
            example3.printInformation();
        }       
    }


    class human{
        public string name;
        public string surname;
        public int no;
        public string city;

        public human(string _name,string _surname,int _no,string _city){
            this.name = _name;
            this.surname=_surname;
            this.no=_no;
            this.city=_city;
        }
        public human(string _name,string _surname){
            this.name = _name;
            this.surname=_surname;
        }
        public human(){
        }

        public void printInformation(){
            Console.WriteLine("Name: {0}, Surname: {1}, No: {2}, City: {3}",name,surname,no,city);
        }
    }   
}
