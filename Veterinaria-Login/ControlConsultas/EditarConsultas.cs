using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlConsultas
{
    public partial class EditarConsultas : UserControl
    {
        public EditarConsultas()
        {
            InitializeComponent();
            comboAnimal.SelectedIndexChanged += comboAnimal_SelectedIndexChanged;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDniEdit.Text;
            comboAnimal.Items.Clear(); // Limpiar el ComboBox

            string selectQuery = "SELECT Nombre FROM Mascotas WHERE DniCliente = @dni";
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
            {
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@dni", dni);

                try
                {
                    connection.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        string nombreMascota = reader["Nombre"].ToString();
                        comboAnimal.Items.Add(nombreMascota); // Agregar solo el nombre al ComboBox
                    }

                    if (comboAnimal.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron mascotas con el DNI especificado.", "Mascotas no encontradas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar las mascotas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string dni = txtDniEdit.Text;
            string nombremascota = comboAnimal.Text;
            string motivoact = txtMotivoEdit.Text;
            string observacionact = txtObservacionEdit.Text;
            DateTime actfecha = timerFecha.Value;

            if (nombremascota.Length > 0 && motivoact.Length > 0 && observacionact.Length > 0 && actfecha > DateTime.MinValue)
            {
                string query = "UPDATE Consultas SET Motivo = @motivo, Observaciones = @observacion, Fecha = @fecha WHERE DniCliente = @dni AND MascotaConsul = @nombreMascota";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@motivo", motivoact);
                        command.Parameters.AddWithValue("@observacion", observacionact);
                        command.Parameters.AddWithValue("@fecha", actfecha);

                        command.Parameters.AddWithValue("@dni", dni);
                        command.Parameters.AddWithValue("@nombreMascota", nombremascota);

                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Actualizados correctamente");
                            LimpiarCampos();

                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar los datos de la mascota");
                            LimpiarCampos();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben contener al menos un caracter para actualizar los datos de la mascota");
            }
        }

        private void comboAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAnimal.SelectedItem != null)
            {
                string nombreMascota = comboAnimal.SelectedItem.ToString();

                string selectQuery = "SELECT Motivo, Observaciones, Fecha FROM Consultas WHERE MascotaConsul = @nombreMascota";
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@nombreMascota", nombreMascota);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = selectCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            txtMotivoEdit.Text = reader["Motivo"].ToString();
                            txtObservacionEdit.Text = reader["Observaciones"].ToString();
                            timerFecha.Value = Convert.ToDateTime(reader["Fecha"]);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos de la mascota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public void LimpiarCampos()
        {
            txtDniEdit.Text = "";
            comboAnimal.SelectedIndex = -1;
            comboAnimal.Items.Clear();
            txtMotivoEdit.Text = "";
            txtObservacionEdit.Text = "";
            timerFecha.Value = DateTime.Today;

        }

        private void PicReturn_Click(object sender, EventArgs e)
        {
            ConsultasPanel PCons = new ConsultasPanel();
            Control contenedor = this.Parent;
            contenedor.Controls.Remove(this);
            contenedor.Controls.Add(PCons);
        }
    }
}
