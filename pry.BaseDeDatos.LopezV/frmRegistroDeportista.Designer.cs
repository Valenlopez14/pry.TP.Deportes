namespace pry.BaseDeDatos.LopezV
{
    partial class frmRegistroDeportista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroDeportista));
            this.lblCodigoDepor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lstDeporte = new System.Windows.Forms.ComboBox();
            this.txtCodigoDepor = new System.Windows.Forms.TextBox();
            this.cmdRegistrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mskEdad = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblCodigoDepor
            // 
            this.lblCodigoDepor.AutoSize = true;
            this.lblCodigoDepor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDepor.Location = new System.Drawing.Point(12, 54);
            this.lblCodigoDepor.Name = "lblCodigoDepor";
            this.lblCodigoDepor.Size = new System.Drawing.Size(137, 20);
            this.lblCodigoDepor.TabIndex = 0;
            this.lblCodigoDepor.Text = "Codigo Deportista";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(12, 112);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporte.Location = new System.Drawing.Point(12, 228);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(67, 20);
            this.lblDeporte.TabIndex = 3;
            this.lblDeporte.Text = "Deporte";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 141);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 20);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(12, 170);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(71, 20);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(12, 199);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(47, 20);
            this.lblEdad.TabIndex = 6;
            this.lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(155, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(155, 114);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(155, 143);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
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
            this.lstDeporte.Location = new System.Drawing.Point(155, 229);
            this.lstDeporte.Name = "lstDeporte";
            this.lstDeporte.Size = new System.Drawing.Size(100, 21);
            this.lstDeporte.TabIndex = 6;
            this.lstDeporte.SelectedIndexChanged += new System.EventHandler(this.lstDeporte_SelectedIndexChanged);
            // 
            // txtCodigoDepor
            // 
            this.txtCodigoDepor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoDepor.Location = new System.Drawing.Point(155, 53);
            this.txtCodigoDepor.Name = "txtCodigoDepor";
            this.txtCodigoDepor.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDepor.TabIndex = 0;
            this.txtCodigoDepor.TextChanged += new System.EventHandler(this.txtCodigoDepor_TextChanged);
            // 
            // cmdRegistrar
            // 
            this.cmdRegistrar.Enabled = false;
            this.cmdRegistrar.Location = new System.Drawing.Point(191, 278);
            this.cmdRegistrar.Name = "cmdRegistrar";
            this.cmdRegistrar.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrar.TabIndex = 7;
            this.cmdRegistrar.Text = "Registrar";
            this.cmdRegistrar.UseVisualStyleBackColor = true;
            this.cmdRegistrar.Click += new System.EventHandler(this.cmdRegistrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(25, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(222, 16);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "REGISTRO DE DEPORTISTAS";
            // 
            // mskEdad
            // 
            this.mskEdad.Location = new System.Drawing.Point(155, 203);
            this.mskEdad.Mask = "99";
            this.mskEdad.Name = "mskEdad";
            this.mskEdad.Size = new System.Drawing.Size(100, 20);
            this.mskEdad.TabIndex = 5;
            this.mskEdad.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskEdad_MaskInputRejected);
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(155, 172);
            this.mskTelefono.Mask = "999999999";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(100, 20);
            this.mskTelefono.TabIndex = 4;
            this.mskTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskTelefono_MaskInputRejected);
            // 
            // frmRegistroDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 316);
            this.Controls.Add(this.mskTelefono);
            this.Controls.Add(this.mskEdad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmdRegistrar);
            this.Controls.Add(this.txtCodigoDepor);
            this.Controls.Add(this.lstDeporte);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblDeporte);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigoDepor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroDeportista";
            this.Text = "Registro Deportista";
            this.Load += new System.EventHandler(this.frmRegistroDeportista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoDepor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox lstDeporte;
        private System.Windows.Forms.TextBox txtCodigoDepor;
        private System.Windows.Forms.Button cmdRegistrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox mskEdad;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
    }
}