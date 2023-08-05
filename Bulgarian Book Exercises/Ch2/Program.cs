using System;

namespace Chapter_2_Excercises
{
	class Program
	{
		// 1) ushort, sbyte, int, byte, short, short

		static bool AreTheyMale()
		{
			bool isMale = false;
			
			Console.WriteLine("Are you a male?");
			
			string answer = Console.ReadLine();

			if (answer == "yes")
			{
				isMale = true;
			}
			
			else if (answer == "no")
			{
				isMale = false;
			}
			
			else 
			{
				Console.WriteLine("Please enter a valid answer.");
			}

			return isMale;
		}

		static void HelloWorld()
		{
			string hello = "Hello";
			string world = "World";
			object helloWorld = hello + " " + world;
			string allOfIt = (string)helloWorld;

			Console.WriteLine(allOfIt);
		}

		static void Strings()
		{
			string str01 = "The \"use\" of quotations causes difficulty";
			string str02 = @"The ""use"" of strings causes difficulty";

			Console.WriteLine(str01 + "\n" + str02);

			Console.WriteLine(@" oo oo
o  o  o
 o   o
  o o
   o");
			Console.WriteLine(@"©")
		}
		
		static void Main()
		{
			Strings();
		}
	}
}
