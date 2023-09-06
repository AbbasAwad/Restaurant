using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanal.Height = button1.Height;
            SidePanal.Top = button1.Top;
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanal.Height = button1.Height;
            SidePanal.Top = button1.Top;

            firstCustomControl1.Visible = false;
            secondcustomcontrol1.Visible = false;
            therdcustomecontrol1.Visible = false;
            fourthcustomcontrol1.Visible = false;
            fifecustomcontrol1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanal.Height = button2.Height;
            SidePanal.Top = button2.Top;
            firstCustomControl1.Visible = true;
            secondcustomcontrol1.Visible = false;
            therdcustomecontrol1.Visible = false;
            fourthcustomcontrol1.Visible = false;
            fifecustomcontrol1.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanal.Height = button3.Height;
            SidePanal.Top = button3.Top;

            firstCustomControl1.Visible = false;
            secondcustomcontrol1.Visible = true;
            therdcustomecontrol1.Visible = false;
            fourthcustomcontrol1.Visible = false;
            fifecustomcontrol1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanal.Height = button4.Height;
            SidePanal.Top = button4.Top;
            firstCustomControl1.Visible = false;
            secondcustomcontrol1.Visible = false;
            therdcustomecontrol1.Visible = true;
            fourthcustomcontrol1.Visible = false;
            fifecustomcontrol1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanal.Height = button5.Height;
            SidePanal.Top = button5.Top;

            firstCustomControl1.Visible = false;
            secondcustomcontrol1.Visible = false;
            therdcustomecontrol1.Visible = false;
            fourthcustomcontrol1.Visible = true;
            fifecustomcontrol1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanal.Height = button6.Height;
            SidePanal.Top = button6.Top;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SidePanal.Height = button7.Height;
            SidePanal.Top = button7.Top;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
