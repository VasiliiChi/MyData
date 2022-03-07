using System;

namespace MyData
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Vasilii";
            byte MyAge = 29;
            bool HaveIApet = true;
            double MyShoeSize = 45;

            Console.WriteLine("My name is {0}", MyName);
            Console.WriteLine("MyAge {0}", MyAge);
            Console.WriteLine("Do I have a pet? {0}", HaveIApet);
            Console.WriteLine("My shoe size is {0}", MyShoeSize);
            Console.ReadKey();
        }
    }
}
