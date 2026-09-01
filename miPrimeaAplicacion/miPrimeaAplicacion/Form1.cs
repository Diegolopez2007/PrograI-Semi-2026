using System;
using System.Data;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1. Obtener la cantidad de meses
            int n = (int)numMeses.Value;

            // 2. Validar y obtener el monto mensual ingresado por el usuario
            if (!decimal.TryParse(txtMontoMes.Text, out decimal cuotaMensual) || cuotaMensual < 0)
            {
                MessageBox.Show("Por favor, ingrese un monto mensual válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Crear la estructura de la tabla
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Mes", typeof(int));
            tabla.Columns.Add("Cuota Mes ($)", typeof(string));
            tabla.Columns.Add("Deuda Acumulada ($)", typeof(string));

            decimal deudaAcumulada = 0;

            // 4. Calcular el incremento de la deuda mes a mes
            for (int i = 1; i <= n; i++)
            {
                deudaAcumulada += cuotaMensual; // La deuda suma la cuota cada mes
                tabla.Rows.Add(i, cuotaMensual.ToString("N2"), deudaAcumulada.ToString("N2"));
            }

            // 5. Asignar datos al DataGridView
            dgvTabla.DataSource = tabla;
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 6. Actualizar la etiqueta con el resultado final
            lblTotal.Text = $"Deuda Total Acumulada: ${deudaAcumulada:N2}";
        }
    }
}