using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeaAplicacion
{
    internal class Estadistica
    {
        public double media(double[] serie)
        {
            return serie.Average();
        }

        public double desviacionTipica(double[] serie, double media)
        {
            return Math.Sqrt(serie.Average(n => Math.Pow(n - media, 2)));
        }

        public double armonica(double[] serie)
        {
            return serie.Length / serie.Sum(x => 1 / x);
        }


        public double varianza(double[] serie, double media)
        {
            double sumaCuadrados = 0;
            for (int i = 0; i < serie.Length; i++)
            {
                sumaCuadrados += Math.Pow(serie[i], 2);
            }
            double varianza = (sumaCuadrados / serie.Length) - Math.Pow(media, 2);
            return varianza;
        }

    }
}