using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.Historial
{
    public partial class PanelHistorial : UserControl
    {
        public PanelHistorial()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, System.EventArgs e)
        {
            string dni = txtBuscar.Text;

            try
            {
                string connectionString = "Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string consulta = @"SELECT C.Dni, C.Nombre, C.Ciudad, M.Nombre AS MascotaNombre, M.Sexo, M.Especie, CO.Motivo, CO.Observaciones, CO.Fecha, T.NombreTratamiento AS NombreTratamiento, T.Descripcion, T.Precio
                                FROM Clientes C
                                INNER JOIN Mascotas M ON C.DNI = M.DniCliente
                                INNER JOIN Consultas CO ON M.DniCliente = CO.DniCliente
                                INNER JOIN Tratamientos T ON CO.DniCliente = T.DniDueñoMascota
                                WHERE C.DNI = @dni";

                    using (SqlCommand command = new SqlCommand(consulta, connection))
                    {
                        command.Parameters.AddWithValue("@dni", dni);

                        DataTable dataTable = new DataTable();

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }

                        Historial.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
