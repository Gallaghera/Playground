using System;

namespace _1.Main.Primitives
{
    class Program
    {
        static void Main(string[] args)
        {

            // ### Primitives ###

            // Primitives are the basic building blocks of programs. These 'data types' are used to house values
            // in 'variables'. A Variable is just a slot in the computers memory that can house some data.

            // ## Numbers ##
            int int1 = 1;
            int int2 = 0;
            int int3 = 9001;
            int int4 = -50;

            double double1 = 1;
            double double2 = 9001.5;
            double double3 = -50;
            double double4 = -50.55555;

            var num1 = 1;
            var num2 = 9001.5;
            var num3 = -50;
            var num4 = -50.55555;

            // There are different types of numbers based on what your needs are. 'int' are integers and are whole numbers only.
            // 'double' are Doubles and they can hold decimals.

            // In the above statements, we are declaring a variable and immediatilly assigning it a value.
            // - 'int' or 'var' means create a variable
            // - 'int1' or 'num1' means name this variable this name that way we can use it later
            // - '=' is how we assign values
            // - '9001.5' is a value
            // - ';' the semicolon is used to end a statement.

            // When creating a variable, you can use the explicit type 'int' but you can also use 'var' which allows the language
            // to take a guess at what it should be. If you hover over the vars in line 26-29, you can see that it assigned int
            // to 26 and 28 while assigning double to 27 and 29.

            // ## Strings ##
            string str1 = "Goku";
            string str2 = "";
            string str3 = " ";
            string str4 = "Goku is a god.";

            // Strings are text and are made of up characters and are wrapped in quotes "  ". An empty space, any letter, any puncuation,
            // and even other quotes are characters and can make up a string.

            // ## Boolean ##
            bool bool1 = true;
            bool bool2 = false;

            // Booleans are simple primitives and they are either true or false. They are basically used for yes/no values.

            // ## Console.Write and Console.WriteLine ##
            Console.Write("Goku");
            Console.Write(" ");
            Console.Write("is");
            Console.Write(" ");
            Console.WriteLine("God");

            Console.WriteLine("Goku is God");

            // Console.write() will write values to the console so you can see them. It writes the values back to back. If you need the next
            // write to be on it's own line, use Console.WriteLine().

            // You can also use Console.Write to write variables to the console.

            Console.WriteLine(str4);
            Console.WriteLine(int1);
            Console.WriteLine(bool1);

            // Take these concepts and try printing things to the console using both variables and inline values.
        }
    }
}
