namespace LibAlumno
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNombreVacio = new System.Windows.Forms.Button();
            this.btenAlumno = new System.Windows.Forms.Button();
            this.btnNombreLargo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNombreVacio
            // 
            this.btnNombreVacio.Location = new System.Drawing.Point(55, 45);
            this.btnNombreVacio.Name = "btnNombreVacio";
            this.btnNombreVacio.Size = new System.Drawing.Size(121, 44);
            this.btnNombreVacio.TabIndex = 0;
            this.btnNombreVacio.Text = "Nombre vacio";
            this.btnNombreVacio.UseVisualStyleBackColor = true;
            this.btnNombreVacio.Click += new System.EventHandler(this.btnNombreVacio_Click);
            // 
            // btenAlumno
            // 
            this.btenAlumno.Location = new System.Drawing.Point(55, 139);
            this.btenAlumno.Name = "btenAlumno";
            this.btenAlumno.Size = new System.Drawing.Size(121, 44);
            this.btenAlumno.TabIndex = 2;
            this.btenAlumno.Text = "Crear alumno";
            this.btenAlumno.UseVisualStyleBackColor = true;
            this.btenAlumno.Click += new System.EventHandler(this.btenAlumno_Click);
            // 
            // btnNombreLargo
            // 
            this.btnNombreLargo.Location = new System.Drawing.Point(55, 92);
            this.btnNombreLargo.Name = "btnNombreLargo";
            this.btnNombreLargo.Size = new System.Drawing.Size(121, 44);
            this.btnNombreLargo.TabIndex = 3;
            this.btnNombreLargo.Text = "Nombre Largo";
            this.btnNombreLargo.UseVisualStyleBackColor = true;
            this.btnNombreLargo.Click += new System.EventHandler(this.btnNombreLargo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 227);
            this.Controls.Add(this.btnNombreLargo);
            this.Controls.Add(this.btenAlumno);
            this.Controls.Add(this.btnNombreVacio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNombreVacio;
        private System.Windows.Forms.Button btenAlumno;
        private System.Windows.Forms.Button btnNombreLargo;
    }
}

