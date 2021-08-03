using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoHeranca
{
    class Conta
    {
        public int Numero { get; set; }

        public double Saldo { get; protected set; } //Alteramos "private" por "protected" pois esse atributo permite que as classes filhas (ContaPoupanca), acessem essa variável.       

        public Cliente Titular { get; set; } 
              


        //Criando método de saque, subtraindo a propriedade valor, que está sendo passado no button1.
        public virtual void Saca(double valor) //"virtual" significa que autorizamos que o método "Saca" da contaPoupanca sobrescreva esse método.
        {
            if (valor + 0.1 <= this.Saldo && valor != 0)
                this.Saldo -= valor;
        }

        //Criando método de saque, somando a propriedade valor, que está sendo passado no button1.
        public void Deposito(double valor)
        {
            if (valor > 0)
                this.Saldo += valor;
        }

        //Criando método de transferência
        //Passando a propriedade valor que será transferido e a conta destino, pois a conta origem é representada pelo "this".
        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposito(valor);
        }
    }
}
