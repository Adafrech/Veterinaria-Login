using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Veterinaria_Login
{
    public partial class AñadirCliente : UserControl
    {
        public AñadirCliente()
        {
            InitializeComponent();
        }

        private void PictureReturn_Click(object sender, System.EventArgs e)
        {
            Control contenedor = this.Parent;

            PanelControlCliente backmenu = new PanelControlCliente();

            contenedor.Controls.Remove(this);

            contenedor.Controls.Add(backmenu);
        }

        private void InsertarClientes_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "INSERT INTO Clientes (Dni, Nombre, Apellido, Ciudad, NumeroTelefono, Correo, Genero) VALUES (@dni, @nombre, @apellido, @ciudad, @telefono, @correo, @genero)";

                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        string dni = txtDni.Text.Trim();
                        string nombre = txtNombre.Text.Trim();
                        string apellido = txtApellido.Text.Trim();
                        string ciudad = txtCiudad.Text.Trim();
                        string telefono = txtTelefono.Text.Trim();
                        string correo = txtEmail.Text.Trim();
                        string genero = GenCombo.Text.Trim();

                        if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(ciudad) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(genero))
                        {
                            conn.Close();
                            throw new Exception("Todos los campos son obligatorios.");
                        }

                        comando.Parameters.AddWithValue("@dni", dni);
                        comando.Parameters.AddWithValue("@nombre", nombre);
                        comando.Parameters.AddWithValue("@apellido", apellido);
                        comando.Parameters.AddWithValue("@ciudad", ciudad);
                        comando.Parameters.AddWithValue("@telefono", telefono);
                        comando.Parameters.AddWithValue("@correo", correo);
                        comando.Parameters.AddWithValue("@genero", genero);

                        comando.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Agregado correctamente");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void LimpiarCampos()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            GenCombo.SelectedIndex = -1;
            GenCombo.Items.Clear();
        }

        private void AñadirCliente_Load(object sender, EventArgs e)
        {

        }



    }

}
