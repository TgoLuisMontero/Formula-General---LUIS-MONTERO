using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula_General___LUIS_MONTERO.Clases
{

    public class C_AplicarFormula
    {
        public C_AplicarFormula() { }

        public double CalcularX1(double a, double b, double c) 
            => ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

        public double CalcularX2(double a, double b, double c)
            => ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
    }
}
