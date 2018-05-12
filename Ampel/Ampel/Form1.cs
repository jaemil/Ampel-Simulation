using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ampel
{
    public partial class Form1 : Form
    {
        public int car = 20;
        public bool rot = true, rotgelb = false, grün = false, gelb = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 500;
            this.Height = 500;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            ptBAmpel.Image = Properties.Resources._1Rot;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            rot = true;
            rotgelb = false;
            grün = false;
            gelb = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (car == 380)//500(Form größe) - 40 - car(100 breit)
            {
                car = 20;
            }
            if (rotgelb)
            {
                car = car + 5;
                ptBAuto.Location = new Point(car, 376);
            }
            else if (grün)
            {
                car = car + 10;
                ptBAuto.Location = new Point(car, 376);
            }
            else if (gelb)
            {
                car = car + 5;
                ptBAuto.Location = new Point(car, 376);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (rot)
            {
                rot = false;
                rotgelb = true;
                grün = false;
                gelb = false;
                ptBAmpel.Image = Properties.Resources._2RotGelb;
            }
            else if (rotgelb)
            {
                rot = false;
                rotgelb = false;
                grün = true;
                gelb = false;
                ptBAmpel.Image = Properties.Resources._3Grün;
            }
            else if (grün)
            {
                rot = false;
                rotgelb = false;
                grün = false;
                gelb = true;
                ptBAmpel.Image = Properties.Resources._4Gelb;
            }
            else if (gelb)
            {
                rot = true;
                rotgelb = false;
                grün = false;
                gelb = false;
                ptBAmpel.Image = Properties.Resources._1Rot;
            }
        }
    }
}
