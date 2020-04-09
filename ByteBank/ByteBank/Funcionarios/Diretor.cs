using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public double GetBonificacao()
        {
            return Salario;
        }
    }
}
