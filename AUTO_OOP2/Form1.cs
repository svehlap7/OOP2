using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUTO_OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Auto auto;
        public void Form1_Load(object sender, EventArgs e)
        {
           auto = new Auto("Scala", 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auto = new Auto(textBox1.Text, Convert.ToInt32(textBox2.Text));
            auto.Rozjed();
            MessageBox.Show(auto.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            auto = new Auto(textBox1.Text, Convert.ToInt32(textBox2.Text));
            auto.Zastav(10);
            MessageBox.Show(auto.ToString());
        }

       
    }
}
