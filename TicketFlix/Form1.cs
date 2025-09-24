using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketFlix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        int totalcase = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, water, cola, coffe, tea, ticket, total;
           
            popcorn=Convert.ToInt16(textBox1.Text);
            water=Convert.ToInt16(textBox2.Text);
            cola=Convert.ToInt16(textBox3.Text);
            coffe=Convert.ToInt16(textBox4.Text);
            tea=Convert.ToInt16(textBox5.Text);
            ticket=Convert.ToInt16(textBox6.Text);

            total = popcorn * 150 + water * 15 + cola * 80 + coffe * 150 + tea * 20 + ticket * 220;
            label14.Text = total.ToString() + "TL";  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            textBox1.Focus();

        }
    }
}
