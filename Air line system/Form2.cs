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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f1 = new Form1();
            f1.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name, country, date, TripType,classtype;
            int phone, id, numberOfticket;
            name = txtName.Text;
            id = int.Parse(txtID.Text);
            phone = int.Parse(txtPhone.Text);
            country = txtCountry.Text;
            date = txtDate.Text;
            numberOfticket = int.Parse(txtNumber.Text);
            TripType = txtTripType.Text;
            classtype=txtclass.Text;
            Customer obj1 = new Customer(name, id, phone, country, date, numberOfticket, TripType,classtype);
            MessageBox.Show(obj1.NetFare().ToString());
            MessageBox.Show("Thank you for Reservation ");
            obj1.add();
        }
    }
}
