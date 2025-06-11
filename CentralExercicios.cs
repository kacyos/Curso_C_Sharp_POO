using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp
{
    public class CentralDeExercicios
    {
        Dictionary<string, Action> Exercicios;

        public CentralDeExercicios(Dictionary<string, Action> exercicios)
        {
            Exercicios = exercicios;
        }

        public void SelecionarEExecutar()
        {
            int i = 1;

            foreach (var exercicio in Exercicios)
            {
                var textoCompleto = exercicio.Key;
                var linhas = textoCompleto.Split('\n');

                foreach (var linha in linhas)
                {
                    if (linha.Contains("#"))
                    {
                        //Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(linha);
                    } else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("  {0}) {1}", i, linha);
                    }                  
                }               

                i++;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nDigite o número (ou vazio para o último)? ");
            Console.ResetColor();

            int.TryParse(Console.ReadLine(), out int num);
            bool numValido = num > 0 && num <= Exercicios.Count;
            num = numValido ? num - 1 : Exercicios.Count - 1;

            string nomeDoExercicio = Exercicios.ElementAt(num).Key;

            Console.Write("\nExecutando exercício ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(nomeDoExercicio);
            Console.ResetColor();

            Console.WriteLine(String.Concat(
                Enumerable.Repeat("=", nomeDoExercicio.Length + 21)) + "\n");

            Action executar = Exercicios.ElementAt(num).Value;
            try
            {
                executar();
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                Console.ResetColor();

                Console.WriteLine(e.StackTrace);
            }
        }
    }
}