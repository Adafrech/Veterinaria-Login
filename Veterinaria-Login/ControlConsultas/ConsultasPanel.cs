using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlConsultas
{
    public partial class ConsultasPanel : UserControl
    {
        string connectionString = "Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True";
        public ConsultasPanel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime fechaActual = DateTime.Now;
            TimeSpan horaActual = fechaActual.TimeOfDay;
        }

        private void PictureConsultas_Click(object sender, EventArgs e)
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
                            return;
                        }
                    }

                    // Verificar si existe el nombre de mascota a cargo del DNI en la tabla Mascotas
                    string sqlCheckMascota = "SELECT COUNT(*) FROM Mascotas WHERE Nombre = @Nombre AND DniCliente = @dni";
                    bool cancelarConsulta = false;

                    using (SqlCommand command = new SqlCommand(sqlCheckMascota, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtMascota.Text);
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
                        string sqlInsertConsulta = "INSERT INTO Consultas (Motivo, Observaciones, DniCliente, Fecha, Hora, MascotaConsul) VALUES (@motivo, @observacion, @dnicliente, @fecha, @hora, @mascotaconsul)";
                        using (SqlCommand command = new SqlCommand(sqlInsertConsulta, connection))
                        {

                            DateTime fechaActual = DateTime.Now;
                            TimeSpan horaActual = fechaActual.TimeOfDay;

                            command.Parameters.AddWithValue("@motivo", txtMotivo.Text);
                            command.Parameters.AddWithValue("@observacion", txtObservacion.Text);
                            command.Parameters.AddWithValue("@dnicliente", txtDniDueño.Text);
                            command.Parameters.AddWithValue("@fecha", SqlDbType.Date).Value = fechaActual.Date;
                            command.Parameters.AddWithValue("@hora", SqlDbType.Time).Value = horaActual;
                            command.Parameters.AddWithValue("@mascotaconsul", txtMascota.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Datos insertados correctamente");
                        }
                    }



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar los datos: " + ex.Message);
            }

        }
    }
}

