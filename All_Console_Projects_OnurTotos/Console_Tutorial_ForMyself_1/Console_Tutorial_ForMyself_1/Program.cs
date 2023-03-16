using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Tutorial_ForMyself_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /********************Getting Started!***************OnurTotos************/

            /*C-Sharp (C#) is a object oriendted programming that is developed by Microsoft.
            
            Generally used for Desktop Apps,Mobile Apps,Web Development,Games,Database App, etc.

            Why C#?
            -Easy to learn,
            -One of the most popular programming language,
            -If you know C,C++ and Java; then you can easily switch to C# or vice versa.
            For IDE; Visual Studio 2019 or newer can be usable.
            */

            //In C#,if we want to make short comment lines we use //.
            /*If we want to make a long comment or description about the code; we use ==> /**/
            /* 
             -Here you are looking at long comment or description lines 
            */

            /******************************PART-1******************************************/

            /* The code itself always finishes with the semicolon(;)*/
            //C# is a case-sensitive:"Mycode" and "mycode" have different meanings.

            //Let's Get Started!
            //Console.Write(); Writes the specified data to the standard output stream.

            /*Console.WriteLine(); Writes the specified data followed by the current line
            terminator to the standard output stream*/

            /*Example: You can try the codes below to see how they are different from each other.
            //Console.Write("Fenerbahce");
            //Console.WriteLine("Merhaba Dunya!");*/

            /*NOTE: Within the WriteLine or Write methods, we can use them as a calculator.*/
            /*Example
            Console.Write(5 + 5);
            Console.WriteLine(5 * 5);
            */

            /*Console.ReadKey(); 
            This method help us to enter the value and to see the result in the console display.
            //Example:
            Console.WriteLine(15*25);
            Console.ReadKey();
            */

            /******************************PART-2******************************************/

            /* Data Types and its Ram usage */

            /* Signed and Unsigned (etc.; sbyte= can keep the negative numbers; uint=can keep only positive numbers;)
            -Byte (1byte) = this data type stores only the numbers between 0 and 255.                
            -sbyte(1byte) = this data type stores only the numbers between -128 and 127.
            -short(2byte) = this data type stores only the numbers between -32768 and 32768.
            -ushort(2byte)= this data type stores only the numbers between 0 and 65535.
            -int(4byte)   = this data type stores only the numbers between -2,147,483,648 and 2,147,483,648.
            -uint(4byte)  = this data type stores only the numbers between 0 and 4,294,967,295.
            -long(8byte)  = this data type stores only the numbers between -9,223,372,036,854,775,808 and 9,223,372,036,854,775,808.
            -Ulong(8byte) = this data type stores only the numbers between 0 and 18,446,774,073,709,551,615.
            -float(4byte) = -1.5x10^-45 and 3.4x10^38 (example of using it : 3.12f).
            -double(8byte)= -5.0x10^-324 and 1.7x10^308.
            -decimal(16byte)= can take 29 digits number starts from -79......... and + 79.....
            -boolean(2byte) = can take true or false. This is a logical data type.
            -char(2byte)  = can only take one character. (example= 'c','!','.','1')
            -string(amount of character x 2 byte) = can take 2 billion characters in it.  (ex: "sadasdasdasdasdadas", "asdas!@!#@3434")
            */

            /*-The way how we define our data type is below:
            type variablename = value;
            
            /*Examples 
            int a, b, c; // Integers
            string d, e; // Arrays
            char f; // Character
            double g //Double
            boolean h; //True or False 
            float ijk; // Float
            a = 5;
            b = 10;
            c = 15;
            d = "Galatasaray";
            e = "Besiktas";
            f = 'K';
            g = 3.5;
            h = true; or false
            ijk= 7.5f */


            /*There are couple ways of displaying the values in Console.WriteLine();
            -Either you can use "quotation marks" + variable name;
            //Console.WriteLine("Hello " + d+ " " + e);

            -Or you can use the index number of the variables within the curly braces
            inside the "quotation marks" and then using their variable names respectively.
            Note that the INDEX NUMBER always start from {0}!
            //Console.WriteLine("Hello {0} {1}",d,e);
            */

            /******************************PART-3******************************************/

            /*
            The Conversion Method:
            -C# is based on string data types that needs to be converted in order to display other
            data types!

            Example:
            string myname=Onur;
            Console.WriteLine(myname);

            -The example above will not generate an error as it is already in string data. 
            -However,following example will cause an error;

            int mynumber=13;
            Console.WriteLine(mynumber);
            -The error would be like: Cannot implicitly convert type 'string' to 'int'.
            -Therefore, we need to convert int to string.

            But How? Here is the solution;
            int mynumber=13;
            mynumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mynumber);

            -or you can directly do this inside Console.WriteLine();

            Console.WriteLine(Convert.ToString(mynumber));

            -And then result will be displayed as it is 13!
            
            /*-The Same Logic goes for the other dataTypes as well!
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
            ....
            ....
            ....
            */
            /******************************PART-4******************************************/

            /*
            C# OPERATORS

            Arithmetic Operators
            +	Addition	    Adds together two values	(x + y)	
            -	Subtraction	    Subtracts one value from another	(x - y)	
            *	Multiplication	Multiplies two values	 (x * y)	
            /	Division	    Divides one value by another (x / y)	
            %	Modulus	        Returns the division remainder	 (x % y)	
            ++	Increment	    Increases the value of a variable by 1	(x++)	
            --	Decrement	    Decreases the value of a variable by 1	(x--)
            

            Assignment Operators
            =	        x = 5	            x = 5	
            +=	        x += 3	            x = x + 3	
            -=	        x -= 3	            x = x - 3	
            *=	        x *= 3	            x = x * 3	
            /=	        x /= 3	            x = x / 3	
            %=	        x %= 3	            x = x % 3	
            &=	        x &= 3	            x = x & 3	
            |=	        x |= 3	            x = x | 3	
            ^=	        x ^= 3	            x = x ^ 3	
            >>=	        x >>= 3         	x = x >> 3	
            <<=	        x <<= 3	            x = x << 3

            Comparison Operators
            ==			Equal to						x == y	
            !=			Not equal						x != y	
            >			Greater than					x > y	
            <			Less than						x < y	
            >=			Greater than or equal to		x >= y	
            <=			Less than or equal to			x <= y
            
            Logical Operators
            
            &&          Logical And     =Returns True if both statements are true
            ||          Logical Or      =Returns Ture if one of the statements is true
            !           Logical Not     =Reverse the result, return false if the result is true

           ---Useful Escape Operators--

           *Escape characters	Result  	Description
                \'	                '	    Single quote
                \"	                "	    Double quote
                \\	                \	    Backslash
                \n	            space       New Line	
                \t	            space       Tab	
                \b	            space       Backspace
           */


            /******************************PART-5******************************************/

            /*CONSOLE EXAMPLES*/

            /*NOTE: If you would like to display the examples below without opening a new editor screen,
            you can just uncomment each example.However, there might be use of same variable name in a different
            example. Therefore, please be informed and careful about it.*/

            /**********************************************************************************************/

            /*Example1
            -Write a console app that will print "Hello World, I am a C-sharper!" on the console by using WriteLine Method?
            */

            //Console.WriteLine("Hello World, I am a C-sharper!");
            //Console.ReadKey();

            /**********************************************************************************************/

            /*Example2
            -Write a console app that will print "Hello World, I am a C-sharper!" on the console by using Write Method?
            */

            //Console.Write("Hello World, I am a C-sharper!");
            //Console.ReadKey();

            /**********************************************************************************************/

            /*Example3
            -Use Write method to display two integers, but first define them
            */

            //int a,b;
            //a=1; b=99;
            //Console.Write("A={0}",a);
            //Console.Write("B={0}",b);
            //Console.ReadKey();

            /**********************************************************************************************/

            /*Example4
            -Create a console app that will ask user its name and surname, then display it in console? 
            */

            //string z;
            //Console.WriteLine("Please enter your name and surname: ");
            //z = Console.ReadLine();
            //Console.ReadKey();

            /**********************************************************************************************/

            /*Example5
            -Write a console app that will get 2 numbers from user and display the summation of them?
            */

            //int a, b,total=0;
            //Console.WriteLine("Please enter the first number: ");
            //a =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the second number: ");
            //b = Convert.ToInt32(Console.ReadLine());
            //total = a + b;
            //Console.WriteLine("Result: " + total);
            //Console.ReadKey();

            /**********************************************************************************************/

            /*Example6
            Write an app where three integers have same value and display the multiplication of them?
            */
            //int z, t, p, total1=0;
            //z = t = p = 60;
            //total1 = z * t *p;
            //Console.Write(total1);
            //Console.ReadKey();

            /**********************************************************************************************/

            /*Example7
            Write an app where it has a boolean data type, and display the result in console? 
            */
            //bool result = 20 > 10;
            //Console.WriteLine(result);
            //Console.ReadKey();

            /**********************************************************************************************/

            /*Example8
            -Write a console app that will get 2 numbers from user and find the biggest number?
            Note: Math is a class of the System. For now, please search it on internet to get more sense of it.
            */
            //int x, y;
            //Console.WriteLine("Please enter the first number: ");
            //x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter the second number: ");
            //y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Biggest Number: " + Math.Max(x, y));
            //Console.ReadKey();

            /**********************************************************************************************/

            /*Example9
            -Write a console app that will get 4 integers from User. First,find the summation of the numbers.
            Then, find the average of those numbers that user entered?
            */

            //int a, b, c, d;
            //double Avrg, Total;
            //Console.WriteLine("Please enter your first number: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter your second number: ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Please enter your third number: ");
            //c = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your fourth number: ");
            //d = Int32.Parse(Console.ReadLine());
            //Total = a + b + c + d;
            //Avrg = Total / 4;
            //Console.WriteLine("Summation: {0}", Total);
            //Console.WriteLine("Average: " + Avrg);
            //Console.ReadKey();


            /*NOTE ABOUT Example9:
            Since we are trying to find the average of the numbers, we need to define Total and Avrg variables
            as a double. This is because of the fact that when the division is used, the result might be decimal.
            Therefore, we define them as a "double".
            */


            /**********************************************************************************************/

            /*Example10
            -Write a console app that will show the ASCII code of the key that user pressed?
            */

            //int tus;
            //Console.Write("Please press any key on the keyboard: ");
            //tus = Console.Read();
            //Console.WriteLine("The ASCII code of the key you just pressed: " + tus);
            //Console.ReadKey();

            /**********************************************************************************************/

            /*Example11
            - Write a console app that will be using BackgroundColor and ForegroundColor methods to change
            console color and display your hometown name in a different color?
            */

            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Clear();
            //Console.CursorSize = 5;
            //Console.WriteLine("TURKEY");
            //Console.ReadKey();

            /**********************************************************************************************/

            /*Example12
            - Write a console app that will use ConsoleKeyInfo method to tell users which key they jsut pressed?
            */
            //ConsoleKeyInfo keyInfo;
            //Console.WriteLine("Please enter a key: ");
            //keyInfo = Console.ReadKey();
            //Console.WriteLine();
            //Console.WriteLine("You just pressed " +keyInfo.Key.ToString());
            //Console.ReadKey();

        }
    }
}
