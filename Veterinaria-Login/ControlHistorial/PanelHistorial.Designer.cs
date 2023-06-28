namespace Veterinaria_Login.Historial
{
    partial class PanelHistorial
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
            this.txtBuscar = new Guna.UI.WinForms.GunaTextBox();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.btnLimpiarHistorial = new Guna.UI.WinForms.GunaButton();
            this.Historial = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Historial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BaseColor = System.Drawing.Color.White;
            this.txtBuscar.BorderColor = System.Drawing.Color.Silver;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBuscar.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBuscar.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.Location = new System.Drawing.Point(36, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.Size = new System.Drawing.Size(160, 30);
            this.txtBuscar.TabIndex = 1;
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
            this.btnBuscar.Location = new System.Drawing.Point(225, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Radius = 15;
            this.btnBuscar.Size = new System.Drawing.Size(160, 42);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar DNI Cliente";
            this.btnBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnLimpiarHistorial
            // 
            this.btnLimpiarHistorial.AnimationHoverSpeed = 0.07F;
            this.btnLimpiarHistorial.AnimationSpeed = 0.03F;
            this.btnLimpiarHistorial.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarHistorial.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLimpiarHistorial.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarHistorial.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLimpiarHistorial.FocusedColor = System.Drawing.Color.Empty;
            this.btnLimpiarHistorial.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLimpiarHistorial.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarHistorial.Image = null;
            this.btnLimpiarHistorial.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLimpiarHistorial.Location = new System.Drawing.Point(406, 18);
            this.btnLimpiarHistorial.Name = "btnLimpiarHistorial";
            this.btnLimpiarHistorial.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLimpiarHistorial.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLimpiarHistorial.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLimpiarHistorial.OnHoverImage = null;
            this.btnLimpiarHistorial.OnPressedColor = System.Drawing.Color.Black;
            this.btnLimpiarHistorial.Radius = 15;
            this.btnLimpiarHistorial.Size = new System.Drawing.Size(160, 42);
            this.btnLimpiarHistorial.TabIndex = 4;
            this.btnLimpiarHistorial.Text = "Limpiar Historial";
            this.btnLimpiarHistorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLimpiarHistorial.Click += new System.EventHandler(this.btnLimpiarHistorial_Click);
            // 
            // Historial
            // 
            this.Historial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Historial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Historial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Historial.Location = new System.Drawing.Point(36, 83);
            this.Historial.MultiSelect = false;
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(568, 293);
            this.Historial.TabIndex = 3;
            this.Historial.TabStop = false;
            this.Historial.VirtualMode = true;
            // 
            // PanelHistorial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnLimpiarHistorial);
            this.Controls.Add(this.Historial);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelHistorial";
            this.Size = new System.Drawing.Size(650, 410);
            this.Load += new System.EventHandler(this.PanelHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Historial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtBuscar;
        private Guna.UI.WinForms.GunaButton btnBuscar;
        private Guna.UI.WinForms.GunaButton btnLimpiarHistorial;
        private System.Windows.Forms.DataGridView Historial;
    }
}
