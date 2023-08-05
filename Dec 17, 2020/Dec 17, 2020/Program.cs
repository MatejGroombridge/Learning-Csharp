// Matej Groombridge, 17-20th December 2020, inspired by Discworld book 6 (which I'm reading at this time).
using System;

namespace Dec_17__2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Witch witch01 = new Witch("Dolores Umbridge", 276, "strength", "Ashen Pine");

            witch01.Brew();
            witch01.ThrowPotion();
            witch01.ThrowPotion();
            witch01.ThrowPotion();
            witch01.ThrowPotion();
            witch01.Brew();
            witch01.Experience();
            witch01.Age();
            witch01.Sleep();
            witch01.Sleep();
            witch01.Age();
            witch01.ThrowPotion();
            witch01.ThrowPotion();

            Witch witch02 = new Witch("Nanny Ogg", 105, "fire-breathing", "Poolog");

            witch02.Brew();
            witch02.ThrowPotion();
            witch02.ThrowPotion();
            witch01.ThrowPotion();
            witch02.ThrowPotion();
            witch02.ThrowPotion();
            witch02.Brew();
            witch02.Experience();
            witch02.Age();
            witch02.Sleep();
            witch02.Sleep();
            witch01.ThrowPotion();
            witch01.Sleep();
            witch02.Age();
            witch02.ThrowPotion();
            witch02.ThrowPotion();
        }
    }

    class Witch
    {
        public int age;
        public string favPotion;
        private string name;
        public string staffMaterial;
        private float experience;
        private int potions;

        public Witch(string _name, int _age, string _favPotion, string _staffMaterial)
        {
            name = _name;
            favPotion = _favPotion;
            staffMaterial = _staffMaterial;
            age = _age;

            potions = 3;
            experience = 0f;
        }

        public void ThrowPotion()
        {
            if (age == 0)
            {
                Console.WriteLine(name + " tried to throw a potion, but realised she was dead.\n");
            }
            else
            {
                if (potions > 0)
                {
                    Console.WriteLine(name + " throws a potion of " + favPotion + ".\n");

                    potions--;

                    experience += 1.25f;
                }
                else
                {
                    Console.WriteLine(name + " is out of potions.\n");
                }
            }
        }

        public void Brew()
        {
            if (age == 0)
            {
                Console.WriteLine(name + " can't brew potions, they're dead");
            }
            else
            {
                Console.WriteLine(name + " brews some " + favPotion + " potions.\n");

                potions = 3;
            }
        }

        public void Experience()
        {
            if (age == 0)
            {
                Console.WriteLine(name + " had " + experience + " before they died.\n");
            }
            else
            {
                Console.WriteLine(name + " has " + experience + " experience points.\n");
            }
        }

        public void Age()
        {
            if (age == 0) 
            {
                Console.WriteLine(name + " is dead.\n");
            }
            else
            {
                Console.WriteLine(name + " is " + age + " years old.\n");
            }            
        }

        public void Sleep()
        {
            if (age == 0)
            {
                Console.WriteLine(name + " is dead.\n");
            }            

            else if (age > 100)
            {
                Random rand = new Random();
                int willDie = rand.Next(1, 4);

                if (willDie == 1)
                {
                    Console.WriteLine(name + " grew too old and died in her sleep.\n");

                    age -= age;
                }
                else
                {
                    Console.WriteLine(name + " woke up from a refreshing sleep.. " + willDie + " years later.\n");

                    age += willDie;
                }
            }

            else
            {
                Console.WriteLine(name + " went to sleep.\n");
                Console.WriteLine(name + " woke up the next morning.\n");
            }
        }
    }
}