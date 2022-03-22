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

namespace practicaDepreciacion
{
    public partial class Form1 : Form
    {
        IActivoServices activoServices;
        public Form1(IActivoServices ActivoServices)
        {
            this.activoServices = ActivoServices;
            InitializeComponent();
        }


        #region barras de texto
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede numeros");
            }
        }

        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }
        private void txtIdbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }
        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txtValorR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txtVidaU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }

        private void txtIdBusca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se puede LETRAS");
            }
        }
        private bool verificar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtValor.Text) || String.IsNullOrEmpty(txtVidaU.Text) || String.IsNullOrEmpty(txtValorR.Text))
            {

                return false;
            }
            return true;
        }
        private void limpiar()
        {
            this.txtNombre.Text = String.Empty;
            this.txtValor.Text = String.Empty;
            this.txtValorR.Text = String.Empty;
            this.txtVidaU.Text = String.Empty;
            this.txtIdBusca.Text = String.Empty;
        }
        #endregion




        private void txtEnviar_Click(object sender, EventArgs e)
        {
            bool verificado = verificar();
            if (verificado == false)
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
            else
            {

                Activo activo = new Activo()
                {
                    Nombre = txtNombre.Text,
                    Valor = double.Parse(txtValor.Text),
                    ValorResidual=double.Parse(txtValorR.Text),
                    VidaUtil= int.Parse(txtVidaU.Text)
                };
                activoServices.Add(activo);
                dataGridView1.DataSource = null;
                limpiar();
                dataGridView1.DataSource = activoServices.Read();

            }
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmDepreciacion depreciacion = new FrmDepreciacion(activoServices.Read()[e.RowIndex]);
                depreciacion.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = activoServices.Read();
        
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Aseguresé de escribir el Id");

            DialogResult a = MessageBox.Show("¿Esta seguro de actualizar el archivo?", "Actualizando el archivo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                bool verificado = verificar();
                if (verificado == false)
                {
                    MessageBox.Show("Tienes que llenar todos los formularios.");
                }
                else
                {

                    Activo activo = new Activo()
                    {
                        Nombre = txtNombre.Text,
                        Valor = double.Parse(txtValor.Text),
                        ValorResidual = double.Parse(txtValorR.Text),
                        VidaUtil = int.Parse(txtVidaU.Text)
                    };
                    activoServices.Update(activo, int.Parse(txtIdBusca.Text));
                    dataGridView1.DataSource = null;
                    limpiar();
                    dataGridView1.DataSource = activoServices.Read();

                }
            }
            else
            {
                MessageBox.Show("Se cancelo esta acción");
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aseguresé de escribir el Id");
            DialogResult a = MessageBox.Show("¿Esta seguro de borrar el archivo?", "Borrando dato...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {

                activoServices.Delete(int.Parse(txtIdBusca.Text));
                dataGridView1.DataSource = null;
                limpiar();
                dataGridView1.DataSource = activoServices.Read();





            }
            else
            {
                MessageBox.Show("Se cancelo esta acción");
            }



        }

        



        //private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    btnEnviar.Show(); txtNombre.Show();
        //    txtValor.Show();
        //    txtValorR.Show();
        //    txtVidaU.Show();
        //    label1.Show();
        //    label2.Show();
        //    label3.Show();
        //    label4.Show();
        //}
        //btnActualizar.Hide();
        //btnBorrar.Hide();
        //DialogResult a = MessageBox.Show("¿Actualizar?", "¿Que esta solicitando?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //           if (a == DialogResult.Yes)
        //{
        //    btnBorrar.Hide();
        //    btnEnviar.Hide();
        //    btnActualizar.Show();
        //    txtNombre.Show();
        //    txtValor.Show();
        //    txtValorR.Show();
        //    txtVidaU.Show();
        //    label1.Show();
        //    label2.Show();
        //    label3.Show();
        //    label4.Show();
        //}
        //else {
        //    DialogResult b = MessageBox.Show("¿Borrar?", "¿Que esta solicitando?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (b == DialogResult.Yes)
        //    {
        //        btnEnviar.Hide();
        //        btnActualizar.Hide();
        //        btnBorrar.Show();
        //        txtNombre.Hide();
        //        txtValor.Hide();
        //        txtValorR.Hide();
        //        txtVidaU.Hide();
        //        label1.Hide();
        //        label2.Hide();
        //        label3.Hide();
        //        label4.Hide();

        //    }
        //    else
        //    {
        //        btnEnviar.Show();
        //        MessageBox.Show("No se seleccionó ninguna opción");
        //    }

        //}
    }
}
