using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronicoConstrutores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente("João Vitor", "08281537957"); //passando os valores do nome e cpf que a classe cliente exige ao instanciar, por conta do método "Cliente".

            MessageBox.Show(cliente.Nome+cliente.Cpf);
            

        }
    }
}
