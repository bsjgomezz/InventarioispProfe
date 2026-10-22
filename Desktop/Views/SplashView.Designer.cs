namespace Desktop.Views
{
    partial class SplashView
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
            components = new System.ComponentModel.Container();
            inventarioisp20 = new Label();
            progressBar = new ProgressBar();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // inventarioisp20
            // 
            inventarioisp20.AutoSize = true;
            inventarioisp20.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            inventarioisp20.Location = new Point(50, 32);
            inventarioisp20.Margin = new Padding(2, 0, 2, 0);
            inventarioisp20.Name = "inventarioisp20";
            inventarioisp20.Size = new Size(251, 41);
            inventarioisp20.TabIndex = 0;
            inventarioisp20.Text = "Inventario ISP20";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(50, 273);
            progressBar.Margin = new Padding(2);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(584, 27);
            progressBar.TabIndex = 1;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // SplashView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(737, 424);
            Controls.Add(progressBar);
            Controls.Add(inventarioisp20);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "SplashView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashView";
            Load += SplashView_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label inventarioisp20;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}