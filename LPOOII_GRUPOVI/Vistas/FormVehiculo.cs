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
    public partial class FormVehiculo : Form
    {
        public FormVehiculo()
        {
            InitializeComponent();
        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            TipoVehiculo vehiculo = new TipoVehiculo();
            vehiculo.tVCodigo = Convert.ToInt32(frmTVCod.Text);
            vehiculo.tarifa = Convert.ToDecimal(frmChinko.Text);
            vehiculo.descripcion = frmDescrip.Text;
            MessageBox.Show("Vehiculo " + vehiculo.tVCodigo + " " + vehiculo.descripcion + " " + "registrado por: " + vehiculo.tarifa);
        }
    }
}
