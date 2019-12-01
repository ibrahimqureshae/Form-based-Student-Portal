using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string uName = uNameTextBox.Text;
            string pass = PasswordTextBox.Text;
            if (uName=="123" && pass=="123")
            {
                Portal obj = new Portal();
                obj.Visible=true;
                this.Visible = false;
            }
        }
    }
}
