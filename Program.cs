using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napszak
{
    internal class Program
    {
        public static string napszak()
        {
            DateTime now = DateTime.Now;
            string koszones;
            if (now.Hour < 12)
            {
                return "Jó reggelt";
            }
            else if (now.Hour < 18)
            {
                return "Jó napot"; ;
            }
            else
            {
                return "Jó estét";
            }

        }

        public static string kamat()
        {
            Console.Write("Kérem, adja meg a lekötni kívánt összeget (Ft): ");
            double osszeg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem, adja meg a lekötés időtartamát (év): ");
            int ev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a kamatot (%): ");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            double vegosszeg = osszeg * Math.Pow(1 + (interestRate / 100), ev);
            Console.WriteLine($"A lekötött összeg {ev} év múlva: {vegosszeg:F2} Ft");
        }

        public static void futas()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine(napszak());
            Console.WriteLine(kamat());
        }
    }
}
