using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayS  //Arrays & Foreach Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays & Foreach Loop

            /*      What is Array??     */

            /* Arrays are used to store more than one variables. We can use an array to store same type variables
            together.

                ---How to create an array?
            1) The datatype should be declared.
            2) Then, we need to define a variable name.
            3) Later, we can decide how many index the array should have.

            Diagram for Arrays:

            datatype [] variablename = new datatype[numberofindex];

                            OR

            datatype [] variablename = {" ","",......};
            */

            //*Example of creating arrays******************************//

            //int[] sayi = { 1, 3, 5, 75, 55, 666, 555, 8888, 88889, 7878745, 899898, 56564 };
            //string[] gunler = { "pzt", "sali", "carsamba", "persembe", "cuma", "cmt", "pzr" };
            //char[] rakam = { 'a', 'b', 'c', 'd', 'e', ':', '!' };
            //Console.WriteLine(sayi[3]);
            //Console.ReadKey();

            //******************************************************************************************************//

            /* Example (1) */
            //Create an array called cars that takes string inside.Then display the first index of the array?

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i12 = 0; i12 < cars.Length; i12++)
            {
                Console.WriteLine(cars[i12]);
            }
            Console.ReadKey();

            //*****************************************************************************************************/

            /*Example(2)*/
            //Create an array called numbers that takes integer inside. The length of the array needs to be 10.
            //Then, use for loop to display the numbers.
            int[] numbers = new int[10];

            numbers[0] = 0;
            numbers[1] = 1;
            numbers[2] = 2;
            numbers[3] = 3;
            numbers[4] = 4;
            numbers[5] = 5;
            numbers[6] = 6;
            numbers[7] = 7;
            numbers[8] = 8;
            numbers[9] = 9;

            ///*short way of defining the list is =>>*/ /*int[] numbers ={0,1,2,3,4,5,6,7,8,9};*/

            for (int i13 = 0; i13 < numbers.Length; i13++)
            {
                Console.WriteLine(numbers[i13]);
            }
            Console.ReadKey();

            //*****************************************************************************************************/

            /*Example(3)
            Writes a program that has an array that takes 17 integers. Let user enter those integers. Then,
            Find the biggest integer by using FOR loop.
            */

            int[] maxfor = new int[17];
            int i1, max;
            for (i1 = 0; i1 < 17; i1++)
            {
                Console.WriteLine("Please enter {0}.value: ", i1 + 1);
                maxfor[i1] = Convert.ToInt32(Console.ReadLine());
            }
            max = maxfor[0];
            for ( i1 = 0; i1 < 17; i1++)
            {
                if (max < maxfor[i1])
                {
                    max = maxfor[i1];
                }
                
            }
            Console.WriteLine("The biggest integer you entered: {0}", max);
            Console.ReadKey();

            //*****************************************************************************************************/

            /*Example(4)
            Write a program that will have an array with 10 integers. The integers will be selected randomly between 1 and 1000.
            Then, display the summation of the numbers that program created between 500-600; and the amount of numbers between
            100 and 500?
            */

            int[] arraysInt = new int[10];
            int summ = 0, counter12=0;
            Random rndm = new Random();
            for (int i14 = 0; i14 < 10; i14++)
            {
                arraysInt[i14] = rndm.Next(1, 1001);
            }
            for (int i14 = 0; i14 < 10; i14++)
            {
                Console.WriteLine("{0}", arraysInt[i14]);
                if (arraysInt[i14]>=500 && arraysInt[i14]<=600)
                {
                    summ += arraysInt[i14];
                }
                if (arraysInt[i14] >= 100 && arraysInt[i14] <= 500)
                {
                    counter12++;
                }
            }
            Console.WriteLine("\nThe summation of the numbers between 500-600 is: {0} ", summ);
            Console.WriteLine("The amount of the numbers between 100-500 is: {0}", counter12);
            Console.ReadKey();
            //*****************************************************************************************************/

            /*Example(5)
            Write a program that will create square matrixes [3x3] that are called "A" and "B". The user will enter the values,
            and then display if they are equal to each other.
            */

            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int i,j,k=0;

            for ( i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("A[{0},{1}]=", i + 1, j + 1);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for ( i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("B[{0},{1}]=", i + 1, j + 1);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();

            Console.WriteLine("----Matrix A----");
            for ( i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", A[i, j]);
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("----Matrix B----");
            for ( i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", B[i, j]);

                }
                Console.WriteLine();
            }
            for (i = 0; i <=2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    if (A[i, j] != B[i, j])
                    {
                        Console.WriteLine("Matrix A is not equal to Matrix B!");
                        k = 1;
                        break;
                    }
                }
            }

            if (k == 0)
            {
                Console.WriteLine("Matrixes are equal to each other.");
            }
            Console.ReadKey();

            //*****************************************************************************************************/
            //*****************************************************************************************************/
            //*****************************************************************************************************/


            //*************************************/FOREACH LOOP/************************************************/

            /*
            --Foreach Loop is used for listing in arrays.
            --Foreach loop create an variable that will take the indexes in the arrays.Then, help us listing all of them.
            --We can also use it for different algorithms.

                --HOW IT WORKS?

                foreach (var item in collection)
                {
                    code block to be executed;
                }

            --var is variable type.
            --item is a variable name that can be changed into any name you would like to use.
            --collection is the name of the array that we would like to process.

            */
            //*****************************************************************************************************/

            /*Example(1)
            Create an string array called lessons with 4 indexes that are Html,Css,Javascript,C# respectively.
            Display it by using Foreach Loop?
            */

            string[] lessons = { "Html", "Css", "JavaScript", "C#" };

            foreach (string willwrite in lessons)
            {
                Console.WriteLine(willwrite);
            }
            Console.ReadKey();

            //*****************************************************************************************************/

            /*Example(2)
            Create an integer array that will take 10 numbers from User and Display it please.
            */


            int[] numbers1 = new int[10];

            for (int i15 = 0; i15 < 10; i15++)
            {
                Console.WriteLine("Please enter " + (i15 + 1) + ". integer:");
                numbers1[i15] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var printed in numbers1)
            {
                Console.Write(printed + " ");
            }

            //for (int i = 0; i <numbers1.Length; i++)
            //{

            //    Console.WriteLine( i+ ".sayi " + numbers[i]);
            //}
            Console.ReadKey();

            //*****************************************************************************************************/

            /*Example(3)
            Create an int array called "notes" that have 9 indexes. Each index has 9 different students grades.
            If the student grades are greater than 50, display message: Congrats, you passed!
            If not, display message: you failed, work harder!
            */

            int[] notes = { 100, 50, 85, 90, 25, 45, 37, 75, 87 };

            foreach (int grades in notes)
            {

                if (grades >= 50)
                {
                    Console.WriteLine(grades + " :Congrats,You passed!");
                }
                else
                {
                    Console.WriteLine(grades + " :You failed, work harder!");
                }

            }
            Console.ReadKey();



        }
    }
}
