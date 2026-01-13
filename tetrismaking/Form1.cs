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
       
        //invisible swuares n stuff
        Rectangle a1 = new Rectangle(60, 250, 70, 70);
        Rectangle a2 = new Rectangle(135, 250, 70, 70);
        Rectangle a3 = new Rectangle(210, 250, 70, 70);
        Rectangle a4 = new Rectangle(285, 250, 70, 70); 
        Rectangle b1 = new Rectangle(60, 325, 70, 70);
        Rectangle b2 = new Rectangle(135, 325, 70, 70);
        Rectangle b3 = new Rectangle(210, 325, 70, 70);
        Rectangle b4 = new Rectangle(285, 325, 70, 70);
        Rectangle c1 = new Rectangle(60, 400, 70, 70);
        Rectangle c2 = new Rectangle(135, 400, 70, 70);
        Rectangle c3 = new Rectangle(210, 400, 70, 70);
        Rectangle c4 = new Rectangle(285, 400, 70, 70);
        Rectangle d1 = new Rectangle(60, 475, 70, 70);
        Rectangle d2 = new Rectangle(135, 475, 70, 70);
        Rectangle d3 = new Rectangle(210, 475, 70, 70);
        Rectangle d4 = new Rectangle(285, 475, 70, 70);

        //live square 
        Rectangle live = new Rectangle(60, 25, 70, 70);

        //top squares that sense if the game ends
        Rectangle e1 = new Rectangle(60, 175, 70, 70);
        Rectangle e2 = new Rectangle(135, 175, 70, 70);
        Rectangle e3 = new Rectangle(210, 175, 70, 70);
        Rectangle e4 = new Rectangle(285, 175, 70, 70);
        //and their respective ints 
        int E1 = 0;
        int E2 = 0;
        int E3 = 0;
        int E4 = 0;


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

        //random number generator 
        Random randgen = new Random();

        //int to determine the shape of the block
        int shape = 1;

        //if you have or have not lost 
        Boolean lost = false;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Invalidate();
            //checking if each grid space intersects with the player and then upping their int
            //if a 1 by 1 square so only checks square under it 
            if (shape == 1)
            {
                if (e1.IntersectsWith(live) && A1 == 1)
                    gameend();//gameend triggers if the squares above are triggered and you lose 
                if (e2.IntersectsWith(live) && A2 == 1)
                    gameend();
                if (e3.IntersectsWith(live) && A3 == 1)
                    gameend();
                if (e4.IntersectsWith(live) && A4 == 1)
                    gameend();


                if (a1.IntersectsWith(live) && B1 == 1)
                { A1 = 1; returnlive(); }

                if (a2.IntersectsWith(live) && B2 == 1)
                { A2 = 1; returnlive(); }

                if (a3.IntersectsWith(live) && B3 == 1)
                { A3 = 1; returnlive(); }

                if (a4.IntersectsWith(live) && B4 == 1)
                { A4 = 1; returnlive(); }

                if (b1.IntersectsWith(live) && C1 == 1)
                { B1 = 1; returnlive(); }

                if (b2.IntersectsWith(live) && C2 == 1)
                { B2 = 1; returnlive(); }

                if (b3.IntersectsWith(live) && C3 == 1)
                { B3 = 1; returnlive(); }

                if (b4.IntersectsWith(live) && C4 == 1)
                { B4 = 1; returnlive(); }

                if (c1.IntersectsWith(live) && D1 == 1)
                { C1 = 1; returnlive(); }

                if (c2.IntersectsWith(live) && D2 == 1)
                { C2 = 1; returnlive(); }

                if (c3.IntersectsWith(live) && D3 == 1)
                { C3 = 1; returnlive(); }

                if (c4.IntersectsWith(live) && D4 == 1)
                { C4 = 1; returnlive(); }

                if (d1.IntersectsWith(live))
                { D1 = 1; returnlive(); }

                if (d2.IntersectsWith(live))
                { D2 = 1; returnlive(); }

                if (d3.IntersectsWith(live))
                { D3 = 1; returnlive(); }

                if (d4.IntersectsWith(live))
                { D4 = 1; returnlive(); }
            }
            if (shape == 2)
            {//tall shape 2x1, senses the bottom square and then manually fils in the one above 
                if (a1.IntersectsWith(live) && B1 == 1)
                { A1 = 1; gameend(); }

                if (a2.IntersectsWith(live) && B2 == 1)
                { A2 = 1;gameend(); }

                if (a3.IntersectsWith(live) && B3 == 1)
                { A3 = 1; gameend(); }

                if (a4.IntersectsWith(live) && B4 == 1)
                { A4 = 1; gameend(); }

                if (b1.IntersectsWith(live) && C1 == 1)
                { B1 = 1; A1 = 1; returnlive(); }

                if (b2.IntersectsWith(live) && C2 == 1)
                { B2 = 1; A2 = 1; returnlive(); }

                if (b3.IntersectsWith(live) && C3 == 1)
                { B3 = 1; A3 = 1; returnlive(); }

                if (b4.IntersectsWith(live) && C4 == 1)
                { B4 = 1; A4 = 1; returnlive(); }

                if (c1.IntersectsWith(live) && D1 == 1)
                { C1 = 1; B1 = 1; returnlive(); }

                if (c2.IntersectsWith(live) && D2 == 1)
                { C2 = 1; B2 = 1; returnlive(); }

                if (c3.IntersectsWith(live) && D3 == 1)
                { C3 = 1; B3 = 1; returnlive(); }

                if (c4.IntersectsWith(live) && D4 == 1)
                { C4 = 1; B4 = 1; returnlive(); }

                if (d1.IntersectsWith(live))
                { D1 = 1; C1 = 1; returnlive(); }

                if (d2.IntersectsWith(live))
                { D2 = 1;C2 = 1; returnlive(); }

                if (d3.IntersectsWith(live))
                { D3 = 1; C3 = 1; returnlive(); }

                if (d4.IntersectsWith(live))
                { D4 = 1; C4 = 1; returnlive(); }

            }
            if (shape == 3)
            {//wide square, only has three lateral positions so only three per level
                if (e1.IntersectsWith(live) && A1 == 1)
                { A1 = 1; A2 = 1; gameend(); }

                if (e2.IntersectsWith(live) && A2 == 1)
                { A2 = 1; A3 = 1; gameend(); }

                if (e3.IntersectsWith(live) && A3 == 1)
                { A3 = 1; A4 = 1; gameend(); }



                if (a1.IntersectsWith(live) && B1 == 1)
                { A1 = 1; A2 = 1; returnlive(); }

                if (a2.IntersectsWith(live) && B2 == 1)
                { A2 = 1; A3 = 1; returnlive(); }

                if (a3.IntersectsWith(live) && B3 == 1)
                { A3 = 1; A4 = 1; returnlive(); }

               

                if (b1.IntersectsWith(live) && C1 == 1)
                { B1 = 1; B2 = 1; returnlive(); }

                if (b2.IntersectsWith(live) && C2 == 1)
                { B2 = 1; B3 = 1; returnlive(); }

                if (b3.IntersectsWith(live) && C3 == 1)
                { B3 = 1; B4 = 1; returnlive(); }

             

                if (c1.IntersectsWith(live) && D1 == 1)
                { C1 = 1; C2 = 1; returnlive(); }

                if (c2.IntersectsWith(live) && D2 == 1)
                { C2 = 1; C3 = 1; returnlive(); }

                if (c3.IntersectsWith(live) && D3 == 1)
                { C3 = 1; C4 = 1; returnlive(); }


                if (d1.IntersectsWith(live))
                { D1 = 1; D2 = 1; returnlive(); }

                if (d2.IntersectsWith(live))
                { D2 = 1; D3 = 1; returnlive(); }

                if (d3.IntersectsWith(live))
                { D3 = 1; D4 = 1; returnlive(); }

               
            }

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
            if (Ctotal == 4)
            {
                realscore += 4;
                C1 = 0;
                C2 = 0;
                C3 = 0;
                C4 = 0;
                rowC = true;
                moverows();

            }
            if (Btotal == 4)
            {
                realscore += 4;
                B1 = 0;
                B2 = 0;
                B3 = 0;
                B4 = 0;
                rowB = true;
                moverows();

            }
            if (Atotal == 4)
            {
                realscore += 4;
                A1 = 0;
                A2 = 0;
                A3 = 0;
                A4 = 0;
                rowA = true;
                moverows();

            }




        }
        private void returnlive()
        {
            Thread.Sleep(10);
            //moving the square back up
            live.Y = 25;
           
            //randomly generating the next shape
           shape= randgen.Next(1, 4);
            //based on number changing shape length
            if (shape == 1)
            {
                live.Height = 70;
                live.Width = 70;
            }

            if (shape == 2)
            {
                live.Height = 145;
                live.Width = 70;
            }
            if (shape == 3)
            {
                live.Height = 70;
                live.Width = 145;
                if ( live.X == 285)
                    live.X = 210;
            }
        }
        private void moverows()
        {//if the entire bottom row is full 
            if (rowD == true)
            {
                {//manually checking if the square above is occupied then moving the value down
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
            {//if row d or row c is filled then same as above but upper rows
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
            {//the pattern continues 
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
        {//initializing graphics 
            Graphics g = e.Graphics;
          //what shows if you have not lost 
            if (lost == false)
            {
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
                    g.FillRectangle(blueBrush, a4);
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
            }

          




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           //movement for each shape
           //1x1 square so has many degrees of freedom 
            if (shape == 1)
            {//only works above the grid, once within can no longer move 
                if (live.Y < 250)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.A:
                            if (live.X > 60)
                                live.X -= 75;
                            break;
                        case Keys.D:
                            if (live.X < 275)
                                live.X += 75;
                            break;
                        case Keys.S:
                            live.Y += 75;
                            break;
                    }
                }
            }//tall square, mostly simmilar to 1x1
            if (shape == 2)
            {

                if (live.Y < 250)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.A:
                            if (live.X > 60)
                                live.X -= 75;
                            break;
                        case Keys.D:
                            if (live.X < 275)
                                live.X += 75;
                            break;
                        case Keys.S:
                            live.Y += 75;
                            break;

                    }
                }
            }
            //wide shape, cant move too far to the right so it doesnt clip out of bounds 
            if (shape == 3)
            {
                if (live.X > 210)
                    live.X = 210;
                if (live.Y < 250)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.A:
                            if (live.X > 60)
                                live.X -= 75;
                            break;
                        case Keys.D:
                            if (live.X < 200)
                                live.X += 75;
                            break;
                        case Keys.S:
                            live.Y += 75;
                            break;

                    }
                }
            }
            }
        private void gameend() 
        {
            lost = true;
        
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
