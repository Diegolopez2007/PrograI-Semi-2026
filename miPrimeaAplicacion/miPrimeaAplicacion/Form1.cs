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

        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        String accion = "nuevo";
        int posicion = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void obtenerDatos()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            dt = ds.Tables["alumnos"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["idAlumno"] };

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                txtCodigoAlumno.Text = dt.Rows[posicion]["codigo"].ToString();
                txtNombreAlumno.Text = dt.Rows[posicion]["nombre"].ToString();
                txtDireccionAlumno.Text = dt.Rows[posicion]["direccion"].ToString();
                txtTelefonoAlumno.Text = dt.Rows[posicion]["telefono"].ToString();
                txtEmailAlumno.Text = dt.Rows[posicion]["email"].ToString();

                lblRegistrosAlumnos.Text = (posicion + 1) + " de " + dt.Rows.Count;
            }
            else
            {
                limpiarCajas();
                lblRegistrosAlumnos.Text = "0 de 0";
            }
        }

        private void activarDesactivarCtrls(Boolean estado)
        {
            grbDatos.Enabled = estado;
            grbNavegacion.Enabled = !estado;
        }

        private void limpiarCajas()
        {
            txtCodigoAlumno.Clear();
            txtNombreAlumno.Clear();
            txtDireccionAlumno.Clear();
            txtTelefonoAlumno.Clear();
            txtEmailAlumno.Clear();
            txtCodigoAlumno.Focus();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarAlumno.Text == "Agregar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarALumno.Text = "Cancelar";

                limpiarCajas();
                activarDesactivarCtrls(true);
            }
            else // Guardar
            {
                activarDesactivarCtrls(false);
                btnAgregarAlumno.Text = "Agregar";
                btnModificarALumno.Text = "Modificar";
                mostrarDatos();
            }
        }

        private void btnModificarALumno_Click(object sender, EventArgs e)
        {
            if (btnModificarALumno.Text == "Modificar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarALumno.Text = "Cancelar";

                activarDesactivarCtrls(true);
            }
            else // Cancelar
            {
                activarDesactivarCtrls(false);
                btnAgregarAlumno.Text = "Agregar";
                btnModificarALumno.Text = "Modificar";
                mostrarDatos();
            }
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            if (dt != null && posicion < dt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                posicion = dt.Rows.Count - 1;
                mostrarDatos();
            }
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            if (dt != null && dt.Rows.Count > 0)
            {
                posicion = 0;
                mostrarDatos();
            }
        }

        private void txtCodigoAlumno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}