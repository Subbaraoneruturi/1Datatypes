using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // here string is the data type and message is the variable name and hello world is value for the variable;
            string message = "Hello World!!";
            int marks = 60;  
            char letter = 'A';
            bool isactive = true;

            marks = 69;
            marks = 70;
            


            int age; // this is called declaration of variable age
            age = 20; // this is intialisation of variable

            Console.WriteLine(message);  //console is the class which is exsiting in system namespace
                                         //here message is parameter because we are passing it as a input
            Console.WriteLine(marks);

            message = "this is me";

            Console.WriteLine(message);


            Console.WriteLine(Sum(299, 2345));
            Sum(1, 2);
        }


        public static int Sum(int firstnumber, int secondnumber)  // here sum is method name before it int is there 
                                                                 // it is return type
        {
            return firstnumber + secondnumber;
        }
    } 
}
