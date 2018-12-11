using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera_apps
{
    class Program
    {

        public static double GetRenta(double balance,double tasaInteres,int periodos)
        {
            return Math.Round( balance /( (1 - (Math.Pow((1 + tasaInteres), -periodos))) / tasaInteres),2)+0.01;

        }
        static void Main(string[] args)
        {
            double TasaInteres;
            double interes;
            double amortizacion;
            double Monto=0;
            double renta=0;
            int periodos;


            Console.WriteLine("Tasa de Interes:");
            TasaInteres = double.Parse(Console.ReadLine());

            Console.WriteLine("Renta");
            renta = double.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de periodos");
            periodos = int.Parse(Console.ReadLine());


            Console.WriteLine(Math.Round(renta*((Math.Pow((1+TasaInteres),periodos)-1)/TasaInteres),2));


            
        
            

               Console.ReadKey();

        }
    }
}
