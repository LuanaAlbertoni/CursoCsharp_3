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

            Funcionario carlos = new Funcionario(2000, "546.896.157-20");

            carlos.Nome = "Carlos";


            carlos.AumentarSalario();
            Console.WriteLine("Novo salario do Carlos:" + carlos.Salario);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("545.658.148-3");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            roberta.AumentarSalario();
            Console.WriteLine("Novo Salario de Roberta: " + roberta.Salario);

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
