namespace Pet_Shop_Management_System
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
