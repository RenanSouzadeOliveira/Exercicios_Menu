namespace Exercicios_menu
{
    partial class frmCinema
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.lblFilme = new System.Windows.Forms.Label();
            this.cbxFilme = new System.Windows.Forms.ComboBox();
            this.chb3D = new System.Windows.Forms.CheckBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbEstudante = new System.Windows.Forms.RadioButton();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblPrecoEstudante = new System.Windows.Forms.Label();
            this.lblPrecoNormal = new System.Windows.Forms.Label();
            this.lblQuantidadePedido = new System.Windows.Forms.Label();
            this.lblPrecoPedido = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.chbPipoca = new System.Windows.Forms.CheckBox();
            this.chbCoca = new System.Windows.Forms.CheckBox();
            this.lblPrecoCoca = new System.Windows.Forms.Label();
            this.lblPrecoPipoca = new System.Windows.Forms.Label();
            this.txbQuantidadePipoca = new System.Windows.Forms.TextBox();
            this.txbQuantidadeCoca = new System.Windows.Forms.TextBox();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.lblValorIngresso = new System.Windows.Forms.Label();
            this.txbValorIngresso = new System.Windows.Forms.TextBox();
            this.lblFilmeSelecionado = new System.Windows.Forms.Label();
            this.txbFilmeSelecionado = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblValorPedido = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.txbValorPedido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 13);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(91, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Nome do Cliente: ";
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(110, 10);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(237, 20);
            this.txbCliente.TabIndex = 1;
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Location = new System.Drawing.Point(364, 13);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(37, 13);
            this.lblFilme.TabIndex = 2;
            this.lblFilme.Text = "Filme: ";
            // 
            // cbxFilme
            // 
            this.cbxFilme.DisplayMember = "IT! A Coisa";
            this.cbxFilme.FormattingEnabled = true;
            this.cbxFilme.Items.AddRange(new object[] {
            "IT! A Coisa",
            "Capitão América",
            "X-Men"});
            this.cbxFilme.Location = new System.Drawing.Point(407, 9);
            this.cbxFilme.Name = "cbxFilme";
            this.cbxFilme.Size = new System.Drawing.Size(200, 21);
            this.cbxFilme.TabIndex = 3;
            // 
            // chb3D
            // 
            this.chb3D.AutoSize = true;
            this.chb3D.Location = new System.Drawing.Point(407, 37);
            this.chb3D.Name = "chb3D";
            this.chb3D.Size = new System.Drawing.Size(87, 17);
            this.chb3D.TabIndex = 4;
            this.chb3D.Text = "3D (R$ 7,50)";
            this.chb3D.UseVisualStyleBackColor = true;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(36, 109);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(34, 13);
            this.lblModo.TabIndex = 5;
            this.lblModo.Text = "Modo";
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Location = new System.Drawing.Point(16, 142);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbNormal.TabIndex = 6;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            // 
            // rdbEstudante
            // 
            this.rdbEstudante.AutoSize = true;
            this.rdbEstudante.Location = new System.Drawing.Point(16, 175);
            this.rdbEstudante.Name = "rdbEstudante";
            this.rdbEstudante.Size = new System.Drawing.Size(73, 17);
            this.rdbEstudante.TabIndex = 7;
            this.rdbEstudante.TabStop = true;
            this.rdbEstudante.Text = "Estudante";
            this.rdbEstudante.UseVisualStyleBackColor = true;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(107, 109);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço";
            // 
            // lblPrecoEstudante
            // 
            this.lblPrecoEstudante.AutoSize = true;
            this.lblPrecoEstudante.Location = new System.Drawing.Point(107, 179);
            this.lblPrecoEstudante.Name = "lblPrecoEstudante";
            this.lblPrecoEstudante.Size = new System.Drawing.Size(45, 13);
            this.lblPrecoEstudante.TabIndex = 9;
            this.lblPrecoEstudante.Text = "R$ 8,50";
            // 
            // lblPrecoNormal
            // 
            this.lblPrecoNormal.AutoSize = true;
            this.lblPrecoNormal.Location = new System.Drawing.Point(107, 146);
            this.lblPrecoNormal.Name = "lblPrecoNormal";
            this.lblPrecoNormal.Size = new System.Drawing.Size(51, 13);
            this.lblPrecoNormal.TabIndex = 10;
            this.lblPrecoNormal.Text = "R$ 17,00";
            // 
            // lblQuantidadePedido
            // 
            this.lblQuantidadePedido.AutoSize = true;
            this.lblQuantidadePedido.Location = new System.Drawing.Point(459, 109);
            this.lblQuantidadePedido.Name = "lblQuantidadePedido";
            this.lblQuantidadePedido.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidadePedido.TabIndex = 11;
            this.lblQuantidadePedido.Text = "Quantidade";
            // 
            // lblPrecoPedido
            // 
            this.lblPrecoPedido.AutoSize = true;
            this.lblPrecoPedido.Location = new System.Drawing.Point(404, 109);
            this.lblPrecoPedido.Name = "lblPrecoPedido";
            this.lblPrecoPedido.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoPedido.TabIndex = 12;
            this.lblPrecoPedido.Text = "Preço";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(312, 109);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(45, 13);
            this.lblPedidos.TabIndex = 13;
            this.lblPedidos.Text = "Pedidos";
            // 
            // chbPipoca
            // 
            this.chbPipoca.AutoSize = true;
            this.chbPipoca.Location = new System.Drawing.Point(315, 146);
            this.chbPipoca.Name = "chbPipoca";
            this.chbPipoca.Size = new System.Drawing.Size(59, 17);
            this.chbPipoca.TabIndex = 14;
            this.chbPipoca.Text = "Pipoca";
            this.chbPipoca.UseVisualStyleBackColor = true;
            // 
            // chbCoca
            // 
            this.chbCoca.AutoSize = true;
            this.chbCoca.Location = new System.Drawing.Point(315, 179);
            this.chbCoca.Name = "chbCoca";
            this.chbCoca.Size = new System.Drawing.Size(75, 17);
            this.chbCoca.TabIndex = 15;
            this.chbCoca.Text = "Coca-Cola";
            this.chbCoca.UseVisualStyleBackColor = true;
            // 
            // lblPrecoCoca
            // 
            this.lblPrecoCoca.AutoSize = true;
            this.lblPrecoCoca.Location = new System.Drawing.Point(404, 183);
            this.lblPrecoCoca.Name = "lblPrecoCoca";
            this.lblPrecoCoca.Size = new System.Drawing.Size(45, 13);
            this.lblPrecoCoca.TabIndex = 16;
            this.lblPrecoCoca.Text = "R$ 4,25";
            // 
            // lblPrecoPipoca
            // 
            this.lblPrecoPipoca.AutoSize = true;
            this.lblPrecoPipoca.Location = new System.Drawing.Point(404, 150);
            this.lblPrecoPipoca.Name = "lblPrecoPipoca";
            this.lblPrecoPipoca.Size = new System.Drawing.Size(45, 13);
            this.lblPrecoPipoca.TabIndex = 17;
            this.lblPrecoPipoca.Text = "R$ 4,50";
            // 
            // txbQuantidadePipoca
            // 
            this.txbQuantidadePipoca.Location = new System.Drawing.Point(462, 146);
            this.txbQuantidadePipoca.Name = "txbQuantidadePipoca";
            this.txbQuantidadePipoca.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidadePipoca.TabIndex = 18;
            // 
            // txbQuantidadeCoca
            // 
            this.txbQuantidadeCoca.Location = new System.Drawing.Point(462, 177);
            this.txbQuantidadeCoca.Name = "txbQuantidadeCoca";
            this.txbQuantidadeCoca.Size = new System.Drawing.Size(100, 20);
            this.txbQuantidadeCoca.TabIndex = 19;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(216, 290);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(174, 23);
            this.btnFinalizarCompra.TabIndex = 20;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // lblValorIngresso
            // 
            this.lblValorIngresso.AutoSize = true;
            this.lblValorIngresso.Location = new System.Drawing.Point(16, 387);
            this.lblValorIngresso.Name = "lblValorIngresso";
            this.lblValorIngresso.Size = new System.Drawing.Size(91, 13);
            this.lblValorIngresso.TabIndex = 21;
            this.lblValorIngresso.Text = "Valor do ingresso:";
            // 
            // txbValorIngresso
            // 
            this.txbValorIngresso.Location = new System.Drawing.Point(16, 404);
            this.txbValorIngresso.Name = "txbValorIngresso";
            this.txbValorIngresso.Size = new System.Drawing.Size(100, 20);
            this.txbValorIngresso.TabIndex = 22;
            // 
            // lblFilmeSelecionado
            // 
            this.lblFilmeSelecionado.AutoSize = true;
            this.lblFilmeSelecionado.Location = new System.Drawing.Point(13, 445);
            this.lblFilmeSelecionado.Name = "lblFilmeSelecionado";
            this.lblFilmeSelecionado.Size = new System.Drawing.Size(93, 13);
            this.lblFilmeSelecionado.TabIndex = 23;
            this.lblFilmeSelecionado.Text = "Filme Selecionado";
            // 
            // txbFilmeSelecionado
            // 
            this.txbFilmeSelecionado.Location = new System.Drawing.Point(16, 462);
            this.txbFilmeSelecionado.Name = "txbFilmeSelecionado";
            this.txbFilmeSelecionado.Size = new System.Drawing.Size(100, 20);
            this.txbFilmeSelecionado.TabIndex = 24;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(256, 445);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(73, 13);
            this.lblTotalPagar.TabIndex = 25;
            this.lblTotalPagar.Text = "Total à pagar:";
            // 
            // lblValorPedido
            // 
            this.lblValorPedido.AutoSize = true;
            this.lblValorPedido.Location = new System.Drawing.Point(256, 387);
            this.lblValorPedido.Name = "lblValorPedido";
            this.lblValorPedido.Size = new System.Drawing.Size(84, 13);
            this.lblValorPedido.TabIndex = 26;
            this.lblValorPedido.Text = "Valor do pedido:";
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(259, 462);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 20);
            this.txbTotal.TabIndex = 27;
            // 
            // txbValorPedido
            // 
            this.txbValorPedido.Location = new System.Drawing.Point(259, 404);
            this.txbValorPedido.Name = "txbValorPedido";
            this.txbValorPedido.Size = new System.Drawing.Size(100, 20);
            this.txbValorPedido.TabIndex = 28;
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 532);
            this.Controls.Add(this.txbValorPedido);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lblValorPedido);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.txbFilmeSelecionado);
            this.Controls.Add(this.lblFilmeSelecionado);
            this.Controls.Add(this.txbValorIngresso);
            this.Controls.Add(this.lblValorIngresso);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.txbQuantidadeCoca);
            this.Controls.Add(this.txbQuantidadePipoca);
            this.Controls.Add(this.lblPrecoPipoca);
            this.Controls.Add(this.lblPrecoCoca);
            this.Controls.Add(this.chbCoca);
            this.Controls.Add(this.chbPipoca);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.lblPrecoPedido);
            this.Controls.Add(this.lblQuantidadePedido);
            this.Controls.Add(this.lblPrecoNormal);
            this.Controls.Add(this.lblPrecoEstudante);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.rdbEstudante);
            this.Controls.Add(this.rdbNormal);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.chb3D);
            this.Controls.Add(this.cbxFilme);
            this.Controls.Add(this.lblFilme);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.lblCliente);
            this.Name = "frmCinema";
            this.Text = "Cinema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCinema_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.ComboBox cbxFilme;
        private System.Windows.Forms.CheckBox chb3D;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbEstudante;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblPrecoEstudante;
        private System.Windows.Forms.Label lblPrecoNormal;
        private System.Windows.Forms.Label lblQuantidadePedido;
        private System.Windows.Forms.Label lblPrecoPedido;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.CheckBox chbPipoca;
        private System.Windows.Forms.CheckBox chbCoca;
        private System.Windows.Forms.Label lblPrecoCoca;
        private System.Windows.Forms.Label lblPrecoPipoca;
        private System.Windows.Forms.TextBox txbQuantidadePipoca;
        private System.Windows.Forms.TextBox txbQuantidadeCoca;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label lblValorIngresso;
        private System.Windows.Forms.TextBox txbValorIngresso;
        private System.Windows.Forms.Label lblFilmeSelecionado;
        private System.Windows.Forms.TextBox txbFilmeSelecionado;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblValorPedido;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.TextBox txbValorPedido;
    }
}