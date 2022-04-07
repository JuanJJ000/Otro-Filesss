
namespace practicaDepreciacion.Formulario
{
    partial class FrmAsignar
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
            this.cmbActivos = new System.Windows.Forms.ComboBox();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbActivos
            // 
            this.cmbActivos.FormattingEnabled = true;
            this.cmbActivos.Location = new System.Drawing.Point(12, 88);
            this.cmbActivos.Name = "cmbActivos";
            this.cmbActivos.Size = new System.Drawing.Size(121, 21);
            this.cmbActivos.TabIndex = 0;
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(227, 88);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleados.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "--->";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(141, 216);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 50);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            // 
            // FrmAsignar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(365, 291);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.cmbActivos);
            this.Name = "FrmAsignar";
            this.Text = "Asignar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbActivos;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignar;
    }
}