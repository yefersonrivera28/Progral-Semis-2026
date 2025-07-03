using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class frm_usuario : Form
    {
        Conexion_base_datos db = new Conexion_base_datos();
        int posicion = 0;

        public frm_usuario()
        {
            InitializeComponent();
            ActualizarDatosYGrid();

            if (db.ds.Tables["usuarios"] != null && db.ds.Tables["usuarios"].Rows.Count > 0)
            {
                posicion = 0;
                MostrarDatos();
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void ActualizarDatosYGrid()
        {
            db.crearDs();
            if (db.ds.Tables["usuarios"] != null)
            {
                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = false; // Mantiene tus columnas manuales personalizadas
                dataGridView1.DataSource = db.ds.Tables["usuarios"];
            }
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtClave.Clear();
            txtConfirmarClave.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void MostrarDatos()
        {
            if (db.ds.Tables["usuarios"] != null && db.ds.Tables["usuarios"].Rows.Count > 0)
            {
                if (posicion >= db.ds.Tables["usuarios"].Rows.Count)
                {
                    posicion = db.ds.Tables["usuarios"].Rows.Count - 1;
                }
                if (posicion < 0)
                {
                    posicion = 0;
                }

                DataRow dr = db.ds.Tables["usuarios"].Rows[posicion];

                txtUsuario.Text = dr["usuario"].ToString();
                txtClave.Text = dr["clave"].ToString();
                txtConfirmarClave.Text = dr["clave"].ToString();
                txtNombre.Text = dr["nombre"].ToString();
                txtDireccion.Text = dr["direccion"].ToString();
                txtTelefono.Text = dr["telefono"].ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text;
            string confirmarClave = txtConfirmarClave.Text;

            if (usuario.Length < 6 || usuario.Length > 16)
            {
                MessageBox.Show("El usuario debe tener entre 6 y 16 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clave != confirmarClave)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!clave.Any(char.IsLetter) || !clave.Any(char.IsDigit))
            {
                MessageBox.Show("La clave debe incluir al menos una letra y un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] datos = {
                usuario,
                clave,
                txtNombre.Text,
                txtDireccion.Text,
                txtTelefono.Text,
                ""
            };

            db.mantenimiento_usuarios_usis018804(datos, "agregar");
            ActualizarDatosYGrid();

            if (db.ds.Tables["usuarios"] != null && db.ds.Tables["usuarios"].Rows.Count > 0)
            {
                posicion = db.ds.Tables["usuarios"].Rows.Count - 1;
                MostrarDatos();
            }

            MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (db.ds.Tables["usuarios"] != null && db.ds.Tables["usuarios"].Rows.Count > 0)
            {
                string idUsuario = db.ds.Tables["usuarios"].Rows[posicion]["idUsuario"].ToString();

                string[] datos = {
                    txtUsuario.Text,
                    txtClave.Text,
                    txtNombre.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    idUsuario
                };

                db.mantenimiento_usuarios_usis018804(datos, "modificar");
                ActualizarDatosYGrid();
                MostrarDatos();
                MessageBox.Show("Registro modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (db.ds.Tables["usuarios"] != null && db.ds.Tables["usuarios"].Rows.Count > 0)
            {
                string idUsuario = db.ds.Tables["usuarios"].Rows[posicion]["idUsuario"].ToString();

                string[] datos = { "", "", "", "", "", idUsuario };

                db.mantenimiento_usuarios_usis018804(datos, "eliminar");
                ActualizarDatosYGrid();

                if (posicion > 0) posicion--;

                if (db.ds.Tables["usuarios"].Rows.Count > 0)
                {
                    MostrarDatos();
                }
                else
                {
                    LimpiarCampos();
                }

                MessageBox.Show("Registro eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            MostrarDatos();
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
            if (db.ds.Tables["usuarios"] != null && posicion < db.ds.Tables["usuarios"].Rows.Count - 1)
            {
                posicion++;
                MostrarDatos();
            }
        }
        //Boton de ir al ultimo registro
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (db.ds.Tables["usuarios"] != null && db.ds.Tables["usuarios"].Rows.Count > 0)
            {
                posicion = db.ds.Tables["usuarios"].Rows.Count - 1;
                MostrarDatos();
            }
        }
        //Boton de salir del formulario de usuarios
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {

        }
    }
}