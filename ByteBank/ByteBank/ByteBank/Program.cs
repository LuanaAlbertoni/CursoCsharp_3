using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "546.896.157-20";
            carlos.Salario = 2000;

            Console.WriteLine

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "545.658.148-3";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            double totalBonificacoes = carlos.GetBonificacao();

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + robertaTeste.GetBonificacao());

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações:" + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
