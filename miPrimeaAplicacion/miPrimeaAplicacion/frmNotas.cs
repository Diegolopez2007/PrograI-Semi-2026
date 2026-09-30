using miPrimeaAplicacion;
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
    public partial class frmNotas : Form
    {
        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();

        public frmNotas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            cargarCombos();
            actualizarGrid();
        }

        private void cargarCombos()
        {
            try
            {
                objDs = objConexion.obtenerDatos();

                // 1. Cargar Alumnos (Clave: idAlumnos con 's')
                if (objDs.Tables.Contains("alumnos") && objDs.Tables["alumnos"].Rows.Count > 0)
                {
                    cmbAlumno.DataSource = null;
                    cmbAlumno.DisplayMember = "nombre";
                    cmbAlumno.ValueMember = "idAlumnos"; // Se corrigió 'idAlumno' por 'idAlumnos'
                    cmbAlumno.DataSource = objDs.Tables["alumnos"];
                }

                // 2. Cargar Materias (Columna: nombre)
                if (objDs.Tables.Contains("materias") && objDs.Tables["materias"].Rows.Count > 0)
                {
                    cmbMateria.DataSource = null;
                    cmbMateria.DisplayMember = "nombre"; // Se corrigió 'materia' por 'nombre'
                    cmbMateria.ValueMember = "idMateria";
                    cmbMateria.DataSource = objDs.Tables["materias"];
                }

                // 3. Cargar Periodos
                if (objDs.Tables.Contains("periodos") && objDs.Tables["periodos"].Rows.Count > 0)
                {
                    cmbPeriodo.DataSource = null;
                    cmbPeriodo.DisplayMember = "periodo";
                    cmbPeriodo.ValueMember = "idPeriodo";
                    cmbPeriodo.DataSource = objDs.Tables["periodos"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar desplegables: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizarGrid()
        {
            try
            {
                objDs = objConexion.obtenerDatos();
                if (objDs.Tables.Contains("notas"))
                {
                    grdNotas.DataSource = objDs.Tables["notas"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla de notas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double calcular()
        {
            double n1 = 0, n2 = 0, n3 = 0;
            double.TryParse(txtNota1.Text, out n1);
            double.TryParse(txtNota2.Text, out n2);
            double.TryParse(txtNota3.Text, out n3);

            double promedio = (n1 + n2 + n3) / 3.0;
            lblResultadoPromedio.Text = promedio.ToString("N2");

            if (promedio >= 6.0)
            {
                lblResultadoEstado.Text = "Aprobado";
                lblResultadoEstado.ForeColor = Color.Green;
            }
            else
            {
                lblResultadoEstado.Text = "Reprobado";
                lblResultadoEstado.ForeColor = Color.Red;
            }

            return promedio;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcular();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbAlumno.SelectedValue == null || cmbMateria.SelectedValue == null || cmbPeriodo.SelectedValue == null)
            {
                MessageBox.Show("Por favor seleccione un Alumno, Materia y Periodo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double promedio = calcular();

            string idAlumno = cmbAlumno.SelectedValue.ToString();
            string idPeriodo = cmbPeriodo.SelectedValue.ToString();
            string idMateria = cmbMateria.SelectedValue.ToString();
            string n1 = txtNota1.Text;
            string n2 = txtNota2.Text;
            string n3 = txtNota3.Text;
            string est = lblResultadoEstado.Text;

            string[] datos = new string[] { idAlumno, idPeriodo, idMateria, n1, n2, n3, promedio.ToString("N2").Replace(",", "."), est };

            string resp = objConexion.administrarDatosNotas(datos, "nuevo");
            if (resp == "1")
            {
                MessageBox.Show("Nota registrada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Error al guardar nota: " + resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}