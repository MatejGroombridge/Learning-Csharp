using System;

namespace Chapter_1_Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");

            int age = Convert.ToInt32(Console.ReadLine()) + 10;

            Console.WriteLine("In 10 years time, you will be " + age + " years old.");
        }
    }
}
