using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mouseOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YANDIN!OYUN BİTTİ...");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void button6_Move(object sender, EventArgs e)
        {

        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("KAZANDIN!OYUN BİTTİ...");           
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("YANDIN!OYUN BİTTİ...");
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("YANDIN!OYUN BİTTİ...");
           
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
           DialogResult cevap= MessageBox.Show("Oyundan Çıkmak Mı İstiyorsun ? ", "BİLGİLENDİRME", MessageBoxButtons.YesNo);
            if(cevap==DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i = 15;
            timer1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }
        int i = 15;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label2.Text = i.ToString();

            i--;
           if(i==-1)
            {
                label2.Text = "SÜRE BİTTİ!KAYBETTİN...";
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("YANDIN!OYUN BİTTİ...");
           
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("YANDIN!OYUN BİTTİ...");
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            MessageBox.Show("YANDIN!OYUN BİTTİ...");

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }
    }
}
