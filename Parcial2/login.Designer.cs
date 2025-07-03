namespace Parcial2
{
    partial class login
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblUsuario = new Label();
            lblClave = new Label();
            txtUsuarioLogin = new TextBox();
            txtClaveLogin = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(30, 30);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(30, 70);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(70, 15);
            lblClave.TabIndex = 1;
            lblClave.Text = "Contraseña:";
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(110, 27);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.Size = new Size(140, 23);
            txtUsuarioLogin.TabIndex = 2;
            // 
            // txtClaveLogin
            // 
            txtClaveLogin.Location = new Point(110, 67);
            txtClaveLogin.Name = "txtClaveLogin";
            txtClaveLogin.PasswordChar = '*';
            txtClaveLogin.Size = new Size(140, 23);
            txtClaveLogin.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(110, 110);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 30);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.Click += btnIngresar_Click;
            // 
            // login
            // 
            ClientSize = new Size(290, 170);
            Controls.Add(lblUsuario);
            Controls.Add(lblClave);
            Controls.Add(txtUsuarioLogin);
            Controls.Add(txtClaveLogin);
            Controls.Add(btnIngresar);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtClaveLogin;
        private System.Windows.Forms.Button btnIngresar;
    }
}