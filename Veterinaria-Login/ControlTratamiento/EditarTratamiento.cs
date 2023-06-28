using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlTratamiento
{
    public partial class EditarTratamiento : UserControl
    {
        public EditarTratamiento()
        {
            InitializeComponent();
            comboAnimal.SelectedIndexChanged += comboAnimal_SelectedIndexChanged;
        }

        private void picReturn_Click(object sender, System.EventArgs e)
        {
            PanelControlTratamiento PTrat = new PanelControlTratamiento();
            Control contenedor = this.Parent;
            contenedor.Controls.Remove(this);
            contenedor.Controls.Add(PTrat);
        }

        private void btnBuscarTrat_Click(object sender, System.EventArgs e)
        {
            string dni = txtDni.Text;
            comboAnimal.Items.Clear(); // Limpiar el ComboBox

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

        private void btnEditarTratamiento_Click(object sender, EventArgs e)
        {

            string dni = txtDni.Text;
            string nombremascota = comboAnimal.Text;
            string actnombretrat = txtNombreTratamiento.Text;
            string actdescrip = txtDescripcion.Text;
            string actprecio = txtPrecio.Text;

            if (nombremascota.Length > 0 && actnombretrat.Length > 0 && actdescrip.Length > 0 && actprecio.Length > 0)
            {
                string query = "UPDATE Tratamientos SET NombreTratamiento = @nombretrat, Descripcion = @descripcion, Precio = @precio WHERE DniDueñoMascota = @dni AND MascotaTratada = @nombreMascota";
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@nombretrat", actnombretrat);
                        command.Parameters.AddWithValue("@descripcion", actdescrip);
                        command.Parameters.AddWithValue("@precio", actprecio);

                        command.Parameters.AddWithValue("@dni", dni);
                        command.Parameters.AddWithValue("@nombreMascota", nombremascota);

                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos Actualizados correctamente");
                            LimpiarCampos();

                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar los datos de la mascota");
                            LimpiarCampos();
                        }
                    }
                }

            }
        }

        public void LimpiarCampos()
        {
            txtDni.Text = string.Empty;
            txtNombreTratamiento.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            comboAnimal.SelectedIndex = -1;
            comboAnimal.Items.Clear();
        }

        private void comboAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAnimal.SelectedItem != null)
            {
                string nombreMascota = comboAnimal.SelectedItem.ToString();

                string selectQuery = "SELECT NombreTratamiento, Descripcion, Precio FROM Tratamientos WHERE MascotaTratada = @nombreMascota";
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-SLVGAGD\\SQLEXPRESS;Initial Catalog=Sistema2;Integrated Security=True"))
                {
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@nombreMascota", nombreMascota);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = selectCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNombreTratamiento.Text = reader["NombreTratamiento"].ToString();
                            txtDescripcion.Text = reader["Descripcion"].ToString();
                            txtPrecio.Text = reader["Precio"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos de la mascota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}