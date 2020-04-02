using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        public double _totalBonificacao;

        public void Registrar(Funcionarios funcionario)
        {
            funcionario.GetBonificacao();
        }
    }
}
