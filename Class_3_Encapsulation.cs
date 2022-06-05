using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            student person1 = new student();
            person1.Name="NAME1";
            person1.Surname="SURNAME1";
            person1.No=123;
            person1.Class_number=1;

            person1.increaseClassNumber();
            person1.printinformations();
            

            student person2 = new student("NAME2","SURNAME2",456,1);
            person2.decreaseClassNumber();
            person2.printinformations();
            
        }       
    }

    class student{
        private string name;
        private string surname;
        private int no;
        private int class_number;

        public string Name{
            get {return name;}
            set {name = value;}
        }

        public string Surname {get =>surname; set => surname=value;}

        public int No {get => no; set => no=value;}

        public int Class_number{
            get {return class_number;}
            set {
                if(value <1){
                    Console.WriteLine("Class name cannot be less than 1 !!!!");
                    class_number=1;
                }
                else{
                    class_number=value;
                }
            }
        }

        public student(){}

        public student(string _name,string _surname, int _no, int _class_number){
            this.Name=_name;
            this.Surname = _surname;
            this.No = _no;
            this.Class_number = _class_number;
        }


        public void printinformations(){
            System.Console.WriteLine("*************** STUDENT INFORMATION***********");
            Console.WriteLine("NAME:     {0}\nSURNAME:   {1}\nNO:        {2}\nCLASS:     {3}",this.Name,this.Surname,this.No,this.Class_number);
        }

        public void increaseClassNumber(){
            this.Class_number++;
        }

        public void decreaseClassNumber(){
            this.Class_number--;
        }

    }

}
