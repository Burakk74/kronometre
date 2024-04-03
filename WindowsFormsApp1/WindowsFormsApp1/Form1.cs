using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0, saniye = 0, salise = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            timer1.Interval = 10;
            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";


        }

    

        private void button1_Click(object sender, EventArgs e)
        {
          

            timer1.Stop();
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Text = "Devam Et";
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dakika = 0;
            saniye = 0;
            salise = 1;
            label4.Text="0";
            label5.Text="0";
            label6.Text ="0";
            button3.Enabled = true;
            button2.Enabled = false;
            button1.Enabled = false;
            button3.Text = "Başla";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(salise == 60)
            {
                saniye++;

                salise = 0;
                if (saniye == 60)
                {
                    dakika++;
                   saniye = 0;
                   
                }
                    
            }
            label6.Text = Convert.ToString(dakika);
            label5.Text = Convert.ToString(saniye);
            label4.Text = Convert.ToString(salise);
            salise++;
        }

     
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled= true;
            timer1.Start();
            
        }

    }
}
