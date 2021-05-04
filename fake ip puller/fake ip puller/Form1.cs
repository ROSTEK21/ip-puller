using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fake_ip_puller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point LastPoint;

        //pulls fake ip's lol
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = ("Waiting...");
            Thread.Sleep(1000);
            label2.Text = ("IP pulled :D");
            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                var lol = new Random();
                MessageBox.Show("Victim's IP: " + $"{lol.Next(1, 255)}.{lol.Next(1, 255)}.{lol.Next(1, 255)}.{lol.Next(1, 255)}", "Real IP Puller");
            }
            else
            {
                var shit = new Random();
                MessageBox.Show("Victim's IP: " + $"{shit.Next(1, 255)}.{shit.Next(1, 255)}.{shit.Next(1, 255)}.{shit.Next(1, 255)}" + " / " + "Your IP: " + $"{shit.Next(1, 255)}.{shit.Next(1, 255)}.{shit.Next(1, 255)}.{shit.Next(1, 255)}", "Real IP Puller");
            }
            label2.Text = ("Ready to Pull IP's");
        }
        
        //closes this shit program
        private void label1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
        
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://pornhub.com"); //put your owm link here ;)
        }
    }
}
