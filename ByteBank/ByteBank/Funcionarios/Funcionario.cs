using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public static int TotaDeFuncionarios { get; private set; }

        public Funcionario(string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            
            CPF = cpf;

            TotaDeFuncionarios++;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}