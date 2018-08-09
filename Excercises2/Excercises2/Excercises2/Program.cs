using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises2
{
    class MarketingFirm
    {
        //A marketing firm wants to keep record of its employees.Each record
        //would have the following characteristics – first name, family name, age,
        //gender (m or f), ID number, unique employee number(27560000 to
        //27569999). Declare the variables needed to keep the information for a
        //single employee using appropriate data types and descriptive names.

        public string firstName;
        public string familyName;
        public int age;
        public char gender;
        public int id;


    }
    class Results
    {
        private const int V = 72;

        static void Main(string[] args)
        {
            //Declare five variables choosing for each of them the most
            //appropriate of the types byte, sbyte, short, ushort, int,
            //uint, long, ulong to represent the following values: 52130,
            //-115, 4825932, 97, -10000.

            byte a = 97;
            sbyte b = -115;
            int c = 4825932;
            int d = 52130;
            int e = -10000;
            short f = 2200;

            long z = a + b + c + d + f;

            //Which of the following values can be assigned to a variable
            // of type float and which to a variable of type double:
            //34.567839023, 12.345, 8923.1234857, 3456.091 ?

            float a1 = 12.345F;
            float b1 = 3456.091F;
            double c1 = 34.567839023;
            double d1 = 8923.1234857;

            //Write a program that safely compares floating-point numbers
            //with precision of 0.000001.Examples:
            //(5.3 ; 6.01) → false; (5.00000001 ; 5.00000003) → true

            float a22 = 14.0003F;
            float a23 = 15.67F;
            Console.WriteLine(a22 == a23);

            float a24 = 14.000000001F;
            float a25 = 14.0000000003F;
            Console.WriteLine(a24 == a25);



            //Declare an integer variable and assign it with the value
            //254 in hexadecimal format. Use Windows Calculator to
            //find its hexadecimal representation.

            int g = 0xFE;
            Console.WriteLine(g);
            

            // Declare a character variable and assign it with the symbol
            //that has Unicode code 72.Hint: first use the Windows
            //Calculator to find the hexadecimal representation of 72.

            char i = (char) 72;
            Console.WriteLine(i);

            //Declare a boolean variable called isFemale and assign
            //an appropriate value corresponding to your gender.

            Boolean isFemale = false;
            Console.WriteLine(isFemale);

            //Declare two string variables and assign them with “Hello” and “World”.
            //Declare an object variable and assign it with the concatenation of the first two
            //variables(mind adding an interval).Declare a third string variable and
            //initialize it with the value of the object variable(you should perform type
            //casting).

            string gr = "Hello ";
            string wr = "World!";
            object sr = gr + wr;
            string gw = (string) sr;
            Console.WriteLine(gw);

            //Declare two string variables and assign them with following value:
            //The "use" of quotations causes difficulties.
            //Do the above in two different ways: with and without using quoted strings.

            string quotes = "The \"use\" of quotations causes difficulties.";
            string quotes1 = "\"The \"use\" of quotations causes difficulties.\"";
            Console.WriteLine(quotes);
            Console.WriteLine(quotes1);

            //Write a program that prints an isosceles triangle of 9 copyright symbols
            //©. Use Windows Character Map to find the Unicode code of the ©
            //symbol.Note: the © symbol may be displayed incorrectly.

            char a3 = '©';
            Console.WriteLine("©");
            Console.WriteLine("©"+ "©"+ "©");
            Console.WriteLine("©"+ "©"+ "©"+ "©"+ "©");

            //Using class MarketingFirm

            MarketingFirm employe1 = new MarketingFirm()
            {
                firstName = "John",
                familyName = "Black",
                age = 25,
                id = 27560001,
                gender = 'm'
            };

           

            //Declare two integer variables and assign them with 5 and 10 and after
            //that exchange their values.

            int x = 5;
            int y = 10;
            int v;

            Console.WriteLine("Before exchange: x={0}   y={1}",x,y);

            v = x;
            x = y;
            y = v;

            Console.WriteLine("After exchange: x={0}   y={1}", x, y);

            //Find online more information about ASCII(American Standard Code for
            //Information Interchange) and write a program that prints the entire ASCII table
            //of characters on the console.

            //Create a program that assigns null values to an integer and to double variables.
            //Try to print them on the console, try to add some values or the null literal to
            //them and see the result.

            int? n1 = null;
            double? n2 = null;
            Console.WriteLine(n1 + " " + n2);
            Console.WriteLine(n1 + 1);

            //A bank account has a holder name(first name, middle name and last name),
            //available amount of money(balance), bank name, IBAN, BIC code and 3 credit
            //card numbers associated with the account.Declare the variables needed to keep
            //the information for a single bank account using the appropriate data types and
            //descriptive names.

            string holderName = "Dragan Ivanov Draganov";
            double balance = 5.05;
            string bankName = "Invest Bank";
            string iban;
            string bic;
            long ccn1 = 3333444455556666 ; // this could be a string 
            long ccn2;
            long ccn3;
            



        }
    }
}
