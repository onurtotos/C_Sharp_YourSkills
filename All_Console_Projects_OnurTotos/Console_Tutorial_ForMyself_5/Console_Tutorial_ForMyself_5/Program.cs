using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tutorial_ForMyself_5
{
    internal class Program 
    {
        /* In this tutorial, methods that used in Arrays
        were explained,and demonstrated with examples.
        For more detail, please do not forget to google it! :)
        ************************************* www.onurtotos.com
        */
        static void Main(string[] args)
        {
            /*
             * CreateInstance
             * SetValue
             * GetValue
             * Copy
             * Contains
             * IndexOf
             * LastIndexOf
             * BinarySearch
            */

            /*************************Examples**********OnurToto$***************************/

            /*Example(1)
            Let's think about fields in the university. Use the following **methods to display them in console.
            **CreateInstance;SetValue;GetValue;Copy.
            */

            Array fields = Array.CreateInstance(typeof(string), 5);
            string[] fieldsOption = (string[])fields;
            string[] fieldsOption1 = new string[3];
            fieldsOption[0] = ("Computer Enginnering");
            fieldsOption[1] = ("Graphic and Design");
            fieldsOption[2] = ("Mapping and GIS");
            fieldsOption[3] = ("Biomedical");
            fieldsOption[4] = ("Public Relations");

            for (int i = 0; i < fieldsOption.GetLength(0); i++)
            {
                Console.WriteLine(i + " " + fieldsOption.GetValue(i));
            }

            fieldsOption.SetValue("Mapping and GIS", 3);
            fieldsOption.SetValue("Biomedical", 2);
            Console.WriteLine("\n After SetValue Method");
            for (int i = 0; i < fieldsOption.GetLength(0); i++)
            {
                Console.WriteLine(i + " " + fieldsOption.GetValue(i));
            }

            Array.Copy(fieldsOption, fieldsOption1, 3);
            Console.WriteLine("\n Copying Array");
            for (int i = 0; i < fieldsOption1.GetLength(0); i++)
            {
                Console.WriteLine(i + " " + fieldsOption1.GetValue(i));
            }

            Console.ReadKey();

            /*Description of Example (1)
            
            This is a C# code that creates an array of strings with a length of 5 using the CreateInstance method of the Array class.
            It then assigns some string values to the elements of the array using indexers.

            The code then uses a for loop to print out the values of each element in the fieldsOption array.
            It uses the GetValue method to get the value of each element at the specified index.

            The code then uses the SetValue method to change the value of the element at index 2 to "Mapping and GIS".
            It then uses another for loop to print out the updated values of each element in the fieldsOption array.

            Next, the Array.Copy method is used to copy the first three elements of the fieldsOption array to a new array called fieldsOption1.
            Another for loop is used to print out the values of each element in the fieldsOption1 array.

            Finally, the code waits for user input using the ReadKey method of the Console class.
            */

            /*************************Examples**********OnurToto$***************************/


            /*Example(2)
             * Let's use the following **methods to search for something in the arrays.?
             **Contains,IndexOf.
            */

            string[] medical = {"Internal Medicine", "ENT", "Eyes", "Dermatologist"};
            string clinic;
            Console.WriteLine("Please enter the clinic you would like to see: ");
            clinic = Console.ReadLine();
            if (medical.Contains(clinic)==true)
            {
                Console.WriteLine(" " + (Array.IndexOf(medical, clinic) + 1) + " the clinic has been found");
            }
            else
            {
                Console.WriteLine("Couldn't find the clinic! Here is a list of the available clinics; ");
            }
            for (int i = 0; i < medical.GetLength(0); i++)
            {
                Console.WriteLine(" " + medical.GetValue(i));
            }
            Console.ReadKey();


            /* Description of Example(2)
            
            -Defines an array of strings called medical and initializes it with some medical clinics.
            -The program then prompts the user to enter the name of a clinic they would like to see using the Console.ReadLine() 
            method and stores the input in a string variable called clinic.
            -The code then uses an if statement to check if the entered clinic string is present in the medical array using the Contains method. 
            If it is present, it prints out the index of the clinic in the array plus one (to account for zero-based indexing) 
            along with a message indicating that the clinic has been found.
            -If it is not present, it prints out a message indicating that the clinic could not be found.
            -After that, the code uses a for loop to print out all the clinics in the medical array using the GetValue method.
            -Finally, the code waits for user input using the ReadKey method of the Console class.
            
            */

            /*************************Examples**********OnurToto$***************************/

            /*Example(3)
             *Let's use the LastIndexOf method to search for something in arrays. 
            */
            string[] students = { "Mike", "John", "Onur", "Mohammed", "Lisa", "Melissa", "Natasha", "Stephanie" };
            string searchStdnt;
            Console.WriteLine("Please enter the student you would like to search for: ");
            searchStdnt = Console.ReadLine();
            if (students.Contains(searchStdnt)==true)
            {
                Console.WriteLine( searchStdnt + " has been found at number " + (Array.LastIndexOf(students, searchStdnt) + 1));
                    
            }
            else
            {
                Console.WriteLine("Couldn't find that student! Here is the students list: ");
            }
            for (int i = 0; i < students.GetLength(0); i++)
            {
                Console.WriteLine(" " + students.GetValue(i));
            }

            Console.ReadKey();

            /*Description of Example (3)
            -Defines an array of strings called students and initializes it with some student names. 
            -The program then prompts the user to enter the name of a student they would like to search for using the Console.ReadLine()
            method and stores the input in a string variable called searchStdnt. 
            -The code then uses an if statement to check if the entered searchStdnt string is present in the students array using the Contains method.
            If it is present, it prints out the name of the student and the index of its last occurrence in the array (using LastIndexOf method) 
            plus one (to account for zero-based indexing) along with a message indicating that the student has been found.
            If it is not present, it prints out a message indicating that the student could not be found.
            -After that, the code uses a for loop to print out all the students in the students array using the GetValue method.
            Finally, the code waits for user input using the ReadKey method of the Console class.
            */

            /*************************Examples**********OnurToto$***************************/

            /* Example (4)
             * Let's use BinarySearch method to find what people look for in the arrays? :)
             * * * * NOTE!!:: If the arrays elements are not alphabetically in order, this method cannot find it.
             * * *
             * *
             * Therefore, to find what user searching for, everything should be in order in the array list.
            */

            /*SOLUTION --1--*/
            /*This Solution will not work properly. The code can be executable, however, the result won't be what we want.
            Since we did not put the names in order, the ELSE code block will work.*/
            string[] nameLists = { "Ahmad", "Jordan", "Lebron", "CEDI", "OKUR", "TURKOGLU" };
            string findIT;
            int queNo;

            Console.WriteLine("Please enter the name you are looking for: ");
            findIT = Console.ReadLine();
            queNo = Array.BinarySearch(nameLists, findIT.ToString());

            if (queNo>=0)
            {
                Console.WriteLine("You found it what you are looking for" + (queNo+1) + "");
            }
            else
            {
                Console.WriteLine("Couldn't find it! Here is the list: ");
            }
            for (int i = 0; i < nameLists.GetLength(0); i++)
            {
                Console.WriteLine(" " + nameLists.GetValue(i));
            }
            Console.ReadKey();


            /*SOLUTION --2--*/
            /*This will work properly since we put the name list in order.*/
            string[] nameLists2 = { "Ahmad", "CEDI", "Jordan", "Lebron",  "OKUR", "TURKOGLU" };
            string findIT2;
            int queNo2;

            Console.WriteLine("Please enter the name you are looking for: ");
            findIT2 = Console.ReadLine();
            queNo2 = Array.BinarySearch(nameLists2, findIT2.ToString());

            if (queNo2 >= 0)
            {
                Console.WriteLine("You found it what you are looking for at number: " + (queNo2 + 1));
            }
            else
            {
                Console.WriteLine("Couldn't find it! Here is the list: ");
            }
            for (int i = 0; i < nameLists2.GetLength(0); i++)
            {
                Console.WriteLine(" " + nameLists2.GetValue(i));
            }
            Console.ReadKey();

            /* Description of Example (4)
             - Defines an array of strings called nameLists and initializes it with some names. 
             - The program prompts the user to enter the name they are looking for using the Console.ReadLine()
             method and stores the input in a string variable called findIT.
             - The code then uses the Array.BinarySearch() method to search for the findIT string in the nameLists array.
              If the search is successful (i.e., queNo is greater than or equal to zero), the program prints out a message
            indicating that the name has been found along with its index in the array (plus one to account for zero-based indexing).
              If the search is unsuccessful, the program prints out a message indicating that the name could not be found.
             - After that, the code uses a for loop to print out all the names in the nameLists array using the GetValue method.
            
            Finally, the code waits for user input using the ReadKey method of the Console class.
            */
        }
    }
}
