using Bai2lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var maps1 = new Maps("2024", "Urf");
            Console.WriteLine(maps1.ShowData());

            Console.ReadLine();
        }
    }
}