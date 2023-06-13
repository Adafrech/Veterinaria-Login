using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlTratamiento
{
    public partial class Tratamiento : UserControl
    {
        string connectionString = "Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True";
        public Tratamiento()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlCheckDNI = "SELECT COUNT(*) FROM Clientes WHERE Dni = @dni";
                    using (SqlCommand command = new SqlCommand(sqlCheckDNI, connection))
                    {
                        command.Parameters.AddWithValue("@dni", txtDni.Text);
                        int count = (int)command.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("El DNI no existe en la tabla Clientes. El tratamiento será cancelado.");
                            return;
                        }
                    }

                    // Verificar si existe el nombre de mascota a cargo del DNI en la tabla Mascotas
                    string sqlCheckMascota = "SELECT COUNT(*) FROM Mascotas WHERE Nombre = @Nombre AND DniCliente = @dni";
                    bool cancelarConsulta = false;

                    using (SqlCommand command = new SqlCommand(sqlCheckMascota, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtMascota.Text);
                        command.Parameters.AddWithValue("@dni", txtDni.Text);
                        int count = (int)command.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("La mascota no está asociada al DNI en la tabla Mascotas. El Tratamiento será cancelado.");
                            cancelarConsulta = true;

                        }

                    }
                    if (!cancelarConsulta)
                    {
                        string sqlInsertTratamiento = "INSERT INTO Tratamientos (NombreTratamiento, Descripcion, Precio, DniDueñoMascota, MascotaTratada) VALUES (@nombretrat, @descripcion, @precio, @dnidueño, @mascotadueño)";
                        using (SqlCommand command = new SqlCommand(sqlInsertTratamiento, connection))
                        {

                            command.Parameters.AddWithValue("@nombretrat", txtNombreTratamiento.Text);
                            command.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                            command.Parameters.AddWithValue("@precio", txtPrecio.Text);
                            command.Parameters.AddWithValue("@dnidueño", txtDni.Text);
                            command.Parameters.AddWithValue("@mascotadueño", txtMascota.Text);
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
