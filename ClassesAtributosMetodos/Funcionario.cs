using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_C_Sharp_POO.ClassesAtributosMetodos
{
    enum Operacao
    {
        Cadastrar = 1,
        Atualizar = 2
    }

    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public double AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
            return SalarioBruto;
        }

        public void ImprimirDadosDaOperacao(Operacao operacao)
        {
            switch (operacao)
            {
                case Operacao.Cadastrar:
                    Console.WriteLine(ToString());
                    break;
                case Operacao.Atualizar:
                    Console.WriteLine($"Funcionário atualizado: {ToString()}");
                    break;
            }
        }

        public override string ToString()
        {
            return $"Funcionário: {Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
