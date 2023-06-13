namespace Veterinaria_Login
{
    partial class PanelControlCliente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelControlCliente));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.x = new Guna.UI.WinForms.GunaPictureBox();
            this.DelCliente = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.PictureQuit = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.PictureEdit = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(30, 30);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.gunaLabel1.Location = new System.Drawing.Point(48, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(66, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Clientes ";
            // 
            // x
            // 
            this.x.BaseColor = System.Drawing.Color.White;
            this.x.Image = ((System.Drawing.Image)(resources.GetObject("x.Image")));
            this.x.Location = new System.Drawing.Point(44, 77);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(75, 75);
            this.x.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.x.TabIndex = 2;
            this.x.TabStop = false;
            this.x.Click += new System.EventHandler(this.AddCliente_Click);
            // 
            // DelCliente
            // 
            this.DelCliente.BaseColor = System.Drawing.Color.White;
            this.DelCliente.Image = ((System.Drawing.Image)(resources.GetObject("DelCliente.Image")));
            this.DelCliente.Location = new System.Drawing.Point(244, 77);
            this.DelCliente.Name = "DelCliente";
            this.DelCliente.Size = new System.Drawing.Size(75, 75);
            this.DelCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DelCliente.TabIndex = 3;
            this.DelCliente.TabStop = false;
            this.DelCliente.Click += new System.EventHandler(this.DelCliente_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.gunaLabel2.Location = new System.Drawing.Point(224, 155);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(116, 20);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Eliminar Cliente";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(94)))));
            this.gunaLabel3.Location = new System.Drawing.Point(30, 155);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(116, 20);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Agregar Cliente";
            // 
            // PictureQuit
            // 
            this.PictureQuit.BaseColor = System.Drawing.Color.White;
            this.PictureQuit.Image = ((System.Drawing.Image)(resources.GetObject("PictureQuit.Image")));
            this.PictureQuit.Location = new System.Drawing.Point(444, 77);
            this.PictureQuit.Name = "PictureQuit";
            this.PictureQuit.Size = new System.Drawing.Size(75, 75);
            this.PictureQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureQuit.TabIndex = 6;
            this.PictureQuit.TabStop = false;
            this.PictureQuit.Click += new System.EventHandler(this.PictureQuit_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.gunaLabel4.Location = new System.Drawing.Point(460, 155);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(39, 20);
            this.gunaLabel4.TabIndex = 7;
            this.gunaLabel4.Text = "Salir";
            // 
            // PictureEdit
            // 
            this.PictureEdit.BaseColor = System.Drawing.Color.White;
            this.PictureEdit.Image = ((System.Drawing.Image)(resources.GetObject("PictureEdit.Image")));
            this.PictureEdit.Location = new System.Drawing.Point(44, 222);
            this.PictureEdit.Name = "PictureEdit";
            this.PictureEdit.Size = new System.Drawing.Size(75, 75);
            this.PictureEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureEdit.TabIndex = 8;
            this.PictureEdit.TabStop = false;
            this.PictureEdit.Click += new System.EventHandler(this.PictureEdit_Click);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(41, 317);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(77, 15);
            this.gunaLabel5.TabIndex = 9;
            this.gunaLabel5.Text = "Editar Cliente";
            // 
            // PanelControlCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.PictureEdit);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.PictureQuit);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.DelCliente);
            this.Controls.Add(this.x);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Name = "PanelControlCliente";
            this.Size = new System.Drawing.Size(650, 410);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox x;
        private Guna.UI.WinForms.GunaPictureBox DelCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaPictureBox PictureQuit;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaPictureBox PictureEdit;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
    }
}
