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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.apellido = frmApellido.Text;
            cliente.nombre = frmNombre.Text;
            cliente.clienteDNI = Convert.ToInt32(frmDNI.Text);
            cliente.telefono = frmTel.Text;
            MessageBox.Show("Cliente " + cliente.apellido + " " + cliente.nombre + " " + "con DNI " + cliente.clienteDNI + " y telefono: " + cliente.telefono);
        }
    }
}
