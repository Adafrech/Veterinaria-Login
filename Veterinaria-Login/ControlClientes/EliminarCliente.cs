using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login
{
    public partial class EliminarCliente : UserControl
    {
        public EliminarCliente()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = DelCliente.Text.Trim();

                if (string.IsNullOrEmpty(dni))
                {
                    throw new Exception("Debe ingresar un DNI válido.");
                }

                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "DELETE FROM Clientes WHERE Dni = @dni";

                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@dni", dni);

                        int rowsAffected = comando.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Persona y registros relacionados eliminados correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna persona con el DNI especificado");
                            conn.Close();
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PictureReturnMascotas_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent;


            PanelControlCliente backmenu = new PanelControlCliente();

            contenedor.Controls.Remove(this);

            contenedor.Controls.Add(backmenu);
        }

        private void PictureReturnCliente_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent;


            PanelControlCliente backmenu = new PanelControlCliente();

            contenedor.Controls.Remove(this);

            contenedor.Controls.Add(backmenu);
        }
    }
}
