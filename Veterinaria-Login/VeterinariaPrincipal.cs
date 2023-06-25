using System.Windows.Forms;
using Veterinaria_Login.ControlConsultas;
using Veterinaria_Login.ControlTratamiento;
using Veterinaria_Login.Historial;

namespace Veterinaria_Login
{
    public partial class VeterinariaPrincipal : Form
    {
        public VeterinariaPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, System.EventArgs e)
        {
            PanelControlCliente controlClientes = new PanelControlCliente();
            PanelPrinc.Controls.Add(controlClientes);
            controlClientes.BringToFront();


        }

        private void btnMascotas_Click(object sender, System.EventArgs e)
        {
            PanelControlMascotas controlmascotas = new PanelControlMascotas();
            PanelPrinc.Controls.Add(controlmascotas);
            controlmascotas.BringToFront();

        }

        private void VeterinariaPrincipal_Load(object sender, System.EventArgs e)
        {
        }

        private void btnConsultas_Click(object sender, System.EventArgs e)
        {
            ConsultasPanel consultas = new ConsultasPanel();
            PanelPrinc.Controls.Add(consultas);
            consultas.BringToFront();
        }

        private void btnTratamientos_Click(object sender, System.EventArgs e)
        {
            PanelControlTratamiento tratamiento = new PanelControlTratamiento();
            PanelPrinc.Controls.Add(tratamiento);
            tratamiento.BringToFront();
        }

        private void btnHistorial_Click(object sender, System.EventArgs e)
        {
            PanelHistorial panel = new PanelHistorial();
            PanelPrinc.Controls.Add(panel);
            panel.BringToFront();

        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        int posY = 0;
        int posX = 0;
        private void VeterinariaPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
