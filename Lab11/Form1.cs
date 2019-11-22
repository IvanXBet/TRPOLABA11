using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Today_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Cut();
            textBox1.Text = "Сегодня";
            textBox1.Text += "       ";
            DateTime thisDay = DateTime.Today;
            textBox1.Text += thisDay.ToString() + " "; 
            textBox1.Text += thisDay.ToString("d") + " "; 
            textBox1.Text += thisDay.ToString("D") + " "; 
            textBox1.Text += thisDay.ToString("g") + " ";
        
            string currentTime = DateTime.Now.TimeOfDay.ToString();
            textBox1.Text += currentTime + " ";
           
            var someTime = new DateTime();
            textBox1.Text += someTime + " ";
         
            textBox1.Text += DateTime.Now.ToString();
          
        }





        public DateTime DateTimethisDay { get; set; }

        private void Splitup_Click(object sender, EventArgs e)
        {
            DateTime sDay = DateTime.Today;
            label1.Text = "День " + sDay.Day; 
            label2.Text = "Месяц " + sDay.Month;
            label3.Text = "Год " + sDay.Year; 
            label4.Text = Convert.ToString(sDay.DayOfWeek);
        }

        private void tomorrow_Click(object sender, EventArgs e)
        {
            DateTime sDay = DateTime.Now;
            DateTime zDay = sDay.AddDays(1);
            textBox1.Text = "pppp ";
            textBox1.Text += "завтра " + zDay;
            zDay = sDay.AddDays(7);
            textBox1.Text += " через неделю " + zDay;
            
            DateTime tDay = DateTime.Today;
            textBox2.Text += " только дата " + tDay.ToString("d");
        }

        private void clinup_1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox1.Cut();
        }

        private void clinup_2_Click(object sender, EventArgs e)
        {
            label1.Text = ""; label2.Text = ""; label3.Text = ""; label4.Text = "";
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            DateTime nowDate = DateTime.Today;
            DateTime dt = Convert.ToDateTime(textBox3.Text);
            int age = nowDate.Year - dt.Year;
            textBox2.Text = Convert.ToString(age) + " лет";
        }
    }
}
