﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqA
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int Id { get; set; }
        public List<int> Scores;
        public override string ToString()
        {
            return string.Format("{0} {1} - {2} ", First, Last, Id);
        }
    }
    class Fruit
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return string.Format("{0} @{1:c} ({2})", Name, Price, Origin.Substring(0, 2).ToUpper());
        }
    }
    class Person
    {
        public string Name { get; set; }
        public double Asset { get; set; }
        public bool IsFemale { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}B {2} {3} {4}yrs", Name, Asset, IsFemale ? "F" : "M", Country, Age);
        }
    }

    class Program
    {
        #region Datasources
        static List<Student> students = new List<Student> {
            new Student{ First="Xavier", Last="Thomas", Id=111, Scores=new List<int>{97,92 ,81 , 55, 60 } },
            new Student{ First="Lyoid", Last="Lopes", Id=112, Scores=new List<int>{96, 88, 86, 77, 55 } },
            new Student{ First="Navdeep", Last="Singh", Id=113, Scores=new List<int>{92, 97, 65, 89,  45} },
            new Student{ First="Lyle", Last="Spurrell", Id=114, Scores=new List<int>{90, 95, 75, 78, 83 } },
            new Student{ First="Viktor", Last="Salnichenko", Id=115, Scores=new List<int>{87, 96, 65, 34,  90} },
            new Student{ First="Sukhpratap", Last="Singh", Id=116, Scores=new List<int>{90, 87, 56, 98, 78 } },
            new Student{ First="Dannel", Last="Alon", Id=117, Scores=new List<int>{90, 84,59 ,67 , 98 } },
            new Student{ First="Francis", Last="Acheampong", Id=118, Scores=new List<int>{89, 56, 56, 67, 87 } },
            new Student{ First="Mahamod", Last="Masleh", Id=119, Scores=new List<int>{67, 78,46 , 78, 98 } },
            new Student{ First="John", Last="Calma", Id=120, Scores=new List<int>{89, 76, 78, 67,  87} },
            new Student{ First="Sarina", Last="Luu", Id=121, Scores=new List<int>{67, 67, 87, 74,  95} },
            new Student{ First="Valerie", Last="Chan", Id=122, Scores=new List<int>{87, 69, 95, 67,  49} },
            new Student{ First="Tej", Last="Singh", Id=127, Scores=new List<int>{90, 87, 96, 98, 78 } },
            new Student{ First="Mabel", Last="Tang", Id=123, Scores=new List<int>{87, 78,59 , 75,  67} },
            new Student{ First="Rishav", Last="Giri", Id=124, Scores=new List<int>{65, 87, 58, 92,  68} },
            new Student{ First="Toni", Last="Lea", Id=125, Scores=new List<int>{78, 97, 83, 83,  87} },
            new Student{ First="Melanie", Last="March", Id=126, Scores=new List<int>{89, 79, 80, 95, 97 } }
        };

        static List<Person> persons = new List<Person>()
        {
            new Person(){ Age=67, Asset=7.6, Country="India", IsFemale=true, Name="Savitri Jindal"},
            new Person(){ Age=81, Asset=3.1, Country="India", IsFemale=true, Name="Indu Jain"},
            new Person(){ Age=70, Asset=2.5, Country="India", IsFemale=true, Name="Vinod Gupta"},
            new Person(){Age = 77,Asset = 27,Country = "US",IsFemale = true,Name = "Jacqueline Mars"},
            new Person(){   Age = 76,   Asset = 25.2,   Country = "Italy",  IsFemale = true,    Name = "Maria Franca Fissolo"},
            new Person(){   Age = 55,   Asset = 20.4,   Country = "Germany",    IsFemale = true,    Name = "Susanne Klatten"},
            new Person(){Age = 53,Asset = 20,Country = "US",IsFemale = true,Name = "Laurene Jobs"},
            new Person(){ Age=60, Asset=12.5, Country="Nigeria", IsFemale=false, Name="Aliko Dangote" },
            new Person(){ Age=76, Asset=10.9, Country="Ethiopia", IsFemale=false, Name="Mohammed Al Amoudi"},
            new Person(){ Age=60, Asset=30.7, Country="Canada", IsFemale=false, Name="David Thomson" },
            new Person(){ Age=76, Asset=11.4, Country="Canada", IsFemale=false, Name="Galen Weston"},
            new Person(){ Age=60, Asset=22.3, Country="India", IsFemale=false, Name="Mukesh Ambani"},
            new Person(){ Age=50, Asset=17.5, Country="India", IsFemale=false, Name="Dilip Shanghvi"},
            new Person(){ Age=83, Asset=30.4, Country="US", IsFemale=false, Name="Sheldon Adelson"},
            new Person(){ Age=78, Asset=30, Country="Brazil", IsFemale=false, Name="Jorge Lemann"},
            new Person(){ Age=72, Asset=7, Country="South Africa", IsFemale=false, Name="Nicky Oppenheimer"},
            new Person(){ Age=62, Asset=18.4, Country="Russia", IsFemale=false, Name="Leonid Mikhelson"},
            new Person(){ Age=51, Asset=17.5, Country="Russia", IsFemale=false, Name="Alexey Mordashov"},
            new Person(){Age=89, Asset=31.2, Country="Hong Kong", IsFemale=false, Name="Li Ka-shing"},
            new Person(){ Age=62, Asset=31.2, Country="China", IsFemale=false, Name="Wang Jianlin"},
            new Person(){Age=67, Asset=33.8, Country="US", IsFemale=true, Name="Alice Walton" },
            new Person(){ Age=60, Asset=34, Country="US", IsFemale=false, Name="Jim Walton"},
            new Person(){ Age=72, Asset=34.1, Country="US", IsFemale=false, Name="Rob Walton"},
            new Person(){ Age=94, Asset=39.5, Country="France", IsFemale=true, Name="Liliane Bettencourt"},
            new Person(){ Age=43, Asset=39.8, Country="US", IsFemale=false, Name="Sergey Brin"},
            new Person(){ Age=43, Asset=39.6, Country="US", IsFemale=false, Name="Larry Page"},
            new Person(){ Age=68, Asset=41.5, Country="France", IsFemale=false, Name="Bernard Arnault"},
            new Person(){ Age=75, Asset=47.5, Country="US", IsFemale=false, Name="Michael Bloomberg"},
            new Person(){ Age=77, Asset=48.3, Country="US", IsFemale=false, Name="David Koch"},
            new Person(){ Age=81, Asset=48.3, Country="US", IsFemale=false, Name="Charles Koch"},
            new Person(){ Age=72, Asset=52.2, Country="US", IsFemale=false, Name="Larry Ellison"},
            new Person(){ Age=77, Asset=54.5, Country="Mexico", IsFemale=false, Name="Carlos Slim Helu"},
            new Person(){Age=33, Asset=56, Country="US", IsFemale=false, Name="Mark Zuckerberg"},
            new Person(){ Age=81, Asset=71.3, Country="Spain", IsFemale=false, Name="Amancio Ortega"},
            new Person(){ Age=53, Asset=72.8, Country="US", IsFemale=false, Name="Jeff Bezos"},
            new Person(){ Age=85, Asset=75.6, Country="US", IsFemale=false, Name="Warren Buffet"},
            new Person(){ Age=60, Asset=86, Country="US", IsFemale=false, Name="Bill Gates"}
        };

        static List<Fruit> fruits = new List<Fruit>()
        {
            new Fruit(){ Name="Mango", Origin="Guyana", Price=5.67},
            new Fruit(){ Name="Kiwi", Origin="New Zeeland", Price=1.34},
            new Fruit(){ Name="Dragon Fruit", Origin="China", Price=3.45},
            new Fruit(){ Name="Avacado", Origin="Mexico", Price=2.56},
            new Fruit(){ Name="Banana", Origin="Ecuador", Price=0.25}
        };

        #endregion
        static void Main(string[] args)
        {
            // Q1.	Show the persons with assets of over 50B

            //var r4 =
            //    from p in persons
            //    where p.Asset > 50
            //    select p.Name;
            //foreach (var p in r4)
            //    Console.WriteLine(p);
            //Console.ReadKey();

            //// Q2.	2.	Show all non-us citizens

            //var r4 =
            //    from p in persons
            //    where p.Country != "US"
            //    select p.Name;
            //foreach (var p in r4)
            //    Console.WriteLine(p);
            //Console.ReadKey();

            // Q3.	Show all females from India

            //var r4 =
            //    from p in persons
            //    where p.Country == "India" && p.IsFemale == true
            //    select p.Name;
            //foreach (var p in r4)
            //    Console.WriteLine(p);
            //Console.ReadKey();

            //4.	Show all persons whose first name is less than five letters long
            //var r4 =
            //    from p in persons
            //    where p.Name.Split()[0].Length < 5
            //    select p.Name;
            //foreach (var p in r4)
            //    Console.WriteLine(p);
            //Console.ReadKey();

            //5. Sort the collection by assets

            //var r4 =
            //from p in persons
            //orderby p.Asset
            //select p;
            //foreach (var p in r4)
            //    Console.WriteLine(p);
            //Console.ReadKey();


            //6.	Group the collection (by country)

            //var group = from p in persons
            //            group p by p.Country;

            //foreach (var country in group)
            //{
            //    Console.WriteLine("{0} ({1})", country.Key, country.Count());
            //    foreach (var item in country)
            //    {
            //        Console.WriteLine( "  " + item);

            //    }
            //}
            //Console.ReadKey();

            //7.	Group the collection and orderby country
            var r3 = from p in persons
                     orderby p.Country
                     group p by p.Country;

            foreach (var aGroup in r3)
            {
                Console.WriteLine("{0} ({1})", aGroup.Key, aGroup.Count());
                foreach (var item in aGroup)
                    Console.WriteLine("    " + item);
            }
            Console.ReadKey();

            //8. show fruits in order by name

            //var r3 = from p in fruits
            //         orderby p.Name
            //         select p;
            //foreach (var v in r3)
            //    Console.WriteLine(v);
            //    Console.ReadKey();

        }
    }
}
