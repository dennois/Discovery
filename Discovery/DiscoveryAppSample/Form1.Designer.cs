namespace DiscoveryAppSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rdbFisica = new System.Windows.Forms.RadioButton();
            this.rdbJuridica = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.cboOfertas = new System.Windows.Forms.ComboBox();
            this.lblOfertas = new System.Windows.Forms.Label();
            this.cboLinha = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 20);
            this.textBox1.TabIndex = 1;
            // 
            // rdbFisica
            // 
            this.rdbFisica.AutoSize = true;
            this.rdbFisica.Location = new System.Drawing.Point(16, 37);
            this.rdbFisica.Name = "rdbFisica";
            this.rdbFisica.Size = new System.Drawing.Size(54, 17);
            this.rdbFisica.TabIndex = 2;
            this.rdbFisica.TabStop = true;
            this.rdbFisica.Text = "Fisíca";
            this.rdbFisica.UseVisualStyleBackColor = true;
            this.rdbFisica.CheckedChanged += new System.EventHandler(this.rdbFisica_CheckedChanged);
            // 
            // rdbJuridica
            // 
            this.rdbJuridica.AutoSize = true;
            this.rdbJuridica.Location = new System.Drawing.Point(76, 37);
            this.rdbJuridica.Name = "rdbJuridica";
            this.rdbJuridica.Size = new System.Drawing.Size(63, 17);
            this.rdbJuridica.TabIndex = 3;
            this.rdbJuridica.TabStop = true;
            this.rdbJuridica.Text = "Jurídica";
            this.rdbJuridica.UseVisualStyleBackColor = true;
            this.rdbJuridica.CheckedChanged += new System.EventHandler(this.rdbJuridica_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo Pessoa";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(346, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF/CNPJ";
            // 
            // cboProdutos
            // 
            this.cboProdutos.DisplayMember = "Value";
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(12, 269);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(346, 21);
            this.cboProdutos.TabIndex = 8;
            this.cboProdutos.ValueMember = "Key";
            this.cboProdutos.SelectedIndexChanged += new System.EventHandler(this.cboProdutos_SelectedIndexChanged);
            // 
            // cboOfertas
            // 
            this.cboOfertas.DisplayMember = "Value";
            this.cboOfertas.FormattingEnabled = true;
            this.cboOfertas.Location = new System.Drawing.Point(12, 339);
            this.cboOfertas.Name = "cboOfertas";
            this.cboOfertas.Size = new System.Drawing.Size(346, 21);
            this.cboOfertas.TabIndex = 10;
            this.cboOfertas.ValueMember = "Key";
            this.cboOfertas.Visible = false;
            // 
            // lblOfertas
            // 
            this.lblOfertas.AutoSize = true;
            this.lblOfertas.Location = new System.Drawing.Point(13, 313);
            this.lblOfertas.Name = "lblOfertas";
            this.lblOfertas.Size = new System.Drawing.Size(41, 13);
            this.lblOfertas.TabIndex = 9;
            this.lblOfertas.Text = "Ofertas";
            this.lblOfertas.Visible = false;
            // 
            // cboLinha
            // 
            this.cboLinha.DisplayMember = "Value";
            this.cboLinha.FormattingEnabled = true;
            this.cboLinha.Location = new System.Drawing.Point(12, 208);
            this.cboLinha.Name = "cboLinha";
            this.cboLinha.Size = new System.Drawing.Size(346, 21);
            this.cboLinha.TabIndex = 12;
            this.cboLinha.ValueMember = "Key";
            this.cboLinha.SelectedIndexChanged += new System.EventHandler(this.cboLinha_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Linha";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.cboLinha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboOfertas);
            this.Controls.Add(this.lblOfertas);
            this.Controls.Add(this.cboProdutos);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbJuridica);
            this.Controls.Add(this.rdbFisica);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rdbFisica;
        private System.Windows.Forms.RadioButton rdbJuridica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.ComboBox cboOfertas;
        private System.Windows.Forms.Label lblOfertas;
        private System.Windows.Forms.ComboBox cboLinha;
        private System.Windows.Forms.Label label5;
    }
}

