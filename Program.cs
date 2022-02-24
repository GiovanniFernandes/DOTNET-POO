using System;
using DOTNET_POO.src.Entities;

namespace DOTNET_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 31, "Knight");
            Wizard Jennica = new Wizard("Jennica", 76, "White Wizard");

            Console.WriteLine(Arus);
            Console.WriteLine(Jennica);
            Console.WriteLine(Arus.Attack());
            Console.WriteLine(Jennica.Attack(15));
            Console.WriteLine(Jennica.Attack(4));
        }
    }
}
