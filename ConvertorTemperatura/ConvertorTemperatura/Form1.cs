using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertorTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float F = float.Parse(textBox1.Text);
            //label1.Text = F.ToString();
            float C = (F - 32) * 5.0f / 9.0f;
            textBox2.Text = C.ToString();
            //label2.Text = C.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float C = float.Parse(textBox2.Text);
            float F = (C * 9f / 5f) + 32;
            textBox1.Text = F.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
