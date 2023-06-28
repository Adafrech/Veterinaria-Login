namespace Veterinaria_Login.ControlConsultas
{
    partial class AgregarConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarConsultas));
            this.PictureConsultas = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtMotivo = new Guna.UI.WinForms.GunaTextBox();
            this.txtDniDueño = new Guna.UI.WinForms.GunaTextBox();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.PicReturn = new Guna.UI.WinForms.GunaPictureBox();
            this.txtObservacion = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.comboAnimal = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureConsultas
            // 
            this.PictureConsultas.BaseColor = System.Drawing.Color.White;
            this.PictureConsultas.Image = ((System.Drawing.Image)(resources.GetObject("PictureConsultas.Image")));
            this.PictureConsultas.Location = new System.Drawing.Point(395, 314);
            this.PictureConsultas.Name = "PictureConsultas";
            this.PictureConsultas.Size = new System.Drawing.Size(54, 54);
            this.PictureConsultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureConsultas.TabIndex = 26;
            this.PictureConsultas.TabStop = false;
            this.PictureConsultas.Click += new System.EventHandler(this.PictureConsultas_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(94)))));
            this.gunaLabel4.Location = new System.Drawing.Point(330, 16);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(84, 17);
            this.gunaLabel4.TabIndex = 24;
            this.gunaLabel4.Text = "Observación";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(94)))));
            this.gunaLabel3.Location = new System.Drawing.Point(26, 196);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(51, 17);
            this.gunaLabel3.TabIndex = 23;
            this.gunaLabel3.Text = "Motivo";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(94)))));
            this.gunaLabel2.Location = new System.Drawing.Point(27, 106);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(59, 17);
            this.gunaLabel2.TabIndex = 22;
            this.gunaLabel2.Text = "Mascota";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(94)))));
            this.gunaLabel1.Location = new System.Drawing.Point(27, 16);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(72, 17);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Dni Dueño";
            // 
            // txtMotivo
            // 
            this.txtMotivo.BaseColor = System.Drawing.Color.White;
            this.txtMotivo.BorderColor = System.Drawing.Color.Silver;
            this.txtMotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotivo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMotivo.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMotivo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMotivo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMotivo.Location = new System.Drawing.Point(30, 219);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PasswordChar = '\0';
            this.txtMotivo.Size = new System.Drawing.Size(160, 30);
            this.txtMotivo.TabIndex = 19;
            // 
            // txtDniDueño
            // 
            this.txtDniDueño.BaseColor = System.Drawing.Color.White;
            this.txtDniDueño.BorderColor = System.Drawing.Color.Silver;
            this.txtDniDueño.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDniDueño.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDniDueño.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDniDueño.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDniDueño.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDniDueño.Location = new System.Drawing.Point(31, 39);
            this.txtDniDueño.Name = "txtDniDueño";
            this.txtDniDueño.PasswordChar = '\0';
            this.txtDniDueño.Size = new System.Drawing.Size(160, 30);
            this.txtDniDueño.TabIndex = 17;
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(334, 185);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(220, 35);
            this.gunaDateTimePicker1.TabIndex = 27;
            this.gunaDateTimePicker1.Text = "miércoles, 21 de junio de 2023";
            this.gunaDateTimePicker1.Value = new System.DateTime(2023, 6, 21, 15, 35, 29, 970);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(95)))), ((int)(((byte)(94)))));
            this.gunaLabel5.Location = new System.Drawing.Point(330, 162);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(119, 17);
            this.gunaLabel5.TabIndex = 28;
            this.gunaLabel5.Text = "Fecha de Consulta";
            // 
            // PicReturn
            // 
            this.PicReturn.BaseColor = System.Drawing.Color.White;
            this.PicReturn.Image = ((System.Drawing.Image)(resources.GetObject("PicReturn.Image")));
            this.PicReturn.Location = new System.Drawing.Point(531, 314);
            this.PicReturn.Name = "PicReturn";
            this.PicReturn.Size = new System.Drawing.Size(54, 54);
            this.PicReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicReturn.TabIndex = 29;
            this.PicReturn.TabStop = false;
            this.PicReturn.Click += new System.EventHandler(this.PicReturn_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.BaseColor = System.Drawing.Color.White;
            this.txtObservacion.BorderColor = System.Drawing.Color.Silver;
            this.txtObservacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacion.FocusedBaseColor = System.Drawing.Color.White;
            this.txtObservacion.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtObservacion.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtObservacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservacion.Location = new System.Drawing.Point(334, 39);
            this.txtObservacion.MultiLine = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.Size = new System.Drawing.Size(200, 120);
            this.txtObservacion.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AnimationHoverSpeed = 0.07F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.Location = new System.Drawing.Point(31, 298);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Radius = 15;
            this.btnBuscar.Size = new System.Drawing.Size(160, 42);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.comboAnimal.Location = new System.Drawing.Point(28, 126);
            this.comboAnimal.Name = "comboAnimal";
            this.comboAnimal.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboAnimal.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboAnimal.Size = new System.Drawing.Size(162, 26);
            this.comboAnimal.TabIndex = 32;
            // 
            // AgregarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboAnimal);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.PicReturn);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaDateTimePicker1);
            this.Controls.Add(this.PictureConsultas);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtDniDueño);
            this.Name = "AgregarConsultas";
            this.Size = new System.Drawing.Size(650, 410);
            ((System.ComponentModel.ISupportInitialize)(this.PictureConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox PictureConsultas;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtMotivo;
        private Guna.UI.WinForms.GunaTextBox txtDniDueño;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaPictureBox PicReturn;
        private Guna.UI.WinForms.GunaTextBox txtObservacion;
        private Guna.UI.WinForms.GunaButton btnBuscar;
        private Guna.UI.WinForms.GunaComboBox comboAnimal;
    }
}
