using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlMascotas
{
    public partial class EliminarMascota : UserControl
    {
        public EliminarMascota()
        {
            InitializeComponent();
        }

        private void EliminarMascota_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    conn.Open();

                    string existsQuery = "SELECT COUNT(*) FROM Clientes WHERE Dni = @dniCliente";

                    using (SqlCommand existsCommand = new SqlCommand(existsQuery, conn))
                    {
                        existsCommand.Parameters.AddWithValue("@dniCliente", txtBuscarDni.Text);
                        int count = (int)existsCommand.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("El cliente no existe en la base de datos.");
                            return;
                        }
                    }

                    string query = "SELECT Nombre FROM Mascotas WHERE DniCliente = @dniCliente";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@dniCliente", txtBuscarDni.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            comboAnimal.Items.Clear();

                            while (reader.Read())
                            {
                                string nombreMascota = reader.GetString(0);
                                comboAnimal.Items.Add(nombreMascota);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la búsqueda de animales: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    connection.Open();

                    if (comboAnimal.SelectedItem == null)
                    {
                        MessageBox.Show("No se ha seleccionado ningún animal para eliminar.");
                        return;
                    }

                    string nombreMascotaSeleccionada = comboAnimal.SelectedItem.ToString();

                    string deleteQuery = "DELETE FROM Mascotas WHERE DniCliente = @dniCliente AND Nombre = @nombreMascota";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@dniCliente", txtBuscarDni.Text);
                        command.Parameters.AddWithValue("@nombreMascota", nombreMascotaSeleccionada);
                        command.ExecuteNonQuery();
                    }



                    MessageBox.Show("Mascota eliminada correctamente");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la eliminación de animales: " + ex.Message);
            }
        }

        public void LimpiarCampos()
        {
            txtBuscarDni.Text = string.Empty;


            comboAnimal.Items.Clear();

            //comboAnimal.SelectedIndex = -1;
        }

        private void picReturn_Click(object sender, EventArgs e)
        {
            PanelControlMascotas controlMascotas = new PanelControlMascotas();
            Control contenedor = this.Parent;
            contenedor.Controls.Remove(this);
            contenedor.Controls.Add(controlMascotas);
        }
    }
}
