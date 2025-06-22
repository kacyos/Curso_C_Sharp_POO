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
    
        public static void CalcularRetangulo()
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com os valores da largura e altura do retângulo:");
            Console.Write("Largura: ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out retangulo.Largura);
            Console.Write("Altura: ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out retangulo.Altura);

            Console.WriteLine();
            Console.WriteLine(retangulo.ToString());
        }

        public static void CadastrarFuncionario()
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Entre com os dados do funcionário:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out funcionario.SalarioBruto);
            Console.Write("Imposto: ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out funcionario.Imposto);

            funcionario.ImprimirDadosDaOperacao(Operacao.Cadastrar);

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double porcentagem);
            funcionario.AumentarSalario(porcentagem);

            funcionario.ImprimirDadosDaOperacao(Operacao.Atualizar);
        }

        public static void CalcularNotaFinal() { 
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            Console.Write("Nota 1: ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out aluno.Nota1);
            Console.Write("Nota 2: ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out aluno.Nota2);
            Console.Write("Nota 3: ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out aluno.Nota3);

            aluno.ImprimirSituacao();
        }
   
        public static void ConversorRealDolar()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double cotacao);
            
            Console.Write("Quantos dólares você vai comprar? ");
            double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double valor);

            double valorConvertido = ConversorDeMoeda.Converter(valor, cotacao);

            Console.WriteLine($"Valor a ser pago em reais = {valorConvertido.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
