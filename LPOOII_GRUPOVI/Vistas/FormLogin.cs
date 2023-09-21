using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBases;
namespace Vistas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void handle_login()
        {
            Usuario[] usuarios = new Usuario[]{
            new Usuario {apellido = "Ramirez", nombre = "RobertoCarlos", password = "123", rol="admin", username="admin"},
            new Usuario {apellido = "Carlos", nombre = "Juan", password = "123", rol="operador", username="operador"}

            };
            string username = FrmUsr.Text;

            string password = FrmPwd.Text;

            Console.WriteLine("username ingresado: " + username);
            Console.WriteLine("password ingresado: " + password);
            Usuario usuarioEncontrado = usuarios.FirstOrDefault(us => us.username==username && us.password == password);
            if (usuarioEncontrado != null)
            {
                FrmMain frmMain = new FrmMain(usuarioEncontrado);
                frmMain.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Datos Incorrectos!");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            handle_login();
        }
    }
}
