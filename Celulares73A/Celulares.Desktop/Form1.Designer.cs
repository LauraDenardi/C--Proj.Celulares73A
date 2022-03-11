namespace Celulares.Desktop
{
    partial class frmPrincipal
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
            this.txtPrecoMin = new System.Windows.Forms.TextBox();
            this.txtPrecoMax = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lstCelulares = new System.Windows.Forms.ListBox();
            this.btnBuscaPreco = new System.Windows.Forms.Button();
            this.btnBuscaModelo = new System.Windows.Forms.Button();
            this.btnBuscaFabricante = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.lblCelulares = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrecoMin
            // 
            this.txtPrecoMin.Location = new System.Drawing.Point(96, 45);
            this.txtPrecoMin.Name = "txtPrecoMin";
            this.txtPrecoMin.Size = new System.Drawing.Size(100, 22);
            this.txtPrecoMin.TabIndex = 0;
            // 
            // txtPrecoMax
            // 
            this.txtPrecoMax.Location = new System.Drawing.Point(250, 45);
            this.txtPrecoMax.Name = "txtPrecoMax";
            this.txtPrecoMax.Size = new System.Drawing.Size(100, 22);
            this.txtPrecoMax.TabIndex = 1;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(96, 102);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(254, 22);
            this.txtModelo.TabIndex = 2;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(19, 461);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 3;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(121, 461);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(96, 155);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(254, 24);
            this.cmbFabricante.TabIndex = 5;
            // 
            // lstCelulares
            // 
            this.lstCelulares.FormattingEnabled = true;
            this.lstCelulares.ItemHeight = 16;
            this.lstCelulares.Location = new System.Drawing.Point(19, 264);
            this.lstCelulares.Name = "lstCelulares";
            this.lstCelulares.Size = new System.Drawing.Size(384, 180);
            this.lstCelulares.TabIndex = 6;
            // 
            // btnBuscaPreco
            // 
            this.btnBuscaPreco.Location = new System.Drawing.Point(370, 45);
            this.btnBuscaPreco.Name = "btnBuscaPreco";
            this.btnBuscaPreco.Size = new System.Drawing.Size(33, 23);
            this.btnBuscaPreco.TabIndex = 7;
            this.btnBuscaPreco.Text = ">";
            this.btnBuscaPreco.UseVisualStyleBackColor = true;
            // 
            // btnBuscaModelo
            // 
            this.btnBuscaModelo.Location = new System.Drawing.Point(370, 101);
            this.btnBuscaModelo.Name = "btnBuscaModelo";
            this.btnBuscaModelo.Size = new System.Drawing.Size(33, 23);
            this.btnBuscaModelo.TabIndex = 8;
            this.btnBuscaModelo.Text = ">";
            this.btnBuscaModelo.UseVisualStyleBackColor = true;
            // 
            // btnBuscaFabricante
            // 
            this.btnBuscaFabricante.Location = new System.Drawing.Point(370, 156);
            this.btnBuscaFabricante.Name = "btnBuscaFabricante";
            this.btnBuscaFabricante.Size = new System.Drawing.Size(33, 23);
            this.btnBuscaFabricante.TabIndex = 9;
            this.btnBuscaFabricante.Text = ">";
            this.btnBuscaFabricante.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(16, 50);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(46, 16);
            this.lblPreco.TabIndex = 10;
            this.lblPreco.Text = "Preço:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(16, 108);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(56, 16);
            this.lblModelo.TabIndex = 11;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(16, 158);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(74, 16);
            this.lblFabricante.TabIndex = 12;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPesquisa.Location = new System.Drawing.Point(16, 9);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(91, 16);
            this.lblPesquisa.TabIndex = 13;
            this.lblPesquisa.Text = "Pesquisar por";
            // 
            // lblCelulares
            // 
            this.lblCelulares.AutoSize = true;
            this.lblCelulares.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCelulares.Location = new System.Drawing.Point(16, 230);
            this.lblCelulares.Name = "lblCelulares";
            this.lblCelulares.Size = new System.Drawing.Size(64, 16);
            this.lblCelulares.TabIndex = 14;
            this.lblCelulares.Text = "Celulares";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(215, 52);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(15, 16);
            this.lblA.TabIndex = 15;
            this.lblA.Text = "a";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 505);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblCelulares);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnBuscaFabricante);
            this.Controls.Add(this.btnBuscaModelo);
            this.Controls.Add(this.btnBuscaPreco);
            this.Controls.Add(this.lstCelulares);
            this.Controls.Add(this.cmbFabricante);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtPrecoMax);
            this.Controls.Add(this.txtPrecoMin);
            this.Name = "frmPrincipal";
            this.Text = "Lista de Celulares ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecoMin;
        private System.Windows.Forms.TextBox txtPrecoMax;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ListBox lstCelulares;
        private System.Windows.Forms.Button btnBuscaPreco;
        private System.Windows.Forms.Button btnBuscaModelo;
        private System.Windows.Forms.Button btnBuscaFabricante;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Label lblCelulares;
        private System.Windows.Forms.Label lblA;
    }
}

