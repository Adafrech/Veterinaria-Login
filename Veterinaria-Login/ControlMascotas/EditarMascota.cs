using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlMascotas
{
    public partial class EditarMascota : UserControl
    {
        public EditarMascota()
        {
            InitializeComponent();
            comboAnimal.SelectedIndexChanged += comboAnimal_SelectedIndexChanged;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
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
            string dni = txtDni.Text;
            string nombreMascotaActual = comboAnimal.Text; // Obtén el nombre de la mascota actual seleccionada en el ComboBox
            string actnombremascota = nuevoNombre.Text;
            string actespecie = comboEspecie.Text;
            string actsexo = txtSexo.Text;
            string actraza = txtRaza.Text;
            DateTime actfecha = fechadate.Value;

            if (actnombremascota.Length > 0 && actespecie.Length > 0 && actsexo.Length > 0 && actraza.Length > 0 && actfecha > DateTime.MinValue)
            {
                string query = "UPDATE Mascotas SET Nombre = @nombreMascota, Sexo = @sexo, Raza = @raza, FechaNacimiento = @fechanac, Especie = @especie WHERE DniCliente = @dni AND Nombre = @nombreMascotaActual";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombreMascota", actnombremascota);
                        command.Parameters.AddWithValue("@sexo", actsexo);
                        command.Parameters.AddWithValue("@raza", actraza);
                        command.Parameters.AddWithValue("@fechanac", actfecha);
                        command.Parameters.AddWithValue("@especie", actespecie);
                        command.Parameters.AddWithValue("@dni", dni);
                        command.Parameters.AddWithValue("@nombreMascotaActual", nombreMascotaActual);

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
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben contener al menos un caracter para actualizar los datos de la mascota");
                LimpiarCampos();
            }
        }

        private void comboAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAnimal.SelectedItem != null)
            {
                string nombreMascota = comboAnimal.SelectedItem.ToString();

                string selectQuery = "SELECT Sexo, Raza, FechaNacimiento, Especie FROM Mascotas WHERE Nombre = @nombreMascota";
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
                            txtSexo.Text = reader["Sexo"].ToString();
                            txtRaza.Text = reader["Raza"].ToString();
                            fechadate.Value = Convert.ToDateTime(reader["FechaNacimiento"]);
                            comboEspecie.Text = reader["Especie"].ToString();
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
            txtDni.Text = "";
            comboAnimal.SelectedIndex = -1;
            comboAnimal.Items.Clear();
            nuevoNombre.Text = "";
            comboEspecie.SelectedIndex = -1;
            txtSexo.Text = "";
            txtRaza.Text = "";
            fechadate.Value = DateTime.Today;

        }




        private void PicReturn_Click(object sender, EventArgs e)
        {
            PanelControlMascotas controlMascotas = new PanelControlMascotas();
            Control contenedor = this.Parent;
            contenedor.Controls.Remove(this);
            contenedor.Controls.Add(controlMascotas);
        }
    }
}