using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Examples //C# IF-ELSE and SWiTCH-CASE EXAMPLES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            /*Example(1):
            Get a price from a User, and then calculate KDV rate which is %18.
            Then calculate the summation of the price and KDV.*/

            double a, kdv = 0.18, total;
            Console.WriteLine("Please write a price of the product: ");
            a = Convert.ToDouble(Console.ReadLine());
            total = a + (a * kdv);
            Console.WriteLine("Total Price Included KDV: " + total);
            Console.ReadKey();

            /*Example(2):
            Get a price and a KDV rate from a User, then calculate the
            total price.*/

            double c, d, total1;
            Console.WriteLine("Please write a price of the product: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please write a KDV rate: ");
            d = Convert.ToDouble(Console.ReadLine());
            total1 = c + ((c * d) / 100);
            Console.WriteLine("Total Price: " + total1);
            Console.ReadKey();

            /*Example(3):
            Take 2 numbers from a User and then display the biggest number by using if-else.*/

            double g, h;
            Console.WriteLine("Please enter the first number: ");
            g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            h = Convert.ToDouble(Console.ReadLine());
            if (g > h)
            {
                Console.WriteLine("The first number is bigger than second number!" + " " + g + ">" + h);
            }
            else if (h > g)
            {
                Console.WriteLine("The second number is bigger than first number!" + " " + h + ">" + g);
            }
            else
            {
                Console.WriteLine("The numbers are equal!" + g + "=" + h);
            }
            Console.ReadKey();
            /*NOTE: The code below uses Math function decide which number is bigger.
            However; by using if, we can create schema easily and add different condition.
                /*Console.WriteLine("Biggest Number: " + Math.Max(g, h));*/

            /*Example(4)
            Get a number from a User, and then decide if it is a odd or even number?*/

            double b;
            Console.WriteLine("Please enter a number: ");
            b = Convert.ToDouble(Console.ReadLine());
            if (b % 2 == 0)
            {
                Console.WriteLine("This is a even number! " + b);
            }
            else
            {
                Console.WriteLine("This is a odd number! " + b);
            }
            Console.ReadKey();

            /*Example(5)
            Get a number from a User, and then decide if it is a negative or positive
            number */

            double betul;
            Console.WriteLine("Please enter a numnber: ");
            betul = Convert.ToDouble(Console.ReadLine());
            if (betul < 0)
            {
                Console.WriteLine("This is a negative number! " + betul);
            }
            else
            {
                if (betul == 0)
                {
                    Console.WriteLine("This is a neutral number! ");
                }
                else
                {
                    Console.WriteLine("This is a positive number! " + betul);
                }
            }
            Console.ReadKey();

            /*Example(6)
            Get a number from a User, and then decide if the number can be divided
            by 3 and 6 at the same time. If that works, display it on the console.*/

            double baran;
            Console.WriteLine("Please enter a number: ");
            baran = Convert.ToDouble(Console.ReadLine());
            if (baran % 3 == 0 && baran % 6 == 0)
            {
                Console.WriteLine("The entered number is divisible by 3 and 6. " + "You entered:" + baran);
            }
            else
            {
                Console.WriteLine("The entered number is not divisible by 3 and 6. " + "You entered:" + baran);
            }
            Console.ReadKey();


            /*Example(7)
            Login prompt: Let User enter a username and password;
            if username = admin and password = 1234, Welcome!
            if not; please try again:)*/

            string eren;
            int sifre;
            Console.WriteLine("Please enter your username: ");
            eren = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            sifre = Convert.ToInt32(Console.ReadLine());

            if (eren == "admin" && sifre == 1234)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("Please try again!");
            }
            Console.ReadKey();


            /*HomeWork - Hiring Challenge
            int yas;
            string egitimseviyesi,adsoyad, cinsiyet;
            char askerlik, ehliyet;*/

            /*Requirements
            Age Range: 20-35
            Education Level: University or Master Degree
            Sex: Woman or Man
            If Man is choosen, then ask if the person had done their military duty.
            Ask for Driver License

            At the end, display: Dear + Name Surname + You will be contacted soon.*/
            int yas;
            string uni, adsoyad, cinsiyet;
            char asker, ehliyet;

            Console.WriteLine("Please enter your name and surname: ");
            adsoyad = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Education: HighSchool(Li) / University(Univ) / MasterDegree(YL) ");
            uni = Console.ReadLine();
            Console.WriteLine("Your Sex: (Kadin/Erkek)");
            cinsiyet = Console.ReadLine();
            Console.WriteLine("Do you have a driver license? E/H ");
            ehliyet = Convert.ToChar(Console.ReadLine());

            if (cinsiyet == "Kadin")
            {
                Console.WriteLine("The criteria is eligible.");
            }
            else if (cinsiyet == "Erkek")
            {

                Console.WriteLine("Have you done your military duty? E/H ");
                asker = Convert.ToChar(Console.ReadLine());
                if (asker == 'E' || asker == 'e')
                {
                    Console.WriteLine("The criteria is eligible.");

                }
                else
                {
                    Console.WriteLine("The criteria is not eligible. ");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Entry! ");
            }


            if (yas >= 18 && yas < 42)
            {
                Console.WriteLine("The criteria is eligible.");
            }
            else
            {
                Console.WriteLine("Sorry, the criteria is not eligible.");
            }
            if (uni == "Univ" || uni == "YL")
            {
                Console.WriteLine("The criteria is eligible.");
            }
            else
            {
                Console.WriteLine("The criteria is not eligible.");
            }
            if (ehliyet == 'E' || ehliyet == 'e')
            {
                Console.WriteLine("The criteria is eligible.");
            }
            else
            {
                Console.WriteLine("The criteria is not eligible.");
            }

            Console.Write("Dear " + adsoyad + "," + "\nThank you for your time." + "You will be contacted soon.");
            Console.ReadKey();




            /* Example:
                Weather Forecast
            If the weather is rainy, take your umbrella when you go out!
            If the weather is shiny(sunny), go out without thinking!
            If the weather is snowy, do not forget to call 911!
            else stay at your place, and drink a Turkish Tea!*/

            Console.WriteLine("Please type the weather condition here: Sunny/Rainy/Snowy");
            string weather;
            weather = Console.ReadLine();

            if (weather == "Sunny")
            {
                Console.WriteLine("go out without thinking!");
            }
            else if (weather == "Rainy")
            {
                Console.WriteLine("Take your umbrella with you when you go out!");
            }
            else if (weather == "Snowy")
            {
                Console.WriteLine("do not forget to call 911!");
            }
            else if (weather == " ")
            {
                Console.WriteLine("Stay at your place and drink a cupf of Turkish Tea!");
            }
            else
            {
                Console.WriteLine("Incorrect Entry!");
            }
            Console.ReadKey();


            /*

            Switch-Case-Default-Break



            switch (Condition Kosul)
            {
                case x:
                    Console.WriteLine("shjdahfhakfjajf\");
                        break;

                case aewewrwerw:
                    Console.WriteLine("adadada");
                        break;

                default://else gorevi gorur//
                    Console.WriteLine("asdadada");
                         break;

            }
            */

            /*Example
            Get a number from a User, and display the days of the week depending on the number
            that User entered?*/

            Console.WriteLine("Please enter a number between 1-7: ");
            int number;
            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Incorrect Entry! Please type a number between 1-7!");
                    break;
            }
            Console.ReadKey();


            /*
            Example: Get 2 numbers from a User. If the User enter 1, do addition;
            if the User enter 2, do subtraction. If the user enter 3, multiply the numbers.
            If the User enter 4, do division.
            */

            double sayi1, sayi2, islem;

            Console.WriteLine("Please enter the first number: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the type of the operator: 1-Addition\n2-Subtraction\n3-Multiply\n4-Division");
            islem = Convert.ToDouble(Console.ReadLine());

            switch (islem)
            {
                case 1:

                    Console.WriteLine("Result: " + (sayi1 + sayi2));
                    break;
                case 2:
                    Console.WriteLine("Result: " + (sayi1 - sayi2));
                    break;
                case 3:
                    Console.WriteLine("Result: " + (sayi1 * sayi2));
                    break;
                case 4:
                    Console.WriteLine("Result: " + (sayi1 / sayi2));
                    break;
                default:
                    Console.WriteLine("Incorrect Entry");
                    break;
            }
            Console.ReadKey();

            /*
             Example: Get a Day Name from User. Then decide if it is a weekday or weekend.
             Then display if it is a weekday; No pain, No gain!; If it is a weekend, then
             display: Let's go out and get some fun!

             */

            string day;
            Console.WriteLine("Please enter a full day name (such as Monday, etc.): ");
            day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("No pain, No gain! Keep up the work!");
                    break;
                case "Tuesday":
                    Console.WriteLine("No pain, No gain! Keep up the work!");
                    break;
                case "Wednesday":
                    Console.WriteLine("No pain, No gain! Keep up the work!");
                    break;
                case "Thursday":
                    Console.WriteLine("No pain, No gain! Keep up the work!");
                    break;
                case "Friday":
                    Console.WriteLine("No pain, No gain! Keep up the work!");
                    break;
                case "Saturday":
                    Console.WriteLine("Let's go out and get some fun!");
                    break;
                case "Sunday":
                    Console.WriteLine("Let's go out and get some fun!");
                    break;
                default:
                    Console.WriteLine("Incorrect Entry! Try again.");
                    break;

            }
            Console.ReadKey();

          

        }
    }
}


