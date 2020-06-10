using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFromsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newSchool = new School();
            newSchool.Name = textSchool.Text;
            newSchool.Address = textAddress.Text;
            newSchool.City = textCity.Text;
            newSchool.State = textState.Text;
            newSchool.Zip = textZip.Text;
            newSchool.PhoneNumber = textPhone.Text;
            try
            {
                newSchool.TwitterAddress = textTwitter.Text;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(newSchool.ToString());
        }

        private void textSchool_TextChanged(object sender, EventArgs e)
        {
            var SchoolName = e;

        }
    }
}
