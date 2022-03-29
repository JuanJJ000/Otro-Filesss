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
        IActivoServices activoServices;
        public FrmEmpleado(IActivoServices activoServices)
        {
                this.activoServices = activoServices;
                InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
