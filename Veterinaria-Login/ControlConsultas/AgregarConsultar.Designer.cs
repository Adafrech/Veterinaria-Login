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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarConsultas));
            this.PictureConsultas = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtObservacion = new Guna.UI.WinForms.GunaTextBox();
            this.txtMotivo = new Guna.UI.WinForms.GunaTextBox();
            this.txtMascota = new Guna.UI.WinForms.GunaTextBox();
            this.txtDniDueño = new Guna.UI.WinForms.GunaTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureConsultas
            // 
            this.PictureConsultas.BaseColor = System.Drawing.Color.White;
            this.PictureConsultas.Image = ((System.Drawing.Image)(resources.GetObject("PictureConsultas.Image")));
            this.PictureConsultas.Location = new System.Drawing.Point(58, 434);
            this.PictureConsultas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureConsultas.Name = "PictureConsultas";
            this.PictureConsultas.Size = new System.Drawing.Size(81, 83);
            this.PictureConsultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureConsultas.TabIndex = 26;
            this.PictureConsultas.TabStop = false;
            this.PictureConsultas.Click += new System.EventHandler(this.PictureConsultas_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(510, 186);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(111, 25);
            this.gunaLabel4.TabIndex = 24;
            this.gunaLabel4.Text = "Observación";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(42, 186);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(69, 25);
            this.gunaLabel3.TabIndex = 23;
            this.gunaLabel3.Text = "Motivo";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(510, 60);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(79, 25);
            this.gunaLabel2.TabIndex = 22;
            this.gunaLabel2.Text = "Mascota";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(42, 60);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(97, 25);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Dni Dueño";
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
            this.txtObservacion.Location = new System.Drawing.Point(514, 214);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservacion.MultiLine = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.Size = new System.Drawing.Size(300, 303);
            this.txtObservacion.TabIndex = 20;
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
            this.txtMotivo.Location = new System.Drawing.Point(46, 214);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PasswordChar = '\0';
            this.txtMotivo.Size = new System.Drawing.Size(300, 52);
            this.txtMotivo.TabIndex = 19;
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
            this.txtMascota.Location = new System.Drawing.Point(514, 88);
            this.txtMascota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMascota.Name = "txtMascota";
            this.txtMascota.PasswordChar = '\0';
            this.txtMascota.Size = new System.Drawing.Size(300, 52);
            this.txtMascota.TabIndex = 18;
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
            this.txtDniDueño.Location = new System.Drawing.Point(46, 88);
            this.txtDniDueño.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDniDueño.Name = "txtDniDueño";
            this.txtDniDueño.PasswordChar = '\0';
            this.txtDniDueño.Size = new System.Drawing.Size(300, 52);
            this.txtDniDueño.TabIndex = 17;
            // 
            // AgregarConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PictureConsultas);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtMascota);
            this.Controls.Add(this.txtDniDueño);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgregarConsultas";
            this.Size = new System.Drawing.Size(975, 631);
            ((System.ComponentModel.ISupportInitialize)(this.PictureConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaPictureBox PictureConsultas;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtObservacion;
        private Guna.UI.WinForms.GunaTextBox txtMotivo;
        private Guna.UI.WinForms.GunaTextBox txtMascota;
        private Guna.UI.WinForms.GunaTextBox txtDniDueño;
        private System.Windows.Forms.Timer timer1;
    }
}
