using System;
using System.Numerics;

namespace Chapter_6_Excercises
{
	class Program
	{
		static void Main(string[] args)
		{
			Seventeen();
		}
		static void BigInt()
		{
			Console.Write("n = ");
			BigInteger n = int.Parse(Console.ReadLine());
			BigInteger factorial = 1;

			do
			{
				factorial *= n;
				n--;
			} while (n > 0);

			Console.WriteLine("n! = " + factorial);
		}

		static void Two()
		{
			Console.Write("Enter a number: ");
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i < n; i++)
			{
				if ((i % 3 == 0) && (i % 7 == 0))
				{

				}
				else
				{
					Console.Write(i + " ");
				}
			}	
		}

		static void Three()
		{
			Console.Write("Enter 5 numbers: ");
			int[] nums = new int[5];
			int largest = int.MinValue;
			int smallest = int.MaxValue;

			for (int i = 0; i < 5; i++)
			{
				nums[i] = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < 5; i++)
			{
				if (nums[i] > largest)
				{
					largest = nums[i];
				}
				
				if (nums[i] < smallest)
				{
					smallest = nums[i];
				}
			}
			Console.WriteLine("The largest number is {0} and the smallest number is {1}", largest, smallest);
		}

		static void Four()
		{
			string[] suits = { "Clubs", "Spades", "Hearts", "Diamonds"};
			string[] cards = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};

			foreach (string suit in suits)
			{
				foreach (string card in cards)
				{
					Console.WriteLine(card + " Of " + suit);
				}
			}

			Console.WriteLine("Joker");
			Console.WriteLine("Joker");
		}

		static void Five()
		{
			Console.Write("Enter a number: ");

			BigInteger n = int.Parse(Console.ReadLine());

			BigInteger a = 0;
			BigInteger b = 1;
			BigInteger thirdNum = 1;

			BigInteger i = 0;

			BigInteger sum = 0;
			BigInteger total = 0;

			do
			{
				sum = a + b;

				thirdNum = a;
				a += b;
				b = thirdNum;

				total += sum;

				i++;
			} 
			while (i < n);

			Console.WriteLine("The sum of the first {0} digits of the Fibonacci sequence is: " + total, n);
		}

		static void Six()
		{
			Console.Write("n = ");
			int n = int.Parse(Console.ReadLine());

			Console.Write("m = ");
			int m = int.Parse(Console.ReadLine());

			int nFac = 1;
			int mFac = 1;

			for (int i = n; i > 0; i--)
			{
				nFac *= i;
			}

			for (int i = m; i > 0; i--)
			{
				mFac *= i;
			}

			Console.WriteLine(nFac);
			Console.WriteLine(mFac);

			int sum = nFac / mFac;

			Console.WriteLine(sum);
		}

		static void Seven()
		{
			Console.Write("N = ");
			int n = int.Parse(Console.ReadLine());

			Console.Write("M = ");
			int m = int.Parse(Console.ReadLine());

			int fac = 1;

			for (int i = n; i > 0; i--)
			{
				fac *= i;
			}

			for (int i = m; i > 0; i--)
			{
				fac *= i;
			}

			int divisor = 1;

			for (int i = n; i > (m); i--)
			{
				divisor *= i;
			}
			Console.WriteLine(divisor);

			Console.WriteLine(fac / divisor);
		}

		static void Eight()
		{
			int n = int.Parse(Console.ReadLine());

			int top = 1;
			int bottom = 1;

			for (int i = n * 2; i > 0; i--)
			{
				top *= i;
			}

			for (int i = n + 1; i > 0; i--)
			{
				bottom *= i;
			}
			for (int i = n; i > 0; i--)
			{
				bottom *= i;
			}

			Console.WriteLine(top / bottom);
		} //catalan nums

		static void Nine() //wrong
		{
			double n = 5;
			double sum = 0f;
			double currentTop = 1f;
			double currentBot = 1f;
			double current = 1f;


			for (int i = (int)n; i > 0; i--)
			{
				sum += current;

				for (int h = i; h > 1; h--)
				{
					currentTop *= h;
				}

				for (int h2 = i; h2 > 1; h2--)
				{
					currentBot *= h2;
				}

				current = currentTop / currentBot;
			}

			Console.WriteLine(sum);
		}

		static void Ten()
		{
			int n = 3;

			for (int row = 0; row < n; row++)
			{ 
				for (int i = row; i < n + row; i++)
				{
					Console.Write(i + " ");
				}
				
				Console.WriteLine();
			}
		}

		static void Eleven()
		{
			int n = 20;
			int five = n % 5;
			int two = n % 2;
			int x = 0;
			
			if ((n / 5) % 2 == 0)
			{
				x = (n / 5) / 2;
			}
			else
			{
				x = (n / 5) - 1;
			}

			x += n / 10;

			Console.WriteLine(x);
		}

		static void Twelve()
		{
			int n = 7;

			while (n > 0)
			{
				Console.Write(n % 2);
				n /= 2;
			}
		}

		static void Thirteen()
		{
			int n = 111;
			int n2 = (n % 10) * 1 + (n % 100 / 10) * 2 + (n % 1000 / 100) * 2 * 2 + (n % 10000 / 1000) * 2 * 2 * 2;
			Console.WriteLine(n2);
		} //lazy

		static void Fourteen()
		{
			int n = 300;
			char digit;
			do
			{
				digit = (char)(n % 16);
				switch (digit)
				{
					default:
						break;
					case (char)10:
						digit = 'A';
						break;
					case (char)11:
						digit = 'B';
						break;
					case (char)12:
						digit = 'C';
						break;
					case (char)13:
						digit = 'D';
						break;
					case (char)14:
						digit = 'E';
						break;
					case (char)15:
						digit = 'F';
						break;
					case (char)16:
						digit = 'G';
						break;
				}

				Console.Write(digit);
				n /= 16;
			} while (n > -1);
		} //comes up with weird symbols

		//15. cant do

		static void Sixteen()
		{
			int n = 7;
			int[] array = new int[n];

			for (int i = 0; i < n; i++)
			{
				array[i] = i + 1;
			}

			Random randomNum = new Random();
			int inBetween = 0;

			for (int i = 0; i < n; i++)
			{
				int ran = randomNum.Next(1, n);
				inBetween = array[ran];
				array[ran] = array[i];
				array[i] = inBetween;
			}

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(array[i]);
			}
		}

		static void Seventeen()
		{
			int n = 5;
			int m = 10;
			int hcf = 1;
			int lcm = 1;

			for (int i = m * n - 1; i > 0; i--)
			{
				if ((i % m == 0) && (i % n == 0))
				{
					lcm = i;
				}
			}

			hcf = Math.Abs(n * m) / lcm;

			Console.WriteLine("The HCF is {0} and the LCM is {1}", hcf, lcm);
		}

		//18. too hard
	}
}