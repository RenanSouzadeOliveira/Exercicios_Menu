using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicios_menu{
    public partial class frmCinema : Form{
        public frmCinema(){
            InitializeComponent();
        }

        private void frmCinema_FormClosing(object sender, FormClosingEventArgs e){
            if (MessageBox.Show("Deseja Sair?", "Compra de Ingresso Cinema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Fechando");
            else{
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e){
            string filme_escolhido = cbxFilme.Text;
            string nome_cliente = txbCliente.Text;
            if (nome_cliente != "" && filme_escolhido != ""){
                
                double preco_ingresso = 0;
                double valor_pedido_pipoca = 0;
                double valor_pedido = 0;
                double valor_pedido_coca = 0;
                double total = 0;
                int quantidade_pipoca = 0;
                int quantidade_coca = 0;

                if (chbPipoca.Checked){
                    quantidade_pipoca = System.Convert.ToInt16(txbQuantidadePipoca.Text);
                    valor_pedido_pipoca = 4.50 * quantidade_pipoca;
                } if (chbCoca.Checked) {
                    quantidade_coca = System.Convert.ToInt16(txbQuantidadeCoca.Text);
                    valor_pedido_coca = 4.25 * quantidade_coca;
                } if (rdbNormal.Checked) {
                    if (chb3D.Checked) {
                        preco_ingresso = 17.00 + 7.50;
                    } else {
                        preco_ingresso = 17.00;
                    }
                } else {
                    if (rdbEstudante.Checked) {
                        if (chb3D.Checked) {
                            preco_ingresso = 8.50 + 7.50;
                        } else {
                            preco_ingresso = 8.50;
                        }
                    }
                }
                valor_pedido = valor_pedido_pipoca + valor_pedido_coca;
                total = valor_pedido + preco_ingresso;
                txbValorPedido.Text = System.Convert.ToString(valor_pedido);
                txbValorIngresso.Text = System.Convert.ToString(preco_ingresso);
                txbFilmeSelecionado.Text = filme_escolhido;
                txbTotal.Text = System.Convert.ToString(total);
            } else {
                MessageBox.Show("campo de nome e filme não podem ser vazios");
            }
        }
    }
}
