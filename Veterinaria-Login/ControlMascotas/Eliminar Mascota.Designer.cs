namespace Veterinaria_Login.ControlMascotas
{
    partial class EliminarMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarMascota));
            this.txtBuscarDni = new Guna.UI.WinForms.GunaTextBox();
            this.lblBusquedaDni = new Guna.UI.WinForms.GunaLabel();
            this.btnBuscar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEliminar = new Guna.UI.WinForms.GunaButton();
            this.comboAnimal = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarDni
            // 
            this.txtBuscarDni.BaseColor = System.Drawing.Color.White;
            this.txtBuscarDni.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscarDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarDni.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscarDni.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBuscarDni.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscarDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarDni.Location = new System.Drawing.Point(27, 53);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.PasswordChar = '\0';
            this.txtBuscarDni.Size = new System.Drawing.Size(160, 30);
            this.txtBuscarDni.TabIndex = 0;
            // 
            // lblBusquedaDni
            // 
            this.lblBusquedaDni.AutoSize = true;
            this.lblBusquedaDni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBusquedaDni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBusquedaDni.Location = new System.Drawing.Point(24, 33);
            this.lblBusquedaDni.Name = "lblBusquedaDni";
            this.lblBusquedaDni.Size = new System.Drawing.Size(120, 17);
            this.lblBusquedaDni.TabIndex = 2;
            this.lblBusquedaDni.Text = "Busqueda por DNI";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AnimationHoverSpeed = 0.07F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBuscar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuscar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.CheckedImage")));
            this.btnBuscar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBuscar.Location = new System.Drawing.Point(27, 165);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Radius = 15;
            this.btnBuscar.Size = new System.Drawing.Size(160, 42);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = null;
            this.btnEliminar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminar.Location = new System.Drawing.Point(294, 165);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminar.OnHoverImage = null;
            this.btnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminar.Radius = 15;
            this.btnEliminar.Size = new System.Drawing.Size(162, 42);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar ";
            this.btnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // comboAnimal
            // 
            this.comboAnimal.BackColor = System.Drawing.Color.Transparent;
            this.comboAnimal.BaseColor = System.Drawing.Color.White;
            this.comboAnimal.BorderColor = System.Drawing.Color.Silver;
            this.comboAnimal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnimal.FocusedColor = System.Drawing.Color.Empty;
            this.comboAnimal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboAnimal.ForeColor = System.Drawing.Color.Black;
            this.comboAnimal.FormattingEnabled = true;
            this.comboAnimal.Location = new System.Drawing.Point(294, 53);
            this.comboAnimal.Name = "comboAnimal";
            this.comboAnimal.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboAnimal.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboAnimal.Size = new System.Drawing.Size(162, 26);
            this.comboAnimal.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.Location = new System.Drawing.Point(293, 33);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(140, 17);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Animales en posesion";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(565, 330);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(60, 60);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 7;
            this.gunaPictureBox1.TabStop = false;
            // 
            // EliminarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.comboAnimal);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBusquedaDni);
            this.Controls.Add(this.txtBuscarDni);
            this.Name = "EliminarMascota";
            this.Size = new System.Drawing.Size(650, 410);
            this.Load += new System.EventHandler(this.EliminarMascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtBuscarDni;
        private Guna.UI.WinForms.GunaLabel lblBusquedaDni;
        private Guna.UI.WinForms.GunaAdvenceButton btnBuscar;
        private Guna.UI.WinForms.GunaButton btnEliminar;
        private Guna.UI.WinForms.GunaComboBox comboAnimal;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}
