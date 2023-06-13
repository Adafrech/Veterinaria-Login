using System;
using System.Windows.Forms;
using Veterinaria_Login.ControlMascotas;

namespace Veterinaria_Login
{
    public partial class PanelControlMascotas : UserControl
    {
        public PanelControlMascotas()
        {
            InitializeComponent();
        }

        private void AddMascota_Click(object sender, EventArgs e)
        {

            AñadirMascota addmascotas = new AñadirMascota();
            Controls.Add(addmascotas);
            addmascotas.BringToFront();
        }

        private void DelMascota_Click(object sender, EventArgs e)
        {
            EliminarMascota delmascotas = new EliminarMascota();
            Controls.Add(delmascotas);
            delmascotas.BringToFront();
        }

        private void PicExit_Click(object sender, EventArgs e)
        {
            Controls.Clear();
        }

        private void PictureEdit_Click(object sender, EventArgs e)
        {
            EditarMascota editarMascota = new EditarMascota();
            Controls.Add(editarMascota);
            editarMascota.BringToFront();
        }
    }
}
