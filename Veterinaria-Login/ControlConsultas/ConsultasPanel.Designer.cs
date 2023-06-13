namespace Veterinaria_Login.ControlConsultas
{
    partial class ConsultasPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasPanel));
            this.txtDniDueño = new Guna.UI.WinForms.GunaTextBox();
            this.txtMotivo = new Guna.UI.WinForms.GunaTextBox();
            this.txtObservacion = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtMascota = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.lblTime = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PictureConsultas = new Guna.UI.WinForms.GunaPictureBox();
            this.lblDate = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureConsultas)).BeginInit();
            this.SuspendLayout();
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
            this.txtDniDueño.Location = new System.Drawing.Point(13, 38);
            this.txtDniDueño.Name = "txtDniDueño";
            this.txtDniDueño.PasswordChar = '\0';
            this.txtDniDueño.Size = new System.Drawing.Size(200, 30);
            this.txtDniDueño.TabIndex = 0;
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
            this.txtMotivo.Location = new System.Drawing.Point(13, 120);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PasswordChar = '\0';
            this.txtMotivo.Size = new System.Drawing.Size(200, 30);
            this.txtMotivo.TabIndex = 3;
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
            this.txtObservacion.Location = new System.Drawing.Point(325, 120);
            this.txtObservacion.MultiLine = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.Size = new System.Drawing.Size(200, 197);
            this.txtObservacion.TabIndex = 4;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(10, 20);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(63, 15);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Dni Dueño";
            // 
            // txtMascota
            // 
            this.txtMascota.BaseColor = System.Drawing.Color.White;
            this.txtMascota.BorderColor = System.Drawing.Color.Silver;
            this.txtMascota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMascota.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMascota.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMascota.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMascota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMascota.Location = new System.Drawing.Point(325, 38);
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.PasswordChar = '\0';
            this.txtMascota.Size = new System.Drawing.Size(200, 30);
            this.txtMascota.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(322, 20);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(52, 15);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Mascota";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(10, 102);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(45, 15);
            this.gunaLabel3.TabIndex = 12;
            this.gunaLabel3.Text = "Motivo";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(322, 102);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(73, 15);
            this.gunaLabel4.TabIndex = 13;
            this.gunaLabel4.Text = "Observación";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTime.Location = new System.Drawing.Point(10, 192);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 15);
            this.lblTime.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PictureConsultas
            // 
            this.PictureConsultas.BaseColor = System.Drawing.Color.White;
            this.PictureConsultas.Image = ((System.Drawing.Image)(resources.GetObject("PictureConsultas.Image")));
            this.PictureConsultas.Location = new System.Drawing.Point(19, 263);
            this.PictureConsultas.Name = "PictureConsultas";
            this.PictureConsultas.Size = new System.Drawing.Size(54, 54);
            this.PictureConsultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureConsultas.TabIndex = 15;
            this.PictureConsultas.TabStop = false;
            this.PictureConsultas.Click += new System.EventHandler(this.PictureConsultas_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.Location = new System.Drawing.Point(16, 206);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 15);
            this.lblDate.TabIndex = 16;
            // 
            // ConsultasPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(221)))));
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.PictureConsultas);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtMascota);
            this.Controls.Add(this.txtDniDueño);
            this.Name = "ConsultasPanel";
            this.Size = new System.Drawing.Size(650, 410);
            ((System.ComponentModel.ISupportInitialize)(this.PictureConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtDniDueño;
        private Guna.UI.WinForms.GunaTextBox txtMotivo;
        private Guna.UI.WinForms.GunaTextBox txtObservacion;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtMascota;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaPictureBox PictureConsultas;
        private Guna.UI.WinForms.GunaLabel lblDate;
    }
}
