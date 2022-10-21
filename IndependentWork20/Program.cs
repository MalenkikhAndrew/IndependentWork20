using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork20
{
    internal class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = PowerD;
            double r = myDelegate(10);
            Console.WriteLine(r);

            myDelegate = PowerS;
            r = myDelegate(10);
            Console.WriteLine(r);

            myDelegate = PowerV;
            r = myDelegate(10);
            Console.WriteLine(r);

            Console.ReadKey();

        }
        static double PowerD(double R)=>2*Math.PI*((double)(R));
        static double PowerS(double R) => Math.PI * ((double)(R*R));
        static double PowerV(double R) => (3*Math.PI*((double)(R*R*R))/4);


    }
}
