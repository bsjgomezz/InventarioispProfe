namespace Desktop.Views
{
    partial class ClientesApiView
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageLista = new TabPage();
            btnRestaurar = new FontAwesome.Sharp.IconButton();
            verEliminadosCheck = new CheckBox();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            label2 = new Label();
            dataGridClientes = new DataGridView();
            tabPageAgregarEditar = new TabPage();
            label7 = new Label();
            comboLocalidades = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtDireccion = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            tabControl1.SuspendLayout();
            tabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).BeginInit();
            tabPageAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(379, 59);
            label1.TabIndex = 0;
            label1.Text = "Clientes API View";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageLista);
            tabControl1.Controls.Add(tabPageAgregarEditar);
            tabControl1.Location = new Point(13, 87);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1291, 673);
            tabControl1.TabIndex = 1;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(btnRestaurar);
            tabPageLista.Controls.Add(verEliminadosCheck);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnModificar);
            tabPageLista.Controls.Add(btnNuevo);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(txtBusqueda);
            tabPageLista.Controls.Add(label2);
            tabPageLista.Controls.Add(dataGridClientes);
            tabPageLista.Location = new Point(8, 46);
            tabPageLista.Margin = new Padding(4);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(4);
            tabPageLista.Size = new Size(1275, 619);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Enabled = false;
            btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRestaurar.IconColor = Color.Black;
            btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRestaurar.Location = new Point(1032, 441);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(173, 46);
            btnRestaurar.TabIndex = 8;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // verEliminadosCheck
            // 
            verEliminadosCheck.AutoSize = true;
            verEliminadosCheck.Location = new Point(1025, 366);
            verEliminadosCheck.Name = "verEliminadosCheck";
            verEliminadosCheck.Size = new Size(203, 36);
            verEliminadosCheck.TabIndex = 7;
            verEliminadosCheck.Text = "Ver eliminados";
            verEliminadosCheck.UseVisualStyleBackColor = true;
            verEliminadosCheck.CheckedChanged += verEliminadosCheck_CheckedChanged;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(1032, 292);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(177, 47);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.Location = new Point(1028, 210);
            btnModificar.Margin = new Padding(4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 47);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.Location = new Point(1028, 134);
            btnNuevo.Margin = new Padding(4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(177, 47);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.Location = new Point(1028, 31);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(177, 47);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(142, 38);
            txtBusqueda.Margin = new Padding(4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(867, 39);
            txtBusqueda.TabIndex = 2;
            txtBusqueda.KeyPress += txtBusqueda_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 1;
            label2.Text = "Buscar:";
            // 
            // dataGridClientes
            // 
            dataGridClientes.AllowUserToAddRows = false;
            dataGridClientes.AllowUserToDeleteRows = false;
            dataGridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridClientes.Location = new Point(9, 101);
            dataGridClientes.Margin = new Padding(4);
            dataGridClientes.Name = "dataGridClientes";
            dataGridClientes.ReadOnly = true;
            dataGridClientes.RowHeadersWidth = 62;
            dataGridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClientes.Size = new Size(1001, 411);
            dataGridClientes.TabIndex = 0;
            // 
            // tabPageAgregarEditar
            // 
            tabPageAgregarEditar.Controls.Add(label7);
            tabPageAgregarEditar.Controls.Add(comboLocalidades);
            tabPageAgregarEditar.Controls.Add(label6);
            tabPageAgregarEditar.Controls.Add(label5);
            tabPageAgregarEditar.Controls.Add(label4);
            tabPageAgregarEditar.Controls.Add(label3);
            tabPageAgregarEditar.Controls.Add(txtDireccion);
            tabPageAgregarEditar.Controls.Add(txtDni);
            tabPageAgregarEditar.Controls.Add(txtApellido);
            tabPageAgregarEditar.Controls.Add(txtNombre);
            tabPageAgregarEditar.Controls.Add(btnCancelar);
            tabPageAgregarEditar.Controls.Add(btnGuardar);
            tabPageAgregarEditar.Location = new Point(8, 46);
            tabPageAgregarEditar.Margin = new Padding(4);
            tabPageAgregarEditar.Name = "tabPageAgregarEditar";
            tabPageAgregarEditar.Padding = new Padding(4);
            tabPageAgregarEditar.Size = new Size(1275, 619);
            tabPageAgregarEditar.TabIndex = 1;
            tabPageAgregarEditar.Text = "Agregar/Editar";
            tabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 508);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(114, 32);
            label7.TabIndex = 15;
            label7.Text = "Localidad";
            // 
            // comboLocalidades
            // 
            comboLocalidades.FormattingEnabled = true;
            comboLocalidades.Location = new Point(270, 500);
            comboLocalidades.Name = "comboLocalidades";
            comboLocalidades.Size = new Size(618, 40);
            comboLocalidades.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 402);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 32);
            label6.TabIndex = 13;
            label6.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(134, 295);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 32);
            label5.TabIndex = 12;
            label5.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 195);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 11;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 102);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 10;
            label3.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(270, 395);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(618, 39);
            txtDireccion.TabIndex = 9;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(270, 288);
            txtDni.Margin = new Padding(4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(618, 39);
            txtDni.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(270, 188);
            txtApellido.Margin = new Padding(4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(618, 39);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(270, 95);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(618, 39);
            txtNombre.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(992, 241);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(177, 47);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.Location = new Point(992, 151);
            btnGuardar.Margin = new Padding(4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(177, 47);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // ClientesApiView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 776);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "ClientesApiView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            tabControl1.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridClientes).EndInit();
            tabPageAgregarEditar.ResumeLayout(false);
            tabPageAgregarEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageLista;
        private TabPage tabPageAgregarEditar;
        private DataGridView dataGridClientes;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBusqueda;
        private Label label2;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtDireccion;
        private TextBox txtDni;
        private TextBox txtApellido;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private CheckBox verEliminadosCheck;
        private FontAwesome.Sharp.IconButton btnRestaurar;
        private ComboBox comboLocalidades;
        private Label label7;
    }
}