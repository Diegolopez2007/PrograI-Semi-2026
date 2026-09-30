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

namespace miPrimeAplicacion
{
    public partial class frmMaterias : Form
    {
        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        int posicion = 0;
        string accion = "nuevo";

        public frmMaterias()
        {
            InitializeComponent();
        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void actualizarDs()
        {
            try
            {
                objDs.Clear();
                objDs = objConexion.obtenerDatos();
                if (objDs.Tables.Contains("materias"))
                {
                    objDt = objDs.Tables["materias"];

                    if (objDt.Columns.Count > 0)
                    {
                        objDt.PrimaryKey = new DataColumn[] { objDt.Columns[0] };
                    }

                    grdMaterias.DataSource = objDt.DefaultView;
                    mostrarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mostrarDatos()
        {
            if (objDt != null && objDt.Rows.Count > 0)
            {
                txtCodigo.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombre.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtUV.Text = objDt.Rows[posicion]["uv"].ToString();

                lblRegistros.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
            else
            {
                limpiarCampos();
                lblRegistros.Text = "0 de 0";
            }
        }

        private void limpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtUV.Clear();
            txtCodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {
                accion = "nuevo";
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                btnEliminar.Enabled = false;
                limpiarCampos();
            }
            else
            {
                string[] datos = new string[]
                {
                    accion == "modificar" ? objDt.Rows[posicion]["idMateria"].ToString() : "0",
                    txtCodigo.Text,
                    txtNombre.Text,
                    txtUV.Text
                };

                string resp = objConexion.administrarDatosMaterias(datos, accion);
                if (resp == "1")
                {
                    MessageBox.Show("Materia guardada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarDs();
                    restablecerBotones();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                accion = "modificar";
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                btnEliminar.Enabled = false;
            }
            else
            {
                restablecerBotones();
                mostrarDatos();
            }
        }

        private void restablecerBotones()
        {
            btnNuevo.Text = "Nuevo";
            btnModificar.Text = "Modificar";
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objDt != null && objDt.Rows.Count > 0)
            {
                if (MessageBox.Show("¿Está seguro de eliminar esta materia?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] datos = new string[] { objDt.Rows[posicion]["idMateria"].ToString() };
                    string resp = objConexion.administrarDatosMaterias(datos, "eliminar");
                    if (resp == "1")
                    {
                        MessageBox.Show("Materia eliminada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        posicion = 0;
                        actualizarDs();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar: " + resp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (objDt != null && posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (objDt != null && objDt.Rows.Count > 0)
            {
                posicion = objDt.Rows.Count - 1;
                mostrarDatos();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (objDt != null)
            {
                objDt.DefaultView.RowFilter = "codigo LIKE '%" + txtBuscar.Text + "%' OR nombre LIKE '%" + txtBuscar.Text + "%'";
            }
        }

        private void grdMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                posicion = e.RowIndex;
                mostrarDatos();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}