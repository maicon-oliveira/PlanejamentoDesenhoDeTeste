using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.core
{
    public static class IMC
    {
        public static double CalcularImc(double Peso, double Altura)
        {
            var resultado = Peso / (Altura * Altura);
            return resultado;
        }

    }
}
