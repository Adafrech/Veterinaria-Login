using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login
{
    public partial class AñadirMascota : UserControl
    {
        public AñadirMascota()
        {
            InitializeComponent();
        }

        private void PictureReturnMascotas_Click(object sender, EventArgs e)
        {
            PanelControlMascotas controlMascotas = new PanelControlMascotas();
            Control contenedor = this.Parent;
            contenedor.Controls.Remove(this);
            contenedor.Controls.Add(controlMascotas);
        }

        private void InsertarMascotas_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))

                {
                    conn.Open();
                    string dniCliente = txtDniFK.Text;
                    string queryVerificarDNI = "SELECT COUNT(*) FROM Clientes WHERE DNI = @dniCliente";

                    using (SqlCommand comandoVerificarDNI = new SqlCommand(queryVerificarDNI, conn))
                    {
                        comandoVerificarDNI.Parameters.AddWithValue("@dniCliente", dniCliente);
                        int count = (int)comandoVerificarDNI.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("El DNI del cliente no existe en la base de datos. No se puede registrar la mascota.");
                            conn.Close();
                            return;
                        }
                    }


                    string query = "INSERT INTO Mascotas (Nombre, Sexo, Raza, FechaNacimiento, DniCliente, Especie) VALUES (@nombre, @sexo, @raza, @nacimiento, @dnicliente, @especie)";

                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        string nombreMascota = txtNombreMascota.Text;
                        string sexoMascota = txtSexo.Text;
                        string razaMascota = txtRaza.Text;
                        DateTime fechaNacimiento = DateTimePick.Value;
                        string opselect = EspecieBox.SelectedItem.ToString();

                        comando.Parameters.AddWithValue("@nombre", nombreMascota);
                        comando.Parameters.AddWithValue("@sexo", sexoMascota);
                        comando.Parameters.AddWithValue("@raza", razaMascota);
                        comando.Parameters.AddWithValue("@nacimiento", fechaNacimiento);
                        comando.Parameters.AddWithValue("@dniCliente", dniCliente);
                        comando.Parameters.AddWithValue("@especie", opselect);


                        comando.ExecuteNonQuery();
                        MessageBox.Show("Mascota agregada correctamente");

                        conn.Close();
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AñadirMascota_Load(object sender, EventArgs e)
        {

        }
        public void LimpiarCampos()
        {
            txtNombreMascota.Text = string.Empty;
            txtSexo.Text = string.Empty;
            txtRaza.Text = string.Empty;
            DateTimePick.Value = DateTime.Now;
            txtDniFK.Text = string.Empty;
            EspecieBox.SelectedIndex = -1;

        }

        private void AñadirMascota_Load_1(object sender, EventArgs e)
        {

        }
    }
}
