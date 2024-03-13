using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Objects.CoolerData.Cooler Cooler = new Objects.CoolerData.Cooler();
            Cooler.addFruit("apple", 3);
            Cooler.addFruit("apple", 1);
            Cooler.printFruits();
            Console.ReadLine();
        }
    }
}
