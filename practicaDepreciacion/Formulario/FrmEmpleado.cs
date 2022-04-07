using AppCore.IServices;
using Domain.Entities;
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
    public partial class FrmEmpleado : Form
    {
        IEmpleadoServices empleadoServices;
      
        public FrmEmpleado(IEmpleadoServices EmpleadoServices)
        {
                this.empleadoServices = EmpleadoServices;
                InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = empleadoServices.Read();

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            Close();
                         
        }
    }
}
