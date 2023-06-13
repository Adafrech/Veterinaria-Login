using System.Windows.Forms;
using Veterinaria_Login.ControlConsultas;
using Veterinaria_Login.ControlTratamiento;

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
            Tratamiento ctrltrat = new Tratamiento();
            PanelPrinc.Controls.Add(ctrltrat);
            ctrltrat.BringToFront();
        }
    }
}
