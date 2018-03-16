using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicios_menu
{
    public partial class frmPizzaria : Form
    {
        public frmPizzaria()
        {
            InitializeComponent();
        }
        

        private void btnPedido_Click(object sender, EventArgs e)
        {
            double mussarela = 20;
            double calabresa = 20;
            double queijos = 25;
            double valorfinal = 0;
            double refrigerante = 5;
            double esfirra = 1.50;
            string mussarelat;
            string calabresat;
            string queijost;
            string esfirrat;
            string refrigerantet;

            if (chkMussarela.Checked)
            {
                valorfinal = mussarela;
                rtbComanda.Text = "Pizza de Mussarela R$20,00" + "\n ";
            }

            if (chkCalabresa.Checked)
            {
                valorfinal = valorfinal + calabresa;
                rtbComanda.Text = rtbComanda.Text + "Pizza de Calabresa R$20,00" + "\n";
            }

            if (chk4queijos.Checked)
            {
                valorfinal = valorfinal + queijos;
                rtbComanda.Text = rtbComanda.Text + "Pizza de 4 Queijos R$25,00" + "\n ";
            }

            if (rbEsfirra.Checked)
            {
                valorfinal = valorfinal + esfirra;
                rtbComanda.Text = rtbComanda.Text + "Esfirra de Chocolare R$1,50" + "\n ";
            }

            if (chkRefri.Checked)
            {
                valorfinal = valorfinal + refrigerante;
                rtbComanda.Text = rtbComanda.Text + "Refrigerante R$5,00" + " " + comboRefrigerantes.Text + "\n ";
               
            }

            txbValor.Text = System.Convert.ToString(valorfinal);
            

        }

        private void frmPizzaria_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Compra de Ingresso Cinema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) MessageBox.Show("Fechando");
            else
            {
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }
 
    }
}
