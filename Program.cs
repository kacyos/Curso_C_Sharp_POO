
using Curso_C_Sharp_POO.ClassesAtributosMetodos;
using Curso_C_Sharp_POO.EstruturaSequencial;
using CursoCSharp;

namespace Curso_C_Sharp_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            var central = new CentralDeExercicios(new Dictionary<string, Action>()
                {
                    {"####### Estrutura Sequencial (entrada, processamento, saída) #######\nSomar", ExEstruturaSequencial.Somar},
                    {"Calcular área do círculo", ExEstruturaSequencial.CalcularAreaCirculo},
                    {"Calcular diferença -> Fórmula:(A * B - C * D)", ExEstruturaSequencial.CalcularDiferenca},
                    {"Calcular salário/hora", ExEstruturaSequencial.CalcularSalario},
                    {"Calcular áreas: Triângulo, Círculo, Trapézio, Quadrado e Retângulo", ExEstruturaSequencial.CalcularAreas},

                    {"####### Classes #######\nComparar idades", ExClassesAtributosMetodos.ComparaIdades },
                    {"Calcular salário médio", ExClassesAtributosMetodos.MediaSalario }
                });

            central.SelecionarEExecutar();
        }
    }
}