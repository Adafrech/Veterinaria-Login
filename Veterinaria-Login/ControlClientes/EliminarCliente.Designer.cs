namespace Veterinaria_Login
{
    partial class EliminarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarCliente));
            this.DelCliente = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.PictureReturnCliente = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureReturnCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // DelCliente
            // 
            this.DelCliente.BaseColor = System.Drawing.Color.White;
            this.DelCliente.BorderColor = System.Drawing.Color.Silver;
            this.DelCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DelCliente.FocusedBaseColor = System.Drawing.Color.White;
            this.DelCliente.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DelCliente.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.DelCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DelCliente.Location = new System.Drawing.Point(28, 75);
            this.DelCliente.Name = "DelCliente";
            this.DelCliente.PasswordChar = '\0';
            this.DelCliente.Size = new System.Drawing.Size(186, 34);
            this.DelCliente.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(94)))));
            this.gunaLabel1.Location = new System.Drawing.Point(25, 55);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(81, 17);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Inserte DNI ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.AnimationHoverSpeed = 0.07F;
            this.btnEliminar.AnimationSpeed = 0.03F;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.Black;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(28, 330);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 15;
            this.btnEliminar.Size = new System.Drawing.Size(176, 36);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // PictureReturnCliente
            // 
            this.PictureReturnCliente.BaseColor = System.Drawing.Color.White;
            this.PictureReturnCliente.Image = ((System.Drawing.Image)(resources.GetObject("PictureReturnCliente.Image")));
            this.PictureReturnCliente.Location = new System.Drawing.Point(565, 330);
            this.PictureReturnCliente.Name = "PictureReturnCliente";
            this.PictureReturnCliente.Size = new System.Drawing.Size(60, 60);
            this.PictureReturnCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureReturnCliente.TabIndex = 25;
            this.PictureReturnCliente.TabStop = false;
            this.PictureReturnCliente.Click += new System.EventHandler(this.PictureReturnCliente_Click);
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PictureReturnCliente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.DelCliente);
            this.Name = "EliminarCliente";
            this.Size = new System.Drawing.Size(650, 410);
            ((System.ComponentModel.ISupportInitialize)(this.PictureReturnCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox DelCliente;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaPictureBox PictureReturnCliente;
    }
}
