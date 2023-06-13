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

            // Buscar el animal por el DNI
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
                        // Si no se encontró el animal, mostrar un mensaje de error
                        MessageBox.Show("No se encontró un animal con el DNI especificado.", "Animal no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el animal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}