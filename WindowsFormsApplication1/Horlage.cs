using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Horlage : Form
    {
        public Horlage()
        {
            InitializeComponent();
        }


        
       
        private int mx, my;
        private double uSec = 6 * Math.PI / 180;
        private double uHour = 30 * Math.PI / 180;
        private double HalfPi = Math.PI / 2;
        private int CenterX, CenterY;


        private void Horlage_Load(object sender, EventArgs e)
        {
            
            mx = this.Top;
            my = this.Left;
            CenterX = pictureBox1.Width / 2;
            CenterY = pictureBox1.Height / 2;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double osx, osy, sx, sy;
            double omx, omy, mmx, mmy;
            double ohx, ohy, hx, hy;
            double curSec, curMin, curHour;
 
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.GhostWhite); 
            System.Drawing.Brush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black); 
            System.Drawing.Graphics formGraphics = pictureBox1.CreateGraphics(); 
            formGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; 
            curSec = (double)DateTime.Now.Second; 
            curMin = (double)DateTime.Now.Minute + (curSec / 60.0); 
            curHour = (double)DateTime.Now.Hour + (curMin / 60.0); 
            sx = Math.Cos((uSec * curSec) - HalfPi) * 90 + (double)CenterX;
            sy = Math.Sin((uSec * curSec) - HalfPi) * 90 + (double)CenterY; 
            osx = Math.Cos((uSec * curSec) + HalfPi) * 35 + (double)CenterX;
            osy = Math.Sin((uSec * curSec) + HalfPi) * 35 + (double)CenterY; 
            mmx = Math.Cos((uSec * curMin) - HalfPi) * 80 + (double)CenterX;
            mmy = Math.Sin((uSec * curMin) - HalfPi) * 80 + (double)CenterY;
            omx = Math.Cos((uSec * curMin) + HalfPi) * 20 + (double)CenterX;
            omy = Math.Sin((uSec * curMin) + HalfPi) * 20 + (double)CenterY; 
            hx = Math.Cos((uHour * curHour) - HalfPi) * 70 + (double)CenterX;
            hy = Math.Sin((uHour * curHour) - HalfPi) * 70 + (double)CenterY;
            ohx = Math.Cos((uHour * curHour) + HalfPi) * 20 + (double)CenterX;
            ohy = Math.Sin((uHour * curHour) + HalfPi) * 20 + (double)CenterY; 
            formGraphics.DrawImage(this.BackgroundImage, pictureBox1.Bounds); 
            myPen.Color = System.Drawing.Color.White;
            myPen.Width = 3;  
            formGraphics.DrawLine(myPen, (int)omx, (int)omy, (int)mmx, (int)mmy); 
            formGraphics.DrawLine(myPen, (int)ohx, (int)ohy, (int)hx, (int)hy); 
            myPen.Width = 2;
            myPen.Color = System.Drawing.Color.White;
            formGraphics.FillEllipse(myBrush, CenterX - 4, CenterY - 4, 8, 8); 
            formGraphics.DrawEllipse(myPen, CenterX - 4, CenterY - 4, 8, 8); 
            myPen.Color = System.Drawing.Color.LightSkyBlue;
            myPen.Width = 2;
            formGraphics.DrawLine(myPen, (int)CenterX, (int)CenterY, (int)sx, (int)sy);
            formGraphics.DrawLine(myPen, (int)osx, (int)osy, (int)CenterX, (int)CenterY);
 

        }
    }
}
