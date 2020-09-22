using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; } 

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public Funcionario(double Salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;

            Salario = Salario;

            TotalDeFuncionarios++;
        }

        public Funcionario(string cpf)
        {
            CPF = cpf;
        }

        public virtual void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.1);
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
