using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlTratamiento
{
    public partial class AñadirTratamiento : UserControl
    {
        string connectionString = "Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True";
        public AñadirTratamiento()
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


                    string sqlCheckMascota = "SELECT COUNT(*) FROM Mascotas WHERE Nombre = @Nombre AND DniCliente = @dni";
                    bool cancelarConsulta = false;

                    using (SqlCommand command = new SqlCommand(sqlCheckMascota, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", comboAnimal.Text);
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
                            command.Parameters.AddWithValue("@mascotadueño", comboAnimal.Text);
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

        private void picReturn_Click(object sender, EventArgs e)
        {
            PanelControlTratamiento PTrat = new PanelControlTratamiento();
            Control contenedor = this.Parent;
            contenedor.Controls.Remove(this);
            contenedor.Controls.Add(PTrat);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            comboAnimal.Items.Clear();

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
                        comboAnimal.Items.Add(nombreMascota);
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
            txtDni.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNombreTratamiento.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            comboAnimal.Text = string.Empty;
            comboAnimal.SelectedIndex = -1;
        }
    }
}
