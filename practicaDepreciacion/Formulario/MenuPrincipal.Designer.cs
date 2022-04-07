
namespace practicaDepreciacion.Formulario
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnActivo = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAsignar.Location = new System.Drawing.Point(423, 314);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(95, 73);
            this.btnAsignar.TabIndex = 0;
            this.btnAsignar.Text = "Asignar Activo a Empleado";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnActivo
            // 
            this.btnActivo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnActivo.Location = new System.Drawing.Point(423, 187);
            this.btnActivo.Name = "btnActivo";
            this.btnActivo.Size = new System.Drawing.Size(95, 73);
            this.btnActivo.TabIndex = 1;
            this.btnActivo.Text = "Activo";
            this.btnActivo.UseVisualStyleBackColor = false;
            this.btnActivo.Click += new System.EventHandler(this.btnActivo_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEmpleado.Location = new System.Drawing.Point(423, 56);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(95, 73);
            this.btnEmpleado.TabIndex = 2;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 453);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnActivo);
            this.Controls.Add(this.btnAsignar);
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnActivo;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}