namespace CrearLeerXML
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
            this.lbAgenda = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbTelef = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelef = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btIzquierda = new System.Windows.Forms.Button();
            this.btDerecha = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAgenda
            // 
            this.lbAgenda.AutoSize = true;
            this.lbAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAgenda.Location = new System.Drawing.Point(183, 35);
            this.lbAgenda.Name = "lbAgenda";
            this.lbAgenda.Size = new System.Drawing.Size(87, 25);
            this.lbAgenda.TabIndex = 0;
            this.lbAgenda.Text = "Agenda";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(42, 86);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(69, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(42, 129);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(77, 20);
            this.lbApellidos.TabIndex = 2;
            this.lbApellidos.Text = "Apellidos:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(42, 177);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(79, 20);
            this.lbDireccion.TabIndex = 3;
            this.lbDireccion.Text = "Dirección:";
            // 
            // lbTelef
            // 
            this.lbTelef.AutoSize = true;
            this.lbTelef.Location = new System.Drawing.Point(42, 224);
            this.lbTelef.Name = "lbTelef";
            this.lbTelef.Size = new System.Drawing.Size(75, 20);
            this.lbTelef.TabIndex = 4;
            this.lbTelef.Text = "Teléfono:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(44, 273);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 20);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "E-mail:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(154, 80);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(249, 26);
            this.tbNombre.TabIndex = 6;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(154, 123);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(249, 26);
            this.tbApellidos.TabIndex = 7;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(154, 171);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(249, 26);
            this.tbDireccion.TabIndex = 8;
            // 
            // tbTelef
            // 
            this.tbTelef.Location = new System.Drawing.Point(154, 218);
            this.tbTelef.Name = "tbTelef";
            this.tbTelef.Size = new System.Drawing.Size(249, 26);
            this.tbTelef.TabIndex = 9;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(154, 267);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(249, 26);
            this.tbEmail.TabIndex = 10;
            // 
            // btIzquierda
            // 
            this.btIzquierda.BackColor = System.Drawing.SystemColors.Window;
            this.btIzquierda.Location = new System.Drawing.Point(48, 27);
            this.btIzquierda.Name = "btIzquierda";
            this.btIzquierda.Size = new System.Drawing.Size(75, 33);
            this.btIzquierda.TabIndex = 11;
            this.btIzquierda.Text = "<<";
            this.btIzquierda.UseVisualStyleBackColor = false;
            this.btIzquierda.Click += new System.EventHandler(this.btIzquierda_Click);
            // 
            // btDerecha
            // 
            this.btDerecha.BackColor = System.Drawing.SystemColors.Window;
            this.btDerecha.Location = new System.Drawing.Point(327, 27);
            this.btDerecha.Name = "btDerecha";
            this.btDerecha.Size = new System.Drawing.Size(75, 33);
            this.btDerecha.TabIndex = 12;
            this.btDerecha.Text = ">>";
            this.btDerecha.UseVisualStyleBackColor = false;
            this.btDerecha.Click += new System.EventHandler(this.btDerecha_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.SystemColors.Window;
            this.btGuardar.Location = new System.Drawing.Point(154, 318);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(122, 32);
            this.btGuardar.TabIndex = 13;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btSerializar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(456, 399);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btDerecha);
            this.Controls.Add(this.btIzquierda);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbTelef);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTelef);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbApellidos);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbAgenda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAgenda;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbTelef;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbTelef;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btIzquierda;
        private System.Windows.Forms.Button btDerecha;
        private System.Windows.Forms.Button btGuardar;
    }
}

