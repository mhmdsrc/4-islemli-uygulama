using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say1, say2, toplama, cıkarma, carpma, bolme;


            say1 = Convert.ToInt32(textBox1.Text);
            say2 = Convert.ToInt32(textBox2.Text);
            toplama = say1 + say2;
            cıkarma = say1 - say2;
            bolme = say1 / say2;
            carpma = say1 * say2;

            textBox3.Text = toplama.ToString();
            textBox4.Text = cıkarma.ToString();
            textBox5.Text = carpma.ToString();
            textBox6.Text = bolme.ToString();
        }
        
    }
}
