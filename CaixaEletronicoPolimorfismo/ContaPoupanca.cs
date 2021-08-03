using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoPolimorfismo
{
    class ContaPoupanca : Conta //Os dois pontos + nome da classe Conta servem para que a ContaPoupanca herde todos os atributos e métodos da classe Conta. Sem repetição de código.
    {
        public override void Saca(double valor) // "override" significa que queremos que esse método sobrescreva o método principal da classe pai(Conta). Para isso, é necessário permitir na classe conta.
        {
            this.Saldo -= valor + 0.1;
        }
    }
}
