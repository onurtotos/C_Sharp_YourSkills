using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*Please do not forget giving me feedback, if you read this!
 * Thanks,
 * Onur :)
*/


namespace Console_Tutorial_ForMyself_7
{
    public class Program     //ArrayList Class and its commonly used methods
    {
        /**************************************EXAMPLES**********************OnurToto$************************************/
        static void Main(string[] args)
        {
            /*Example(1)
             * Create an array from ArrayList Class and then use the following methods;
             * AddRange,RemoveRange,GetRange,InsertRange?
            */

            //Create an ArrayList
            ArrayList stuff = new ArrayList();
            stuff.Add("Computer Engineering");
            stuff.Add("GIS and Mapping");
            stuff.Add("Software Engineering");
            Console.WriteLine("Commonly chosen fields at the universities: ");
            foreach (var item in stuff)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Create another ArrayList
            ArrayList newStuff = new ArrayList();
            newStuff.Add("Cloud Computing");
            newStuff.Add("Civil Engineering");
            newStuff.Add("Machine Engineering");


            //This is the code block, where we add newStuff List to stuff List.
            stuff.AddRange(newStuff);
            Console.WriteLine("After adding new fields to the universities: ");
            for (int i = 0; i < stuff.Count; i++)
            {
                Console.WriteLine(stuff[i]);
            }
            Console.WriteLine();

            //This is the code block, where we remove the indexes with a specified range. 
            stuff.RemoveRange(0, 2);
            Console.WriteLine("After removing some fields from the universities: ");
            foreach (var item in stuff)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //This is the code block, where we insert some new indexes with start of specified index.
            ArrayList extStuff = new ArrayList();
            extStuff.Add("Telecommunication");
            extStuff.Add("Psychology");
            extStuff.Add("Physiotherapy");
            stuff.InsertRange(3, extStuff);

            Console.WriteLine("After adding extra fields to the universities: ");
            foreach (var item in stuff)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            //This is the code block, where we display the specific range from an arrayList by creating a new ArrayList.
            ArrayList finalStuff = stuff.GetRange(3,3);
            Console.WriteLine("The fields that were added with extra quota: ");
            foreach (var item in finalStuff)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(finalStuff.Count);
            Console.WriteLine();
            Console.ReadKey();

            /**************************************EXAMPLES**********************OnurToto$************************************/

            /*Example(2)
             * Create an array from ArrayList Class and then use the following methods;
             * CopyTo,Clone, and ToArray?
            */

            //Create an array
            string[] teamS= new string[6];
            teamS.SetValue("Fener", 0);
            teamS.SetValue("Cimbom", 1);
            teamS.SetValue("Mardin", 2);
            Console.WriteLine("Champions League");
            foreach (var item in teamS)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Create an ArrayList
            ArrayList newTeams = new ArrayList();
            newTeams.Add("Bejiktash");
            newTeams.Add("Manchester");
            newTeams.Add("Liverpool");


            //Here, we copy the elements in the newTeams to the teamS array.
            newTeams.CopyTo(teamS, 3);
            Console.WriteLine("New Champions League Teams");
            foreach (var item in teamS)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Here, we clone newTeams array into the waitList array.
            ArrayList waitList = new ArrayList();
            waitList = (ArrayList)newTeams.Clone();
            Console.WriteLine("Teams that got the next stage: ");
            foreach (var item in waitList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Here, ToArray also acts as it Clones.
            string[] newList = (string[])waitList.ToArray(typeof(string));
            Console.WriteLine("New Team Members");
            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine();

            /**************************************EXAMPLES**********************OnurToto$************************************/


            /*Example(3)
            * Create an array from SortedList Class, and then put the teams in order from A-Z
            * where they are entered randomly?
            */
           
            SortedList basketballTeams = new SortedList();
            basketballTeams.Add("FB","FBULKER");
            basketballTeams.Add("GS", "GSTERRA");
            basketballTeams.Add("BJK", "BJKGRUNDIG");
            basketballTeams.Add("TS", "TSKULUP");
            Console.WriteLine("EURO League Members: ");
            foreach (DictionaryEntry item in basketballTeams)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine();

            /**************************************EXAMPLES**********************OnurToto$************************************/

            /*Example(4)
            * Create an array from Generic Collection Class, and then use List Class to create array?
            */

            List<string> hospitaL = new List<string>();
            hospitaL.Add("Internal Medicine");
            hospitaL.Add("Eye Doctor");
            hospitaL.Add("Ear-Nose-Throat");
            Console.WriteLine("Our Policlinics: ");
            foreach (var item in hospitaL)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            hospitaL.RemoveAt(1);
            hospitaL.Add("Kids");
            hospitaL.Add("General Surgery");
            Console.WriteLine("Here, we remove some of the departmants from our policlinics, and add new ones: ");
            Console.WriteLine("Current Policlinics List");
            foreach (string item in hospitaL)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.ReadKey();

            /**************************************EXAMPLES**********************OnurToto$************************************/

            /*Example(5)
            * Create an array from Generic Collection Class, and then use LinkedList Class to create array?
            */

            LinkedList<string> shoppingMall = new LinkedList<string>();
            shoppingMall.AddFirst("Nike");
            shoppingMall.AddLast("Fener");
            shoppingMall.AddLast("H&M");
            Console.WriteLine("Our Shopping Centers");
            foreach (string item in shoppingMall)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            shoppingMall.RemoveFirst();
            shoppingMall.AddFirst("Adidas");
            shoppingMall.AddLast("Apple");
            Console.WriteLine("Final Category");
            foreach (string item in shoppingMall)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(); 
            Console.ReadKey();

            /**************************************EXAMPLES**********************OnurToto$************************************/

            /*Example(6)
            * Create an array from Generic Collection Class, and then use SortedDictionary class to create array?
            */

            SortedDictionary<string, string> keyValuePairs = new SortedDictionary<string, string>();
            keyValuePairs.Add("Onur Totos","-Software Developer");
            keyValuePairs.Add("Elon Musk","-Business Developer");
            keyValuePairs.Add("Bill Gates","-Software Developer");
            keyValuePairs.Add("Zuckenberg","-Business Developer");
            keyValuePairs.Add("Lebron James","-Business Developer");
            keyValuePairs.Add("Harvey Specter", "Lawyer");
            Console.WriteLine("The list of our magicians in this world: ");
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine();

            
            keyValuePairs.Remove("Harvey Specter");
            Console.WriteLine("After removing one of our magicians from the list:");
            foreach (var item in keyValuePairs)
            {
               
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine();


            var oRdeR = from item in keyValuePairs orderby item.Value descending select item.Value;
            Console.WriteLine("Ordered List of Our Magicians Occupations by ascending");
            foreach (var item in oRdeR)
            {
                
                Console.WriteLine(item);
            }
                
            
            Console.ReadKey();
        }
    }
}
