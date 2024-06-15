using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInterface;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmComputeSalary_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        // COMPUTE SALARY
        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = textBox1.Text;
            string LastName = textBox2.Text;
            string department = textBox3.Text;
            string job_title = textBox4.Text;
            int hoursWorked = int.Parse(textBox6.Text);
            double ratePerHour = double.Parse(textBox5.Text);
            

            // create the object to call it out
            PartTimeEmployee pte = new PartTimeEmployee(FirstName, LastName, department, job_title);
            // call the method ComputeSalary
            pte.ComputeSalary(hoursWorked,ratePerHour);
            //display the details
            label10.Text = pte.FirstName;
            label11.Text = pte.LastName;
            label12.Text = pte.getSalary().ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
