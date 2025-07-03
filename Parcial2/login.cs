using System;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validamos directamente tu código institucional USTR140726
            if (txtUsuarioLogin.Text.Trim() == "USTR140726")
            {
                MessageBox.Show("¡Bienvenido al sistema!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_usuario formUsuario = new frm_usuario();
                this.Hide();
                formUsuario.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario no registrado o incorrecto.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}