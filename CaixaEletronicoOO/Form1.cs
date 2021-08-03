using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();

            conta.Deposito(1000);

            conta.Saca(100);
            conta.Saca(100);
            conta.Titular = new Cliente();
            conta.Titular.nome = "João Vitor";
            MessageBox.Show("O saldo atual de "+conta.Titular.nome+" é "+conta.Saldo);


        }
    }
}
