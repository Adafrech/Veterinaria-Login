using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlClientes
{
    public partial class EditarCliente : UserControl
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
            {
                string dni = txtBusqueda.Text;
                string query = "SELECT Nombre, Apellido, Ciudad, NumeroTelefono, Correo FROM Clientes WHERE Dni = @dni";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@dni", dni);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader.GetString(0);
                            string apellido = reader.GetString(1);
                            string ciudad = reader.GetString(2);
                            string number = reader.GetString(3);
                            string correo = reader.GetString(4);



                            txtNombreBusqueda.Text = nombre;
                            txtApellidoBusqueda.Text = apellido;
                            txtCiudadBusqueda.Text = ciudad;
                            txtTelefonoBusqueda.Text = number;
                            txtEmailBusqueda.Text = correo;
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado");
                        }
                    }
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string dni = txtBusqueda.Text;

            string actnombre = txtNombreBusqueda.Text;
            string actapellido = txtApellidoBusqueda.Text;
            string actciudad = txtCiudadBusqueda.Text;
            string actelefono = txtTelefonoBusqueda.Text;
            string actemail = txtEmailBusqueda.Text;




            if (actnombre.Length > 0 && actapellido.Length > 0 && actciudad.Length > 0 && actelefono.Length > 0 && actemail.Length > 0)
            {
                string query = "UPDATE Clientes SET Nombre = @nombre, Apellido = @apellido ,Ciudad = @ciudad, NumeroTelefono = @telefono, Correo = @correo WHERE DNI = @DNI";


                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombre", actnombre);
                        command.Parameters.AddWithValue("@apellido", actapellido);
                        command.Parameters.AddWithValue("@ciudad", actciudad);
                        command.Parameters.AddWithValue("@telefono", actelefono);
                        command.Parameters.AddWithValue("@correo", actemail);
                        command.Parameters.AddWithValue("@DNI", dni);

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
            }
        }

        public void LimpiarCampos()
        {
            txtNombreBusqueda.Text = "";
            txtApellidoBusqueda.Text = "";
            txtCiudadBusqueda.Text = "";
            txtTelefonoBusqueda.Text = "";
            txtEmailBusqueda.Text = "";
        }
    }
}