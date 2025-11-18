using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Task 1: Variables and DataTypes
            //Console.WriteLine("Task 1");

            ////Declaring variables
            //string userName; 
            //int luckyNumber;

            ////Initializing variables
            //userName = "Safal";
            //luckyNumber = 7;

            ////Printing output
            //Console.WriteLine("Hello, "+userName+"! Your lucky number is "+luckyNumber);

            ////Task 2: Constants
            //const double Pi = 3.14;
            ////Printing Pi value without modifying
            //Console.WriteLine(Pi);

            ////Trying to modify pi
            ////Pi = Pi + 1;

            //int r = 7; //Radius
            //Console.WriteLine("Area: "+(r*r)*Pi);
            //Console.WriteLine("Circumferences: "+2*Pi*r);

            ////Task 3: Data Types and Type Conversion
            //byte b = 1;
            //short s = 254;
            //int i = 42;
            //long l = 13987;
            //float f = 1.0f;
            //double d = 3.12;
            //decimal de = 10;
            //char c = 'C';
            //bool boo = true;


            ////converting integer value
            //String str = i.ToString();
            //String pi = "3.14";
            //double pie = double.Parse(pi);

            //Console.WriteLine("Printing Variables");
            //Console.WriteLine($"Converting int to str: {str}\nConverting string to double: {pie}");
            //Console.WriteLine($"Byte: {b}\nShort: {s}\nInteger: {i}\nLong: {l}\nFloat: {f}\nDouble: {d}\nDecimal: {de}\nCharacter: {c}\nBoolean: {boo}");


            ////Task 4: Array and Array methods
            ////Single-dimensional integer array
            //int[] arr = [1, 2, 6, 4, 5, 3];
            ////Sorting array in ascending order
            //Array.Sort(arr);
            ////Reversing array
            //Array.Reverse(arr);

            ////Printing array elements
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            ////Finding index of an element
            //Console.WriteLine("Index of element '2': "+Array.IndexOf(arr,2));

            //Task 5: Generic Collections
            Console.WriteLine("Task 5");
            //Creating a list of strings
            List<string> fruits = new List<string>() { "Apple", "Mango", "Orange" };

            //Adding elements to the list
            fruits.Add("Banana");

            //Removing an element from the list
            fruits.Remove("Mango");

            //Iterating through the list and printing elements
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //Creating a dictionary to store fruit IDs and fruit names 
            Dictionary<int, string> fruitDict = new Dictionary<int, string>()
            {
                {1, "Apple"},
                {2, "Mango"},
                {3, "Orange"}
            };

            //Adding a new key-value pair to the dictionary
            fruitDict.Add(4, "Banana");

            //Printing all key-value pairs in the dictionary
            foreach (KeyValuePair<int, string> kvp in fruitDict)
            {
                Console.WriteLine("Fruit ID: " + kvp.Key + ", Fruit Name: " + kvp.Value);
            }
        }
    }
}