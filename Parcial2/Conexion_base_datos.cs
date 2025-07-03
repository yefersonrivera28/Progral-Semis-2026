using System;
using System.Data;
using System.Data.SqlClient;

namespace Parcial2
{
    public class Conexion_base_datos
    {
        public SqlConnection conexion = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=bd_parcial2;Integrated Security=True;");
        public DataSet ds = new DataSet();

        public void crearDs()
        {
            try
            {
                ds.Clear();
                string query = "SELECT * FROM usuarios_usis018804";
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                da.Fill(ds, "usuarios");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        public void mantenimiento_usuarios_usis018804(string[] datos, string accion)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;

                if (accion == "agregar")
                {
                    cmd.CommandText = "INSERT INTO usuarios_usis018804 (usuario, clave, nombre, direccion, telefono) VALUES (@u, @c, @n, @d, @t)";
                    cmd.Parameters.AddWithValue("@u", datos[0]);
                    cmd.Parameters.AddWithValue("@c", datos[1]);
                    cmd.Parameters.AddWithValue("@n", datos[2]);
                    cmd.Parameters.AddWithValue("@d", datos[3]);
                    cmd.Parameters.AddWithValue("@t", datos[4]);
                }
                else if (accion == "modificar")
                {
                    cmd.CommandText = "UPDATE usuarios_usis018804 SET usuario=@u, clave=@c, nombre=@n, direccion=@d, telefono=@t WHERE idUsuario=@id";
                    cmd.Parameters.AddWithValue("@u", datos[0]);
                    cmd.Parameters.AddWithValue("@c", datos[1]);
                    cmd.Parameters.AddWithValue("@n", datos[2]);
                    cmd.Parameters.AddWithValue("@d", datos[3]);
                    cmd.Parameters.AddWithValue("@t", datos[4]);
                    cmd.Parameters.AddWithValue("@id", datos[5]);
                }
                else if (accion == "eliminar")
                {
                    cmd.CommandText = "DELETE FROM usuarios_usis018804 WHERE idUsuario=@id";
                    cmd.Parameters.AddWithValue("@id", datos[5]);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error en operación: " + ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
    }
}