using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tutorial_ForMyself_8 //Generic CLASSES
{
    internal class Program //SortedSet-ListDictionary-HybridDictionary-OrderedDictionary-StringCollection
    {
        static void Main(string[] args) 
        {
            /*EXAMPLES*/

            //SortedSet classes help us with putting the entries alphabetically in order, once we display them.

            SortedSet<string> months = new SortedSet<string>();
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");
            months.Add("May");
            months.Add("June");
            months.Add("July");
            months.Add("August");
            months.Add("September");
            months.Add("October");
            months.Add("November");
            months.Add("December");
            
            Console.WriteLine("The months from A-Z: ");
            foreach (var item in months)
            {
               
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Console.WriteLine();

            months.RemoveWhere(rmw => rmw.StartsWith("J"));
            //The method above will remove the months that are started with letter 'J'.

            Console.WriteLine("After removing the months, which starts with letter J: ");
            foreach (var item in months)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();
            /***********************************ONUR TOTOS**************************************************/


            /*EXAMPLE of HashSet*/

            HashSet<int> numbers = new HashSet<int>();
            numbers.Add(454646);
            numbers.Add(454646);
            numbers.Add(454646);
            numbers.Add(554646);
            numbers.Add(554646);
            numbers.Add(554646);
            numbers.Add(654646);
            numbers.Add(754646);
            numbers.Add(854646);
            numbers.Add(854646);
            numbers.Add(854646);
            numbers.Add(954646);
            numbers.Add(1054646);
            
            Console.WriteLine("Orders of Numbers");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();

            //IMPORTANT NOTE:
            /*From the result; as you can see that even if you add the same data more than once, it will be
            display just one time. That is the distinct feature of the HashSet from other methods. This is also valid
            for all of the data types!!!*/

            Console.WriteLine();
            Console.WriteLine();
            numbers.Remove(854646);
            numbers.Remove(454646);
            Console.WriteLine("After removing the numbers, which starts with 4 and 8: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();

            /***********************************ONUR TOTOS**************************************************/

            /*Example of ListDictionary*/

            ListDictionary schoolClasses = new ListDictionary();
            schoolClasses.Add("Primary", "1,2,3,4");
            schoolClasses.Add("MidSchool", "5,6,7,8");
            schoolClasses.Add("HighSchool", "9,10,11,12");
            Console.WriteLine("Type of Schools: ");
            foreach (DictionaryEntry okul in schoolClasses)
            {
                Console.WriteLine(okul.Key);
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Each type of schools classes:");
            foreach (DictionaryEntry okul in schoolClasses)
            {
                Console.WriteLine(okul.Value);

            }
            Console.ReadKey();

            /***********************************ONUR TOTOS**************************************************/

            //Example of HybridDictionary Class

            HybridDictionary fruits = new HybridDictionary();
            fruits.Add("Strawberry", "1.5$");
            fruits.Add("GreenApple", "2.5$");
            fruits.Add("RedApple", "2.5$");
            fruits.Add("Watermelon", "3.5$");
            fruits.Add("Melon", "4.5$");
            fruits.Add("Pear", "3.5$");
            fruits.Add("Pineapple", "5.5$");
            fruits.Add("Palm", "6.5$");
            fruits.Add("Peach", "7.5$");
            fruits.Add("Grape", "4.5$");
            Console.WriteLine("List of fruits: ");
            Console.WriteLine("   Fruits                    Price(kg)  ");
            foreach (DictionaryEntry frts in fruits)
            {
                Console.WriteLine("   {0,-25}  {1}", frts.Key, frts.Value);
            }
            Console.WriteLine();
            Console.ReadKey();

            //Searching for a specific fruit from the fruits list
        
            if (fruits.Contains("Pear"))
            {
                foreach (DictionaryEntry item in fruits)
                {
                    Console.WriteLine( item.Key);
                }
                
            }
            else
            {
                Console.WriteLine("Not found!");
            }
            
            Console.WriteLine();
            Console.ReadKey();

            /***********************************ONUR TOTOS**************************************************/

            //Example of OrderedDictionary Classes
            /*OrderDictionary Algorithm
             *First, create an object by using OrderDictionary Class.
             *Second, use Add method to insert to values or strings.
             *Then, create an string array in order to count the key values in the list.
             *Finally, display it by using for loop respectively.
            */

            OrderedDictionary soccerTeams = new OrderedDictionary();
            soccerTeams.Add("FB", "FENERBAHCE");
            soccerTeams.Add("GS", "GALATASARAY");
            soccerTeams.Add("BJK","BESIKTAS");
            soccerTeams.Add("TS", "TRABZONSPOR");

            Console.WriteLine("The four biggest teams in TURKEY: ");

            string[] orderS = new string[soccerTeams.Keys.Count];
            soccerTeams.Keys.CopyTo(orderS, 0);
            for (int i = 0; i < soccerTeams.Keys.Count; i++)
            {
                Console.WriteLine("Index: {0}, Abbreviation: {1}, Team: {2}", i, orderS[i], soccerTeams[i]);
            }
            Console.ReadKey();
            Console.WriteLine();

            soccerTeams.RemoveAt(3);
            Console.WriteLine("The three biggest teams in TURKEY: ");
            string[] orderS1 = new string[soccerTeams.Keys.Count];
            soccerTeams.Keys.CopyTo(orderS, 0);
            for (int i = 0; i < soccerTeams.Keys.Count; i++)
            {
                Console.WriteLine("Index: {0}, Abbreviation: {1}, Team: {2}", i, orderS1[i], soccerTeams[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
           

            /***********************************ONUR TOTOS**************************************************/

            //Example of StringCollection
            StringCollection cars = new StringCollection();
            cars.Add("BMW");
            cars.Add("Mercedes");
            cars.Add("Jaguar");
            cars.Add("Ford");
            Console.WriteLine("Car Brands:");
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Combining
            string[] newCars = new string[] { "Fiat", "Audi", "GMC" };
            cars.AddRange(newCars);
            Console.WriteLine("After adding new Car Brands:");
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Removing
            cars.RemoveAt(5);
            Console.WriteLine("After removing a Car Brand:");
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.ReadKey();
            
        }
    }
}
