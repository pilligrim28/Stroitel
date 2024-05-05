using System.Windows.Forms;

namespace Stroitel
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            radioStandart.Checked = true;
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            if (radioStandart.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.standart;
            }
            else if (radioNestandart.Checked == true)
            {
                pictureBox1.Image = Properties.Resources.nestandart;
            }
            else
            {
                pictureBox1.Image = null;
                    }

        }

        private void radioStandart_CheckedChanged(object sender, System.EventArgs e)
        {
           
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           if (checkedListBox1.SelectedIndex == 0)

            {
                panelKuhnya.Visible = true;
            }
           else
            {
                panelKuhnya.Visible = false;
            }
        }
    }
}
