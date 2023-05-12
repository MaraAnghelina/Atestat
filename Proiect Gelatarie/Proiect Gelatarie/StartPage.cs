using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Gelatarie
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm f = new EmployeeForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            GuestLogin f = new GuestLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
