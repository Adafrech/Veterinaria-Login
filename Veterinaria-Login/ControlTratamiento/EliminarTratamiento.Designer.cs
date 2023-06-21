namespace Veterinaria_Login.ControlTratamiento
{
    partial class EliminarTratamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarTratamiento));
            this.btnEliminarTrat = new Guna.UI.WinForms.GunaButton();
            this.lblDni = new Guna.UI.WinForms.GunaLabel();
            this.txtDni = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // btnEliminarTrat
            // 
            this.btnEliminarTrat.AnimationHoverSpeed = 0.07F;
            this.btnEliminarTrat.AnimationSpeed = 0.03F;
            this.btnEliminarTrat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEliminarTrat.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarTrat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEliminarTrat.FocusedColor = System.Drawing.Color.Empty;
            this.btnEliminarTrat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEliminarTrat.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTrat.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTrat.Image")));
            this.btnEliminarTrat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEliminarTrat.Location = new System.Drawing.Point(348, 83);
            this.btnEliminarTrat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarTrat.Name = "btnEliminarTrat";
            this.btnEliminarTrat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEliminarTrat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEliminarTrat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEliminarTrat.OnHoverImage = null;
            this.btnEliminarTrat.OnPressedColor = System.Drawing.Color.Black;
            this.btnEliminarTrat.Size = new System.Drawing.Size(240, 65);
            this.btnEliminarTrat.TabIndex = 24;
            this.btnEliminarTrat.Text = "Buscar";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDni.Location = new System.Drawing.Point(45, 74);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(39, 25);
            this.lblDni.TabIndex = 23;
            this.lblDni.Text = "Dni";
            // 
            // txtDni
            // 
            this.txtDni.BaseColor = System.Drawing.Color.White;
            this.txtDni.BorderColor = System.Drawing.Color.Silver;
            this.txtDni.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDni.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDni.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDni.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDni.Location = new System.Drawing.Point(50, 102);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDni.Name = "txtDni";
            this.txtDni.PasswordChar = '\0';
            this.txtDni.Size = new System.Drawing.Size(240, 52);
            this.txtDni.TabIndex = 22;
            // 
            // EliminarTratamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminarTrat);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EliminarTratamiento";
            this.Size = new System.Drawing.Size(975, 631);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnEliminarTrat;
        private Guna.UI.WinForms.GunaLabel lblDni;
        private Guna.UI.WinForms.GunaTextBox txtDni;
    }
}
