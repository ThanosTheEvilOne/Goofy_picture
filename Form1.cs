using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms14_Picture
{
    public partial class Form1 : Form


    { 

        public Form1()
        {
            InitializeComponent();
        }

        Point piste = new Point(80, 50); //Referenssin alku koordinaatit

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var bmp = new Bitmap(Properties.Resources.Hessu); //Kutsuu läpinäkyvyyden taustalle
            bmp.MakeTransparent(); // 
            e.Graphics.DrawImage(bmp,piste); 
            DoubleBuffered = true; 


        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) // Aktivoituu kun hiiren nappia painetaan
        {
            if (e.Button == MouseButtons.Left) // Vasen hiiren painallus
            {
                piste = e.Location; // referenssipisteen koordinaatit

                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) // Hiiren liikutustoiminto
        {
            if (e.Button == MouseButtons.Left)
            {
                piste = e.Location;

                Invalidate();
            }
        }
    }
}
