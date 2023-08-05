using System;

namespace Chapter_7_Excercises
{
	class Program
	{
		static void Main(string[] args)
		{
			Four();
		}

		static void Two()
		{
			int[] array1 = { 1, 2, 3, 4, 5, 6 };
			int[] array2 = { 1, 2, 3, 4, 5, 6 };
			bool isEqual = true;

			for (int i = 0; i < array1.Length; i++)
			{
				if (array1[i] != array2[i])
				{
					isEqual = false;
					break;
				}
				else if (array1.Length !=  array2.Length)
				{
					isEqual = false;
					break;
				}
			}

			Console.WriteLine(isEqual ? "They are equal" : "They are not equal");
		}

		static void Three()
		{
			char[] one = { 'B', 'a', 'g', 'B' };
			char[] two = { 'B', 'a', 'g', 'B', 'c'}; //doesnt account for that

			for (int item = 0; item < one.Length; item++)
			{
				if (one[item] > two[item])
				{
					Console.WriteLine("two");
				}
				else if (one[item] < two[item])
				{
					Console.WriteLine("one");
				}

				if ((item == one.Length - 1) && (one[item] == two[item]))
				{
					Console.WriteLine("thou art equal");
				}
			}
		} //eh

		static void Four()
		{
			int[] array = { 1, 2, 2, 2, 1, 4, 2, 4, 2, 0, 5, 5, 5, 5 };
			int largest = 0;
			int tryLarg = 0;

			for (int i = 0; i < array.Length; i++)
			{
				int h = i;
				tryLarg = array[h];

				while ((h + 1) < array.Length)
				{
					if (array[h] == array[h + 1])
					{
						tryLarg += array[h + 1];
					}

					h++;
				}

				tryLarg -= array[h];

				if (tryLarg > largest)
				{
					largest = tryLarg;
				}
			}

			Console.WriteLine(largest);
		}
	}
}
