namespace pry.BaseDeDatos.LopezV
{
    partial class frmEliminarEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarEntrenador));
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoEntrenador = new System.Windows.Forms.TextBox();
            this.txtCodigoEntrBuscado = new System.Windows.Forms.TextBox();
            this.lblDeporteEntr = new System.Windows.Forms.Label();
            this.lblProvinciaEntr = new System.Windows.Forms.Label();
            this.lblDireccionEntr = new System.Windows.Forms.Label();
            this.lblApellidoEntr = new System.Windows.Forms.Label();
            this.lblNombreEntr = new System.Windows.Forms.Label();
            this.lblCodigoEntrenadorBusq = new System.Windows.Forms.Label();
            this.lblCodigoEntrenador = new System.Windows.Forms.Label();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.lstProvincia = new System.Windows.Forms.ComboBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(161, 209);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 29;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(161, 171);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 28;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(161, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 27;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigoEntrenador
            // 
            this.txtCodigoEntrenador.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoEntrenador.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEntrenador.Location = new System.Drawing.Point(161, 102);
            this.txtCodigoEntrenador.Name = "txtCodigoEntrenador";
            this.txtCodigoEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEntrenador.TabIndex = 26;
            this.txtCodigoEntrenador.TextChanged += new System.EventHandler(this.txtCodigoEntrenador_TextChanged);
            // 
            // txtCodigoEntrBuscado
            // 
            this.txtCodigoEntrBuscado.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoEntrBuscado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEntrBuscado.Location = new System.Drawing.Point(161, 9);
            this.txtCodigoEntrBuscado.Name = "txtCodigoEntrBuscado";
            this.txtCodigoEntrBuscado.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEntrBuscado.TabIndex = 25;
            // 
            // lblDeporteEntr
            // 
            this.lblDeporteEntr.AutoSize = true;
            this.lblDeporteEntr.BackColor = System.Drawing.Color.White;
            this.lblDeporteEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteEntr.Location = new System.Drawing.Point(12, 289);
            this.lblDeporteEntr.Name = "lblDeporteEntr";
            this.lblDeporteEntr.Size = new System.Drawing.Size(58, 15);
            this.lblDeporteEntr.TabIndex = 24;
            this.lblDeporteEntr.Text = "Deporte";
            // 
            // lblProvinciaEntr
            // 
            this.lblProvinciaEntr.AutoSize = true;
            this.lblProvinciaEntr.BackColor = System.Drawing.Color.White;
            this.lblProvinciaEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinciaEntr.Location = new System.Drawing.Point(12, 251);
            this.lblProvinciaEntr.Name = "lblProvinciaEntr";
            this.lblProvinciaEntr.Size = new System.Drawing.Size(66, 15);
            this.lblProvinciaEntr.TabIndex = 23;
            this.lblProvinciaEntr.Text = "Provincia";
            // 
            // lblDireccionEntr
            // 
            this.lblDireccionEntr.AutoSize = true;
            this.lblDireccionEntr.BackColor = System.Drawing.Color.White;
            this.lblDireccionEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEntr.Location = new System.Drawing.Point(12, 213);
            this.lblDireccionEntr.Name = "lblDireccionEntr";
            this.lblDireccionEntr.Size = new System.Drawing.Size(68, 15);
            this.lblDireccionEntr.TabIndex = 22;
            this.lblDireccionEntr.Text = "Direccion";
            // 
            // lblApellidoEntr
            // 
            this.lblApellidoEntr.AutoSize = true;
            this.lblApellidoEntr.BackColor = System.Drawing.Color.White;
            this.lblApellidoEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEntr.Location = new System.Drawing.Point(12, 175);
            this.lblApellidoEntr.Name = "lblApellidoEntr";
            this.lblApellidoEntr.Size = new System.Drawing.Size(59, 15);
            this.lblApellidoEntr.TabIndex = 21;
            this.lblApellidoEntr.Text = "Apellido";
            // 
            // lblNombreEntr
            // 
            this.lblNombreEntr.AutoSize = true;
            this.lblNombreEntr.BackColor = System.Drawing.Color.White;
            this.lblNombreEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEntr.Location = new System.Drawing.Point(12, 137);
            this.lblNombreEntr.Name = "lblNombreEntr";
            this.lblNombreEntr.Size = new System.Drawing.Size(58, 15);
            this.lblNombreEntr.TabIndex = 20;
            this.lblNombreEntr.Text = "Nombre";
            // 
            // lblCodigoEntrenadorBusq
            // 
            this.lblCodigoEntrenadorBusq.AutoSize = true;
            this.lblCodigoEntrenadorBusq.BackColor = System.Drawing.Color.White;
            this.lblCodigoEntrenadorBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrenadorBusq.Location = new System.Drawing.Point(12, 99);
            this.lblCodigoEntrenadorBusq.Name = "lblCodigoEntrenadorBusq";
            this.lblCodigoEntrenadorBusq.Size = new System.Drawing.Size(127, 15);
            this.lblCodigoEntrenadorBusq.TabIndex = 19;
            this.lblCodigoEntrenadorBusq.Text = "Codigo Entrenador";
            // 
            // lblCodigoEntrenador
            // 
            this.lblCodigoEntrenador.AutoSize = true;
            this.lblCodigoEntrenador.BackColor = System.Drawing.Color.White;
            this.lblCodigoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrenador.Location = new System.Drawing.Point(12, 9);
            this.lblCodigoEntrenador.Name = "lblCodigoEntrenador";
            this.lblCodigoEntrenador.Size = new System.Drawing.Size(127, 15);
            this.lblCodigoEntrenador.TabIndex = 18;
            this.lblCodigoEntrenador.Text = "Codigo Entrenador";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(198, 334);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 17;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(198, 52);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 16;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // lstProvincia
            // 
            this.lstProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProvincia.FormattingEnabled = true;
            this.lstProvincia.Items.AddRange(new object[] {
            "BOLIVAR",
            "CAÑAR",
            "CHIMBORAZO",
            "PICHINCHA"});
            this.lstProvincia.Location = new System.Drawing.Point(161, 251);
            this.lstProvincia.Name = "lstProvincia";
            this.lstProvincia.Size = new System.Drawing.Size(100, 21);
            this.lstProvincia.TabIndex = 30;
            this.lstProvincia.SelectedIndexChanged += new System.EventHandler(this.lstProvincia_SelectedIndexChanged);
            // 
            // lstDeporte
            // 
            this.lstDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporte.FormattingEnabled = true;
            this.lstDeporte.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL"});
            this.lstDeporte.Location = new System.Drawing.Point(161, 289);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(100, 21);
            this.lstDeporte.TabIndex = 31;
            this.lstDeporte.SelectedIndexChanged += new System.EventHandler(this.lstDeporte_SelectedIndexChanged);
            // 
            // frmEliminarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 370);
            this.Controls.Add(this.lstDeporte);
            this.Controls.Add(this.lstProvincia);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoEntrenador);
            this.Controls.Add(this.txtCodigoEntrBuscado);
            this.Controls.Add(this.lblDeporteEntr);
            this.Controls.Add(this.lblProvinciaEntr);
            this.Controls.Add(this.lblDireccionEntr);
            this.Controls.Add(this.lblApellidoEntr);
            this.Controls.Add(this.lblNombreEntr);
            this.Controls.Add(this.lblCodigoEntrenadorBusq);
            this.Controls.Add(this.lblCodigoEntrenador);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEliminarEntrenador";
            this.Text = "Eliminar Entrenador";
            this.Load += new System.EventHandler(this.frmEliminarEntrenador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoEntrenador;
        private System.Windows.Forms.TextBox txtCodigoEntrBuscado;
        private System.Windows.Forms.Label lblDeporteEntr;
        private System.Windows.Forms.Label lblProvinciaEntr;
        private System.Windows.Forms.Label lblDireccionEntr;
        private System.Windows.Forms.Label lblApellidoEntr;
        private System.Windows.Forms.Label lblNombreEntr;
        private System.Windows.Forms.Label lblCodigoEntrenadorBusq;
        private System.Windows.Forms.Label lblCodigoEntrenador;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.ComboBox lstProvincia;
        private System.Windows.Forms.ComboBox lstDeporte;
    }
}