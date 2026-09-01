using System;
using System.Windows.Forms;

namespace DeduccionesSueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSueldoBase.Text, out double sueldoBase) && sueldoBase > 0)
            {

                double isss = sueldoBase * 0.03;
                if (isss > 30.00)
                {
                    isss = 30.00;
                }


                double afp = sueldoBase * 0.0725;


                double sueldoImponible = sueldoBase - isss - afp;


                double isr = 0.0;

                if (sueldoImponible <= 472.00)
                {
                    isr = 0.0;
                }
                else if (sueldoImponible <= 895.24)
                {
                    isr = ((sueldoImponible - 472.00) * 0.10) + 17.67;
                }
                else if (sueldoImponible <= 2038.10)
                {
                    isr = ((sueldoImponible - 895.24) * 0.20) + 60.00;
                }
                else
                {
                    isr = ((sueldoImponible - 2038.10) * 0.30) + 288.57;
                }


                double totalDeducciones = isss + afp + isr;
                double sueldoNeto = sueldoBase - totalDeducciones;


                txtISSS.Text = isss.ToString("C2");
                txtAFP.Text = afp.ToString("C2");
                txtISR.Text = isr.ToString("C2");
                txtSueldoNeto.Text = sueldoNeto.ToString("C2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto de sueldo válido mayor a cero.",
                                "Error de entrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtSueldoBase.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSueldoBase.Clear();
            txtISSS.Clear();
            txtAFP.Clear();
            txtISR.Clear();
            txtSueldoNeto.Clear();
            txtSueldoBase.Focus();
        }
    }
}