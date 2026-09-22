namespace Desktop.Views
{
    partial class iniciarSesionView
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
            logobox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnLogin = new FontAwesome.Sharp.IconButton();
            checkPassword = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)logobox).BeginInit();
            SuspendLayout();
            // 
            // logobox
            // 
            logobox.Image = Properties.Resources.logoinstituto;
            logobox.InitialImage = Properties.Resources.logoinstituto;
            logobox.Location = new Point(27, 70);
            logobox.Name = "logobox";
            logobox.Size = new Size(300, 300);
            logobox.SizeMode = PictureBoxSizeMode.StretchImage;
            logobox.TabIndex = 0;
            logobox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 89);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 1;
            label1.Text = "Usuario:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(366, 269);
            label2.Name = "label2";
            label2.Size = new Size(151, 29);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(583, 89);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(440, 39);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(583, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(440, 39);
            txtPassword.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.Location = new Point(873, 452);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLogin
            // 
            btnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            btnLogin.IconColor = Color.Black;
            btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLogin.Location = new Point(583, 452);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(181, 46);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // checkPassword
            // 
            checkPassword.AutoSize = true;
            checkPassword.Location = new Point(721, 374);
            checkPassword.Name = "checkPassword";
            checkPassword.Size = new Size(184, 36);
            checkPassword.TabIndex = 7;
            checkPassword.Text = "Ver Password";
            checkPassword.UseVisualStyleBackColor = true;
            checkPassword.CheckedChanged += checkPassword_CheckedChanged;
            // 
            // iniciarSesionView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 595);
            Controls.Add(logobox);
            Controls.Add(checkPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnCancelar);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "iniciarSesionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log in Firebase";
            ((System.ComponentModel.ISupportInitialize)logobox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logobox;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPassword;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnLogin;
        private CheckBox checkPassword;
    }
}