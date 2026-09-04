using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment10
{
    internal class Program
    {
        #region Question 4
        //static void swap<T>(ref T num1 , ref T num2)
        //{
        //    T temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //} 
        #endregion

        #region Question 5

        //static T FindMax<T>(T[] items) where T: IComparable<T> 
        //{
        //    T max = items[0];
        //    foreach (T item in items)
        //    {
        //        if (item.CompareTo(max) > 0)
        //        {
        //            max = item;
        //        }
        //    }
        //    return max;
        //}

        #endregion
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

            //int a = 10, b = 20;
            //Console.WriteLine($"Number A before swapping is {a} and B is {b}");
            //swap<int>(ref a , ref b);
            //Console.WriteLine($"Number A after swapping is {a} and B is {b}");

            #endregion

            #region Question 5

            //Q5: Write a generic method FindMax<T> that finds maximum value

            //int[] items = { 10, 20, 30, 40, 50, 44, 5, 0 };
            //int maximumNumber =FindMax(items);
            //Console.WriteLine($"The max number is {maximumNumber}");

            #endregion

            #region Question 6

            //Q6: What is a generic interface? Write IRepository<T>.
            //A generic interface is an interface that can work with different data types. The type is specified when the interface is used.

            #endregion

            #region Question 7

            //Q7: What is the 'struct' constraint? Write an example.
            //The struct constraint means that the generic type must be a value type, such as int, double, bool, or a custom struct.

            //Console.WriteLine(new Box<int>(10).Value);
            //Console.WriteLine(new Box<double>(5.5).Value);




            #endregion

            #region Question 8

            //Q8: What is the 'class' constraint? Write an example.
            //The class constraint means that the generic type must be a reference type, such as string or a custom class.

            //Console.WriteLine(new ClassConstraint<string>("mariam").Value);
            //Console.WriteLine(new ClassConstraint<Class1>(new Class1("Mariam")).Value.Name);

            #endregion

            #region Question 9

            //Q9: What is the 'new()' constraint? Write an example.
            //The new() constraint means that the generic type T must have a public parameterless constructor (a constructor with no parameters).
            //Factory< Product > factory = new Factory<Product>();
            //Product p = factory.Create();
            //Console.WriteLine(p.Id);

            #endregion

            #region Question 10

            //Q10: What is the interface constraint? Write an example.
            //The interface constraint means that the generic type T must implement a specific interface.

            //Printer<Document> printer1 = new Printer<Document>();
            //printer1.print(new Document());
            //Printer<Report> printer2 = new Printer<Report>();
            //printer2.print(new Report());


            #endregion

            #region Question 11

            //Q11: What is the base class constraint? Write an example.
            //The base class constraint means that the generic type T must inherit from a specific class.

            //AnimalContainer<Dog> dogs = new AnimalContainer<Dog>();
            //dogs.Add(new Dog("dubby"));
            //dogs.Add(new Dog("Max"));
            //dogs.print();

            #endregion

            #region Question 12 

            //Q12: How do you apply multiple constraints? Write an example.
            //You can apply more than one constraint to the same generic type by putting them together after where T :.
            // For example, we can require T to: Inherit from a specific base class,Implement a specific interface, Have a parameterless constructor.


            //Repository<Order> repository = new Repository<Order>();
            //Order order = repository.Create();
            //order.audit();
            #endregion

            #region Question 13

            //Q13: What does the 'default' keyword do in generics?
            //The default keyword returns the default value for a generic type T.

            #endregion

            #region Question 14 

            //Q14: Write a SafeList<T> that returns default when the index isinvalid.
            //List<int> items = new List<int> { 1, 2, 3, 4, 5 };
            //Console.WriteLine(SafeList<int>.Get(4, items));
            //Console.WriteLine (SafeList<int>.Get(5,items));


            #endregion

            #region Question 15

            //Q15: What is covariance? Explain the 'out' keyword.
            //Covariance allows us to use a more specific type where a more general type is expected
            //out before T means that The generic type T is used as an output type.

            #endregion

            #region Question 16

            //Q16: What is contravariance? Explain the 'in' keyword.
            //Contravariance allows us to assign a generic type with a more general type to a generic type with a more specific type.
            //in before T means that The generic type T is used as an input type.

            #endregion


        }
    }
}
