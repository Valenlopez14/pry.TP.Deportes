namespace pry.BaseDeDatos.LopezV
{
    partial class frmRegistroEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroEntrenador));
            this.cmdRegistrarEntr = new System.Windows.Forms.Button();
            this.txtCodigoEntr = new System.Windows.Forms.TextBox();
            this.lstDeporteEntr = new System.Windows.Forms.ComboBox();
            this.txtDireccionEntr = new System.Windows.Forms.TextBox();
            this.txtApellidoEntr = new System.Windows.Forms.TextBox();
            this.txtNombreEntr = new System.Windows.Forms.TextBox();
            this.lblProvinciaEntr = new System.Windows.Forms.Label();
            this.lblDireccionEntr = new System.Windows.Forms.Label();
            this.lblDeporteEntr = new System.Windows.Forms.Label();
            this.lblApellidoEntr = new System.Windows.Forms.Label();
            this.lblNombreEntr = new System.Windows.Forms.Label();
            this.lblCodigoEntr = new System.Windows.Forms.Label();
            this.lstProvinciaEntr = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdRegistrarEntr
            // 
            this.cmdRegistrarEntr.Location = new System.Drawing.Point(184, 264);
            this.cmdRegistrarEntr.Name = "cmdRegistrarEntr";
            this.cmdRegistrarEntr.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrarEntr.TabIndex = 30;
            this.cmdRegistrarEntr.Text = "Registrar";
            this.cmdRegistrarEntr.UseVisualStyleBackColor = true;
            this.cmdRegistrarEntr.Click += new System.EventHandler(this.cmdRegistrarEntr_Click);
            // 
            // txtCodigoEntr
            // 
            this.txtCodigoEntr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoEntr.Location = new System.Drawing.Point(155, 61);
            this.txtCodigoEntr.Name = "txtCodigoEntr";
            this.txtCodigoEntr.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEntr.TabIndex = 1;
            this.txtCodigoEntr.TextChanged += new System.EventHandler(this.txtCodigoEntr_TextChanged);
            // 
            // lstDeporteEntr
            // 
            this.lstDeporteEntr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporteEntr.FormattingEnabled = true;
            this.lstDeporteEntr.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL"});
            this.lstDeporteEntr.Location = new System.Drawing.Point(155, 217);
            this.lstDeporteEntr.Name = "lstDeporteEntr";
            this.lstDeporteEntr.Size = new System.Drawing.Size(100, 21);
            this.lstDeporteEntr.TabIndex = 28;
            this.lstDeporteEntr.SelectedIndexChanged += new System.EventHandler(this.lstDeporteEntr_SelectedIndexChanged);
            // 
            // txtDireccionEntr
            // 
            this.txtDireccionEntr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccionEntr.Location = new System.Drawing.Point(155, 154);
            this.txtDireccionEntr.Name = "txtDireccionEntr";
            this.txtDireccionEntr.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionEntr.TabIndex = 25;
            this.txtDireccionEntr.TextChanged += new System.EventHandler(this.txtDireccionEntr_TextChanged);
            // 
            // txtApellidoEntr
            // 
            this.txtApellidoEntr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoEntr.Location = new System.Drawing.Point(155, 123);
            this.txtApellidoEntr.Name = "txtApellidoEntr";
            this.txtApellidoEntr.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoEntr.TabIndex = 24;
            this.txtApellidoEntr.TextChanged += new System.EventHandler(this.txtApellidoEntr_TextChanged);
            // 
            // txtNombreEntr
            // 
            this.txtNombreEntr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEntr.Location = new System.Drawing.Point(155, 92);
            this.txtNombreEntr.Name = "txtNombreEntr";
            this.txtNombreEntr.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEntr.TabIndex = 23;
            this.txtNombreEntr.TextChanged += new System.EventHandler(this.txtNombreEntr_TextChanged);
            // 
            // lblProvinciaEntr
            // 
            this.lblProvinciaEntr.AutoSize = true;
            this.lblProvinciaEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvinciaEntr.Location = new System.Drawing.Point(12, 185);
            this.lblProvinciaEntr.Name = "lblProvinciaEntr";
            this.lblProvinciaEntr.Size = new System.Drawing.Size(72, 20);
            this.lblProvinciaEntr.TabIndex = 22;
            this.lblProvinciaEntr.Text = "Provincia";
            // 
            // lblDireccionEntr
            // 
            this.lblDireccionEntr.AutoSize = true;
            this.lblDireccionEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionEntr.Location = new System.Drawing.Point(12, 154);
            this.lblDireccionEntr.Name = "lblDireccionEntr";
            this.lblDireccionEntr.Size = new System.Drawing.Size(75, 20);
            this.lblDireccionEntr.TabIndex = 20;
            this.lblDireccionEntr.Text = "Direccion";
            // 
            // lblDeporteEntr
            // 
            this.lblDeporteEntr.AutoSize = true;
            this.lblDeporteEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteEntr.Location = new System.Drawing.Point(10, 216);
            this.lblDeporteEntr.Name = "lblDeporteEntr";
            this.lblDeporteEntr.Size = new System.Drawing.Size(67, 20);
            this.lblDeporteEntr.TabIndex = 19;
            this.lblDeporteEntr.Text = "Deporte";
            // 
            // lblApellidoEntr
            // 
            this.lblApellidoEntr.AutoSize = true;
            this.lblApellidoEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEntr.Location = new System.Drawing.Point(12, 123);
            this.lblApellidoEntr.Name = "lblApellidoEntr";
            this.lblApellidoEntr.Size = new System.Drawing.Size(65, 20);
            this.lblApellidoEntr.TabIndex = 18;
            this.lblApellidoEntr.Text = "Apellido";
            // 
            // lblNombreEntr
            // 
            this.lblNombreEntr.AutoSize = true;
            this.lblNombreEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEntr.Location = new System.Drawing.Point(12, 92);
            this.lblNombreEntr.Name = "lblNombreEntr";
            this.lblNombreEntr.Size = new System.Drawing.Size(65, 20);
            this.lblNombreEntr.TabIndex = 17;
            this.lblNombreEntr.Text = "Nombre";
            // 
            // lblCodigoEntr
            // 
            this.lblCodigoEntr.AutoSize = true;
            this.lblCodigoEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEntr.Location = new System.Drawing.Point(12, 61);
            this.lblCodigoEntr.Name = "lblCodigoEntr";
            this.lblCodigoEntr.Size = new System.Drawing.Size(143, 20);
            this.lblCodigoEntr.TabIndex = 16;
            this.lblCodigoEntr.Text = "Codigo Entrenador";
            // 
            // lstProvinciaEntr
            // 
            this.lstProvinciaEntr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProvinciaEntr.FormattingEnabled = true;
            this.lstProvinciaEntr.Items.AddRange(new object[] {
            "BOLIVAR",
            "CAÑAR",
            "CHIMBORAZO",
            "PICHINCHA"});
            this.lstProvinciaEntr.Location = new System.Drawing.Point(155, 185);
            this.lstProvinciaEntr.Name = "lstProvinciaEntr";
            this.lstProvinciaEntr.Size = new System.Drawing.Size(100, 21);
            this.lstProvinciaEntr.TabIndex = 5;
            this.lstProvinciaEntr.SelectedIndexChanged += new System.EventHandler(this.lstProvinciaEntr_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(15, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(241, 16);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "REGISTRO DE ENTRENADORES";
            // 
            // frmRegistroEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 308);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstProvinciaEntr);
            this.Controls.Add(this.cmdRegistrarEntr);
            this.Controls.Add(this.txtCodigoEntr);
            this.Controls.Add(this.lstDeporteEntr);
            this.Controls.Add(this.txtDireccionEntr);
            this.Controls.Add(this.txtApellidoEntr);
            this.Controls.Add(this.txtNombreEntr);
            this.Controls.Add(this.lblProvinciaEntr);
            this.Controls.Add(this.lblDireccionEntr);
            this.Controls.Add(this.lblDeporteEntr);
            this.Controls.Add(this.lblApellidoEntr);
            this.Controls.Add(this.lblNombreEntr);
            this.Controls.Add(this.lblCodigoEntr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistroEntrenador";
            this.Text = "frmRegistroEntrenador";
            this.Load += new System.EventHandler(this.frmRegistroEntrenador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRegistrarEntr;
        private System.Windows.Forms.TextBox txtCodigoEntr;
        private System.Windows.Forms.ComboBox lstDeporteEntr;
        private System.Windows.Forms.TextBox txtDireccionEntr;
        private System.Windows.Forms.TextBox txtApellidoEntr;
        private System.Windows.Forms.TextBox txtNombreEntr;
        private System.Windows.Forms.Label lblProvinciaEntr;
        private System.Windows.Forms.Label lblDireccionEntr;
        private System.Windows.Forms.Label lblDeporteEntr;
        private System.Windows.Forms.Label lblApellidoEntr;
        private System.Windows.Forms.Label lblNombreEntr;
        private System.Windows.Forms.Label lblCodigoEntr;
        private System.Windows.Forms.ComboBox lstProvinciaEntr;
        private System.Windows.Forms.Label lblTitulo;
    }
}