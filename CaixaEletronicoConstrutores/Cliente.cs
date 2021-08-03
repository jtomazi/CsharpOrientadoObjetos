using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoConstrutores
{
    class Cliente
    {

        public string Nome { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }


        //criando método com o mesmo nome da classe, para definir o nome e cpf do cliente no momento de instanciar a classe. Exemplo no Form1.
        public Cliente(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }

        //Essa classe com o mesmo nome da anterior e sem parâmetros permite que seja opcional o nome e cpf da classe anterior. 
        public Cliente() { }

    }
}
