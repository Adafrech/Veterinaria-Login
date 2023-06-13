using System;
using System.Windows.Forms;

namespace Veterinaria_Login
{
    public partial class InicioLogin : Form
    {
        string connectionString = "Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True";

        public InicioLogin()
        {
            InitializeComponent();
        }
        private void ImgExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicioLogin_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* string user = txtUser.Text;
            string pass = txtPass.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                    VeterinariaPrincipal Panel = new VeterinariaPrincipal();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", user);
                        command.Parameters.AddWithValue("@Contraseña", pass);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            DialogResult rdo = MessageBox.Show("Inicio de sesión exitoso");
                            connection.Close();



                            VeterinariaPrincipal veterinaria = new VeterinariaPrincipal();
                            veterinaria.ShowDialog();




                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                            connection.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }

            */
        }


        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if (e.KeyChar == Convert.ToChar(Keys.Enter))
             {

                 string user = txtUser.Text;
                 string pass = txtPass.Text;
                 using (SqlConnection connection = new SqlConnection(connectionString))
                     try
                     {
                         connection.Open();
                         string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                         VeterinariaPrincipal Panel = new VeterinariaPrincipal();

                         using (SqlCommand command = new SqlCommand(query, connection))
                         {
                             command.Parameters.AddWithValue("@Usuario", user);
                             command.Parameters.AddWithValue("@Contraseña", pass);

                             int count = (int)command.ExecuteScalar();

                             if (count > 0)
                             {
                                 DialogResult rdo = MessageBox.Show("Inicio de sesión exitoso");
                                 connection.Close();
                                 this.Hide();
                                 VeterinariaPrincipal veterinaria = new VeterinariaPrincipal();
                                 veterinaria.Show();

                             }
                             else
                             {
                                 MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                                 connection.Close();
                             }
                         }

                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                     }
             } */
        }
    }
}