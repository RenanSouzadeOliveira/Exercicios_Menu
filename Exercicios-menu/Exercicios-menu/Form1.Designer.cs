namespace Exercicios_menu
{
    partial class frmExercicios
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
            this.mnustrOptions = new System.Windows.Forms.MenuStrip();
            this.strItemPoupanca = new System.Windows.Forms.ToolStripMenuItem();
            this.strItemPizzaria = new System.Windows.Forms.ToolStripMenuItem();
            this.strItemCinema = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnustrOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnustrOptions
            // 
            this.mnustrOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strItemPoupanca,
            this.strItemPizzaria,
            this.strItemCinema,
            this.sairToolStripMenuItem});
            this.mnustrOptions.Location = new System.Drawing.Point(0, 0);
            this.mnustrOptions.Name = "mnustrOptions";
            this.mnustrOptions.Size = new System.Drawing.Size(907, 24);
            this.mnustrOptions.TabIndex = 1;
            this.mnustrOptions.Text = "menuStrip1";
            // 
            // strItemPoupanca
            // 
            this.strItemPoupanca.Name = "strItemPoupanca";
            this.strItemPoupanca.Size = new System.Drawing.Size(72, 20);
            this.strItemPoupanca.Text = "Poupança";
            this.strItemPoupanca.Click += new System.EventHandler(this.strItemPoupanca_Click);
            // 
            // strItemPizzaria
            // 
            this.strItemPizzaria.Name = "strItemPizzaria";
            this.strItemPizzaria.Size = new System.Drawing.Size(58, 20);
            this.strItemPizzaria.Text = "Pizzaria";
            this.strItemPizzaria.Click += new System.EventHandler(this.strItemPizzaria_Click);
            // 
            // strItemCinema
            // 
            this.strItemCinema.Name = "strItemCinema";
            this.strItemCinema.Size = new System.Drawing.Size(60, 20);
            this.strItemCinema.Text = "Cinema";
            this.strItemCinema.Click += new System.EventHandler(this.strItemCinema_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmExercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 346);
            this.Controls.Add(this.mnustrOptions);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnustrOptions;
            this.Name = "frmExercicios";
            this.Text = "Exercicios Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnustrOptions.ResumeLayout(false);
            this.mnustrOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnustrOptions;
        private System.Windows.Forms.ToolStripMenuItem strItemPoupanca;
        private System.Windows.Forms.ToolStripMenuItem strItemPizzaria;
        private System.Windows.Forms.ToolStripMenuItem strItemCinema;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

