namespace pry.BaseDeDatos.LopezV
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrenadorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(322, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistasToolStripMenuItem1,
            this.entrenadoresToolStripMenuItem1});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // deportistasToolStripMenuItem1
            // 
            this.deportistasToolStripMenuItem1.Name = "deportistasToolStripMenuItem1";
            this.deportistasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deportistasToolStripMenuItem1.Text = "Deportistas";
            this.deportistasToolStripMenuItem1.Click += new System.EventHandler(this.deportistasToolStripMenuItem1_Click);
            // 
            // entrenadoresToolStripMenuItem1
            // 
            this.entrenadoresToolStripMenuItem1.Name = "entrenadoresToolStripMenuItem1";
            this.entrenadoresToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.entrenadoresToolStripMenuItem1.Text = "Entrenadores";
            this.entrenadoresToolStripMenuItem1.Click += new System.EventHandler(this.entrenadoresToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistasToolStripMenuItem,
            this.entrenadoresToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // deportistasToolStripMenuItem
            // 
            this.deportistasToolStripMenuItem.Name = "deportistasToolStripMenuItem";
            this.deportistasToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.deportistasToolStripMenuItem.Text = "Deportistas";
            this.deportistasToolStripMenuItem.Click += new System.EventHandler(this.deportistasToolStripMenuItem_Click);
            // 
            // entrenadoresToolStripMenuItem
            // 
            this.entrenadoresToolStripMenuItem.Name = "entrenadoresToolStripMenuItem";
            this.entrenadoresToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.entrenadoresToolStripMenuItem.Text = "Entrenadores";
            this.entrenadoresToolStripMenuItem.Click += new System.EventHandler(this.entrenadoresToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrenadorToolStripMenuItem,
            this.deportistaToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // entrenadorToolStripMenuItem
            // 
            this.entrenadorToolStripMenuItem.Name = "entrenadorToolStripMenuItem";
            this.entrenadorToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.entrenadorToolStripMenuItem.Text = "Entrenador";
            this.entrenadorToolStripMenuItem.Click += new System.EventHandler(this.entrenadorToolStripMenuItem_Click);
            // 
            // deportistaToolStripMenuItem
            // 
            this.deportistaToolStripMenuItem.Name = "deportistaToolStripMenuItem";
            this.deportistaToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.deportistaToolStripMenuItem.Text = "Deportista";
            this.deportistaToolStripMenuItem.Click += new System.EventHandler(this.deportistaToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrenadorToolStripMenuItem1,
            this.deportistaToolStripMenuItem1});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // entrenadorToolStripMenuItem1
            // 
            this.entrenadorToolStripMenuItem1.Name = "entrenadorToolStripMenuItem1";
            this.entrenadorToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.entrenadorToolStripMenuItem1.Text = "Entrenador";
            this.entrenadorToolStripMenuItem1.Click += new System.EventHandler(this.entrenadorToolStripMenuItem1_Click);
            // 
            // deportistaToolStripMenuItem1
            // 
            this.deportistaToolStripMenuItem1.Name = "deportistaToolStripMenuItem1";
            this.deportistaToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.deportistaToolStripMenuItem1.Text = "Deportista";
            this.deportistaToolStripMenuItem1.Click += new System.EventHandler(this.deportistaToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(12, 17);
            this.lblFecha.Text = "-";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(12, 17);
            this.lblEstado.Text = "-";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha,
            this.lblEstado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 166);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(322, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 162);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(322, 188);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entrenadoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrenadorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deportistaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

