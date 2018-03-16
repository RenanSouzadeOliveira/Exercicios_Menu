namespace Exercicios_menu
{
    partial class frmPoupanca
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.txbRendimento = new System.Windows.Forms.TextBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.txbMeses = new System.Windows.Forms.TextBox();
            this.btnCalcularPoup = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(14, 16);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(157, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor Mensal à ser Depositado: ";
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(177, 13);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 20);
            this.txbValor.TabIndex = 1;
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Location = new System.Drawing.Point(14, 60);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(151, 13);
            this.lblRendimento.TabIndex = 2;
            this.lblRendimento.Text = "Porcentagem de Rendimento: ";
            // 
            // txbRendimento
            // 
            this.txbRendimento.Location = new System.Drawing.Point(177, 57);
            this.txbRendimento.Name = "txbRendimento";
            this.txbRendimento.Size = new System.Drawing.Size(100, 20);
            this.txbRendimento.TabIndex = 3;
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(14, 101);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(136, 13);
            this.lblMeses.TabIndex = 4;
            this.lblMeses.Text = "Meses à serem Poupanca: ";
            // 
            // txbMeses
            // 
            this.txbMeses.Location = new System.Drawing.Point(177, 101);
            this.txbMeses.Name = "txbMeses";
            this.txbMeses.Size = new System.Drawing.Size(100, 20);
            this.txbMeses.TabIndex = 5;
            // 
            // btnCalcularPoup
            // 
            this.btnCalcularPoup.Location = new System.Drawing.Point(17, 234);
            this.btnCalcularPoup.Name = "btnCalcularPoup";
            this.btnCalcularPoup.Size = new System.Drawing.Size(260, 43);
            this.btnCalcularPoup.TabIndex = 6;
            this.btnCalcularPoup.Text = "Calcular Poupança";
            this.btnCalcularPoup.UseVisualStyleBackColor = true;
            this.btnCalcularPoup.Click += new System.EventHandler(this.btnCalcularPoup_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(17, 146);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 13);
            this.lblSaldo.TabIndex = 7;
            // 
            // frmPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 289);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnCalcularPoup);
            this.Controls.Add(this.txbMeses);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.txbRendimento);
            this.Controls.Add(this.lblRendimento);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblValor);
            this.Name = "frmPoupanca";
            this.Text = "Calculo de Poupança";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPoupanca_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label lblRendimento;
        private System.Windows.Forms.TextBox txbRendimento;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.TextBox txbMeses;
        private System.Windows.Forms.Button btnCalcularPoup;
        private System.Windows.Forms.Label lblSaldo;
    }
}