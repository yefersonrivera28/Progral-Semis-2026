namespace Parcial2
{
    partial class frm_usuario
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
            lblConfirmarClave = new Label();
            lblNombre = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            txtConfirmarClave = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnPrimero = new Button();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            btnUltimo = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            lblClave.Location = new Point(30, 65);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(39, 15);
            lblClave.TabIndex = 1;
            lblClave.Text = "Clave:";
            // 
            // lblConfirmarClave
            // 
            lblConfirmarClave.AutoSize = true;
            lblConfirmarClave.Location = new Point(30, 100);
            lblConfirmarClave.Name = "lblConfirmarClave";
            lblConfirmarClave.Size = new Size(96, 15);
            lblConfirmarClave.TabIndex = 2;
            lblConfirmarClave.Text = "Confirmar Clave:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 135);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(30, 170);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 4;
            lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(30, 205);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(140, 27);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(140, 62);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(180, 23);
            txtClave.TabIndex = 7;
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(140, 97);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.PasswordChar = '*';
            txtConfirmarClave.Size = new Size(180, 23);
            txtConfirmarClave.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(140, 167);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(180, 23);
            txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(140, 202);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(180, 23);
            txtTelefono.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(350, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 30);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(350, 67);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 30);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(350, 107);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(30, 250);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(80, 30);
            btnPrimero.TabIndex = 15;
            btnPrimero.Text = "|< Primero";
            btnPrimero.Click += btnPrimero_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(120, 250);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(80, 30);
            btnAnterior.TabIndex = 16;
            btnAnterior.Text = "< Anterior";
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(210, 250);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(80, 30);
            btnSiguiente.TabIndex = 17;
            btnSiguiente.Text = "Siguiente >";
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(300, 250);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(80, 30);
            btnUltimo.TabIndex = 18;
            btnUltimo.Text = "Último >|";
            btnUltimo.Click += btnUltimo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(350, 155);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 19;
            button1.Text = "Salir";
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(448, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(442, 183);
            dataGridView1.TabIndex = 20;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "usuario";
            Column1.HeaderText = "Usuario";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "nombre";
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "direccion";
            Column3.HeaderText = "Direccion";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "telefono";
            Column4.HeaderText = "Telefono";
            Column4.Name = "Column4";
            // 
            // frm_usuario
            // 
            ClientSize = new Size(902, 381);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(lblUsuario);
            Controls.Add(lblClave);
            Controls.Add(lblConfirmarClave);
            Controls.Add(lblNombre);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(txtUsuario);
            Controls.Add(txtClave);
            Controls.Add(txtConfirmarClave);
            Controls.Add(txtNombre);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnPrimero);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(btnUltimo);
            Name = "frm_usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Usuarios";
            Load += frm_usuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblConfirmarClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnUltimo;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}