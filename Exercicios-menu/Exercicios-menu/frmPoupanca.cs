using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicios_menu{
    public partial class frmPoupanca : Form{
        public frmPoupanca(){
            InitializeComponent();
        }

        private void frmPoupanca_FormClosing(object sender, FormClosingEventArgs e){
            if(MessageBox.Show("Deseja Sair?","Calculo de Poupança",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)MessageBox.Show("Fechando");
            else{
                MessageBox.Show("Voltando");
                e.Cancel = true;
            }
        }

        private void btnCalcularPoup_Click(object sender, EventArgs e){
            Double val_mensal = System.Convert.ToDouble(txbValor.Text);
            Double percent_rend = System.Convert.ToDouble(txbRendimento.Text);
            int qtd_meses = System.Convert.ToInt16(txbMeses.Text);

            Double valor_acumulado = (val_mensal * (Math.Pow((1+percent_rend),qtd_meses)-1)) / percent_rend;

            lblSaldo.Text = System.Convert.ToString(valor_acumulado); 
        }
    }
}
