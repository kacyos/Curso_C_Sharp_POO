using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_POO.ClassesAtributosMetodos
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double CalcularNotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double CalcularNotaFaltante()
        {
            double notaFinal = CalcularNotaFinal();
            if (notaFinal < 60.0)
            {
                return 60.0 - notaFinal;
            }
            return 0;
        }

        public void ImprimirSituacao() { 
            double notaFinal = CalcularNotaFinal();

            if (notaFinal >= 60.0)
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F2",CultureInfo.InvariantCulture)}\n" +
                    $"APROVADO");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                    $"REPROVADO\n" +
                    $"FALTAM {CalcularNotaFaltante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        
        }


    }
}
