using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_POO.ClassesAtributosMetodos
{
    internal class ConversorDeMoeda
    {
        static double IOF = 0.06;

        public static double Converter(double valor, double cotacao)
        {
            var imposto = valor * cotacao * IOF;

            return (valor * cotacao + imposto);
        }
    }
}
