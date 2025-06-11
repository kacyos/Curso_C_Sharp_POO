using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_POO.EstruturaSequencial
{
    class ExEstruturaSequencial
    {
        public static void Somar()
        {
            int number1,
               number2,
               soma;

            Console.Write("Digite o primeiro valor: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            number2 = int.Parse(Console.ReadLine());

            soma = number1 + number2;

            Console.WriteLine("SOMA = " + soma);
            Console.ReadKey();
        }

        public static void CalcularAreaCirculo()
        {
            const double pi = 3.14159;

            Console.Write("Informe o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * (raio * raio);

            Console.WriteLine(
                $"A área do círculo é: {area.ToString("F4", CultureInfo.InvariantCulture)}"
            );
        }

        public static void CalcularDiferenca()
        {
            int a, b, c, d, diferenca;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b) - (c * d);

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }

        public static void CalcularSalario()
        {
            Console.Write("Informe o número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor por hora: U$ ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valorHora;

            Console.WriteLine($"\nNumero: {numero}\nSalário: U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

        }

        public static void CalcularAreas()
        {
            double a, b, c;

            Console.WriteLine("Informe 3 valores de ponto flutuante:");
            string[] valores = Console.ReadLine().Split(" ");

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = a * c / 2.0;
            double circulo = 3.14159 * c * c;
            double trapezio = (a + b) / 2.0 * c;
            double quadrado = b * b;
            double retangulo = a * b;

            Console.WriteLine($"Triangulo: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}
