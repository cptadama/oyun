using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace corona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Random random = new Random();

        int coronakill;


        public void timer_durdur()
        {
            timer1.Stop();
        }

        public void fotograf()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
        }

        public void oyunsonu()
        {
            

        }

        public void method()
        {
            if (coronakill >= 20)
            {
                pictureBox1.Top += 2;
                pictureBox2.Top += 3;
                pictureBox3.Top += 4;
                pictureBox4.Top += 5;
                pictureBox5.Top += 6;
                pictureBox6.Top += 6;
            }

            if (coronakill >= 40)
            {
                pictureBox1.Top += 3;
                pictureBox2.Top += 4;
                pictureBox3.Top += 5;
                pictureBox4.Top += 6;
                pictureBox5.Top += 7;
                pictureBox6.Top += 7;
            }

            if (coronakill >= 60)
            {
                pictureBox1.Top += 4;
                pictureBox2.Top += 5;
                pictureBox3.Top += 6;
                pictureBox4.Top += 7;
                pictureBox5.Top += 8;
                pictureBox6.Top += 8;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();

            int x = random.Next(0, 1000);
            int y = random.Next(-90, -70);

            int z = random.Next(0, 1000);
            int t = random.Next(-90, -70);

            int k = random.Next(0, 1000);
            int l = random.Next(-90, -70);

            int a = random.Next(0, 1000);
            int b = random.Next(-90, -70);

            int c = random.Next(0, 1000);
            int d = random.Next(-90, -70);

            int f = random.Next(0, 1000);
            int g = random.Next(-90, -70);
            pictureBox1.Location = new Point(x, y);
            pictureBox2.Location = new Point(z, t);
            pictureBox3.Location = new Point(k, l);
            pictureBox4.Location = new Point(a, b);
            pictureBox5.Location = new Point(c, d);
            pictureBox6.Location = new Point(f, g);
            button1.Enabled = false;
            button1.Visible = false;
            label1.Visible = false;

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;

            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;

            coronakill = 0;
            LblCorona.Text = "0";
            label2.Visible = true;
            LblCorona.Visible = true;
            label1.Location = new Point(465, -30);


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            int x = random.Next(0, 1000);
            int y = random.Next(-90, -70);
            pictureBox1.Top = y;
            pictureBox1.Left = x;
            coronakill++;
            LblCorona.Text = coronakill.ToString();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            int x = random.Next(0, 1000);
            int y = random.Next(-90, -70);
            pictureBox2.Top = y;
            pictureBox2.Left = x;
            coronakill++;
            LblCorona.Text = coronakill.ToString();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            int x = random.Next(0, 1000);
            int y = random.Next(-90, -70);
            pictureBox3.Top = y;
            pictureBox3.Left = x;
            coronakill++;
            LblCorona.Text = coronakill.ToString();
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            int x = random.Next(0, 1000);
            int y = random.Next(-90, -70);
            pictureBox4.Top = y;
            pictureBox4.Left = x;
            coronakill++;
            LblCorona.Text = coronakill.ToString();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            int x = random.Next(0, 1000);
            int y = random.Next(-90, -70);
            pictureBox5.Top = y;
            pictureBox5.Left = x;
            coronakill++;
            LblCorona.Text = coronakill.ToString();
        }

        private void pictureBox6_Click_2(object sender, EventArgs e)
        {
            int x = random.Next(0, 1000);
            int y = random.Next(-90, -70);
            pictureBox6.Top = y;
            pictureBox6.Left = x;
            coronakill++;
            LblCorona.Text = coronakill.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pictureBox1.Top += 1;
            pictureBox2.Top += 2;
            pictureBox3.Top += 3;
            pictureBox4.Top += 4;
            pictureBox5.Top += 5;
            pictureBox6.Top += 6;
            
            method();

            if (pictureBox1.Top >= 528 || pictureBox2.Top >= 528 || pictureBox3.Top >= 528 || pictureBox4.Top >= 528 || pictureBox5.Top >= 528 || pictureBox6.Top >= 528)
            {
                timer_durdur();
                fotograf();
                label1.Visible = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Top += 5;
            if (label1.Top >= 270)
            {
                timer2.Stop();
                button1.Enabled = true;
                button1.Text = "Restart";
                button1.Visible = true;

            }
        }
    }
}
