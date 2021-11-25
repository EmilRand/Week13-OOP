using System;

namespace ConsoleApp2
{
    class Program
    {
        class cat
        {
            public string name;
            public string color;
            public double hungryness;

            public cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hungryness = 0;
                Console.WriteLine($"");
            }
            public string Name
            {
                get { return Name; }
            }
            public string Color
            {
                get { return color; }
            }
            public void Meows()
            {
                Console.WriteLine("Meow");
                hungryness += 0.2;
            }
            public void Sleeps()
            {
                Console.WriteLine("*ZZZzzz*");
            }

            public void rename(string newname)
            {
                name = newname;
            }
            static void Main(string[] args)
            {
                cat mycat = new cat("Jamal", "purple");
                
                while (mycat.hungryness != 1)
                {
                    mycat.Meows();
                }
                Console.WriteLine("Rename you cat");
                string userInput = Console.ReadLine();
                mycat.rename(userInput);
                Console.WriteLine($"{mycat.name}");
                Console.WriteLine($"Level of hungryness: {mycat.hungryness}");
            }
        }
    }
}
