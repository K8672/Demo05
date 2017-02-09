using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a few Person objects
            Person person1 = new Person
            {
                Firstname = "Kirsi", Lastname = "Mainio", SocialSecurityNumber = "11111111-2222"
            };
            Person person2 = new Person
            {
                Firstname = "Matti", Lastname = "Husso", SocialSecurityNumber = "22222222-3333"
            };
            Person person3 = new Person
            {
                Firstname = "Teppo", Lastname = "Taistelija", SocialSecurityNumber = "44444444-5555"
            };

            //create a Persons object
            Persons myFriends = new Persons();

            //add person object to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get on person from Persons collection
            Person person4 = myFriends.GetPerson(6);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("Person not found in that index!");
            }

            //print collection
            myFriends.PrintCollection();

            //find person
            string sotu = "22223422-3333";
            Console.WriteLine("Find sotu : " + sotu);
            Person person5 = myFriends.FindPerson(sotu);
            if(person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }else
            {
                Console.WriteLine("Cant find person with that sotu..");
            }
        }
    }
}