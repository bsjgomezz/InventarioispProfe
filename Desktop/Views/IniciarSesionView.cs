using Firebase.Auth;
using Firebase.Auth.Providers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class iniciarSesionView : Form
    {
        FirebaseAuthClient? firebaseAuthClient;
        int intentos = 0;
        public iniciarSesionView()
        {
            InitializeComponent();
            ConfiguracionFirebaseAuthClient();
        }

        private void ConfiguracionFirebaseAuthClient()
        {
            var configAuthClient = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyC6qgOlT4hET90ROT7zyfVQNiLbzbrZVoM",
                AuthDomain = "inventarioisp20bau.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                }

            };
            firebaseAuthClient = new FirebaseAuthClient(configAuthClient);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await firebaseAuthClient!
                    .SignInWithEmailAndPasswordAsync(txtUser.Text, txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show($"Usuario o contraseña incorrectos :(");
                    intentos++;
                    return;
                }

                {
                    MessageBox.Show
                    ($" Usuario encontrado! " + $" Bienvenido ;D");
                    this.Hide();
                    var mainView = new MenuPrincipalView();
                    mainView.Show();
                    this.Close();
                }

            }
            catch (FirebaseAuthException error)
            {
                MessageBox.Show($"Ha ocurrido el siguiente error al iniciar sesión ---> {error.Message}");
                intentos++;
            }
            if (intentos >= 3)
            {
                MessageBox.Show($"Se han agotado los intentos de inicio de sesión, el programa se cerrará.");
                Application.Exit();
            }


        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            //txt.passwordChar = checkPassword.Checked ? '\0' : '*';
            if (checkPassword.Checked)

                txtPassword.PasswordChar = '\0';
            else

                txtPassword.PasswordChar = '*';


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
