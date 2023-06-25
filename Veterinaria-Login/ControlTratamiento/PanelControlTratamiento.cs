using System.Windows.Forms;

namespace Veterinaria_Login.ControlTratamiento
{
    public partial class PanelControlTratamiento : UserControl
    {
        public PanelControlTratamiento()
        {
            InitializeComponent();
        }

        private void AddTrat_Click(object sender, System.EventArgs e)
        {
            AñadirTratamiento addtrat = new AñadirTratamiento();
            Controls.Add(addtrat);
            addtrat.BringToFront();
        }

        private void EditTrat_Click(object sender, System.EventArgs e)
        {
            EditarTratamiento editrat = new EditarTratamiento();
            Controls.Add(editrat);
            editrat.BringToFront();
        }

        private void QuitTrat_Click(object sender, System.EventArgs e)
        {
            Controls.Clear();
        }
    }
}
