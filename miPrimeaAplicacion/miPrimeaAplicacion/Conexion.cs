using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace miPrimeaAplicacion
{
    public class Conexion
    {
        public SqlConnection objConexion = new SqlConnection();
        public SqlCommand objComando = new SqlCommand();
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter();
        DataSet objDs = new DataSet();

        public Conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";

            objConexion.ConnectionString = cadenaConexion;

            if (objConexion.State == ConnectionState.Closed)
            {
                objConexion.Open();
            }
        }

        // ==========================================
        // MÉTODOS OBLIGATORIOS (Usuarios - usss126126)
        // ==========================================
        public DataSet crearDs()
        {
            objDs.Clear();
            objComando.Connection = objConexion;
            objDataAdapter.SelectCommand = objComando;
            objComando.CommandText = "SELECT * FROM usuarios_usss126126";
            objDataAdapter.Fill(objDs, "usuarios_usss126126");
            return objDs;
        }

        public string mantenimiento_usuarios_usss126126(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO usuarios_usss126126 (usuario, clave, nombre, direccion, telefono) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '" + datos[5] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE usuarios_usss126126 SET usuario='" + datos[1] + "', clave='" + datos[2] + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" + datos[5] + "' WHERE idUsuario=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM usuarios_usss126126 WHERE idUsuario=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        // ==========================================
        // MÉTODOS ANTERIORES (Intactos para tu proyecto)
        // ==========================================
        public DataSet obtenerDatos()
        {
            objDs.Clear();
            objComando.Connection = objConexion;
            objDataAdapter.SelectCommand = objComando;

            objComando.CommandText = "SELECT * FROM alumnos";
            objDataAdapter.Fill(objDs, "alumnos");

            objComando.CommandText = "SELECT * FROM materias";
            objDataAdapter.Fill(objDs, "materias");

            objComando.CommandText = "SELECT * FROM periodos";
            objDataAdapter.Fill(objDs, "periodos");

            objComando.CommandText = "SELECT n.idNota, a.nombre AS Alumno, p.periodo AS Periodo, n.fecha FROM notas n INNER JOIN alumnos a ON n.idAlumno = a.idAlumno INNER JOIN periodos p ON n.idPeriodo = p.idPeriodo";
            objDataAdapter.Fill(objDs, "notas");

            return objDs;
        }

        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono, email) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "' WHERE idAlumno=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosMaterias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO materias(codigo,nombre,uv) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE materias SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', uv='" + datos[3] + "' WHERE idMateria=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosPeriodos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO periodos(periodo) VALUES ('" + datos[1] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE periodos SET periodo='" + datos[1] + "' WHERE idPeriodo=" + datos[0];
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM periodos WHERE idPeriodo=" + datos[0];
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosNotas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO notas(idAlumno, idPeriodo, fecha) VALUES (" + datos[0] + ", " + datos[1] + ", GETDATE())";
            }
            return ejecutarSQL(sql);
        }

        public String ejecutarSQL(String sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}