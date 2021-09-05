using System;
using System.Collections.Generic;
namespace gitHub_mokymai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sarasas = new List<string>() { "Geltona", "Zalia", "Raudona", "Lietuva" };
            foras (int i = 0; i < sarasas.Count; i++)
            {
                Console.WriteLine(sarasas[i]);
            }

        }
    }
}
