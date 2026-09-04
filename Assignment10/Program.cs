using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment10
{
    internal class Program
    {
        static void swap<T>(ref T num1 , ref T num2)
        {
            T temp = num1;
            num1 = num2;
            num2 = temp;
        }
        static void Main(string[] args)
        {

            #region Question 1

            //Q1: What is a generic class? Why use generics?
            //A generic class is a class where the data type is not specified when the class is created. Instead, the type is specified when the class is used.
            //We use generics to write one class or method that can work with different data types instead of writing separate code for each type.

            #endregion

            #region Question 2

            //Q2: Write a generic class Container<T> with Add and Get methods.
            //Container<int> numbers = new Container<int>();
            //numbers.Add(10);
            //numbers.Add(20);
            //numbers.Add(30);
            //Console.WriteLine(numbers.Get(0));
            //Console.WriteLine(numbers.Get(1));
            //Console.WriteLine(numbers.Get(2));
            //Console.WriteLine(numbers.Get(3));


            #endregion

            #region Question 3

            //Q3:What are multiple type parameters? Write Pair<TKey,TValue >.
            //Multiple type parameters mean that a generic class can use more than one data type.Each type parameter can represent a different type.

            //Pair<int, string> pair = new Pair<int, string>(10, "Mariam");
            //Console.WriteLine($"My name is {pair.Second} and my age is {pair.First}");
            #endregion

            #region Question 4

            //Q4: What is a generic method? Write Swap<T> method.
            //A generic method is a method that can work with different data types. The type is specified when the method is called.

            int a = 10, b = 20;
            Console.WriteLine($"Number A before swapping is {a} and B is {b}");
            swap<int>(ref a , ref b);
            Console.WriteLine($"Number A after swapping is {a} and B is {b}");

            #endregion

        }
    }
}
