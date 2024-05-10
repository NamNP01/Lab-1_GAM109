using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Main()
        {
            float a = 5;
            float b = 10;
            Calculator obj = new Calculator(a, b);
            float KQCong = obj.PhepCong(a, b);
            System.Console.WriteLine(KQCong);
            float KQTru = obj.PhepTru(a, b);
            System.Console.WriteLine(KQTru);
            float KQNhan = obj.PhepNhan(a, b);
            System.Console.WriteLine(KQNhan);
            float KQChia = obj.PhepChia(a, b);
            System.Console.WriteLine(KQChia);
            Console.ReadLine();
        }
    }
}
