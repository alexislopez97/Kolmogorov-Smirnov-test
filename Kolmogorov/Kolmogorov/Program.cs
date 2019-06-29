using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolmogorov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> NumRectangulares = new List<double>();
            Random aleatorio = new Random();
            double ale;
            double DisAcu;
            double Dn;

            Console.Write("Introduce la cantidad de numeros Rectangulares: ");
            int num = Convert.ToInt16(Console.ReadLine());

            /*
            NumRectangulares.Add(0.65251);
            NumRectangulares.Add(0.36815);
            NumRectangulares.Add(0.64397);
            NumRectangulares.Add(0.04515);
            NumRectangulares.Add(0.83761);
            NumRectangulares.Add(0.14387);
            NumRectangulares.Add(0.51321);
            NumRectangulares.Add(0.72472);
            NumRectangulares.Add(0.05466);
            */

            for (int i = 0; i < num; i++)
            {
                ale = aleatorio.Next(10001, 99999);
                Convert.ToDouble(ale);
                NumRectangulares.Add(ale / 100000);
                Console.WriteLine(NumRectangulares[i]);

            }
            NumRectangulares = NumRectangulares.OrderBy(n => n).ToList();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("i" + "    xi" + "        F(xi)= i/N" + "       Dn= MAX/|F(xi-xi)|");

            int j = 0;
            for (double i = 0; i < NumRectangulares.Count; i++)
            {
                DisAcu = (i + 1) / NumRectangulares.Count;
                Dn = DisAcu - NumRectangulares[j];
                Console.WriteLine((i + 1) + "  " + "{0:N5}" + "   " +
                    (i + 1) + "/" + NumRectangulares.Count + " = " + "{1:N5}" + "   " +
                    "{2:N5}" + "-" + "{3:N5}" + " = " + "{4:N5}", NumRectangulares[j], DisAcu, DisAcu, NumRectangulares[j], Dn);
                j++;
            }

            Console.ReadKey();
        }
    }
}
