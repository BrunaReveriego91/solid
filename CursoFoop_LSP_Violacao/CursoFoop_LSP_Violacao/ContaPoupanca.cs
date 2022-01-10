using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoFoop_LSP_Violacao
{
    class ContaPoupanca : Conta
    {
        public override void Saque(double valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
        }
    }
}
