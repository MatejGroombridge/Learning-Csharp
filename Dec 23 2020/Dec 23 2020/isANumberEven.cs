using System;

namespace Dec_23_2020
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter a number to find out wether it is even: ");

			int num = Convert.ToInt32(Console.ReadLine());

			if (num % 2 == 0)
			{
				Console.WriteLine(num + " is even.");
			}
			else
			{
				Console.WriteLine(num + " is not even.");
			}
		}
	}
}