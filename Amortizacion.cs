using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera_apps
{
    class Program
    {

        public static double GetRenta(double balance, double tasaInteres, int periodos)
        {
            return Math.Round((balance / ((1 - (Math.Pow((1 + tasaInteres), -periodos))) / tasaInteres)), 2)+0.01;

        }
        static void Main(string[] args)
        {
            double TasaInteres = 0.03;
            double interes = 0;
            double amortizacion = 0;
            double balance = 500;
            double renta = 0;
            int periodos = 12;

            /*
                        Console.WriteLine("Tasa de Interes:");
                        TasaInteres = double.Parse(Console.ReadLine());
                        Console.WriteLine("Balance");
                        balance = double.Parse(Console.ReadLine());
                        Console.WriteLine("Cantidad de periodos");
                        periodos = int.Parse(Console.ReadLine());
            */
            renta = GetRenta(balance, TasaInteres, periodos);
            Console.WriteLine(renta);
            Console.WriteLine("Balance | Interes | Amortizacion | Renta");


            for (int i = 0; i < periodos; i++)
            {


                if (balance > renta)
                {
                    interes = Math.Round(balance * (TasaInteres), 2);
                    amortizacion = Math.Round(renta - interes, 2);
                    balance = Math.Round(balance - amortizacion, 2);


                    Console.WriteLine(balance + " | " + interes + " | " + amortizacion + " | " + renta);
                }

                if (balance < renta)
                {
 
                    interes = Math.Round( balance * (TasaInteres),2);
                    renta = Math.Round(balance + interes,2);
                    amortizacion = Math.Round(renta - interes, 2);
                    Console.WriteLine(balance + " | " + interes + " | " + amortizacion + " | " + renta);
                    break;
                }

            }
            Console.ReadKey();

        }
    }
}
