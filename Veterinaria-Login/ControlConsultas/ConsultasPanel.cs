using System;
using System.Windows.Forms;

namespace Veterinaria_Login.ControlConsultas
{
    public partial class ConsultasPanel : UserControl
    {

        public ConsultasPanel()
        {
            InitializeComponent();
        }

        private void AddConsul_Click(object sender, EventArgs e)
        {
            AgregarConsultas addconsul = new AgregarConsultas();
            Controls.Add(addconsul);
            addconsul.BringToFront();
        }

        private void DelConsul_Click(object sender, EventArgs e)
        {
            EliminarConsultas delcon = new EliminarConsultas();
            Controls.Add(delcon);
            delcon.BringToFront();
        }

        private void EditConsul_Click(object sender, EventArgs e)
        {
            EditarConsultas editcon = new EditarConsultas();
            Controls.Add(editcon);
            editcon.BringToFront();
        }

        private void PicQuit_Click(object sender, EventArgs e)
        {
            Controls.Clear();
        }
    }
}

