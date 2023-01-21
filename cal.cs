using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CGPA.Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")

            {
                MessageBox.Show("Marks are empty");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);
                int n3 = Int32.Parse(textBox3.Text);
                int n4 = Int32.Parse(textBox4.Text);
                int n5 = Int32.Parse(textBox5.Text);
                int n6 = Int32.Parse(textBox6.Text);
                int h1 = Int32.Parse(comboBox1.Text);
                int h2 = Int32.Parse(comboBox2.Text);
                int h3 = Int32.Parse(comboBox3.Text);
                int h4 = Int32.Parse(comboBox4.Text);
                int h5 = Int32.Parse(comboBox5.Text);
                int h6 = Int32.Parse(comboBox6.Text);
               

                if (checkBox1.Checked)
                {
                    n1 = 0;
                   
                }
                if (checkBox2.Checked)
                {
                    n2 = 0;
                }
                if (checkBox3.Checked)
                {
                    n3 = 0;
                }
                if (checkBox4.Checked)
                {
                    n4 = 0;
                }
                if (checkBox5.Checked)
                {
                    n5 = 0;
                }
                if (checkBox6.Checked)
                {
                    n6 = 0;
                }
                float gp = gradepoint(n1) * h1 + gradepoint(n2) * h2 + gradepoint(n3) * h3 + gradepoint(n4) * h4 + gradepoint(n5) * h5 + gradepoint(n6) * h6;
                int ch = h1 + h2 + h3 + h4 + h5 + h6;
                float gpa = gp / ch;
                label12.Text = gradepoint(n1).ToString();
                label12.Visible = true;
                label13.Text = gradepoint(n2).ToString();
                label13.Visible = true;
                label14.Text = gradepoint(n3).ToString();
                label14.Visible = true;
                label15.Text = gradepoint(n4).ToString();
                label15.Visible = true;
                label16.Text = gradepoint(n5).ToString();
                label16.Visible = true;
                label17.Text = gradepoint(n6).ToString();
                label17.Visible = true;
                label18.Text = "Total GPA = " + gpa.ToString();
                label18.Visible = true;


            }
        }
        
        float gradepoint(int marks)
        {
            float g = 0;

            if (marks<50)
            {
                g = 0.0f;
                
            }
         
            else if(marks >= 50 && marks <= 59)
            {
                g = 1.0f;
            }
            else if (marks >= 60 && marks <= 69)
            {
                g = 2.0f;
            }
            else if (marks >= 70 && marks <= 79)
            {
                g = 3.0f;
            }
            else if (marks >= 80 && marks <= 100)
            {
                g = 4.0f;
            }
            else if(marks < 0 || marks > 100){
                MessageBox.Show("Marks are out of range");
            }
            


            return g;
        }
    }
    
}
