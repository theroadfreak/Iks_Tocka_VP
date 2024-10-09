namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private string XOflag = "X";

        private string zemi_i_smeni_XO()
        {
            string temp = XOflag;
            if (XOflag == "X")
            {
                XOflag = "O";
            }
            else
            {
                XOflag = "X";
            }

            return temp;
        }

        private void proveri_win(string koj_pobedi)
        {
            if (
                (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "") ||
                (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "") ||
                (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "") ||
                (button1.Text == button6.Text && button6.Text == button9.Text && button9.Text != "") ||
                (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "") ||
                (button3.Text == button4.Text && button4.Text == button7.Text && button7.Text != "") ||
                (button1.Text == button5.Text && button5.Text == button7.Text && button7.Text != "") ||
                (button3.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
                )
            {
                label1.Text = koj_pobedi + " pobedi!";
                smeni_kopcinja(false);
            }
        }

        private void smeni_kopcinja(bool u_sho)
        {
            button1.Enabled = u_sho;
            button2.Enabled = u_sho;
            button3.Enabled = u_sho;
            button4.Enabled = u_sho;
            button5.Enabled = u_sho;
            button6.Enabled = u_sho;
            button7.Enabled = u_sho;
            button8.Enabled = u_sho;
            button9.Enabled = u_sho;
        }

        private void isprazni_kopcinja()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                button1.Text = zemi_i_smeni_XO();
                proveri_win(button1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                button2.Text = zemi_i_smeni_XO();
                proveri_win(button2.Text);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                button3.Text = zemi_i_smeni_XO();
                proveri_win(button3.Text);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                button6.Text = zemi_i_smeni_XO();
                proveri_win(button6.Text);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                button5.Text = zemi_i_smeni_XO();
                proveri_win(button5.Text);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                button4.Text = zemi_i_smeni_XO();
                proveri_win(button4.Text);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                button9.Text = zemi_i_smeni_XO();
                proveri_win(button9.Text);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                button8.Text = zemi_i_smeni_XO();
                proveri_win(button8.Text);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                button7.Text = zemi_i_smeni_XO();
                proveri_win(button7.Text);

            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novaIgraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            smeni_kopcinja(true);
            isprazni_kopcinja();

        }

        private void novaIgraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            label1.Text = "";
            smeni_kopcinja(true);
            isprazni_kopcinja();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
