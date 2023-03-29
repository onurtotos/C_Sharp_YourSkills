using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Console_Tutorial_ForMyself_6
{
    internal class Program  /*Lists and Collections*/
    {

        static void Main(string[] args)
        {
            /**********************************EXAMPLES***************************OnurToto$****************/

            /*Example(1)
             * Let's create an array from System.Collections library, then use Add and Insert methods to 
             add new values into the array.
            */

            //First, go top and add using System.Collections library.
            ArrayList arrys = new ArrayList();
            arrys.Add(5);
            arrys.Add("John");
            arrys.Add('&');
            arrys.Add(true);
            arrys.Add(13.5);
            Console.WriteLine("Here is the elements of arrys list: ");
            foreach (object item in arrys)
            {
                Console.WriteLine(item);
            }
            //By using Insert and Add methods to add new elements into the list.
            arrys.Insert(1, "Fenerbahce");
            //Insert helps us adding a value into the specific location that we would like to add.
            arrys.Insert(2, '*');
            Console.WriteLine();
            Console.WriteLine("After using Insert and Add method to enlarge the arrys list");
            foreach (object item1 in arrys)
            {
                Console.WriteLine(item1);
            }
            Console.WriteLine();
            Console.ReadKey();

            /**********************************EXAMPLES***************************OnurToto$****************/

            /*Examples(2)
             * Create an array from ArrayList class then use "Sort" method to put the indexes in order, and
             use "Reverse" method to inverse the list. Finally, use "Count" method to display the elements
             in the array?
            */

            ArrayList numbersList = new ArrayList();
            numbersList.Add(100);
            numbersList.Add(900);
            numbersList.Add(300);
            numbersList.Add(1100);
            numbersList.Add(500);
            numbersList.Add(700);
            
            //Displaying the numbersList
            Console.WriteLine("The elements of numbersList arraylist: ");
            foreach (var item2 in numbersList)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine();
            
            //Displaying the numbersList by ascending
            numbersList.Sort();
            Console.WriteLine("numbersList after using sort method: ");
            foreach (var item3 in numbersList)
            {
                Console.WriteLine(item3);
            }
            Console.WriteLine();

            //Displaying the numberList inversly
            numbersList.Reverse();
            Console.WriteLine("numbersList after using reverse method: ");
            foreach (var item4 in numbersList)
            {
                Console.WriteLine(item4);
            }
            Console.WriteLine();

            //Displaying the number of elements in numberList
            Console.WriteLine("numbersList after using counting method: ");
            for (int i = 0; i < numbersList.Count; i++)
            {
                Console.WriteLine(numbersList[i]);

            }
            Console.WriteLine();
            Console.ReadKey();

            /**********************************EXAMPLES***************************OnurToto$****************/

            /*Example(3)
            Create an array by using ArrayList classes to call methods respectively Remove,RemoveAt and Clear to
            see what is happening actually? :)
            */

            ArrayList abcd = new ArrayList();
            abcd.Add("123456");
            abcd.Add(123456);
            abcd.Add("L");
            abcd.Add("LebronJ");
            abcd.Add("Merso");
            abcd.Add("WHO");
            abcd.Add('.');

            Console.WriteLine("The elements of abcd: ");
            foreach (var item5 in abcd)
            {
                Console.WriteLine(item5);
            }
            Console.WriteLine();

            //Now, it's time to use Remove and RemoveAt methods!

            abcd.Remove("L");
            abcd.Remove(123456);
            abcd.RemoveAt(3);
            abcd.RemoveAt(0);
            Console.WriteLine("The elements of abcd after using Remove and RemoveAt methods:");
            foreach (var item6 in abcd)
            {
                Console.WriteLine(item6);
            }
            Console.WriteLine();
            //Finally, time to call for Clear method. Please have a look carefully at Console after
            //Clear method works!

            abcd.Clear();
            Console.WriteLine("The elements of abcd after using Clear method:  ");
            foreach (var item7 in abcd)
            {
                Console.WriteLine(item7);
            }
            Console.WriteLine();
            Console.WriteLine("Clear methods clear all of the elements,text, numbers, etc.");
            Console.ReadKey();

        }
    }
}
