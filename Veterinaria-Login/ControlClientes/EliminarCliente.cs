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

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar al cliente y todos los registros relacionados?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                    {
                        conn.Open();

                        string deleteMascotasQuery = "DELETE FROM Mascotas WHERE DniCliente = @dni";
                        using (SqlCommand deleteMascotasCommand = new SqlCommand(deleteMascotasQuery, conn))
                        {
                            deleteMascotasCommand.Parameters.AddWithValue("@dni", dni);
                            deleteMascotasCommand.ExecuteNonQuery();
                        }

                        string deleteConsultasQuery = "DELETE FROM Consultas WHERE DniCliente = @dni";
                        using (SqlCommand deleteConsultasCommand = new SqlCommand(deleteConsultasQuery, conn))
                        {
                            deleteConsultasCommand.Parameters.AddWithValue("@dni", dni);
                            deleteConsultasCommand.ExecuteNonQuery();
                        }


                        string deleteTratamientosQuery = "DELETE FROM Tratamientos WHERE DniDueñoMascota = @dni";
                        using (SqlCommand deleteTratamientosCommand = new SqlCommand(deleteTratamientosQuery, conn))
                        {
                            deleteTratamientosCommand.Parameters.AddWithValue("@dni", dni);
                            deleteTratamientosCommand.ExecuteNonQuery();
                        }


                        string deleteClientesQuery = "DELETE FROM Clientes WHERE Dni = @dni";
                        using (SqlCommand deleteClientesCommand = new SqlCommand(deleteClientesQuery, conn))
                        {
                            deleteClientesCommand.Parameters.AddWithValue("@dni", dni);

                            int rowsAffected = deleteClientesCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente y registros relacionados eliminados correctamente.");
                                DelCliente.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningun Cliente con el DNI especificado.");
                                DelCliente.Text = "";
                            }
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
