using System;

namespace Denemeasf
{
    class Program
    {
        static void Main(string[] args)
        {
            Champion champion1 = new Champion("umut",25);
            //champion1.Name = "Ahri";
            //champion1.Health = 500;
            //champion1.Mana = 300;
            Console.WriteLine(champion1.Name);

            Champion champion2 = new Champion("merve",35,25) ;
            Console.WriteLine(champion2.Mana);
        }
    }
}
