using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            ContaPoupanca c2 = new ContaPoupanca();
            TotalizadorDeContas t = new TotalizadorDeContas();

            c1.Deposito(100);
            c2.Deposito(100);

            t.Adiciona(c1);
            t.Adiciona(c2);

            MessageBox.Show("O total das contas é: " + t.Total);


        }
             

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
