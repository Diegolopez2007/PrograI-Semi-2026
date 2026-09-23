using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Estadistica objEsta = new Estadistica();


        private void btnProcesar_Click(object sender, EventArgs e)
        {
            limpiar();

            if (string.IsNullOrWhiteSpace(txtSerie.Text)) return;

            double[] miSerie = txtSerie.Text.Split(',')
                                           .Select(n => double.Parse(n.Trim()))
                                           .ToArray();

            double m = objEsta.media(miSerie);

            ltsValores.Items.Add("La media es: " + m);
            ltsValores.Items.Add("La desviacion tipica: " + objEsta.desviacionTipica(miSerie, m));
            ltsValores.Items.Add("La media armonica: " + objEsta.armonica(miSerie));
            ltsValores.Items.Add("La desviacion estandar es: " + objEsta.varianza(miSerie, m));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            ltsValores.Items.Clear();
        }
    }
}