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
    public partial class FrmMain : Form
    {
        private Usuario user;
        public FrmMain(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            if (user.rol == "admin")
            {
                gestionSectoresToolStripMenuItem.Visible = true;
                gestionVehiculosToolStripMenuItem.Visible = true;
                gestionClientesToolStripMenuItem.Visible = false;
                gestionDeEstacionamientoToolStripMenu.Visible = false;

            }
            if (user.rol== "operador")
            {
                gestionSectoresToolStripMenuItem.Visible = false;
                gestionVehiculosToolStripMenuItem.Visible = false;
                gestionClientesToolStripMenuItem.Visible = true;
                gestionDeEstacionamientoToolStripMenu.Visible = true;
            }
            
        }

      
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void gestionVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVehiculo formVehiculo = new FormVehiculo();
            formVehiculo.Show();
            this.Hide();
        }

        private void gestionClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente formCliente = new FormCliente();
            formCliente.Show();
            this.Hide();
        }
    }
}
