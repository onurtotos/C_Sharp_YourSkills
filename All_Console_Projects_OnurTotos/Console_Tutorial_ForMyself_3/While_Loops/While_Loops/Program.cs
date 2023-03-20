using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops  //(While & Do While) 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WhileLoops (While & Do While) 

            /*Part I - While Loop
             
            -While Loops keep processing a block of code as long as a condition is TRUE!
            -In while loops, the starting point should be defined before the while loop starts!
            Here is an example of while loop syntax:
            
                while (condition)
                {
                    code block to be executed
                }

            ***In the code above example, condition is any expression that returns a Boolean result – true or false.
            ***It determines how long the loop body will be repeated and is called the loop condition.
            ***In this example the loop body is the programming code executed at each iteration of the loop, i.e. whenever the input condition is true.
                
            */
            /***********************************************************************************************************/

            /*Example (1)
            Display the numbers as long as the numbers are less than 5? 
            */
            int i = 0;
            while (i < 5) //5 e kadar True //5 iken False
            {
                Console.WriteLine("Number: " + i);
                i = i + 2;
            }
            Console.ReadKey();

            /***********************************************************************************************************/

            /*Example(2)
            Display the numbers until the User enters 0? 
            */
            int num = 1;
            while (num != 0)
            {
                Console.WriteLine("Please enter an integer: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + num);
            }
            Console.WriteLine("You found it!");
            Console.ReadKey();

            /***********************************************************************************************************/

            /*Example(3)
            Display the summation of the odd numbers
            where the numbers between 0 and 100? 
            */
            int sayi = 0;
            int totalsm = 0;
            while (sayi < 100)
            {
                if (sayi % 2 == 1)
                {
                    Console.WriteLine(sayi);
                    totalsm += sayi;
                }
                sayi++;

            }
            Console.WriteLine("The summation of the odd numbers:" + totalsm);
            Console.ReadKey();

            /***********************************************************************************************************/

            /*Example(4)
            Display the summation of the numbers where 
            it starts from 1 to the number User entered?
            */
            Console.Write("Please enter an integer value: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num12 = 1;
            int sum = 1;
            Console.Write("The sum 1");
            while (num < n)
            {
                num12++;
                sum += num12;
                Console.Write(" + " + num12);
            }
            Console.WriteLine(" = " + sum);
            Console.ReadKey();

            /*  Example 4 step by step!

            First we initialize the variables num and sum with the value of 1.
            In num; we keep the current number,which we add to the sum of the preceding numbers.

            Through each loop we increase num with 1 to get the next number,
            then in the condition of the loop we check whether it is in the range from 1 to n.

            The sum variable contains the sum of the numbers from 1 to num at any time.
            Upon entering the loop we add to sum the next number stored in num.

            We print on the console all num numbers from 1 to n with a separator "+" and the final result of the summing after the loop’s ending.

            The result of the program’s executed as it followed.
            */

            /***********************************************************************************************************/

            /*Example(5)
            Check if the entered number is a prime number?
            */

            Console.WriteLine("Please enter a positive number: ");
            int num23 = Convert.ToInt32(Console.ReadLine());
            int b = 2;
            int c = Convert.ToInt32(Math.Sqrt(num23));
            bool prime = true;
            while (prime && (b <= c))
            {
                if (num23 % b == 0)
                {
                    prime = false;
                }

                b++;
            }
            Console.WriteLine("Prime? " + prime);
            Console.ReadKey();

            /***********************************************************************************************************/

            /*Example(6)
            Write a program that will create a guessing game between 0 and 10 ?
            And display how many times it took for user to find it out!*/

            int usernumber, counter = 0, rndmnumber;
            Random rndm = new Random();
            rndmnumber = rndm.Next(10);
            while (true)
            {
                Console.WriteLine("Enter a guess between 0 and 10: ");
                usernumber = Convert.ToInt32(Console.ReadLine());
                counter++;
                if (usernumber == rndmnumber)
                {
                    Console.WriteLine("Congrats! You found " + usernumber + " at your " + counter + ". guess!");
                    break;
                }
                else
                {
                    Console.WriteLine("Keep trying please!");
                }
            }
            Console.ReadKey();

            /***********************************************************************************************************/


            /*Example(7)
             Guessing Game! --Tip: The numbers should be between 0 and 100? :)
            */
            int guess = 0, jackspot;
            Random rasgele = new Random();
            jackspot = rasgele.Next(0, 100);
            while (guess != jackspot)
            {
                counter = 0;
                counter++;
                Console.WriteLine("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess > jackspot)
                {
                    Console.WriteLine("Decrease your guess!");
                }
                else if (guess < jackspot)
                {
                    Console.WriteLine("Increase your guess!");
                }
            }
            Console.WriteLine("Congrats!");
            Console.WriteLine("You hit the jackspot at your {0}. guess!!", counter);
            Console.ReadKey();

            /***********************************************************************************************************/

            /*Example(8)
            Let's say there is a company that wants to calculate their annual expenses by entering the amounts.
            If the total expenses are greater than 1000000, the program will stop and give a message!
            */
            int expenses, totals = 0;
            while (totals < 1000000)
            {
                Console.WriteLine("Enter your expenses: ");
                expenses = Convert.ToInt32(Console.ReadLine());
                totals += expenses;
                Console.WriteLine("Total Expenses: " + totals);
                if (totals > 1000000)
                {
                    Console.WriteLine("Caution!! You exceeded 1.000.000 TL" + totals);
                    break;
                }
            }
            Console.ReadKey();


            /***********************************************************************************************************/

            /*Example(9)
            There is a company that wants to generate an invoice. The limit for each invoice in total is 7000TL.
            If the invoice exceeds 7000TL, please let them know that they should use e-invoice module.
            */

            int product = 1, invoicetotal = 0;
            while (product != 0)
            {
                Console.WriteLine("Please enter the price of the product: ");
                product = Convert.ToInt32(Console.ReadLine());
                invoicetotal += product;

                if (invoicetotal > 7000)
                {
                    Console.WriteLine("You exceeded 7000TL, please use your e-invoice module!");
                    break;
                }

                Console.WriteLine("So far the total is: " + invoicetotal);
            }
            Console.ReadKey();

            /***********************************************************************************************************/

            /*Example(10)
            Write a program that figures out how many digits the number user entered has?
            */
            Console.WriteLine("Please enter a number:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;

            while (sayi > 0)
            {

                sayi1 /= 10;
                basamak++;
            }

            Console.WriteLine("You have entered " + basamak + " digit number.");
            Console.ReadKey();

            //***********************************************************************************************************//
            //***********************************************************************************************************//

            /*Part-II -Do While
            How Do While Loop is used in the code?
            --Unlike for and while loops, it does control the condition at the end of the code block.
            --
                    do {
                    code block;
                    } while(condition);
            */

            //***********************************************************************************************************//

            /*Example(1)
            Display the numbers as long as the numbers are less than 5?  Compare the code below that
            was written by using While Loop.
            */

            int i7 = 0;
            do
            {
                Console.WriteLine(i7);
                i7++;
            }
            while (i7 < 5);
            Console.ReadKey();

            int a = 10;
            do
            {
                Console.WriteLine(a);
                a--;
            } while (a > 0);
            Console.ReadKey();


            int i8 = 0;
            while (i8 < 5) //it's True till 5 //
            {
                Console.WriteLine("Number: " + i8);
                i8++;
            }
            Console.ReadKey();

            //***********************************************************************************************************//

            /*Example(2)
            Display the numbers until the User enters 0? 
            */

            int usernumber3;
            do
            {
                Console.WriteLine("Please enter an integer: ");
                usernumber3 = Convert.ToInt32(Console.ReadLine());

            } while (usernumber3 != 0);
            Console.WriteLine("You entered 0. The program stopped.");
            Console.ReadKey();

            //***********************************************************************************************************//

            /*Example(3)
            Calculate the factorial of the number that user entered? 
            */
            int usernumber5, fact = 1;
            Console.WriteLine("Please enter an integer: ");
            usernumber5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Factorial of the " + usernumber5);
            do
            {
                fact *= usernumber5;
                usernumber5--;

            } while (usernumber5 > 0);

            Console.Write(" is " + fact);
            Console.ReadKey();

            //***********************************************************************************************************//

            /*Example(4)
            Write a program that will get 10 users age and then display
            how many of them can go to Military or not? Note: Age of 20 or above can enter the military. 
            */
            int i1 = 0;
            int counter1 = 0;
            do
            {
                Console.WriteLine("Please enter " + (i1+1) + ". person's age: ");
                int yas = Int32.Parse(Console.ReadLine());

                if (yas > 20)
                {
                    counter1++;
                }
             
                i1++;
                

            } while (i1 < 10);

            Console.WriteLine("People can go to Military is " + counter);
            Console.WriteLine("People cannot go to Military is " + (10 - counter));

            Console.ReadKey();

            //***********************************************************************************************************//

            /*Example(5)
            Multiply the numbers until the User enters 0 ?
            */

            int multiply = 1;
            int usernumber6;
            do
            {

                Console.WriteLine("Please enter an integer: ");
                usernumber6 = Convert.ToInt32(Console.ReadLine());
                if (usernumber6 == 0)
                {
                    Console.WriteLine("You entered 0. The program stopped.");
                    break;
                }
                multiply *= usernumber6;
                Console.WriteLine("Multiplication of the integers: " + multiply);


            } while (usernumber6 != 0);

            Console.ReadKey();

            //***********************************************************************************************************//

            /*Example for Random-I
            Generate two random numbers and display it in the console. 
            */
            Random random = new Random();
            int num1 = random.Next(50, 101);
            int num2 = random.Next(101, 200);

            Console.WriteLine("Random number 1: " + num1);
            Console.WriteLine("Random number 2: " + num2);

            Console.ReadKey();
            //***********************************************************************************************************//

            /*Example for Random-II
            Generate two random numbers and then sum of the odd numbers between those two random numbers.
            */


            Random random2 = new Random();
            int e = random2.Next(0, 101);
            int f = random2.Next(0, 101);
            Console.WriteLine($"Random numbers: {e}, {f}");

            //// Swap the numbers if number1 is greater than number2
            if (e > f)
            {
                int k = e;
                e= f;
                f = k;
            }


            //// Find odd numbers between number1 and number2 using while loop
            Console.WriteLine($"Odd numbers between {e} and {f}:");
            int current = e;
            int sum123 = 0;
            while (current <= f)
            {
                if (current % 2 == 1)
                {
                    Console.Write(current + "+");
                    sum123 += current;
                }
                current++;
            }
            Console.WriteLine("=" + sum123);
            Console.ReadKey();


            //************************************THANK YOU FOR YOUR TIME!****************************************************//
            //*****************************************   Onur_TOTOS    *****************************************************//

        }
    }
}
