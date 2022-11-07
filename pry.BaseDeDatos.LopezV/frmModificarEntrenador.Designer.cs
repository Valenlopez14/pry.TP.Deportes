namespace pry.BaseDeDatos.LopezV
{
    partial class frmModificarEntrenador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarEntrenador));
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lblCodigoEntrenador = new System.Windows.Forms.Label();
            this.lblCodigoEntrenadorBusq = new System.Windows.Forms.Label();
            this.lblNombreEntr = new System.Windows.Forms.Label();
            this.lblApellidoEntr = new System.Windows.Forms.Label();
            this.lblDireccionEntr = new System.Windows.Forms.Label();
            this.lblProvinciaEntr = new System.Windows.Forms.Label();
            this.lblDeporteEntr = new System.Windows.Forms.Label();
            this.txtCodigoBusc = new System.Windows.Forms.TextBox();
            this.txtCodigoEntr = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lstProvincia = new System.Windows.Forms.ComboBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(196, 55);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 0;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(196, 337);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 1;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblCodigoEntrenador
            // 
            this.lblCodigoEntrenador.AutoSize = true;
            this.lblCodigoEntrenador.BackColor = System.Drawing.Color.White;
            this.lblCodigoEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrenador.Location = new System.Drawing.Point(8, 12);
            this.lblCodigoEntrenador.Name = "lblCodigoEntrenador";
            this.lblCodigoEntrenador.Size = new System.Drawing.Size(127, 15);
            this.lblCodigoEntrenador.TabIndex = 2;
            this.lblCodigoEntrenador.Text = "Codigo Entrenador";
            // 
            // lblCodigoEntrenadorBusq
            // 
            this.lblCodigoEntrenadorBusq.AutoSize = true;
            this.lblCodigoEntrenadorBusq.BackColor = System.Drawing.Color.White;
            this.lblCodigoEntrenadorBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntrenadorBusq.Location = new System.Drawing.Point(8, 102);
            this.lblCodigoEntrenadorBusq.Name = "lblCodigoEntrenadorBusq";
            this.lblCodigoEntrenadorBusq.Size = new System.Drawing.Size(127, 15);
            this.lblCodigoEntrenadorBusq.TabIndex = 3;
            this.lblCodigoEntrenadorBusq.Text = "Codigo Entrenador";
            // 
            // lblNombreEntr
            // 
            this.lblNombreEntr.AutoSize = true;
            this.lblNombreEntr.BackColor = System.Drawing.Color.White;
            this.lblNombreEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEntr.Location = new System.Drawing.Point(8, 140);
            this.lblNombreEntr.Name = "lblNombreEntr";
            this.lblNombreEntr.Size = new System.Drawing.Size(58, 15);
            this.lblNombreEntr.TabIndex = 4;
            this.lblNombreEntr.Text = "Nombre";
            // 
            // lblApellidoEntr
            // 
            this.lblApellidoEntr.AutoSize = true;
            this.lblApellidoEntr.BackColor = System.Drawing.Color.White;
            this.lblApellidoEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEntr.Location = new System.Drawing.Point(8, 178);
            this.lblApellidoEntr.Name = "lblApellidoEntr";
            this.lblApellidoEntr.Size = new System.Drawing.Size(59, 15);
            this.lblApellidoEntr.TabIndex = 5;
            this.lblApellidoEntr.Text = "Apellido";
            // 
            // lblDireccionEntr
            // 
            this.lblDireccionEntr.AutoSize = true;
            this.lblDireccionEntr.BackColor = System.Drawing.Color.White;
            this.lblDireccionEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEntr.Location = new System.Drawing.Point(8, 216);
            this.lblDireccionEntr.Name = "lblDireccionEntr";
            this.lblDireccionEntr.Size = new System.Drawing.Size(68, 15);
            this.lblDireccionEntr.TabIndex = 6;
            this.lblDireccionEntr.Text = "Direccion";
            // 
            // lblProvinciaEntr
            // 
            this.lblProvinciaEntr.AutoSize = true;
            this.lblProvinciaEntr.BackColor = System.Drawing.Color.White;
            this.lblProvinciaEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinciaEntr.Location = new System.Drawing.Point(8, 254);
            this.lblProvinciaEntr.Name = "lblProvinciaEntr";
            this.lblProvinciaEntr.Size = new System.Drawing.Size(66, 15);
            this.lblProvinciaEntr.TabIndex = 7;
            this.lblProvinciaEntr.Text = "Provincia";
            // 
            // lblDeporteEntr
            // 
            this.lblDeporteEntr.AutoSize = true;
            this.lblDeporteEntr.BackColor = System.Drawing.Color.White;
            this.lblDeporteEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteEntr.Location = new System.Drawing.Point(8, 292);
            this.lblDeporteEntr.Name = "lblDeporteEntr";
            this.lblDeporteEntr.Size = new System.Drawing.Size(58, 15);
            this.lblDeporteEntr.TabIndex = 8;
            this.lblDeporteEntr.Text = "Deporte";
            // 
            // txtCodigoBusc
            // 
            this.txtCodigoBusc.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoBusc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBusc.Location = new System.Drawing.Point(157, 12);
            this.txtCodigoBusc.Name = "txtCodigoBusc";
            this.txtCodigoBusc.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoBusc.TabIndex = 9;
            // 
            // txtCodigoEntr
            // 
            this.txtCodigoEntr.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoEntr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEntr.Location = new System.Drawing.Point(157, 105);
            this.txtCodigoEntr.Name = "txtCodigoEntr";
            this.txtCodigoEntr.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEntr.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(157, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(157, 174);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(157, 212);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 13;
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
            this.lstProvincia.Location = new System.Drawing.Point(157, 247);
            this.lstProvincia.Name = "lstProvincia";
            this.lstProvincia.Size = new System.Drawing.Size(100, 21);
            this.lstProvincia.TabIndex = 14;
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
            this.lstDeporte.Location = new System.Drawing.Point(157, 285);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(100, 21);
            this.lstDeporte.TabIndex = 15;
            // 
            // frmModificarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 372);
            this.Controls.Add(this.lstDeporte);
            this.Controls.Add(this.lstProvincia);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigoEntr);
            this.Controls.Add(this.txtCodigoBusc);
            this.Controls.Add(this.lblDeporteEntr);
            this.Controls.Add(this.lblProvinciaEntr);
            this.Controls.Add(this.lblDireccionEntr);
            this.Controls.Add(this.lblApellidoEntr);
            this.Controls.Add(this.lblNombreEntr);
            this.Controls.Add(this.lblCodigoEntrenadorBusq);
            this.Controls.Add(this.lblCodigoEntrenador);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarEntrenador";
            this.Text = "ModificarEntrenador";
            this.Load += new System.EventHandler(this.frmModificarEntrenador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label lblCodigoEntrenador;
        private System.Windows.Forms.Label lblCodigoEntrenadorBusq;
        private System.Windows.Forms.Label lblNombreEntr;
        private System.Windows.Forms.Label lblApellidoEntr;
        private System.Windows.Forms.Label lblDireccionEntr;
        private System.Windows.Forms.Label lblProvinciaEntr;
        private System.Windows.Forms.Label lblDeporteEntr;
        private System.Windows.Forms.TextBox txtCodigoBusc;
        private System.Windows.Forms.TextBox txtCodigoEntr;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox lstProvincia;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.Timer timer1;
    }
}