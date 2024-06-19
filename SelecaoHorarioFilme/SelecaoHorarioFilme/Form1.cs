using System.Windows.Forms;

namespace SelecaoHorarioFilme
{
    public partial class frmHorarios : Form
    {
        public frmHorarios()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelCheck1.BorderStyle = BorderStyle.FixedSingle;
            panelCheck2.BorderStyle = BorderStyle.None;
            panelCheck3.BorderStyle = BorderStyle.None;
            panelCheck4.BorderStyle = BorderStyle.None;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelCheck1.BorderStyle = BorderStyle.None;
            panelCheck2.BorderStyle = BorderStyle.FixedSingle;
            panelCheck3.BorderStyle = BorderStyle.None;
            panelCheck4.BorderStyle = BorderStyle.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelCheck1.BorderStyle = BorderStyle.None;
            panelCheck2.BorderStyle = BorderStyle.None;
            panelCheck3.BorderStyle = BorderStyle.FixedSingle;
            panelCheck4.BorderStyle = BorderStyle.None;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panelCheck1.BorderStyle = BorderStyle.None;
            panelCheck2.BorderStyle = BorderStyle.None;
            panelCheck3.BorderStyle = BorderStyle.None;
            panelCheck4.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
