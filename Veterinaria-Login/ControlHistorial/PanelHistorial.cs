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
                    string consulta = @"SELECT C.Dni, C.Nombre, C.Ciudad, M.Nombre AS MascotaNombre, M.Sexo, M.Especie, M.FechaNacimiento, CO.Motivo, CO.Observaciones, CO.Fecha, T.NombreTratamiento AS NombreTratamiento, T.Descripcion, T.Precio
                    FROM Clientes C
                    INNER JOIN Mascotas M ON C.DNI = M.DniCliente
                    LEFT JOIN Consultas CO ON M.DniCliente = CO.DniCliente AND M.Nombre = CO.MascotaConsuly
                    LEFT JOIN Tratamientos T ON M.DniCliente = T.DniDueñoMascota AND M.Nombre = T.MascotaTratada
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

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No existe ningún cliente con el DNI ingresado.");
                        }
                        else
                        {
                            Historial.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }
        private void PanelHistorial_Load(object sender, EventArgs e)
        {

        }
    }

}