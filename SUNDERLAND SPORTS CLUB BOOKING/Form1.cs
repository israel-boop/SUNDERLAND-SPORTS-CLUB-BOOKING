using Microsoft.VisualBasic.Logging;

namespace SUNDERLAND_SPORTS_CLUB_BOOKING
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // when the progressbar is 100, the timer stops and takes the user into the login form
            timer1.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form2 go = new Form2();
                go.Show();
                this.Hide();
            }
        }
    }
}