using CodeFirst2.Classes;
using CodeFirst2.DbOps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Company company = new Company
            {
                Name = textBox_name.Text,
                Description = textBox_description.Text,
                StartDate = dateTimePicker.Value,
            };
            if (CompanyDbOps.setCompany(company))
                MessageBox.Show("Add with exit");
            else
                MessageBox.Show("The company already exits");
        }
    }
}
