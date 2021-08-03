using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoOO
{
    class Conta
    {

        //get e set servem para encapsulamento

        public int numero { get; set; }
                
        public double Saldo { get; private set; } 
        //para proteger essa propriedade de outras clases, é usado get e set.
        // "get" permite que a propriedade Saldo seja lida por outra classe.
        //já o "private set", permite escrita/alteração apenas pela própria classe "Conta".
        //Então para sacar ou depositar, é necessário invocar os métodos correspondentes, não tem como fazer diretamente.

        public Cliente Titular { get; set; } //atribuindo a clase cliente para a classe conta, podendo acessar os dados do cliente a partir da conta. (cliente.Titular.nome por exemplo).


        //Criando método de saque, subtraindo a propriedade valor, que está sendo passado no button1.
        public void Saca(double valor)
        {
            if ( valor+0.1 <= this.Saldo && valor != 0)
            this.Saldo -= valor + 0.1;
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
