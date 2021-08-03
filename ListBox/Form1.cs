using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Adicionando itens na listbox
            listBox1.Items.Add(txtAdicionar.Text);

            //Apagando conteúdo do textbox após adicionar o item a lista.
            txtAdicionar.Text = "";

            //Trazendo foco ao textbox após adicionar item a lista.
            txtAdicionar.Focus();
          
        }

        private void btnRemoverSelecionado_Click(object sender, EventArgs e)
        {
            //Removendo o item selecionado
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpa a lista inteira.
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transferência realizada com sucesso!", "",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(numAdicionar);
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRadio1Origem.Enabled)
            {
                btnRadio1Destino.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (btnRadio1Destino.Enabled)
            {
                btnRadio1Origem.Enabled = false;
            }
        }

        private void btnRadio2Origem_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRadio2Origem.Enabled)
            {
                btnRadio2Destino.Enabled = false;
            }
        }

        private void btnRadio2Destino_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRadio2Destino.Checked)
            {
                btnRadio2Origem.Enabled = false;
            }
        }

        private void btnRadio1Origem_Click(object sender, EventArgs e)
        {

        }
    }
}
