using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpComSQLServer
{
    public partial class frmPrincipal : Form
    {
        frmPrincipal frm;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public frmPrincipal(frmPrincipal formularioPri)
        {
            InitializeComponent();
            frm = formularioPri;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCli = new frmCliente(this);
            frmCli.ShowDialog(this);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
