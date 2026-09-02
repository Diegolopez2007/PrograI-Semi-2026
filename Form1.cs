using System;
using System.Globalization;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double valor;

            if (!double.TryParse(txtValor.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
            {
                if (!double.TryParse(txtValor.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out valor))
                {
                    MessageBox.Show(
                        "Ingrese un valor numérico válido.",
                        "Dato incorrecto",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtValor.Focus();
                    return;
                }
            }

            if (valor < 0)
            {
                MessageBox.Show(
                    "El área no puede ser negativa.",
                    "Dato incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtValor.Focus();
                return;
            }

            if (cmbOrigen.SelectedIndex == -1 || cmbDestino.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione la unidad de origen y la unidad de destino.",
                    "Faltan datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string origen = cmbOrigen.SelectedItem.ToString();
            string destino = cmbDestino.SelectedItem.ToString();

            double metrosCuadrados = ConvertirAMetrosCuadrados(valor, origen);
            double resultado = ConvertirDesdeMetrosCuadrados(metrosCuadrados, destino);

            txtResultado.Text = resultado.ToString("N6");
        }

        private double ConvertirAMetrosCuadrados(double valor, string unidad)
        {
            switch (unidad)
            {
                case "Pie Cuadrado":
                    return valor * 0.09290304;

                case "Vara Cuadrada":
                    return valor * 0.698896;

                case "Yarda Cuadrada":
                    return valor * 0.83612736;

                case "Metro Cuadrado":
                    return valor;

                case "Tarea":
                    return valor * 437.5;

                case "Manzana":
                    return valor * 6988.96;

                case "Hectárea":
                    return valor * 10000;

                default:
                    return 0;
            }
        }

        private double ConvertirDesdeMetrosCuadrados(double metrosCuadrados, string unidad)
        {
            switch (unidad)
            {
                case "Pie Cuadrado":
                    return metrosCuadrados / 0.09290304;

                case "Vara Cuadrada":
                    return metrosCuadrados / 0.698896;

                case "Yarda Cuadrada":
                    return metrosCuadrados / 0.83612736;

                case "Metro Cuadrado":
                    return metrosCuadrados;

                case "Tarea":
                    return metrosCuadrados / 437.5;

                case "Manzana":
                    return metrosCuadrados / 6988.96;

                case "Hectárea":
                    return metrosCuadrados / 10000;

                default:
                    return 0;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            txtResultado.Clear();
            cmbOrigen.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            txtValor.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}