using System;

namespace Monopoly_Sim_1._0
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Monopoly Simulator V1.0. By Matej Groombridge");

			Player playerOne = new Player();

			Console.Write("Enter your player name: ");
			string name = Console.ReadLine();

			Console.Write("Enter the number of turns: ");
			long numOfTurns = int.Parse(Console.ReadLine());
			Console.WriteLine();

			int roll = 0;
			int pos = 0;
			bool firstTurnInJail = true;
			long[] tileFrequency = new long[40];
			string[] tileNames = { "Old Kent Road", "Commnity Chest", "Whitechapel Road","Income Tax", "King's Cross station", "The Angel Islington", "Euston Road", "Chance", "Pentonville Road", "Just Visiting", "Pall Mall", "Electric Company", "Whitehall", "Northumberland Ave", "Marylebone Station", "Bow Street", "Community Chest", "Marlborough Street", "Vine Street", "Free Parking", "Strand", "Chance", "Fleet Street", "Trafalgar Square", "Fenchurch Street Station", "Leicester Square", "Coventry Street", "Water Works", "Piccadilly", "Go To Jail", "Regent Street", "Oxford Street", "Community Chest", "Bond Street", "Liverpool Street Station", "Park Lane", "Park Lane", "Super Tax", "Mayfair", "Go" };
			bool inJail = false;

			for (int turn = 0; turn < numOfTurns; turn++)
			{
				roll = 0;
				
				if (pos == 30)
				{
					if (firstTurnInJail) 
					{
						pos = 10;
						firstTurnInJail = false;
						inJail = true;
					}    //if its the first time in jail.
					else
					{
						firstTurnInJail = true;
						inJail = false;
						roll = playerOne.Roll();
					}							//if its the second turn in jail.
				}					//skips turn if in jail.
				else if ((pos == 10) && inJail)
				{
					firstTurnInJail = true;
					inJail = false;
					roll = playerOne.Roll();
				}  //checks if you're in jail or just visiting.
  				else 
				{
					roll = playerOne.Roll();
				}                             //rolls the die.

				pos += playerOne.Position(roll);

				if (pos > 40)
				{
					pos -= 40;
				}                    //reset the position as you go past start.

				tileFrequency[pos - 1]++;

				Console.WriteLine(inJail ? "Turn {3}: {0} is in Jail." : "Turn {3}: {0} rolled {1}, moving them to {2}.", name, roll, tileNames[pos - 1], turn + 1);

				Console.ReadKey();
			}
		}
	}

	class Player
	{
		public int Roll()
		{
			Random rollOne = new Random();
			Random rollTwo = new Random();
			int currentRoll = rollOne.Next(1, 7) + rollTwo.Next(1, 7);
			return currentRoll;
		}

		public int Position(int _roll)
		{
			int _pos = 0;
			_pos += _roll;
			return _pos;
		}
	}
}
