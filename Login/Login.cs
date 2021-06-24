
using System;
using System.Windows.Forms;
using ToDoAppM;


namespace Login
{
    public partial class Login : Form
    {
        private Business business = new Business();
        public Login()
        {
            InitializeComponent();
        }

   

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
