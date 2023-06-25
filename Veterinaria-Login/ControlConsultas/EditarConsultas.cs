using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlConsultas
{
    public partial class EditarConsultas : UserControl
    {
        public EditarConsultas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
            {
                string dni = txtDniEdit.Text;
                string query = "SELECT Motivo, Observaciones, Fecha, MascotaConsul  FROM Consultas WHERE DniCliente = @dni";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@dni", dni);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string motivo = reader.GetString(0);
                            string observacion = reader.GetString(1);
                            DateTime fecha = reader.GetDateTime(2);
                            string mascotac = reader.GetString(3);



                            txtMotivoEdit.Text = motivo;
                            txtObservacionEdit.Text = observacion;
                            txtMascotaEdit.Text = mascotac;
                            timerFecha.Value = fecha;


                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado");
                        }
                    }
                }
            }
        }
    }
}
