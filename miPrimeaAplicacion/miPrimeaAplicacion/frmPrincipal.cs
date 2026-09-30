using miPrimeAplicacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 objAlumnos = new Form1();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias objFormMaterias = new frmMaterias();
            objFormMaterias.MdiParent = this;
            objFormMaterias.Show();

        }

        private void periodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodos objFormPeriodos = new frmPeriodos();
            objFormPeriodos.MdiParent = this;
            objFormPeriodos.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotas objFormNotas = new frmNotas();
            objFormNotas.MdiParent = this;
            objFormNotas.Show();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}