using System;
using System.Collections;
using System.Collections.Generic;
namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(5);
            list.Add(7);

            List<string> colors = new List<string>();

            colors.Add("blue");
            colors.Add("yellow");
            colors.Add("gray");
            colors.Add("aqua");
            colors.Add("green");
            colors.Add("red");


            list.ForEach(numbers => System.Console.WriteLine(numbers));
            colors.ForEach(items => System.Console.WriteLine(items));


            list.Remove(7);

            colors.RemoveAt(3);

            if(colors.Contains("aqua")){
                System.Console.WriteLine("aqua is in the list");
            }

            //getting the index of an item in the list
            int index = colors.BinarySearch("red");
            System.Console.WriteLine(index);


            //convert array to list
            string[] animals={"dog","cat","bird"};
            List<string> animalList = new List<string>(animals);

            //deleting all items of list
            animalList.Clear();


            //********************************object lists
            List<users> userList = new List<users>();

            users user1 = new users();
            user1.Name="name1";
            user1.Surname="surname1";
            user1.Age=12;


            users user2 = new users();
            user2.Name="name2";
            user2.Surname="surname2";
            user2.Age=44;

            userList.Add(user1);
            userList.Add(user2);


            // SECOND WAY TO DO:

            List<users> newuserList = new List<users>();

            newuserList.Add(new users(){
                Name="secondwayname",
                Surname="secondwaysurname",
                Age=10
            });


            foreach(users s in userList){
                Console.WriteLine("name: "+s.Name);
                Console.WriteLine("surname: "+s.Surname);
                Console.WriteLine("age: "+s.Age);
                System.Console.WriteLine("***********************");
            }

          
        }
    }

    public class users{
        private string name;
        private string surname;
        private int age;

        public string Name{get => name; set => name =value;}
        public string Surname {get => surname; set => surname=value;}

        public int Age {get => age; set =>age=value;}
    }
}
