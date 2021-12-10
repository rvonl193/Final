// Ryan von Lutzow
// Final Project C#
// 12-8-21

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {

            InitializeComponent();

        }

        private void Form_Load(object sender, EventArgs e)
        {



        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {

            User u = new User();

            u.Username = UsernameLabel.Text;
            u.Password = PasswordLabel.Text;

            SQLiteDataAccess.SaveUser(u);

            UsernameLabel.Text = "";
            PasswordLabel.Text = "";

        }

    }

}
