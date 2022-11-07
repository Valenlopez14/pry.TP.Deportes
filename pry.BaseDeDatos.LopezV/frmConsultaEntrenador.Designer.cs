namespace pry.BaseDeDatos.LopezV
{
    partial class frmConsultaEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEntrenador));
            this.GrillaConsultaEntr = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaConsultaEntr)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaConsultaEntr
            // 
            this.GrillaConsultaEntr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaConsultaEntr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GrillaConsultaEntr.Location = new System.Drawing.Point(0, 0);
            this.GrillaConsultaEntr.Name = "GrillaConsultaEntr";
            this.GrillaConsultaEntr.Size = new System.Drawing.Size(538, 335);
            this.GrillaConsultaEntr.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Direccion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Edad";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Deporte";
            this.Column5.Name = "Column5";
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(451, 353);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 23);
            this.cmdListar.TabIndex = 2;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // frmConsultaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 397);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.GrillaConsultaEntr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaEntrenador";
            this.Text = "Consulta Entrenador";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaConsultaEntr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaConsultaEntr;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}