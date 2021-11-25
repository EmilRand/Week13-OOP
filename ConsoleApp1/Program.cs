using System;

namespace OOPPart1
{
    class Program
    {
        class dog
        {
            string name;
            int spots;
            double happiness;

            public dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} with {spots} has been creaed!");
            }
            public string Name
            {
                get { return Name; }
            }
            public int Spots
            {
                get { return spots; }
            }

            public void Barks()
            {
                Console.WriteLine("Woof Woof");
                happiness += 0.2;
            }
            public void Waggs()
            {
                Console.WriteLine("*Wiggle Wiggle*");
            }
            
            public void rename(string newname)
            {
                name = newname;
            }

            static void Main(string[] args)
            {
                dog mydog = new dog("Jamal", 5);
                // mydog.happiness = 10;
                //mydog.name = "Jamal high as fuck";
                while (mydog.happiness != 1)
                {
                    mydog.Barks();
                }
                Console.WriteLine("Rename you dog");
                string userInput = Console.ReadLine();
                mydog.rename(userInput);
                Console.WriteLine($"{mydog.name}");
                Console.WriteLine($"Level of happiness: {mydog.happiness}");

            }


        }
    }
}