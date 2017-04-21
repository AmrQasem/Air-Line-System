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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id;
            id = txtID.Text;
            Customer ob1 = new Customer();
            if (ob1.delete(id) == true)
            {
                MessageBox.Show("Done");
                this.Visible = false;
                Form1 f1 = new Form1();
                f1.Visible = true;
            }
            else
            {
                MessageBox.Show("Not found");
                return;
            }
        }
    }
}
