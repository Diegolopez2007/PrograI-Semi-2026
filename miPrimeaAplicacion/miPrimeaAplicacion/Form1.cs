using System;
using System.Drawing;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Form1 : Form
    {
        private const double CUOTA_BASE = 2.50;
        private const double TARIFA_INTERMEDIA = 0.45;
        private const double TARIFA_ALTA = 0.75;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtMetros.Text, out double metros) && metros >= 0)
            {
                double total = CalcularMonto(metros);
                ActualizarInterfazResultado(metros, total);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad numérica de metros cúbicos válida.",
                                "Dato Inválido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtMetros.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            lblTotalPagar.Text = "Total: $0.00";
            lblEstadoConsumo.Text = "Estado: Esperando datos...";
            lblEstadoConsumo.ForeColor = Color.FromArgb(100, 100, 100);
            txtMetros.Focus();
        }

        private double CalcularMonto(double m3)
        {
            if (m3 <= 10)
            {
                return CUOTA_BASE;
            }
            else if (m3 <= 25)
            {
                return CUOTA_BASE + ((m3 - 10) * TARIFA_INTERMEDIA);
            }
            else
            {
                return CUOTA_BASE + (15 * TARIFA_INTERMEDIA) + ((m3 - 25) * TARIFA_ALTA);
            }
        }

        private void ActualizarInterfazResultado(double m3, double total)
        {
            lblTotalPagar.Text = $"Total: ${total:F2}";

            if (m3 <= 10)
            {
                lblEstadoConsumo.Text = "Consumo: Eficiente (Tarifa Base)";
                lblEstadoConsumo.ForeColor = Color.DarkGreen;
            }
            else if (m3 <= 25)
            {
                lblEstadoConsumo.Text = "Consumo: Moderado";
                lblEstadoConsumo.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblEstadoConsumo.Text = "Consumo: Alto (Sanción por exceso)";
                lblEstadoConsumo.ForeColor = Color.DarkRed;
            }
        }
    }
}