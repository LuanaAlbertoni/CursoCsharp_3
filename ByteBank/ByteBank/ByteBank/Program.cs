using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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

            // CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("155.766.321-89");
            roberta.Nome = "Roberta";
            roberta.Senha = "1234";

            GerenteDeConta luana = new GerenteDeConta("066.389.989-99");
            luana.Nome = "Luana";
            luana.Senha = "asd";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(roberta, "1234");
            sistemaInterno.Logar(luana, "asd");
            sistemaInterno.Logar(parceiro, "123456");
        }


        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer guilherme = new Designer("856.777.033-45");
            guilherme.Nome = "Pedro";


            Auxiliar pedro = new Auxiliar("345.658.667-33");
            pedro.Nome = "Pedro";

            GerenteDeConta luana = new GerenteDeConta("066.389.989-99");
            luana.Nome = "Luana";

            Desenvolvedor lucas = new Desenvolvedor("123.765.889-88");
            lucas.Nome = "Lucas";

            gerenciadorBonificacao.Registrar(guilherme);
            //gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(luana);
            gerenciadorBonificacao.Registrar(lucas);


            Console.WriteLine("Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}
