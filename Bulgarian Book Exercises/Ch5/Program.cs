using System;

namespace Chapter_5_Excercises
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Eleven();
			}
		}

		static void One()
		{
			int num1 = 7;
			int num2 = 5;

			if (num1 > num2)
			{
				int newNum = num1;
				num1 = num2;
				num2 = newNum;
			}
		}

		static void Two()
		{
			int a = 5;
			int b = 7;
			int c = 8;

			if (((a * b) > 0) && (c > 0))
			{
				Console.WriteLine("+");
			}
			else if (((a * b) > 0) && (c < 0))
			{
				Console.WriteLine("-");
			}
			else if (((a * b) < 0) && (c > 0))
			{
				Console.WriteLine("-");
			}
		}

		static void Three()
		{
			int a = 1;
			int b = 2;
			int c = 3;

			if (a > b)
			{
				if (a > c)
				{
					Console.WriteLine(a);
				}
				else
				{
					Console.WriteLine(c);
				}
			}
			else
			{
				if (b > c)
				{
					Console.WriteLine(b);
				}
				else
				{
					Console.WriteLine(c);
				}
			}
		}

		static void Four()
		{
			double a = 1.2;
			double b = 1.0;
			double c = 1.30;

			if (a > b)
			{
				if (a > c)
				{
					if (c > b)
					{
						Console.WriteLine("acb");
					}
					else
					{
						Console.WriteLine("abc");
					}
				}
				else
				{
					Console.WriteLine("cab");
				}
			}
			else
			{
				if (b > c)
				{
					if (c > a)
					{
						Console.WriteLine("bca");
					}
					else
					{
						Console.WriteLine("bac");
					}
				}
				else
				{
					Console.WriteLine("cba");
				}
			}
		}

		static void Five()
		{
			Console.Write("Enter a number from one to three: ");
			int a = int.Parse(Console.ReadLine());
			switch (a)
			{
				case 1:
					Console.WriteLine("One");
					break;
				case 2:
					Console.WriteLine("Two");
					break;
				case 3:
					Console.WriteLine("Three");
					break;
				default:
					break;
			}
		}

		static void Six()
		{
			int a = 1;
			int b = 3;
			int c = 2;

			Console.WriteLine("{0}x^2 + {1}x + {2}", a, b, c);

			double x = 0;
			double x2 = 0;

			int discriminant = b * b - 4 * a * c;

			if (discriminant == 0)
			{
				x = -b / (2 * a);
				Console.WriteLine(x);
			}
			else if (discriminant > 0)
			{
				x = (-b + (Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
				x2 = (-b - (Math.Sqrt(b * b - 4 * a * c)) / (2 * a));

				Console.WriteLine("{0} and {1}", x, x2);
			}
			else
			{
				Console.WriteLine("x has no value");
			}
		}//not sure if this is right. check again later (i havent really learnt this maths yet.

		static void Seven()
		{
			int[] array = new int[5];
			int largestNum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = int.Parse(Console.ReadLine());
			}

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > largestNum)
				{
					largestNum = array[i];
				}
			}

			Console.WriteLine(largestNum);
		}

		static void Ten()
		{
			Console.Write("Enter a score: ");
			int score = int.Parse(Console.ReadLine());

			switch (score)
			{
				case 1:
				case 2:
				case 3:
					score *= 10;
					Console.WriteLine(score);
					break;
				case 4:
				case 5:
				case 6:
					score *= 100;
					Console.WriteLine(score);
					break;
				case 7:
				case 8:
				case 9:
					score *= 1000;
					Console.WriteLine(score);
					break;
				default:
					Console.WriteLine("invalid number");
					break;
			}
		} 

		static void Eleven()
		{
			Console.WriteLine("Enter a number between 0 and 999: ");

			int num = int.Parse(Console.ReadLine());
			int hundreds = 0;
			int tens = 0;
			int units = 0;
			int teens = 0;

			bool isValid = true;

			string answer;

			string[] hundred = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
			string[] ten = { "", "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
			string[] unit = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Zero" };
			string[] teen = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

			//check if the number is valid
			if ((num < 0) || (num > 999))
			{
				isValid = false;
			}

			if (isValid)
			{
				//get the indexes
				
				if (num > 99)
				{
					hundreds = num / 100;
				} //hundreds index
				if (((num % 100) > 9) && ((num % 100) < 20))
				{
					teens = (num % 100) - 10;
				} //teens index
				tens = ((num % 100) / 10) - 1; //tens index
				units = num % 10; //units index


				//check if the number ends in a zero
				if (num == 0)
				{
					units = 10;
				}

				//get the answer

				if (num > 99)
				{
					if (num % 100 == 0)
					{
						answer = (hundred[hundreds] + " Hundred");
					} //00
					else if ((num % 100) < 10)
					{
						answer = (hundred[hundreds] + " Hundred And " + unit[units]);
					} //0X
					else if (((num % 100) < 20) && ((num % 100) > 9))
					{
						answer = (hundred[hundreds] + " hundred and " + teen[teens]);
					} //1X
					else
					{
						answer = (hundred[hundreds] + " Hundred And " + ten[tens] + " " + unit[units]);
					}
				} //if bigger than 99
				else if ((num < 100) && (num > 19))
				{
					answer = ten[tens] + " " + unit[units];
				} //if between 100 and 19
				else if ((num < 20) && (num > 9))
				{
					answer = teen[teens];
				} //if between 19 and 10
				else
				{
					answer = unit[units];
				} // if under 10

				//print the answer

				Console.WriteLine(answer + "\n");
			}
			else
			{
				Console.WriteLine("Invalid Number");
			}
		}
	}
}