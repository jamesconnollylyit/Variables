using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        enum Orientation : int
        {
            north = 1,
            south = 2,
            east = 3,
            west = 4
        }

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person
            {
                FirstName = "James",
                SurName = "Connolly",
                HouseNo = 4,
                Street = "Main Street",
                Town = "Letterkenny",
                County = "Donegal"
            });

            people.Add(new Person
            {
                FirstName = "Joe",
                SurName = "Soap",
                HouseNo = 56,
                Street = "High Street",
                Town = "Letterkenny",
                County = "Donegal"
            });

           
            List<Person> secondList = new List<Person>();
            secondList.Add(new Person
            {
                FirstName = "John",
                SurName = "Doe",
                HouseNo = 56,
                Street = "Main Street",
                Town = "Letterkenny",
                County = "Donegal"
            });

            people.AddRange(secondList);

            //people.Remove(new Person
            //{
            //    FirstName = "John",
            //    SurName = "Doe",
            //    HouseNo = 56,
            //    Street = "Main Street",
            //    Town = "Letterkenny",
            //    County = "Donegal"
            //});

            Console.WriteLine(people.Contains(new Person
            {
                FirstName = "John",
                SurName = "Doe",
                HouseNo = 56,
                Street = "Main Street",
                Town = "Letterkenny",
                County = "Donegal"
            }));


            //people.Remove(new Person
            //{
            //    FirstName = "John",
            //    SurName = "Doe",
            //    HouseNo = 56,
            //    Street = "Main Street",
            //    Town = "Letterkenny",
            //    County = "Donegal"
            //}); 
             
            people.RemoveAll(t => t.FirstName == "John");

            foreach (var person in people)
            {
                Console.WriteLine($"Person firstname is : {person.FirstName}");
                Console.WriteLine($"Person surname is : {person.SurName}");
                Console.WriteLine($"Person HouseNo is : {person.HouseNo}");
                Console.WriteLine($"Person Street is : {person.Street}");
                Console.WriteLine($"Person Town is : {person.Town}");
                Console.WriteLine($"Person County is : {person.County}");
            }

            Console.ReadKey();
                      
           
        }

      

        struct Person
        {
            public string FirstName;
            public string SurName;
            public string Street;
            public string Town;
            public string County;
            public int HouseNo;
        }
       

    }
}
