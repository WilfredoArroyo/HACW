namespace HeladosLDSisInf
{
    partial class Frm_Sistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cuentaLabel;
            System.Windows.Forms.Label nombreCompletoLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label tipoUsuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sistema));
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_IrProductos = new System.Windows.Forms.Button();
            this.Btn_InvProducto = new System.Windows.Forms.Button();
            this.Btn_Pedidos = new System.Windows.Forms.Button();
            this.Btn_HIstorialVentas = new System.Windows.Forms.Button();
            this.Btn_InvHelado = new System.Windows.Forms.Button();
            this.lbl_Prueba = new System.Windows.Forms.Label();
            this.Btn_GUsuario = new System.Windows.Forms.Button();
            this.DGB_Usuario = new System.Windows.Forms.DataGridView();
            this.GroupBox_usuario = new System.Windows.Forms.GroupBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.cuentaTextBox = new System.Windows.Forms.TextBox();
            this.nombreCompletoTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.tipoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Panel_HV = new System.Windows.Forms.Panel();
            this.historialVentaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataTime_InicioHV = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeFinalHV = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_BuscarHV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historialVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cuentaLabel = new System.Windows.Forms.Label();
            nombreCompletoLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            tipoUsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGB_Usuario)).BeginInit();
            this.GroupBox_usuario.SuspendLayout();
            this.Panel_HV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialVentaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cuentaLabel
            // 
            cuentaLabel.AutoSize = true;
            cuentaLabel.Font = new System.Drawing.Font("Monoid", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cuentaLabel.ForeColor = System.Drawing.Color.White;
            cuentaLabel.Location = new System.Drawing.Point(6, 81);
            cuentaLabel.Name = "cuentaLabel";
            cuentaLabel.Size = new System.Drawing.Size(87, 22);
            cuentaLabel.TabIndex = 0;
            cuentaLabel.Text = "Cuenta:";
            // 
            // nombreCompletoLabel
            // 
            nombreCompletoLabel.AutoSize = true;
            nombreCompletoLabel.Font = new System.Drawing.Font("Monoid", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreCompletoLabel.ForeColor = System.Drawing.Color.White;
            nombreCompletoLabel.Location = new System.Drawing.Point(6, 144);
            nombreCompletoLabel.Name = "nombreCompletoLabel";
            nombreCompletoLabel.Size = new System.Drawing.Size(186, 22);
            nombreCompletoLabel.TabIndex = 2;
            nombreCompletoLabel.Text = "Nombre Completo:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Monoid", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.Color.White;
            passwordLabel.Location = new System.Drawing.Point(6, 232);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(109, 22);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            // 
            // tipoUsuarioLabel
            // 
            tipoUsuarioLabel.AutoSize = true;
            tipoUsuarioLabel.Font = new System.Drawing.Font("Monoid", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoUsuarioLabel.ForeColor = System.Drawing.Color.White;
            tipoUsuarioLabel.Location = new System.Drawing.Point(6, 298);
            tipoUsuarioLabel.Name = "tipoUsuarioLabel";
            tipoUsuarioLabel.Size = new System.Drawing.Size(153, 22);
            tipoUsuarioLabel.TabIndex = 6;
            tipoUsuarioLabel.Text = "Tipo Usuario:";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.ForeColor = System.Drawing.Color.White;
            this.Btn_Salir.Location = new System.Drawing.Point(1131, 643);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(147, 59);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.Text = "SALIR";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_IrProductos
            // 
            this.Btn_IrProductos.BackColor = System.Drawing.Color.Maroon;
            this.Btn_IrProductos.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_IrProductos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Btn_IrProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_IrProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_IrProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_IrProductos.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IrProductos.ForeColor = System.Drawing.Color.White;
            this.Btn_IrProductos.Location = new System.Drawing.Point(12, 120);
            this.Btn_IrProductos.Name = "Btn_IrProductos";
            this.Btn_IrProductos.Size = new System.Drawing.Size(169, 85);
            this.Btn_IrProductos.TabIndex = 1;
            this.Btn_IrProductos.Text = "IR A PRODUCTOS";
            this.Btn_IrProductos.UseVisualStyleBackColor = false;
            this.Btn_IrProductos.Click += new System.EventHandler(this.Btn_Productos_Click);
            // 
            // Btn_InvProducto
            // 
            this.Btn_InvProducto.BackColor = System.Drawing.Color.Maroon;
            this.Btn_InvProducto.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_InvProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Btn_InvProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_InvProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_InvProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_InvProducto.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_InvProducto.ForeColor = System.Drawing.Color.White;
            this.Btn_InvProducto.Location = new System.Drawing.Point(12, 202);
            this.Btn_InvProducto.Name = "Btn_InvProducto";
            this.Btn_InvProducto.Size = new System.Drawing.Size(169, 85);
            this.Btn_InvProducto.TabIndex = 2;
            this.Btn_InvProducto.Text = "VER INVENTIARIO DE PRODUCTOS";
            this.Btn_InvProducto.UseVisualStyleBackColor = false;
            this.Btn_InvProducto.Click += new System.EventHandler(this.Btn_InvProducto_Click);
            // 
            // Btn_Pedidos
            // 
            this.Btn_Pedidos.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Pedidos.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_Pedidos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Btn_Pedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Pedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pedidos.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Pedidos.ForeColor = System.Drawing.Color.White;
            this.Btn_Pedidos.Location = new System.Drawing.Point(12, 365);
            this.Btn_Pedidos.Name = "Btn_Pedidos";
            this.Btn_Pedidos.Size = new System.Drawing.Size(169, 85);
            this.Btn_Pedidos.TabIndex = 3;
            this.Btn_Pedidos.Text = "VER PEDIDOS";
            this.Btn_Pedidos.UseVisualStyleBackColor = false;
            this.Btn_Pedidos.Click += new System.EventHandler(this.Btn_Pedidos_Click);
            // 
            // Btn_HIstorialVentas
            // 
            this.Btn_HIstorialVentas.BackColor = System.Drawing.Color.Maroon;
            this.Btn_HIstorialVentas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_HIstorialVentas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Btn_HIstorialVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_HIstorialVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_HIstorialVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_HIstorialVentas.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HIstorialVentas.ForeColor = System.Drawing.Color.White;
            this.Btn_HIstorialVentas.Location = new System.Drawing.Point(12, 447);
            this.Btn_HIstorialVentas.Name = "Btn_HIstorialVentas";
            this.Btn_HIstorialVentas.Size = new System.Drawing.Size(169, 85);
            this.Btn_HIstorialVentas.TabIndex = 4;
            this.Btn_HIstorialVentas.Text = "VER HISTORIAL DE VENTAS";
            this.Btn_HIstorialVentas.UseVisualStyleBackColor = false;
            this.Btn_HIstorialVentas.Click += new System.EventHandler(this.Btn_HIstorialVentas_Click);
            // 
            // Btn_InvHelado
            // 
            this.Btn_InvHelado.BackColor = System.Drawing.Color.Maroon;
            this.Btn_InvHelado.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_InvHelado.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Btn_InvHelado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_InvHelado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_InvHelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_InvHelado.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_InvHelado.ForeColor = System.Drawing.Color.White;
            this.Btn_InvHelado.Location = new System.Drawing.Point(12, 284);
            this.Btn_InvHelado.Name = "Btn_InvHelado";
            this.Btn_InvHelado.Size = new System.Drawing.Size(169, 85);
            this.Btn_InvHelado.TabIndex = 5;
            this.Btn_InvHelado.Text = "VER INVENTARIO DE HELADOS";
            this.Btn_InvHelado.UseVisualStyleBackColor = false;
            this.Btn_InvHelado.Click += new System.EventHandler(this.Btn_InvHelado_Click);
            // 
            // lbl_Prueba
            // 
            this.lbl_Prueba.AutoSize = true;
            this.lbl_Prueba.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Prueba.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prueba.Location = new System.Drawing.Point(112, 26);
            this.lbl_Prueba.Name = "lbl_Prueba";
            this.lbl_Prueba.Size = new System.Drawing.Size(0, 26);
            this.lbl_Prueba.TabIndex = 7;
            // 
            // Btn_GUsuario
            // 
            this.Btn_GUsuario.BackColor = System.Drawing.Color.Maroon;
            this.Btn_GUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Btn_GUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.Btn_GUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_GUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_GUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GUsuario.Font = new System.Drawing.Font("Stencil", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GUsuario.ForeColor = System.Drawing.Color.White;
            this.Btn_GUsuario.Location = new System.Drawing.Point(12, 527);
            this.Btn_GUsuario.Name = "Btn_GUsuario";
            this.Btn_GUsuario.Size = new System.Drawing.Size(169, 85);
            this.Btn_GUsuario.TabIndex = 8;
            this.Btn_GUsuario.Text = "GESTIONAR USUARIOS";
            this.Btn_GUsuario.UseVisualStyleBackColor = false;
            this.Btn_GUsuario.Click += new System.EventHandler(this.Btn_GUsuario_Click);
            // 
            // DGB_Usuario
            // 
            this.DGB_Usuario.AllowUserToOrderColumns = true;
            this.DGB_Usuario.AutoGenerateColumns = false;
            this.DGB_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGB_Usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DGB_Usuario.DataSource = this.usuarioBindingSource;
            this.DGB_Usuario.Location = new System.Drawing.Point(231, 111);
            this.DGB_Usuario.Name = "DGB_Usuario";
            this.DGB_Usuario.RowHeadersWidth = 51;
            this.DGB_Usuario.RowTemplate.Height = 24;
            this.DGB_Usuario.Size = new System.Drawing.Size(671, 524);
            this.DGB_Usuario.TabIndex = 9;
            // 
            // GroupBox_usuario
            // 
            this.GroupBox_usuario.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox_usuario.Controls.Add(this.Btn_Cancelar);
            this.GroupBox_usuario.Controls.Add(this.Btn_Guardar);
            this.GroupBox_usuario.Controls.Add(cuentaLabel);
            this.GroupBox_usuario.Controls.Add(this.cuentaTextBox);
            this.GroupBox_usuario.Controls.Add(nombreCompletoLabel);
            this.GroupBox_usuario.Controls.Add(this.nombreCompletoTextBox);
            this.GroupBox_usuario.Controls.Add(passwordLabel);
            this.GroupBox_usuario.Controls.Add(this.passwordTextBox);
            this.GroupBox_usuario.Controls.Add(tipoUsuarioLabel);
            this.GroupBox_usuario.Controls.Add(this.tipoUsuarioTextBox);
            this.GroupBox_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_usuario.ForeColor = System.Drawing.Color.White;
            this.GroupBox_usuario.Location = new System.Drawing.Point(941, 135);
            this.GroupBox_usuario.Name = "GroupBox_usuario";
            this.GroupBox_usuario.Size = new System.Drawing.Size(444, 480);
            this.GroupBox_usuario.TabIndex = 10;
            this.GroupBox_usuario.TabStop = false;
            this.GroupBox_usuario.Text = "Usuario";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.Location = new System.Drawing.Point(209, 392);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(168, 52);
            this.Btn_Cancelar.TabIndex = 9;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Location = new System.Drawing.Point(19, 392);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(173, 52);
            this.Btn_Guardar.TabIndex = 8;
            this.Btn_Guardar.Text = "GUARDAR";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // cuentaTextBox
            // 
            this.cuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cuenta", true));
            this.cuentaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuentaTextBox.Location = new System.Drawing.Point(209, 81);
            this.cuentaTextBox.Name = "cuentaTextBox";
            this.cuentaTextBox.Size = new System.Drawing.Size(217, 27);
            this.cuentaTextBox.TabIndex = 1;
            // 
            // nombreCompletoTextBox
            // 
            this.nombreCompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "NombreCompleto", true));
            this.nombreCompletoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCompletoTextBox.Location = new System.Drawing.Point(209, 144);
            this.nombreCompletoTextBox.Name = "nombreCompletoTextBox";
            this.nombreCompletoTextBox.Size = new System.Drawing.Size(217, 27);
            this.nombreCompletoTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(209, 235);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(217, 27);
            this.passwordTextBox.TabIndex = 5;
            // 
            // tipoUsuarioTextBox
            // 
            this.tipoUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "TipoUsuario", true));
            this.tipoUsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoUsuarioTextBox.Location = new System.Drawing.Point(209, 298);
            this.tipoUsuarioTextBox.Name = "tipoUsuarioTextBox";
            this.tipoUsuarioTextBox.Size = new System.Drawing.Size(217, 27);
            this.tipoUsuarioTextBox.TabIndex = 7;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(1162, 66);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(197, 52);
            this.Btn_Buscar.TabIndex = 10;
            this.Btn_Buscar.Text = "BUSCAR";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.Location = new System.Drawing.Point(1162, 31);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(197, 30);
            this.txt_Buscar.TabIndex = 11;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.Btn_Nuevo.Location = new System.Drawing.Point(1001, 47);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(134, 52);
            this.Btn_Nuevo.TabIndex = 12;
            this.Btn_Nuevo.Text = "NUEVO";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.ForeColor = System.Drawing.Color.White;
            this.Btn_Editar.Location = new System.Drawing.Point(812, 47);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(123, 52);
            this.Btn_Editar.TabIndex = 13;
            this.Btn_Editar.Text = "EDITAR";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(697, 47);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(109, 52);
            this.Btn_Eliminar.TabIndex = 14;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Panel_HV
            // 
            this.Panel_HV.BackColor = System.Drawing.Color.Transparent;
            this.Panel_HV.Controls.Add(this.label4);
            this.Panel_HV.Controls.Add(this.textBox1);
            this.Panel_HV.Controls.Add(this.button2);
            this.Panel_HV.Controls.Add(this.button1);
            this.Panel_HV.Controls.Add(this.label3);
            this.Panel_HV.Controls.Add(this.Btn_BuscarHV);
            this.Panel_HV.Controls.Add(this.label2);
            this.Panel_HV.Controls.Add(this.dateTimeFinalHV);
            this.Panel_HV.Controls.Add(this.label1);
            this.Panel_HV.Controls.Add(this.dataTime_InicioHV);
            this.Panel_HV.Controls.Add(this.historialVentaDataGridView);
            this.Panel_HV.Location = new System.Drawing.Point(214, 26);
            this.Panel_HV.Name = "Panel_HV";
            this.Panel_HV.Size = new System.Drawing.Size(1171, 611);
            this.Panel_HV.TabIndex = 15;
            // 
            // historialVentaDataGridView
            // 
            this.historialVentaDataGridView.AutoGenerateColumns = false;
            this.historialVentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialVentaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.historialVentaDataGridView.DataSource = this.historialVentaBindingSource;
            this.historialVentaDataGridView.Location = new System.Drawing.Point(27, 108);
            this.historialVentaDataGridView.Name = "historialVentaDataGridView";
            this.historialVentaDataGridView.RowHeadersWidth = 51;
            this.historialVentaDataGridView.RowTemplate.Height = 24;
            this.historialVentaDataGridView.Size = new System.Drawing.Size(700, 478);
            this.historialVentaDataGridView.TabIndex = 0;
            // 
            // dataTime_InicioHV
            // 
            this.dataTime_InicioHV.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTime_InicioHV.Location = new System.Drawing.Point(816, 111);
            this.dataTime_InicioHV.Name = "dataTime_InicioHV";
            this.dataTime_InicioHV.Size = new System.Drawing.Size(293, 22);
            this.dataTime_InicioHV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(813, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicio";
            // 
            // dateTimeFinalHV
            // 
            this.dateTimeFinalHV.Location = new System.Drawing.Point(819, 208);
            this.dateTimeFinalHV.Name = "dateTimeFinalHV";
            this.dateTimeFinalHV.Size = new System.Drawing.Size(290, 22);
            this.dateTimeFinalHV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(812, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final";
            // 
            // Btn_BuscarHV
            // 
            this.Btn_BuscarHV.BackColor = System.Drawing.Color.Maroon;
            this.Btn_BuscarHV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BuscarHV.ForeColor = System.Drawing.Color.White;
            this.Btn_BuscarHV.Location = new System.Drawing.Point(896, 261);
            this.Btn_BuscarHV.Name = "Btn_BuscarHV";
            this.Btn_BuscarHV.Size = new System.Drawing.Size(123, 48);
            this.Btn_BuscarHV.TabIndex = 5;
            this.Btn_BuscarHV.Text = "BUSCAR";
            this.Btn_BuscarHV.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(734, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "VER HISTORIAL DE FECHAS DETERMINADAS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(819, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 67);
            this.button1.TabIndex = 7;
            this.button1.Text = "GANANCIA TOTAL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1011, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 67);
            this.button2.TabIndex = 8;
            this.button2.Text = "GANANCIA DE FECHAS DETERMINADAS";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(925, 484);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 35);
            this.textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1061, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bs.";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "V_Id";
            this.dataGridViewTextBoxColumn5.HeaderText = "V_Id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ganancia";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ganancia";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "V_Desc";
            this.dataGridViewTextBoxColumn7.HeaderText = "V_Desc";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FechaHora";
            this.dataGridViewTextBoxColumn8.HeaderText = "FechaHora";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // historialVentaBindingSource
            // 
            this.historialVentaBindingSource.DataSource = typeof(HeladosLDSisInf.Models.HistorialVenta);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(HeladosLDSisInf.Models.Usuario);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cuenta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cuenta";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreCompleto";
            this.dataGridViewTextBoxColumn3.HeaderText = "NombreCompleto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TipoUsuario";
            this.dataGridViewTextBoxColumn4.HeaderText = "TipoUsuario";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Frm_Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeladosLDSisInf.Properties.Resources.FRm_producto_pantalla;
            this.ClientSize = new System.Drawing.Size(1397, 714);
            this.Controls.Add(this.Panel_HV);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.GroupBox_usuario);
            this.Controls.Add(this.DGB_Usuario);
            this.Controls.Add(this.Btn_GUsuario);
            this.Controls.Add(this.lbl_Prueba);
            this.Controls.Add(this.Btn_InvHelado);
            this.Controls.Add(this.Btn_HIstorialVentas);
            this.Controls.Add(this.Btn_Pedidos);
            this.Controls.Add(this.Btn_InvProducto);
            this.Controls.Add(this.Btn_IrProductos);
            this.Controls.Add(this.Btn_Salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Sistema";
            this.Load += new System.EventHandler(this.Frm_Sistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGB_Usuario)).EndInit();
            this.GroupBox_usuario.ResumeLayout(false);
            this.GroupBox_usuario.PerformLayout();
            this.Panel_HV.ResumeLayout(false);
            this.Panel_HV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historialVentaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_IrProductos;
        private System.Windows.Forms.Button Btn_InvProducto;
        private System.Windows.Forms.Button Btn_Pedidos;
        private System.Windows.Forms.Button Btn_HIstorialVentas;
        private System.Windows.Forms.Button Btn_InvHelado;
        private System.Windows.Forms.Label lbl_Prueba;
        private System.Windows.Forms.Button Btn_GUsuario;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.DataGridView DGB_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox GroupBox_usuario;
        private System.Windows.Forms.TextBox cuentaTextBox;
        private System.Windows.Forms.TextBox nombreCompletoTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox tipoUsuarioTextBox;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Panel Panel_HV;
        private System.Windows.Forms.DataGridView historialVentaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource historialVentaBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimeFinalHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataTime_InicioHV;
        private System.Windows.Forms.Button Btn_BuscarHV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}