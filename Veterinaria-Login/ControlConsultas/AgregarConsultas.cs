using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlConsultas
{
    public partial class AgregarConsultas : UserControl
    {
        string connectionString = "Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True";
        public AgregarConsultas()
        {
            InitializeComponent();
        }

        private void PictureConsultas_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlCheckDNI = "SELECT COUNT(*) FROM Clientes WHERE Dni = @dni";
                    using (SqlCommand command = new SqlCommand(sqlCheckDNI, connection))
                    {
                        command.Parameters.AddWithValue("@dni", txtDniDueño.Text);
                        int count = (int)command.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("El DNI no existe en la tabla Clientes. La consulta será cancelada.");
                            txtDniDueño.Text = "";
                            return;
                        }
                    }

                    // Verificar si existe el nombre de mascota a cargo del DNI en la tabla Mascotas
                    string sqlCheckMascota = "SELECT COUNT(*) FROM Mascotas WHERE Nombre = @Nombre AND DniCliente = @dni";
                    bool cancelarConsulta = false;

                    using (SqlCommand command = new SqlCommand(sqlCheckMascota, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", comboAnimal.Text);
                        command.Parameters.AddWithValue("@dni", txtDniDueño.Text);
                        int count = (int)command.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("La mascota no está asociada al DNI en la tabla Mascotas. La consulta será cancelada.");
                            cancelarConsulta = true;


                        }

                    }
                    if (!cancelarConsulta)
                    {
                        string sqlInsertConsulta = "INSERT INTO Consultas (Motivo, Observaciones, DniCliente, Fecha, MascotaConsul) VALUES (@motivo, @observacion, @dnicliente, @fecha, @mascotaconsul)";
                        using (SqlCommand command = new SqlCommand(sqlInsertConsulta, connection))
                        {

                            DateTime fechaActual = DateTime.Now;


                            command.Parameters.AddWithValue("@motivo", txtMotivo.Text);
                            command.Parameters.AddWithValue("@observacion", txtObservacion.Text);
                            command.Parameters.AddWithValue("@dnicliente", txtDniDueño.Text);
                            command.Parameters.AddWithValue("@fecha", SqlDbType.Date).Value = fechaActual.Date;
                            command.Parameters.AddWithValue("@mascotaconsul", comboAnimal.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Datos insertados correctamente");
                            LimpiarCampos();
                        }
                    }



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDniDueño.Text;
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

        public void LimpiarCampos()
        {
            txtDniDueño.Text = "";
            comboAnimal.SelectedIndex = -1;
            comboAnimal.Items.Clear();
            txtMotivo.Text = "";
            txtObservacion.Text = "";

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
