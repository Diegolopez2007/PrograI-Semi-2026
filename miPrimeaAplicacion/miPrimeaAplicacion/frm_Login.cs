using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class frm_login : Form
    {
        // Cadena de conexión para la base de datos local .mdf
        string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True;Connect Timeout=30";

        public frm_login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    // Nota: Si tu tabla en el explorador se llama usuarios_usss126 (sin el último 26), 
                    // asegúrate de ponerle el nombre exacto aquí.
                    string query = "SELECT COUNT(1) FROM usuarios_usss126126 WHERE usuario = @usuario AND clave = @clave";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@clave", clave);

                        conexion.Open();
                        int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                        if (resultado == 1)
                        {
                            MessageBox.Show("¡Bienvenido al sistema!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Instancia y abre el formulario frm_usuario correctamente
                            frm_usuario frm = new frm_usuario();
                            frm.Show();
                            this.Hide(); // Oculta el login
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos. Acceso denegado.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsuario.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}