using System.Security.AccessControl;

namespace FWAiO
{
    public partial class AppAbout : Form
    {
        Point lastPoint;
        public AppAbout()
        {
            InitializeComponent();
        }
        private void UI_Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void UI_Button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void init(object sender, EventArgs e)
        {
            this.hi.Text = "Hello, " + System.Environment.UserName;
        }
    }
}