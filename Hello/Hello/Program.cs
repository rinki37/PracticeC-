                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Below line prints it in the console
            //  Console.WriteLine("Hello C# lovers!!!");


            //Comments in C#
            // This is single line comment
            /* This is used foir multui line comment. */


            // Data types in c#
            // int x = 34; //int data type
            // long i=345454643; //long data type
            // float y = 4.5F; //floating point 
            // double z= 4.52; //double type
            // char a = 'X'; // character type
            // bool isValid = true; //boolean type
            // string str = "I used to codse in Rust";  //string type
            // Console.WriteLine("My name is rinki and the number is " + x);
            // Console.WriteLine("Integer is " + x + " Float is " + y +  " Char is " + a + " Boolean is " + isValid + " String is " + str);


            // calculating size of any variable
            // Console.WriteLine("The size of integer is " + sizeof(int) + "bytes.");


            // Taking string input from user
            // Console.WriteLine("Enter a string :");
            // string str1 = Console.ReadLine(); // takes input from user and assign it to str1
            // Console.WriteLine("You have entered : "+ str1); // Printing the user input to the console          


            // taking integer user input 
            // Console.WriteLine("Enter your name");
            // string name=  Console.ReadLine();
            // Console.WriteLine("Enter your age ");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Hi "+ name + " your age is"+ age);



            // type casting - implicit and explicit
            // 1. Implicit type casting
            // char to int to long to float to double
            // int x = 5;
            // double y = x; // implicit type casting
            // Console.WriteLine(y);
            // 2. Explicit Type casting
            // int a = (int)3.5; // double is converted into integer through explicit type casting
            // Console.WriteLine(a); // will print only 3




            // Using math class
            // int x = 4, y = 7;
            // int res = Math.Max(x, y);
            // Console.WriteLine(res);



            // string interpolation- also used for concatenation
            // string firstName = "John";
            // string lastName = "Doe";
            // string name = $"My full name is: {firstName} {lastName}";
            // Console.WriteLine(name);


            // accessing string using index
            // string myString = "Hello";
            // Console.WriteLine(myString[1]);



            // boolean data type use
            // int myAge = 25;
            // int votingAge = 18;
            // Console.WriteLine(myAge >= votingAge);



            // if else 
            // int time = 22;
            // if (time < 10)
            // {
            //     Console.WriteLine("Good morning.");
            // }
            // else if (time < 20)
            // {
            //     Console.WriteLine("Good day.");
            // }
            // else
            // { 
            //     Console.WriteLine("Good evening.");
            // }



            // using ternary operator
            // int time = 20;
            // string result = (time < 18) ? "Good day." : "Good evening.";
            // Console.WriteLine(result);



            // for each loop
            // string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            // foreach (string i in cars)
            // {
            //    Console.WriteLine(i);
            // }



            // creating array and printing it
            // string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            // for (int i = 0; i < cars.Length; i++)
            // {
            //    Console.WriteLine(cars[i]);
            // }



            // Sort a string array
            // string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            // Array.Sort(cars);
            // foreach (string i in cars)
            // {
            //    Console.WriteLine(i);
            // }



            // sort an integer array
            // int[] myNumbers = {5, 1, 8, 9};
            // Array.Sort(myNumbers);
            // foreach (int i in myNumbers)
            // {
            //    Console.WriteLine(i);
            // }




        
            // system.linq namespace
            //int[] myNumbers = { 5, 1, 8, 9 };
            //Console.WriteLine(myNumbers.Max());  // returns the largest value
            //Console.WriteLine(myNumbers.Min());  // returns the smallest value
                 


    Console.ReadKey();

        }
    }
}
                                                                                                                                                                       
