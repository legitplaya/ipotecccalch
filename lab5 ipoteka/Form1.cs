using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_ipoteka
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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            textBox4.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum_kredit = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
            double time_kredit = Convert.ToDouble(comboBox1.Text)*12;
            double percent = Convert.ToDouble(textBox4.Text)/100/12;

            double ipoteka = sum_kredit * (percent * Math.Pow(1 + percent, time_kredit) / (Math.Pow(1 + percent, time_kredit) - 1));

            MessageBox.Show("Ежемесячный платеж по ипотеке составляет: " + ipoteka);
        }
    }
}
