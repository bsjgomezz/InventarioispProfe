namespace Desktop.Views
{
    partial class LocalidadesApiView
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
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            btnAgregarL = new FontAwesome.Sharp.IconButton();
            tabContrlol1 = new TabControl();
            tabPage1 = new TabPage();
            btnAnularL = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnBuscarL = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridLocalidades = new DataGridView();
            tabPage2 = new TabPage();
            label2 = new Label();
            tabContrlol1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).BeginInit();
            SuspendLayout();
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // btnAgregarL
            // 
            btnAgregarL.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregarL.IconColor = Color.Black;
            btnAgregarL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarL.Location = new Point(626, 33);
            btnAgregarL.Name = "btnAgregarL";
            btnAgregarL.Size = new Size(87, 29);
            btnAgregarL.TabIndex = 0;
            btnAgregarL.Text = "Agregar";
            btnAgregarL.UseVisualStyleBackColor = true;
            // 
            // tabContrlol1
            // 
            tabContrlol1.Controls.Add(tabPage1);
            tabContrlol1.Controls.Add(tabPage2);
            tabContrlol1.Location = new Point(10, 105);
            tabContrlol1.Name = "tabContrlol1";
            tabContrlol1.SelectedIndex = 0;
            tabContrlol1.Size = new Size(727, 382);
            tabContrlol1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAnularL);
            tabPage1.Controls.Add(iconButton1);
            tabPage1.Controls.Add(btnBuscarL);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnAgregarL);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(dataGridLocalidades);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(719, 349);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista de Localidades";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAnularL
            // 
            btnAnularL.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAnularL.IconColor = Color.Black;
            btnAnularL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnularL.Location = new Point(626, 131);
            btnAnularL.Name = "btnAnularL";
            btnAnularL.Size = new Size(87, 29);
            btnAnularL.TabIndex = 7;
            btnAnularL.Text = "Anular";
            btnAnularL.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(626, 80);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(87, 29);
            iconButton1.TabIndex = 6;
            iconButton1.Text = "Modificar";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnBuscarL
            // 
            btnBuscarL.IconChar = FontAwesome.Sharp.IconChar.None;
            btnBuscarL.IconColor = Color.Black;
            btnBuscarL.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarL.Location = new Point(511, 2);
            btnBuscarL.Name = "btnBuscarL";
            btnBuscarL.Size = new Size(94, 29);
            btnBuscarL.TabIndex = 5;
            btnBuscarL.Text = "Buscar";
            btnBuscarL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 4;
            label1.Text = "Buscar:";
            // 
            
            // dataGridLocalidades
            // 
            dataGridLocalidades.AllowUserToAddRows = false;
            dataGridLocalidades.AllowUserToDeleteRows = false;
            dataGridLocalidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLocalidades.Location = new Point(5, 33);
            dataGridLocalidades.Margin = new Padding(2);
            dataGridLocalidades.Name = "dataGridLocalidades";
            dataGridLocalidades.ReadOnly = true;
            dataGridLocalidades.RowHeadersWidth = 62;
            dataGridLocalidades.Size = new Size(616, 302);
            dataGridLocalidades.TabIndex = 2;
            //dataGridLocalidades.CellContentClick += this.dataGridLocalidades_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(719, 349);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registro Localidad";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 9);
            label2.Name = "label2";
            label2.Size = new Size(145, 31);
            label2.TabIndex = 2;
            label2.Text = "Localidades ";
            // 
            // LocalidadesApiView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 486);
            Controls.Add(label2);
            Controls.Add(tabContrlol1);
            Name = "LocalidadesApiView";
            Text = "LocalidadesView";
            tabContrlol1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridLocalidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconButton btnAgregarL;
        private TabControl tabContrlol1;
        private TabPage tabPage1;
        private DataGridView dataGridLocalidades;
        private TabPage tabPage2;
        private FontAwesome.Sharp.IconButton btnBuscarL;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnAnularL;
        private FontAwesome.Sharp.IconButton iconButton1;
        private object txtBuscarL;
    }
}