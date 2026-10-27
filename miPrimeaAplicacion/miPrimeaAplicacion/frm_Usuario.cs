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
    public partial class frm_usuario : Form
    {
        Conexion conexion = new Conexion();
        DataSet ds = new DataSet();
        int posicion = 0;

        public frm_usuario()
        {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            // CAMBIO: Usamos tu método personalizado con tu identificador usss126126
            ds = conexion.crearDs();
            if (ds.Tables["usuarios_usss126126"] != null && ds.Tables["usuarios_usss126126"].Rows.Count > 0)
            {
                posicion = 0;
                MostrarDatos();
                dataGridView1.DataSource = ds.Tables["usuarios_usss126126"];
            }
            else
            {
                dataGridView1.DataSource = null;
                LimpiarCampos();
            }
        }

        private void MostrarDatos()
        {
            if (ds.Tables["usuarios_usss126126"].Rows.Count > 0 && posicion < ds.Tables["usuarios_usss126126"].Rows.Count)
            {
                DataRow fila = ds.Tables["usuarios_usss126126"].Rows[posicion];
                txtId.Text = fila["idUsuario"].ToString();
                txtUsuario.Text = fila["usuario"].ToString();
                txtClave.Text = fila["clave"].ToString();
                txtConfirmarClave.Text = fila["clave"].ToString();
                txtNombre.Text = fila["nombre"].ToString();
                txtDireccion.Text = fila["direccion"].ToString();
                txtTelefono.Text = fila["telefono"].ToString();
            }
        }

        private bool ValidarCampos()
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();
            string confirmar = txtConfirmarClave.Text.Trim();

            // 1. Validar longitud del usuario (mínimo 6, máximo 16 caracteres)[cite: 1]
            if (usuario.Length < 6 || usuario.Length > 16)
            {
                MessageBox.Show("El usuario debe tener un mínimo de 6 caracteres y un máximo de 16.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            // 2. Validar que la clave pida confirmación y coincidan[cite: 1]
            if (clave != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor verifique.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarClave.Focus();
                return false;
            }

            // 3. Validar que la clave contenga letras y números[cite: 1]
            bool tieneLetras = false;
            bool tieneNumeros = false;
            foreach (char c in clave)
            {
                if (char.IsLetter(c)) tieneLetras = true;
                if (char.IsDigit(c)) tieneNumeros = true;
            }

            if (!tieneLetras || !tieneNumeros)
            {
                MessageBox.Show("La clave debe contener obligatoriamente letras y números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string[] datos = {
                "0",
                txtUsuario.Text.Trim(),
                txtClave.Text.Trim(),
                txtNombre.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtTelefono.Text.Trim()
            };

            // CAMBIO: Llamada al método de mantenimiento con tu identificador personal
            string respuesta = conexion.mantenimiento_usuarios_usss126126(datos, "nuevo");
            if (respuesta == "1")
            {
                MessageBox.Show("Usuario registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDatos();
                LimpiarCampos(); // Limpia automáticamente para agregar uno nuevo
            }
            else
            {
                MessageBox.Show("Error al registrar: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un registro para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            string[] datos = {
                txtId.Text.Trim(),
                txtUsuario.Text.Trim(),
                txtClave.Text.Trim(),
                txtNombre.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtTelefono.Text.Trim()
            };

            string respuesta = conexion.mantenimiento_usuarios_usss126126(datos, "modificar");
            if (respuesta == "1" || respuesta == "0")
            {
                MessageBox.Show("Usuario modificado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDatos();
            }
            else
            {
                MessageBox.Show("Error al modificar: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                string[] datos = { txtId.Text.Trim(), "", "", "", "", "" };
                string respuesta = conexion.mantenimiento_usuarios_usss126126(datos, "eliminar");

                MessageBox.Show("Usuario eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDatos();
                LimpiarCampos(); // Limpia los campos después de eliminar
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Focus();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (ds.Tables["usuarios_usss126126"] != null && ds.Tables["usuarios_usss126126"].Rows.Count > 0)
            {
                posicion = 0;
                MostrarDatos();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                MostrarDatos();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (ds.Tables["usuarios_usss126126"] != null && posicion < ds.Tables["usuarios_usss126126"].Rows.Count - 1)
            {
                posicion++;
                MostrarDatos();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (ds.Tables["usuarios_usss126126"] != null && ds.Tables["usuarios_usss126126"].Rows.Count > 0)
            {
                posicion = ds.Tables["usuarios_usss126126"].Rows.Count - 1;
                MostrarDatos();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ds.Tables["usuarios_usss126126"].Rows.Count)
            {
                posicion = e.RowIndex;
                MostrarDatos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón Cerrar Sesión: Abre el login de nuevo y cierra este formulario
            frm_login loginForm = new frm_login();
            loginForm.Show();
            this.Close();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtConfirmarClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}