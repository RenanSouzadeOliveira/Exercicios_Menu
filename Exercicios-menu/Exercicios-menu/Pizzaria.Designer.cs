namespace Exercicios_menu
{
    partial class frmPizzaria
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
            this.chkMussarela = new System.Windows.Forms.CheckBox();
            this.rbEsfirra = new System.Windows.Forms.RadioButton();
            this.comboRefrigerantes = new System.Windows.Forms.ComboBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblPizza = new System.Windows.Forms.Label();
            this.chkCalabresa = new System.Windows.Forms.CheckBox();
            this.chk4queijos = new System.Windows.Forms.CheckBox();
            this.lblRefrigerante = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnPedido = new System.Windows.Forms.Button();
            this.chkRefri = new System.Windows.Forms.CheckBox();
            this.rtbComanda = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // chkMussarela
            // 
            this.chkMussarela.AutoSize = true;
            this.chkMussarela.Location = new System.Drawing.Point(12, 41);
            this.chkMussarela.Name = "chkMussarela";
            this.chkMussarela.Size = new System.Drawing.Size(121, 17);
            this.chkMussarela.TabIndex = 0;
            this.chkMussarela.Text = "Mussarela R$ 20,00";
            this.chkMussarela.UseVisualStyleBackColor = true;
            // 
            // rbEsfirra
            // 
            this.rbEsfirra.AutoSize = true;
            this.rbEsfirra.Location = new System.Drawing.Point(151, 86);
            this.rbEsfirra.Name = "rbEsfirra";
            this.rbEsfirra.Size = new System.Drawing.Size(160, 17);
            this.rbEsfirra.TabIndex = 1;
            this.rbEsfirra.TabStop = true;
            this.rbEsfirra.Text = "Esfirra de chocolate R$ 1,50";
            this.rbEsfirra.UseVisualStyleBackColor = true;
            // 
            // comboRefrigerantes
            // 
            this.comboRefrigerantes.FormattingEnabled = true;
            this.comboRefrigerantes.Items.AddRange(new object[] {
            "Coca-Cola",
            "Fanta Laranja",
            "Guarana",
            "Tubaina"});
            this.comboRefrigerantes.Location = new System.Drawing.Point(151, 59);
            this.comboRefrigerantes.Name = "comboRefrigerantes";
            this.comboRefrigerantes.Size = new System.Drawing.Size(121, 21);
            this.comboRefrigerantes.TabIndex = 2;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(138, 146);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 20);
            this.txbValor.TabIndex = 3;
            // 
            // lblPizza
            // 
            this.lblPizza.AutoSize = true;
            this.lblPizza.Location = new System.Drawing.Point(13, 25);
            this.lblPizza.Name = "lblPizza";
            this.lblPizza.Size = new System.Drawing.Size(32, 13);
            this.lblPizza.TabIndex = 4;
            this.lblPizza.Text = "Pizza";
            // 
            // chkCalabresa
            // 
            this.chkCalabresa.AutoSize = true;
            this.chkCalabresa.Location = new System.Drawing.Point(12, 64);
            this.chkCalabresa.Name = "chkCalabresa";
            this.chkCalabresa.Size = new System.Drawing.Size(120, 17);
            this.chkCalabresa.TabIndex = 5;
            this.chkCalabresa.Text = "Calabresa R$ 20,00";
            this.chkCalabresa.UseVisualStyleBackColor = true;
            // 
            // chk4queijos
            // 
            this.chk4queijos.AutoSize = true;
            this.chk4queijos.Location = new System.Drawing.Point(12, 87);
            this.chk4queijos.Name = "chk4queijos";
            this.chk4queijos.Size = new System.Drawing.Size(115, 17);
            this.chk4queijos.TabIndex = 6;
            this.chk4queijos.Text = "4 queijos R$ 25,00";
            this.chk4queijos.UseVisualStyleBackColor = true;
            // 
            // lblRefrigerante
            // 
            this.lblRefrigerante.AutoSize = true;
            this.lblRefrigerante.Location = new System.Drawing.Point(148, 41);
            this.lblRefrigerante.Name = "lblRefrigerante";
            this.lblRefrigerante.Size = new System.Drawing.Size(45, 13);
            this.lblRefrigerante.TabIndex = 7;
            this.lblRefrigerante.Text = "Escolha";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(76, 149);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(56, 13);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor Final";
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(134, 114);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(113, 23);
            this.btnPedido.TabIndex = 9;
            this.btnPedido.Text = "Finalizar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // chkRefri
            // 
            this.chkRefri.AutoSize = true;
            this.chkRefri.Location = new System.Drawing.Point(151, 13);
            this.chkRefri.Name = "chkRefri";
            this.chkRefri.Size = new System.Drawing.Size(125, 17);
            this.chkRefri.TabIndex = 10;
            this.chkRefri.Text = "Refrigerante R$ 5,00";
            this.chkRefri.UseVisualStyleBackColor = true;
            // 
            // rtbComanda
            // 
            this.rtbComanda.Location = new System.Drawing.Point(79, 172);
            this.rtbComanda.Name = "rtbComanda";
            this.rtbComanda.Size = new System.Drawing.Size(214, 96);
            this.rtbComanda.TabIndex = 11;
            this.rtbComanda.Text = "";
            // 
            // frmPizzaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.rtbComanda);
            this.Controls.Add(this.chkRefri);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblRefrigerante);
            this.Controls.Add(this.chk4queijos);
            this.Controls.Add(this.chkCalabresa);
            this.Controls.Add(this.lblPizza);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.comboRefrigerantes);
            this.Controls.Add(this.rbEsfirra);
            this.Controls.Add(this.chkMussarela);
            this.Name = "frmPizzaria";
            this.Text = "Pizzaria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPizzaria_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMussarela;
        private System.Windows.Forms.RadioButton rbEsfirra;
        private System.Windows.Forms.ComboBox comboRefrigerantes;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label lblPizza;
        private System.Windows.Forms.CheckBox chkCalabresa;
        private System.Windows.Forms.CheckBox chk4queijos;
        private System.Windows.Forms.Label lblRefrigerante;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.CheckBox chkRefri;
        private System.Windows.Forms.RichTextBox rtbComanda;
    }
}