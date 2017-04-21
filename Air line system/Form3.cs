using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_line_system
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Customer obj1 = new Customer();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtCountry.Text.Any() == false || txtDate.Text.Any() == false)
            {
                MessageBox.Show("Please Enter valid Country and Date");
                return;
            }
            string country, date;
            country = txtCountry.Text;
            date = txtDate.Text;
            if (obj1.Search(country, date) == true)
            {
                this.Visible = false;
                Form2 f2 = new Form2();
                f2.Visible = true;
            }
            else
            {
                MessageBox.Show("Not Found");
                return;
            }
            
        }
    }
}
