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
    public partial class frmPeriodos : Form
    {
        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        int posicion = 0;
        string accion = "nuevo";

        public frmPeriodos()
        {
            InitializeComponent();
        }

        private void frmPeriodos_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void actualizarDs()
        {
            try
            {
                objDs.Clear();
                objDs = objConexion.obtenerDatos();
                if (objDs.Tables.Contains("periodos"))
                {
                    objDt = objDs.Tables["periodos"];
                    if (objDt.Columns.Count > 0)
                    {
                        objDt.PrimaryKey = new DataColumn[] { objDt.Columns[0] };
                    }
                    grdPeriodos.DataSource = objDt.DefaultView;
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
                txtPeriodo.Text = objDt.Rows[posicion]["periodo"].ToString();
                lblRegistros.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
            else
            {
                txtPeriodo.Clear();
                lblRegistros.Text = "0 de 0";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {
                accion = "nuevo";
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                btnEliminar.Enabled = false;
                txtPeriodo.Clear();
                txtPeriodo.Focus();
            }
            else
            {
                string[] datos = new string[]
                {
                    accion == "modificar" ? objDt.Rows[posicion]["idPeriodo"].ToString() : "0",
                    txtPeriodo.Text
                };

                string resp = objConexion.administrarDatosPeriodos(datos, accion);
                if (resp == "1")
                {
                    MessageBox.Show("Periodo guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (MessageBox.Show("¿Está seguro de eliminar este periodo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string[] datos = new string[] { objDt.Rows[posicion]["idPeriodo"].ToString() };
                    string resp = objConexion.administrarDatosPeriodos(datos, "eliminar");
                    if (resp == "1")
                    {
                        MessageBox.Show("Periodo eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void grdPeriodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                posicion = e.RowIndex;
                mostrarDatos();
            }
        }
    }
}