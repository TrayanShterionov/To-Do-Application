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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var user = business.Get(1);

            if (user == null)
            {
                user = new Users()
                {
                    Username = "Admin0",
                    Password = ""
                   
                };
                business.Add(user);
            }

        }
    }
}
