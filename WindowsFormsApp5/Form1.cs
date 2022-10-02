using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int r;
        double alan, cevre, pi = 3.14;
        private void button1_Click(object sender, EventArgs e)
        {
            r = Convert.ToInt32(textBox1.Text);
            alan = Math.PI * r * r;
            MessageBox.Show("Alan: " + alan + " cm2", "Alan Sonucu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r = Convert.ToInt32(textBox1.Text);
            cevre = 2 * Math.PI * r;
            MessageBox.Show("Çevre: " + cevre + " cm", "Çevre Sonucu");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text + " cm";
        }
    }
}
