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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;

            string selectQuery = "SELECT Nombre, Sexo, Raza, FechaNacimiento, Especie FROM Mascotas WHERE DniCliente = @dni";
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
            {
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@dni", dni);

                try
                {
                    connection.Open();
                    SqlDataReader reader = selectCommand.ExecuteReader();

                    if (reader.Read())
                    {

                        string nombreMascota = reader["Nombre"].ToString();
                        txtSexo.Text = reader["Sexo"].ToString();
                        txtRaza.Text = reader["Raza"].ToString();
                        fechadate.Value = Convert.ToDateTime(reader["FechaNacimiento"]);
                        comboEspecie.Text = reader["Especie"].ToString();

                        comboAnimal.Items.Add(nombreMascota);

                    }
                    else
                    {

                        MessageBox.Show("No se encontró un animal con el DNI especificado.", "Animal no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el animal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string actnombremascota = nuevoNombre.Text;
            string actespecie = comboEspecie.SelectedIndex.ToString();
            string actsexo = txtSexo.Text;
            string actraza = txtRaza.Text;
            DateTime actfecha = fechadate.Value;

            if (actnombremascota.Length > 0 && actespecie.Length > 0 && actsexo.Length > 0 && actraza.Length > 0 && actfecha > DateTime.MinValue)
            {
                string query = "UPDATE Mascotas SET Nombre = @nombreMascota, Sexo = @sexo, Raza = @raza, FechaNacimiento = @fechanac WHERE DniCliente = @dni";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombreMascota", actnombremascota);
                        command.Parameters.AddWithValue("@sexo", actsexo);
                        command.Parameters.AddWithValue("@raza", actraza);
                        command.Parameters.AddWithValue("@fechanac", actfecha);
                        command.Parameters.AddWithValue("@dni", dni);

                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Actualizados correctamente");
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar los datos del cliente");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben contener al menos un caracter para actualizar los datos del cliente");
                LimpiarCampos();
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
    }
}