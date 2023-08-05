using System;

namespace Chapter_4_Excercises
{
	class Program
	{
		static void Main(string[] args)
		{
			SumOfSpecialSequence();
		}

		static void SumFiveEnteredNums()
		{
			ulong[] nums = new ulong[5];
			int i = 0;
			ulong sum = 0;

			Console.Write("Enter five numbers: ");

			do
			{
				bool parseSucess = ulong.TryParse(Console.ReadLine(), out nums[i]);
				if (parseSucess == false)
				{
					Console.WriteLine("\nInvalid Number. Enter a new one.");
					continue;
				}

				sum += nums[i];

				i++;
			}
			while (i < 5);

			Console.WriteLine("The sum is {0}", sum);
		}

		static void BiggestOfFiveEnteredNumbers()
		{
			ulong[] nums = new ulong[5];
			int i = 0;
			ulong biggestNum = 0;

			Console.Write("Enter five numbers: ");

			do
			{
				bool parseSucess = ulong.TryParse(Console.ReadLine(), out nums[i]);
				if (parseSucess == false)
				{
					Console.WriteLine("\nInvalid Number. Enter a new one.");
					continue;
				}

				if (nums[i] > biggestNum)
				{
					biggestNum = nums[i];
				}

				i++;
			}
			while (i < 5);

			Console.WriteLine("The biggest number is {0}", biggestNum);
		}

		static void Sum_n_EnteredNums()
		{
			Console.Write("Enter the number of numbers you're entering: ");

			int arrayLength = Convert.ToInt32(Console.ReadLine());
			ulong[] nums = new ulong[arrayLength];
			int i = 0;
			ulong sum = 0;
			bool tooBig = false;

			Console.Write("Enter {0} numbers: ", arrayLength);

			do
			{
				bool parseSucess = ulong.TryParse(Console.ReadLine(), out nums[i]);
				if (parseSucess == false)
				{
					Console.WriteLine("\nInvalid Number. Enter a new one.");
					continue;
				}

				sum += nums[i];

				i++;
			}
			while (i < arrayLength);

			Console.WriteLine("The sum is {0}", sum);
		}

		static void NumsBetween_n_AndOne()
		{
			Console.Write("Enter a number: ");
			int num = Convert.ToInt32(Console.ReadLine());

			for (int i = 1; i <= num; i++)
			{
				Console.WriteLine(i);
			}
		}

		static void FibonacciFirst100Nums()
		{
			ulong num1 = 1;
			ulong oldNum = 0;
			ulong otherNum = 0;
			ulong thisTurn = 0;

			Console.WriteLine("The first 100 digits of the Fibonacci Sequence:\n1: 0\n2: 1");

			for (int i = 0; i <= 97; i++)
			{
				thisTurn = num1 + oldNum;
				
				Console.WriteLine((i + 3) + ": " + thisTurn);
				
				otherNum = oldNum;
				oldNum = num1;
				num1 += otherNum;
			}
		}

		static void SumOfSpecialSequence() //This one was really hard but I got it quickly with no help. Would've been better if I made it a while loop that stopped when the given precision was reached.
		{
			decimal sum = 0;
			decimal answer = 1;
			decimal otherSum = 0;

			for (int i = 1; i < 10000; i += 2)
			{
				otherSum = (decimal)i;
				
				sum = 1 / (otherSum + 1) - 1 / (otherSum + 2);

				answer += sum;
			}
			Console.WriteLine("The sum is: {0:F3}", answer);
		}
	}
}