using AppCore.IServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion.Formulario
{
    public partial class MenuPrincipal : Form
    {

        IActivoServices activoServices;
        IEmpleadoServices empleadoServices;

        public MenuPrincipal(IActivoServices ActivoServices, IEmpleadoServices EmpleadoServices)
        {
            this.activoServices = ActivoServices;
            this.empleadoServices = EmpleadoServices;
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {


        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {

            FrmEmpleado frmEmpleado = new FrmEmpleado(empleadoServices);
            this.Hide();
            frmEmpleado.ShowDialog();
            this.Show();

        }

        private void btnActivo_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(activoServices);
            this.Hide();
            form1.ShowDialog();
            this.Show();

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            FrmAsignar frmAsignar = new FrmAsignar();
            this.Hide();
            frmAsignar.ShowDialog();
            this.Show();
        }
    }
}
