using LatihanPert5Overloading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPert5Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MindanMax MindanMax1 = new MindanMax();

            Console.WriteLine("=========================\nMencari Nilai Min dan Max\n=========================");
            Console.WriteLine("Nilai a : 20.23\nNilai b : 10.04\n===================================================");
            Console.WriteLine("Nilai Min dari kedua nilai tersebut adalah : {0}", MindanMax1.MencariNilaiMin(20.23, 10.04));
            Console.WriteLine("Nilai Max dari kedua nilai tersebut adalah : {0}", MindanMax1.MencariNilaiMax(20.23, 10.04));
            Console.ReadLine();
        }
    }
}
