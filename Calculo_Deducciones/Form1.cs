using System;
using System.Windows.Forms;

namespace Calculo_Deducciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal sueldo;

           
            if (!decimal.TryParse(txtSueldo.Text, out sueldo))
            {
                MessageBox.Show(
                    "Ingrese un sueldo válido.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtSueldo.Focus();
                return;
            }

          
            if (sueldo <= 0)
            {
                MessageBox.Show(
                    "El sueldo debe ser mayor que cero.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtSueldo.Focus();
                return;
            }

            

            decimal baseISSS = sueldo;

           
            if (baseISSS > 1000)
            {
                baseISSS = 1000;
            }

            decimal isss = baseISSS * 0.03m;


           

            decimal afp = sueldo * 0.0725m;


            

            decimal salarioGravable = sueldo - isss - afp;


           

            decimal isr = CalcularISR(salarioGravable);


            

            decimal totalDeducciones = isss + afp + isr;


            
            decimal sueldoLiquido = sueldo - totalDeducciones;



            txtISSS.Text = isss.ToString("C2");
            txtAFP.Text = afp.ToString("C2");
            txtGravable.Text = salarioGravable.ToString("C2");
            txtISR.Text = isr.ToString("C2");
            txtTotal.Text = totalDeducciones.ToString("C2");
            txtLiquido.Text = sueldoLiquido.ToString("C2");
        }



        private decimal CalcularISR(decimal salario)
        {
            decimal isr = 0;

            if (salario <= 472.00m)
            {
                isr = 0;
            }
            else if (salario <= 895.24m)
            {
                isr = 17.67m + ((salario - 472.00m) * 0.10m);
            }
            else if (salario <= 2038.10m)
            {
                isr = 60.00m + ((salario - 895.24m) * 0.20m);
            }
            else
            {
                isr = 288.57m + ((salario - 2038.10m) * 0.30m);
            }

            return isr;
        }


      
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSueldo.Clear();
            txtISSS.Clear();
            txtAFP.Clear();
            txtGravable.Clear();
            txtISR.Clear();
            txtTotal.Clear();
            txtLiquido.Clear();

            txtSueldo.Focus();
        }
    }
}