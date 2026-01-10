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
using System.Drawing.Text;

namespace tetrismaking
{
    public partial class Form1 : Form
    {       SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush greyBrush = new SolidBrush(Color.Gray);
            Pen greyPen = new Pen(Color.Gray, 3);
        string[] smth = new string[4];
        //invisible swuares n stuff
        Rectangle a1 = new Rectangle(60, 100, 70, 70);
        Rectangle a2 = new Rectangle(135, 100, 70, 70);
        Rectangle a3 = new Rectangle(210, 100, 70, 70);
        Rectangle a4 = new Rectangle(285, 100, 70, 70); 
        Rectangle b1 = new Rectangle(60, 175, 70, 70);
        Rectangle b2 = new Rectangle(135, 175, 70, 70);
        Rectangle b3 = new Rectangle(210, 175, 70, 70);
        Rectangle b4 = new Rectangle(285, 175, 70, 70);
        Rectangle c1 = new Rectangle(60, 250, 70, 70);
        Rectangle c2 = new Rectangle(135, 250, 70, 70);
        Rectangle c3 = new Rectangle(210, 250, 70, 70);
        Rectangle c4 = new Rectangle(285, 250, 70, 70);
        Rectangle d1 = new Rectangle(60, 325, 70, 70);
        Rectangle d2 = new Rectangle(135, 325, 70, 70);
        Rectangle d3 = new Rectangle(210, 325, 70, 70);
        Rectangle d4 = new Rectangle(285, 325, 70, 70);

        //live square 
        Rectangle live = new Rectangle(60, 25, 70, 70);

        //bottom of map 
        Rectangle bottom = new Rectangle(00, 395, 900, 90);
        //if occupied ints
        int A1 = 0;
        int A2 = 0;
        int A3 = 0;
        int A4 = 0;
        int B1 = 0;
        int B2 = 0;
        int B3 = 0;
        int B4 = 0;
        int C1 = 0;
        int C2 = 0;
        int C3 = 0;
        int C4 = 0;
        int D1 = 0;
        int D2 = 0;
        int D3 = 0;
        int D4 = 0;

        //socre 
        int score = 0;
        int realscore;
        //movement controls
        Boolean apressed = false;
        Boolean wpressed = false;
        Boolean dpressed = false;
        Boolean spressed = false;

        //checking which row is full
        Boolean rowA = false;
        Boolean rowB = false;
        Boolean rowC = false;
        Boolean rowD = false;


        public Form1()
        {
           
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Invalidate();
            //checking if each grid space intersects with the player and then upping their int
            smth[1] = "hi";
            if (a1.IntersectsWith(live) && B1 == 1)
            { A1 = 1; live.Y = 25; }

            if (a2.IntersectsWith(live) && B2 == 1)
            { A2 = 1; live.Y = 25; }

            if (a3.IntersectsWith(live) && B3 == 1)
            { A3 = 1; live.Y = 25; }

            if (a4.IntersectsWith(live) && B4 == 1)
            { A4 = 1; live.Y = 25; }

            if (b1.IntersectsWith(live) && C1 == 1)
            { B1 = 1; live.Y = 25; }

            if (b2.IntersectsWith(live) && C2 == 1)
            { B2 = 1; live.Y = 25; }

            if (b3.IntersectsWith(live) && C3 == 1)
            { B3 = 1; live.Y = 25; }

            if (b4.IntersectsWith(live) && C4 == 1)
            { B4 = 1; live.Y = 25; }

            if (c1.IntersectsWith(live) && D1 == 1)
            { C1 = 1; live.Y = 25; }

            if (c2.IntersectsWith(live) && D2 == 1)
            { C2 = 1; live.Y = 25; }

            if (c3.IntersectsWith(live) && D3 == 1)
            { C3 = 1; live.Y = 25; }

            if (c4.IntersectsWith(live) && D4 == 1)
            { C4 = 1; live.Y = 25; }

            if (d1.IntersectsWith(live))
            { D1 = 1; live.Y = 25; }

            if (d2.IntersectsWith(live))
            { D2 = 1; live.Y = 25; }

            if (d3.IntersectsWith(live))
            { D3 = 1; live.Y = 25; }

            if (d4.IntersectsWith(live))
            { D4 = 1; live.Y = 25; }

            //adding up the total value of each row 
            int Atotal = A1+A2+A3+A4;
            int Btotal = B1+B2+B3+B4;
            int Ctotal = C1+C2+C3+C4;
            int Dtotal = D1+D2+D3+D4;
            scorelabel.Text = Atotal +" "+ Btotal + " "+ Ctotal + "  "+ Dtotal;
            //if a row is filled clearing it and shifting ti down
            if (Dtotal == 4)
            {
                realscore += 4;
                D1 = 0;
                D2 = 0;
                D3 = 0;
                D4 = 0;
                rowD = true;
                moverows();

            }
             
       
            
       
        }
        private void moverows()
        {
            if (rowD == true)
            {
                {
                    if (C1 == 1)
                        D1 = 1;
                    C1 = 0;
                }
                if (C2 == 1)
                {
                    D2 = 1;
                    C2 = 0;
                }
                if (C3 == 1)
                {
                    D3 = 1;
                    C3 = 0;
                }
                if (C4 == 1)
                {
                    D4 = 1;
                    C4 = 0;
                }
            }
            if (rowD == true || rowC == true)
            {
                if (B1 == 1)
                {
                    C1 = 1;
                    B1 = 0;
                }
                if (B2 == 1)
                {
                    C2 = 1;
                    B2 = 0;
                }
                if (B3 == 1)
                {
                    C3 = 1;
                    B3 = 0;
                }
                if (B4 == 1)
                {
                    C4 = 1;
                    B4 = 0;
                }
            }
            if (rowD == true || rowC == true || rowB == true)
            {
                if (A1 == 1)
                {
                    B1 = 1;
                    A1 = 0;
                }
                if (A2 == 1)
                {
                    B2 = 1;
                    A2 = 0;
                }
                if (A3 == 1)
                {
                    B3 = 1;
                    A3 = 0;
                }
                if (A4 == 1)
                {
                    B4 = 1;
                    A4 = 0;
                }
            





            }


            rowD = false;

        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
          
            //generating backround grid 
            if (A1 == 0)
            g.FillRectangle(blackBrush, a1);
            else 
            g.FillRectangle(blueBrush, a1);
            if (A2 == 0)
                g.FillRectangle(blackBrush, a2);
            else
                g.FillRectangle(blueBrush, a2);
            if (A3 == 0)
                g.FillRectangle(blackBrush, a3);
            else
                g.FillRectangle(blueBrush, a3);
            if (A4 == 0)
                g.FillRectangle(blackBrush, a4);
            else 
                g.FillRectangle(blueBrush,a4);
            if (B1 == 0)
                g.FillRectangle(blackBrush, b1);
            else
                g.FillRectangle(blueBrush, b1);
            if (B2 == 0)
                g.FillRectangle(blackBrush, b2);
            else
                g.FillRectangle(blueBrush, b2);
            if (B3 == 0)
                g.FillRectangle(blackBrush, b3);
            else
                g.FillRectangle(blueBrush, b3);
            if (B4 == 0)
                g.FillRectangle(blackBrush, b4);
            else
                g.FillRectangle(blueBrush, b4);
            if (C1 == 0)
                g.FillRectangle(blackBrush, c1);
            else
                g.FillRectangle(blueBrush, c1);
            if (C2 == 0)
                g.FillRectangle(blackBrush, c2);
            else
                g.FillRectangle(blueBrush, c2);
            if (C3 == 0)
                g.FillRectangle(blackBrush, c3);
            else
                g.FillRectangle(blueBrush, c3);
            if (C4 == 0)
                g.FillRectangle(blackBrush, c4);
            else
                g.FillRectangle(blueBrush, c4);
            if (D1 == 0)
                g.FillRectangle(blackBrush, d1);
            else
                g.FillRectangle(blueBrush, d1);
            if (D2 == 0)
                g.FillRectangle(blackBrush, d2);
            else
                g.FillRectangle(blueBrush, d2);
            if (D3 == 0)
                g.FillRectangle(blackBrush, d3);
            else
                g.FillRectangle(blueBrush, d3);
            if (D4 == 0)
                g.FillRectangle(blackBrush, d4);
            else
                g.FillRectangle(blueBrush, d4);


            //generating live square 
            g.FillRectangle(greyBrush, live);

            //generating floor
            g.FillRectangle(greyBrush, bottom);




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//chaking when keys are pressed down and activating their boolean
            switch (e.KeyCode)
            {
                case Keys.A:
                    if ( live.X > 60)
                        live.X -= 75;
                    break;
                case Keys.D:
                    if ( live.X < 275)
                        live.X += 75;
                    break;
                case Keys.S:
                        live.Y += 75;
                    break;
            }

            }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            }
       

        private void timer2_Tick(object sender, EventArgs e)
        {//moving the box dow 
            live.Y += 75;
        }

        private void leftrighttimer_Tick(object sender, EventArgs e)
        {
           
        }
        private void horisontalmove()
        {   
            
        }
    }
}
