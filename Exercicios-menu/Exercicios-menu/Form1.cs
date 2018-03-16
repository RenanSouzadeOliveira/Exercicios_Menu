using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicios_menu{
    public partial class frmExercicios : Form{
        public frmExercicios(){
            InitializeComponent();
        }

        private void strItemPoupanca_Click(object sender, EventArgs e){
            frmPoupanca poup = new frmPoupanca(); // Instanciando o objeto do frmTeste1(Formulario teste 1)
            poup.MdiParent = this; // Esse comando define que a instancia do frmTeste1 será formulario filho do formulario principal
            poup.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e){
            this.Close();
        }

        private void strItemCinema_Click(object sender, EventArgs e){
            frmCinema cine = new frmCinema(); // Instanciando o objeto do frmTeste1(Formulario teste 1)
            cine.MdiParent = this; // Esse comando define que a instancia do frmTeste1 será formulario filho do formulario principal
            cine.Show();
        }

        private void strItemPizzaria_Click(object sender, EventArgs e)
        {
            frmPizzaria pizza = new frmPizzaria();
            pizza.MdiParent = this;
            pizza.Show();

        }

        
    }
}
