using System.Drawing;
using System.Windows.Forms;
using Veterinaria_Login.ControlClientes;

namespace Veterinaria_Login
{
    public partial class PanelControlCliente : UserControl
    {


        public PanelControlCliente()
        {
            InitializeComponent();
        }

        private void PictureQuit_Click(object sender, System.EventArgs e)
        {
            Controls.Clear();
            BackColor = Color.FromArgb(45, 199, 255);
        }

        private void AddCliente_Click(object sender, System.EventArgs e)
        {

            AñadirCliente addcliente = new AñadirCliente();
            Controls.Add(addcliente);
            addcliente.BringToFront();

        }

        private void DelCliente_Click(object sender, System.EventArgs e)
        {


            EliminarCliente deletecliente = new EliminarCliente();
            Controls.Add(deletecliente);
            deletecliente.BringToFront();
        }

        private void PictureEdit_Click(object sender, System.EventArgs e)
        {
            EditarCliente edit = new EditarCliente();
            Controls.Add(edit);
            edit.BringToFront();
        }
    }
}
