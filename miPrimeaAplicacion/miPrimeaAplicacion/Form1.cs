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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Matriz de etiquetas (12 ítems por cada categoría)
        String[][] etiquetas = {
            // 0: Monedas (Base: Dólar USD)
            new string[] { "Dólar USD", "Quetzal", "Lempira", "Córdoba", "Colón CR", "Euro", "Yen Japonés", "Peso Mexicano", "Libra Esterlina", "Bitcoin", "Dólar Canadiense", "Franco Suizo" },
            
            // 1: Masa (Base: Kilogramo)
            new string[] { "Kilogramo", "Gramo", "Miligramo", "Libra", "Onza", "Tonelada Métrica", "Arroba", "Quintal", "Stone", "Quilate", "Grano", "Tonelada Corta" },
            
            // 2: Volumen (Base: Litro)
            new string[] { "Litro", "Mililitro", "Metro Cúbico", "Galón US", "Pinta US", "Onza Fluida US", "Taza US", "Cucharada US", "Cucharadita US", "Barril Petróleo", "Cuarto (Quart) US", "Centilitro" },
            
            // 3: Longitud (Base: Metro)
            new string[] { "Metro", "Centímetro", "Milímetro", "Kilómetro", "Pulgada", "Pie", "Yarda", "Vara", "Milla", "Milla Náutica", "Micrómetro", "Nanómetro" },
            
            // 4: Almacenamiento (Base: Byte)
            new string[] { "Byte", "Bit", "Kilobyte (KB)", "Megabyte (MB)", "Gigabyte (GB)", "Terabyte (TB)", "Petabyte (PB)", "Kibibyte (KiB)", "Mebibyte (MiB)", "Gibibyte (GiB)", "Tebibyte (TiB)", "Nibble" },
            
            // 5: Tiempo (Base: Segundo)
            new string[] { "Segundo", "Milisegundo", "Microsegundo", "Nanosegundo", "Minuto", "Hora", "Día", "Semana", "Mes (30 días)", "Año (365 días)", "Década", "Siglo" }
        };

        // Matriz de factores de conversión
        Double[][] valores = {
            // 0: Monedas
            new double[] { 1, 7.63, 26.81, 36.80, 449.23, 0.92, 155.20, 18.10, 0.79, 0.000015, 1.36, 0.89 },
            
            // 1: Masa
            new double[] { 1, 1000, 1000000, 2.20462, 35.274, 0.001, 0.0881849, 0.0220462, 0.157473, 5000, 15432.4, 0.00110231 },
            
            // 2: Volumen
            new double[] { 1, 1000, 0.001, 0.264172, 2.11338, 33.814, 4.22675, 67.628, 202.884, 0.00628981, 1.05669, 100 },
            
            // 3: Longitud
            new double[] { 1, 100, 1000, 0.001, 39.3701, 3.28084, 1.09361, 1.1963, 0.000621371, 0.000539957, 1000000, 1000000000 },
            
            // 4: Almacenamiento
            new double[] { 1, 8, 0.001, 0.000001, 1e-9, 1e-12, 1e-15, 0.0009765625, 0.0000009536743, 0.00000000093132257, 0.0000000000009094947, 2 },
            
            // 5: Tiempo
            new double[] { 1, 1000, 1000000, 1000000000, 0.0166666667, 0.0002777778, 0.00001157407, 0.000001653439, 3.85802469e-7, 3.1709792e-8, 3.1709792e-9, 3.1709792e-10 }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            // Asegúrate de que las opciones del cboOpciones coincidan con el siguiente orden:
            // 0: Monedas, 1: Masa, 2: Volumen, 3: Longitud, 4: Almacenamiento, 5: Tiempo
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1. Validar que se hayan seleccionado las tres opciones en los ComboBox
            if (cboOpciones.SelectedIndex == -1 || cboDe.SelectedIndex == -1 || cboA.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione la categoría y las unidades a convertir.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que la cantidad ingresada sea un número válido utilizando double.TryParse
            double cantidad;
            if (!double.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Por favor, ingrese una cantidad numérica válida.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCantidad.Focus();
                return;
            }

            int de = cboDe.SelectedIndex;
            int a = cboA.SelectedIndex;
            int opcion = cboOpciones.SelectedIndex;

            // 3. Cálculo de conversión
            double respuesta = valores[opcion][a] / valores[opcion][de] * cantidad;

            lblRespuesta.Text = respuesta.ToString();
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiamos los valores anteriores
            cboDe.Items.Clear();
            cboA.Items.Clear();

            // Asignamos las etiquetas correspondientes a la categoría elegida
            int opcion = cboOpciones.SelectedIndex;
            if (opcion >= 0 && opcion < etiquetas.Length)
            {
                cboDe.Items.AddRange(etiquetas[opcion]);
                cboA.Items.AddRange(etiquetas[opcion]);
            }
        }
    }
}