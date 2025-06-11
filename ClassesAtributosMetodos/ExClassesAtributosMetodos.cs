using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_POO.ClassesAtributosMetodos
{
    class ExClassesAtributosMetodos
    {
        public static void ComparaIdades()
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            int.TryParse(Console.ReadLine(), out p1.Idade);

            Console.WriteLine("\nDados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            int.TryParse(Console.ReadLine(), out p2.Idade);

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"\n{p1.Nome} é mais velho(a) que {p2.Nome}.");
            }
            else if (p1.Idade < p2.Idade)
            {
                Console.WriteLine($"\n{p2.Nome} é mais velho(a) que {p1.Nome}.");
            }
            else
            {
                Console.WriteLine($"\n{p1.Nome} e {p2.Nome} têm a mesma idade.");
            }

        }

        public static void MediaSalario()
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out f1.Salario);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out f2.Salario);

            string media = ((f1.Salario + f2.Salario) / 2).ToString("F2", CultureInfo.InvariantCulture);

            Console.WriteLine("\nSalário médio {0}", media);
        }
    }
}
