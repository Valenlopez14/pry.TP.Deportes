namespace pry.BaseDeDatos.LopezV
{
    partial class frmModificarDeportista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarDeportista));
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.lblCodigoDeportistaN = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtCodigoDepor = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCodigoDeporBusc = new System.Windows.Forms.TextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mskEdad = new System.Windows.Forms.MaskedTextBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Enabled = false;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(171, 365);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 26);
            this.cmdGuardar.TabIndex = 0;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeportista.Location = new System.Drawing.Point(12, 30);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(122, 15);
            this.lblCodigoDeportista.TabIndex = 2;
            this.lblCodigoDeportista.Text = "Codigo Deportista";
            // 
            // lblCodigoDeportistaN
            // 
            this.lblCodigoDeportistaN.AutoSize = true;
            this.lblCodigoDeportistaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDeportistaN.Location = new System.Drawing.Point(12, 127);
            this.lblCodigoDeportistaN.Name = "lblCodigoDeportistaN";
            this.lblCodigoDeportistaN.Size = new System.Drawing.Size(122, 15);
            this.lblCodigoDeportistaN.TabIndex = 3;
            this.lblCodigoDeportistaN.Text = "Codigo Deportista";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 160);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 193);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 15);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 226);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(68, 15);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(12, 259);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(63, 15);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(12, 292);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 15);
            this.lblEdad.TabIndex = 8;
            this.lblEdad.Text = "Edad";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(12, 325);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(58, 15);
            this.lblDeporte.TabIndex = 9;
            this.lblDeporte.Text = "Deporte";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(171, 71);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar.TabIndex = 10;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtCodigoDepor
            // 
            this.txtCodigoDepor.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodigoDepor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoDepor.Location = new System.Drawing.Point(140, 126);
            this.txtCodigoDepor.Name = "txtCodigoDepor";
            this.txtCodigoDepor.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDepor.TabIndex = 11;
            this.txtCodigoDepor.TextChanged += new System.EventHandler(this.txtCodigoDepor_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(140, 192);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 13;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(140, 226);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 14;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtCodigoDeporBusc
            // 
            this.txtCodigoDeporBusc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoDeporBusc.Location = new System.Drawing.Point(140, 29);
            this.txtCodigoDeporBusc.Name = "txtCodigoDeporBusc";
            this.txtCodigoDeporBusc.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDeporBusc.TabIndex = 18;
            this.txtCodigoDeporBusc.TextChanged += new System.EventHandler(this.txtCodigoDeporBusc_TextChanged);
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(140, 258);
            this.mskTelefono.Mask = "999999999";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(100, 20);
            this.mskTelefono.TabIndex = 19;
            this.mskTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefono_MaskInputRejected);
            // 
            // mskEdad
            // 
            this.mskEdad.Location = new System.Drawing.Point(140, 291);
            this.mskEdad.Mask = "99";
            this.mskEdad.Name = "mskEdad";
            this.mskEdad.Size = new System.Drawing.Size(100, 20);
            this.mskEdad.TabIndex = 20;
            this.mskEdad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskEdad_MaskInputRejected);
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
            this.lstDeporte.Location = new System.Drawing.Point(140, 325);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(100, 21);
            this.lstDeporte.TabIndex = 21;
            this.lstDeporte.SelectedIndexChanged += new System.EventHandler(this.lstDeporte_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(140, 159);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 22;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // frmModificarDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 403);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lstDeporte);
            this.Controls.Add(this.mskEdad);
            this.Controls.Add(this.mskTelefono);
            this.Controls.Add(this.txtCodigoDeporBusc);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtCodigoDepor);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.lblDeporte);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoDeportistaN);
            this.Controls.Add(this.lblCodigoDeportista);
            this.Controls.Add(this.cmdGuardar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModificarDeportista";
            this.Text = "Modificar Deportista";
            this.Load += new System.EventHandler(this.frmModificarDeportista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.Label lblCodigoDeportistaN;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtCodigoDepor;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCodigoDeporBusc;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.MaskedTextBox mskEdad;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.TextBox txtNombre;
    }
}