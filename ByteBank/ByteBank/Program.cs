using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            carlos.Nome = "Carlos";

            gerenciador.Registrar(carlos);

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do carlos " + carlos.Salario);

            Console.WriteLine("CPF do Carlos " + carlos.CPF);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);


            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";


            Funcionario robertaTeste = roberta;

            roberta.AumentarSalario();
            Console.WriteLine("CPF da Roberta " + roberta.CPF);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Console.WriteLine("Novo salário da roberta " + roberta.Salario);

            Console.WriteLine("Bonificacao de uma referencia de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificacao de uma referencia de Funcionario: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());


            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());


            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
