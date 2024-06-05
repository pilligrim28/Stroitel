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
            else
            {
                pictureBox1.Image = Properties.Resources.nestandart;
            }


        }

        private void radioStandart_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void checkKuhnya_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkKuhnya.Checked)
            {
                panelKuhnya.Visible = true;
            }
            else
            {
                panelKuhnya.Visible = false;
            }
        }

        private void checkGost_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkGost.Checked)
            {
                panelGost.Visible = true;
            }
            else
            {
                panelGost.Visible = false;
            }
        }

        private void checkSpal_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkSpal.Checked)
            {
                panelSpal.Visible = true;
            }
            else
            {
                panelSpal.Visible = false;
            }
        }

        private void checkVanna_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkVanna.Checked)
            {
                panelVanna.Visible = true;
            }
            else
            {
                panelVanna.Visible = false;
            }
        }

        private void checkKorid_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkKorid.Checked)
            {
                panelKoridor.Visible = true;
            }
            else
            {
                panelKoridor.Visible = false;
            }
        }

        private void checkOther_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkOther.Checked)
            {
                panelOther.Visible = true;
            }
            else
            {
                panelOther.Visible = false;
            }
        }

        private void checkFund_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkFund.Checked)
            {
                fundament.Visible = true;
            }
            else
            {
                fundament.Visible = false;
            }
        }

        private void buttRasch_Click(object sender, System.EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = textFam.Text;
            dataGridView1.Rows[0].Cells[1].Value = textName.Text;
            dataGridView1.Rows[0].Cells[2].Value = textOtch.Text;
            dataGridView1.Rows[0].Cells[3].Value = maskedTextBox1.Text;
            dataGridView1.Rows[0].Cells[4].Value = comboBox2.Text +", " + comboBox3.Text+ ", " + comboBox1.Text + " " + textBox29.Text + ", "+"д."+ maskedTextBox3.Text+", " +"корп."+ maskedTextBox4.Text+", "+"кв."+maskedTextBox5.Text;
        }
    }
}
