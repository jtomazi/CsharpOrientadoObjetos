
namespace ListBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemoverSelecionado = new System.Windows.Forms.Button();
            this.txtAdicionar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numAdicionar = new System.Windows.Forms.NumericUpDown();
            this.btnRadio1Origem = new System.Windows.Forms.RadioButton();
            this.btnRadio2Origem = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRadio1Destino = new System.Windows.Forms.RadioButton();
            this.btnRadio2Destino = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numAdicionar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(34, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(366, 244);
            this.listBox1.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(326, 160);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(34, 469);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRemoverSelecionado
            // 
            this.btnRemoverSelecionado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverSelecionado.Location = new System.Drawing.Point(34, 440);
            this.btnRemoverSelecionado.Name = "btnRemoverSelecionado";
            this.btnRemoverSelecionado.Size = new System.Drawing.Size(130, 23);
            this.btnRemoverSelecionado.TabIndex = 3;
            this.btnRemoverSelecionado.Text = "Remover selecionado";
            this.btnRemoverSelecionado.UseVisualStyleBackColor = true;
            this.btnRemoverSelecionado.Click += new System.EventHandler(this.btnRemoverSelecionado_Click);
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.Location = new System.Drawing.Point(34, 160);
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.Size = new System.Drawing.Size(227, 23);
            this.txtAdicionar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Transferência de estoque";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(325, 439);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // numAdicionar
            // 
            this.numAdicionar.Location = new System.Drawing.Point(267, 160);
            this.numAdicionar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAdicionar.Name = "numAdicionar";
            this.numAdicionar.Size = new System.Drawing.Size(53, 23);
            this.numAdicionar.TabIndex = 7;
            this.numAdicionar.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnRadio1Origem
            // 
            this.btnRadio1Origem.AutoSize = true;
            this.btnRadio1Origem.Location = new System.Drawing.Point(34, 82);
            this.btnRadio1Origem.Name = "btnRadio1Origem";
            this.btnRadio1Origem.Size = new System.Drawing.Size(56, 19);
            this.btnRadio1Origem.TabIndex = 8;
            this.btnRadio1Origem.TabStop = true;
            this.btnRadio1Origem.Text = "Loja 1";
            this.btnRadio1Origem.UseVisualStyleBackColor = true;
            this.btnRadio1Origem.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.btnRadio1Origem.Click += new System.EventHandler(this.btnRadio1Origem_Click);
            // 
            // btnRadio2Origem
            // 
            this.btnRadio2Origem.AutoSize = true;
            this.btnRadio2Origem.Location = new System.Drawing.Point(34, 107);
            this.btnRadio2Origem.Name = "btnRadio2Origem";
            this.btnRadio2Origem.Size = new System.Drawing.Size(56, 19);
            this.btnRadio2Origem.TabIndex = 9;
            this.btnRadio2Origem.TabStop = true;
            this.btnRadio2Origem.Text = "Loja 2";
            this.btnRadio2Origem.UseVisualStyleBackColor = true;
            this.btnRadio2Origem.CheckedChanged += new System.EventHandler(this.btnRadio2Origem_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Origem";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Destino";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRadio1Destino
            // 
            this.btnRadio1Destino.AutoSize = true;
            this.btnRadio1Destino.Location = new System.Drawing.Point(205, 81);
            this.btnRadio1Destino.Name = "btnRadio1Destino";
            this.btnRadio1Destino.Size = new System.Drawing.Size(56, 19);
            this.btnRadio1Destino.TabIndex = 14;
            this.btnRadio1Destino.TabStop = true;
            this.btnRadio1Destino.Text = "Loja 1";
            this.btnRadio1Destino.UseVisualStyleBackColor = true;
            this.btnRadio1Destino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // btnRadio2Destino
            // 
            this.btnRadio2Destino.AutoSize = true;
            this.btnRadio2Destino.Location = new System.Drawing.Point(205, 106);
            this.btnRadio2Destino.Name = "btnRadio2Destino";
            this.btnRadio2Destino.Size = new System.Drawing.Size(56, 19);
            this.btnRadio2Destino.TabIndex = 15;
            this.btnRadio2Destino.TabStop = true;
            this.btnRadio2Destino.Text = "Loja 2";
            this.btnRadio2Destino.UseVisualStyleBackColor = true;
            this.btnRadio2Destino.CheckedChanged += new System.EventHandler(this.btnRadio2Destino_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 540);
            this.Controls.Add(this.btnRadio2Destino);
            this.Controls.Add(this.btnRadio1Destino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRadio2Origem);
            this.Controls.Add(this.btnRadio1Origem);
            this.Controls.Add(this.numAdicionar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdicionar);
            this.Controls.Add(this.btnRemoverSelecionado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAdicionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemoverSelecionado;
        private System.Windows.Forms.TextBox txtAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numAdicionar;
        private System.Windows.Forms.RadioButton btnRadio1Origem;
        private System.Windows.Forms.RadioButton btnRadio2Origem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btnRadio1Destino;
        private System.Windows.Forms.RadioButton btnRadio2Destino;
    }
}

