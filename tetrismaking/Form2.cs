using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tetrismaking
{    
    public partial class Form2 : Form
    {//initalizing brushes :)
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush cyanBrush = new SolidBrush(Color.Cyan);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush orangleBrush = new SolidBrush(Color.Orange);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush greyBrush = new SolidBrush(Color.Gray);
        Pen greyPen = new Pen(Color.Gray, 3);

        //invisible swuares n stuff
        Rectangle a1 = new Rectangle(60, 325, 70, 70);
        Rectangle a2 = new Rectangle(135, 325, 70, 70);
        Rectangle a3 = new Rectangle(210, 325, 70, 70);
        Rectangle a4 = new Rectangle(285, 325, 70, 70);
        Rectangle b1 = new Rectangle(60, 400, 70, 70);
        Rectangle b2 = new Rectangle(135, 400, 70, 70);
        Rectangle b3 = new Rectangle(210, 400, 70, 70);
        Rectangle b4 = new Rectangle(285, 400, 70, 70);
        Rectangle c1 = new Rectangle(60, 475, 70, 70);
        Rectangle c2 = new Rectangle(135, 475, 70, 70);
        Rectangle c3 = new Rectangle(210, 475, 70, 70);
        Rectangle c4 = new Rectangle(285, 475, 70, 70);
        Rectangle d1 = new Rectangle(60, 550, 70, 70);
        Rectangle d2 = new Rectangle(135, 550, 70, 70);
        Rectangle d3 = new Rectangle(210, 550, 70, 70);
        Rectangle d4 = new Rectangle(285, 550, 70, 70);

        Rectangle e1 = new Rectangle(60, 250, 70, 70);
        Rectangle e2 = new Rectangle(135, 250, 70, 70);
        Rectangle e3 = new Rectangle(210, 250, 70, 70);
        Rectangle e4 = new Rectangle(285, 250, 70, 70);

        //live square 
        Rectangle live = new Rectangle(60, 25, 70, 70);

        //top squares that sense if the game ends
        Rectangle f1 = new Rectangle(60, 175, 70, 70);
        Rectangle f2 = new Rectangle(135, 175, 70, 70);
        Rectangle f3 = new Rectangle(210, 175, 70, 70);
        Rectangle f4 = new Rectangle(285, 175, 70, 70);
        //and their respective ints 
        int F1 = 0;
        int F2 = 0;
        int F3 = 0;
        int F4 = 0;


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
        int E1 = 0;
        int E2 = 0;
        int E3 = 0;
        int E4 = 0;

        //for determining the color of the shape that filled them
        //A value of 1 is red, 2 is orange and 3 is cyan

        int A11 = 0;
        int A22 = 0;
        int A33 = 0;
        int A44 = 0;
        int B11 = 0;
        int B22 = 0;
        int B33 = 0;
        int B44 = 0;
        int C11 = 0;
        int C22 = 0;
        int C33 = 0;
        int C44 = 0;
        int D11 = 0;
        int D22 = 0;
        int D33 = 0;
        int D44 = 0;
        int E11 = 0;
        int E22 = 0;
        int E33 = 0;
        int E44 = 0;

        //socre 
        int score = 0;
        int realscore;
     

        //checking which row is full
        Boolean rowE = false;
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

        //external file handling hopefully
        string filePath = @"C:\Users\csimm\Documents\tetrisscores.txt";
        List<Player> winners = new List<Player>
          {//default scores
        new Player { Name = "Dave", Score = 25 },
        new Player { Name = "Adam", Score= 74 },
        new Player { Name = "God", Score= 10 }
          };

        //array to store and then display the next few blocks 
        int[] nextblock = new int[5];

        //int to save the prior value of the swuare
        int oldsquare = 0;
        public Form2()
        {
            InitializeComponent();
        }
        class Player
        {
            //actually making the ids for each player so the scoring will worksssss
            public string Name { get; set; }
            public int Score { get; set; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < nextblock.Length; i++) {
                nextblock[i]= randgen.Next(1,4);
            }

        }

        private void invalidatetimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            //checking if each grid space intersects with the player and then upping their int
            //if a 1 by 1 square so only checks square under it 
            if (shape == 1)
            {
                if (f1.IntersectsWith(live) && E1 == 1)
                    gameend();//gameend triggers if the squares above are triggered and you lose 
                if (f2.IntersectsWith(live) && E2 == 1)
                    gameend();
                if (f3.IntersectsWith(live) && E3 == 1)
                    gameend();
                if (f4.IntersectsWith(live) && E4 == 1)
                    gameend();

                if (e1.IntersectsWith(live) && A1 == 1)
                { E1 = 1; E11 = 1; returnlive(); }

                if (e2.IntersectsWith(live) && A2 == 1)
                { E2 = 1; E22 = 1; returnlive(); }

                if (e3.IntersectsWith(live) && A3 == 1)
                { E3 = 1; E33 = 1; returnlive(); }

                if (e4.IntersectsWith(live) && A4 == 1)
                { E4 = 1; E44 = 1; returnlive(); }
                //return live moves the square up and changes its shape 
                if (a1.IntersectsWith(live) && B1 == 1)
                { A1 = 1; A11 = 1; returnlive(); }

                if (a2.IntersectsWith(live) && B2 == 1)
                { A2 = 1; A22 = 1; returnlive(); }

                if (a3.IntersectsWith(live) && B3 == 1)
                { A3 = 1; A33 = 1; returnlive(); }

                if (a4.IntersectsWith(live) && B4 == 1)
                { A4 = 1; A44 = 1; returnlive(); }

                if (b1.IntersectsWith(live) && C1 == 1)
                { B1 = 1; B11 = 1; returnlive(); }

                if (b2.IntersectsWith(live) && C2 == 1)
                { B2 = 1; B22 = 1; returnlive(); }

                if (b3.IntersectsWith(live) && C3 == 1)
                { B3 = 1; B33 = 1; returnlive(); }

                if (b4.IntersectsWith(live) && C4 == 1)
                { B4 = 1; B44 = 1; returnlive(); }

                if (c1.IntersectsWith(live) && D1 == 1)
                { C1 = 1; C11 = 1; returnlive(); }

                if (c2.IntersectsWith(live) && D2 == 1)
                { C2 = 1; C22 = 1; returnlive(); }

                if (c3.IntersectsWith(live) && D3 == 1)
                { C3 = 1; C33 = 1; returnlive(); }

                if (c4.IntersectsWith(live) && D4 == 1)
                { C4 = 1; C44 = 1; returnlive(); }

                if (d1.IntersectsWith(live))
                { D1 = 1; D11 = 1; returnlive(); }

                if (d2.IntersectsWith(live))
                { D2 = 1; D22 = 1; returnlive(); }

                if (d3.IntersectsWith(live))
                { D3 = 1; D33 = 1; returnlive(); }

                if (d4.IntersectsWith(live))
                { D4 = 1; D44 = 1; returnlive(); }
            }
            if (shape == 2)
            {//tall shape 2x1, senses the bottom square and then manually fils in the one above 
                if (e1.IntersectsWith(live) && A1 == 1)
                { E1 = 1; E11 = 2; gameend(); }

                if (e2.IntersectsWith(live) && A2 == 1)
                { E2 = 1; E22 = 2; gameend(); }

                if (e3.IntersectsWith(live) && A3 == 1)
                { E3 = 1; E33 = 2; gameend(); }

                if (e4.IntersectsWith(live) && A4 == 1)
                { E4 = 1; E44 = 2; gameend(); }
                //affects two spaces but only checks for the bottom square 
                if (a1.IntersectsWith(live) && B1 == 1)
                { E1 = 1; A1 = 1; E11 = 2; A11 = 2; returnlive(); }

                if (a2.IntersectsWith(live) && B2 == 1)
                { E2 = 1; A2 = 1; E22 = 2; A22 = 2; returnlive(); }

                if (a3.IntersectsWith(live) && B3 == 1)
                { E3 = 1; A3 = 1; E33 = 2; A33 = 2; returnlive(); }

                if (a4.IntersectsWith(live) && B4 == 1)
                { E4 = 1; A4 = 1; E44 = 2; A44 = 2; returnlive(); }

                if (b1.IntersectsWith(live) && C1 == 1)
                { B1 = 1; A1 = 1; B11 = 2; A11 = 2; returnlive(); }

                if (b2.IntersectsWith(live) && C2 == 1)
                { B2 = 1; A2 = 1; B22 = 2; A22 = 2; returnlive(); }

                if (b3.IntersectsWith(live) && C3 == 1)
                { B3 = 1; A3 = 1; B33 = 2; A33 = 2; returnlive(); }

                if (b4.IntersectsWith(live) && C4 == 1)
                { B4 = 1; A4 = 1; B44 = 2; A44 = 2; returnlive(); }

                if (c1.IntersectsWith(live) && D1 == 1)
                { C1 = 1; B1 = 1; B11 = 2; C11 = 2; returnlive(); }

                if (c2.IntersectsWith(live) && D2 == 1)
                { C2 = 1; B2 = 1; B22 = 2; C22 = 2; returnlive(); }

                if (c3.IntersectsWith(live) && D3 == 1)
                { C3 = 1; B3 = 1; B33 = 2; C33 = 2; returnlive(); }

                if (c4.IntersectsWith(live) && D4 == 1)
                { C4 = 1; B4 = 1; B44 = 2; C44 = 2; returnlive(); }

                if (d1.IntersectsWith(live))
                { D1 = 1; C1 = 1; D11 = 2; C11 = 2; returnlive(); }

                if (d2.IntersectsWith(live))
                { D2 = 1; C2 = 1; D22 = 2; C22 = 2; returnlive(); }

                if (d3.IntersectsWith(live))
                { D3 = 1; C3 = 1; D33 = 2; C33 = 2; returnlive(); }

                if (d4.IntersectsWith(live))
                { D4 = 1; C4 = 1; D44 = 2; C44 = 2; returnlive(); }

            }
            if (shape == 3)
            {//wide square, only has three lateral positions so only three per level
                if (f1.IntersectsWith(live) && E1 == 1 || f1.IntersectsWith(live) && E2 == 1)
                { E1 = 1; E2 = 1; E11 = 3; E22 = 3; gameend(); }

                if (f2.IntersectsWith(live) && E2 == 1 || f2.IntersectsWith(live) && E3 == 1)
                { E2 = 1; E3 = 1; E33 = 3; E22 = 3; gameend(); }

                if (f3.IntersectsWith(live) && E3 == 1 || f3.IntersectsWith(live) && E4 == 1)
                { E3 = 1; E4 = 1; E33 = 3; E44 = 3; gameend(); }


                //only technically exists as the left square but has an overlay that shows 2 wide 
                //also checks if the square diagonally below it is full so it doesnt pass thru
                if (e1.IntersectsWith(live) && A1 == 1 || e1.IntersectsWith(live) && A2 == 1)
                { E1 = 1; E2 = 1; E11 = 3; E22 = 3; returnlive(); }

                if (e2.IntersectsWith(live) && A2 == 1 || e2.IntersectsWith(live) && A3 == 1)
                { E2 = 1; E3 = 1; E33 = 3; E22 = 3; returnlive(); }

                if (e3.IntersectsWith(live) && A3 == 1 || e3.IntersectsWith(live) && A4 == 1)
                { E3 = 1; E4 = 1; E33 = 3; E44 = 3; returnlive(); }

                if (a1.IntersectsWith(live) && B1 == 1 || a1.IntersectsWith(live) && B2 == 1)
                { A1 = 1; A2 = 1; A11 = 3; A22 = 3; returnlive(); }

                if (a2.IntersectsWith(live) && B2 == 1 || a2.IntersectsWith(live) && B3 == 1)
                { A2 = 1; A3 = 1; A33 = 3; A22 = 3; returnlive(); }

                if (a3.IntersectsWith(live) && B3 == 1 || a3.IntersectsWith(live) && B4 == 1)
                { A3 = 1; A4 = 1; A33 = 3; A44 = 3; returnlive(); }



                if (b1.IntersectsWith(live) && C1 == 1 || b1.IntersectsWith(live) && C2 == 1)
                { B1 = 1; B2 = 1; B11 = 3; B22 = 3; returnlive(); }

                if (b2.IntersectsWith(live) && C2 == 1 || b2.IntersectsWith(live) && C3 == 1)
                { B2 = 1; B3 = 1; B22 = 3; B33 = 3; returnlive(); }

                if (b3.IntersectsWith(live) && C3 == 1 || b3.IntersectsWith(live) && C4 == 1)
                { B3 = 1; B4 = 1; B33 = 3; B44 = 3; returnlive(); }



                if (c1.IntersectsWith(live) && D1 == 1 || c1.IntersectsWith(live) && D2 == 1)
                { C1 = 1; C2 = 1; C11 = 3; C22 = 3; returnlive(); }

                if (c2.IntersectsWith(live) && D2 == 1 || c2.IntersectsWith(live) && D3 == 1)
                { C2 = 1; C3 = 1; C22 = 3; C33 = 3; returnlive(); }

                if (c3.IntersectsWith(live) && D3 == 1 || c3.IntersectsWith(live) && D4 == 1)
                { C3 = 1; C4 = 1; C33 = 3; C44 = 3; returnlive(); }


                if (d1.IntersectsWith(live))
                { D1 = 1; D2 = 1; D11 = 3; D22 = 3; returnlive(); }

                if (d2.IntersectsWith(live))
                { D2 = 1; D3 = 1; D33 = 3; D22 = 3; returnlive(); }

                if (d3.IntersectsWith(live))
                { D3 = 1; D4 = 1; D33 = 3; D44 = 3; returnlive(); }


            }

            //adding up the total value of each row 
           // rowD = false;
           // rowC=false;
           // rowB=false;
           // rowA=false;
           // rowE = false;
            int Etotal = E1 + E2 + E3 + E4;
            int Atotal = A1 + A2 + A3 + A4;
            int Btotal = B1 + B2 + B3 + B4;
            int Ctotal = C1 + C2 + C3 + C4;
            int Dtotal = D1 + D2 + D3 + D4;

            //scorelabel.Text = Etotal + " " + Atotal + " " + Btotal + " " + Ctotal + "  " + Dtotal;
            //if a row is filled clearing it and shifting ti down
            if (Dtotal == 4 || Ctotal == 4 || Btotal == 4 || Atotal == 4)
            {
                if (Dtotal == 4)
                {
                    realscore += 4;
                    //making unoccupied
                    D1 = 0;
                    D2 = 0;
                    D3 = 0;
                    D4 = 0;
                    //making black
                    D11 = 0;
                    D22 = 0;
                    D33 = 0;
                    D44 = 0;
                    //telling the next function which is row is full
                    rowD = true;
                    //starting the next function
                   // moverows();

                }
                if (Ctotal == 4)
                {
                    realscore += 4;
                    C1 = 0;
                    C2 = 0;
                    C3 = 0;
                    C4 = 0;
                    C11 = 0;
                    C22 = 0;
                    C33 = 0;
                    C44 = 0;
                    rowC = true;
                   // moverows();

                }
                if (Btotal == 4)
                {
                    realscore += 4;
                    B1 = 0;
                    B2 = 0;
                    B3 = 0;
                    B4 = 0;
                    B11 = 0;
                    B22 = 0;
                    B33 = 0;
                    B44 = 0;
                    rowB = true;
                   // moverows();

                }
                if (Atotal == 4)
                {
                    realscore += 4;
                    A1 = 0;
                    A2 = 0;
                    A3 = 0;
                    A4 = 0;
                    A11 = 0;
                    A22 = 0;
                    A33 = 0;
                    A44 = 0;
                    rowA = true;
                   // moverows();

                }
                if (Etotal == 4)
                {
                    realscore += 4;
                    E1 = 0;
                    E2 = 0;
                    E3 = 0;
                    E4 = 0;
                    E11 = 0;
                    E22 = 0;
                    E33 = 0;
                    E44 = 0;
                    rowE = true;
                   // moverows();

                }
                moverows();
            }



        }
        private void returnlive()
        {//remebering the prior square
            oldsquare = shape;

            //moving the square back up
            live.Y = 25;
            if (gravitytimer.Interval > 250)
                gravitytimer.Interval -= 25;
            //pulling the next shape from the array
            shape = nextblock[1];
            //shifting them all down
            for (int i = 0; i < nextblock.Length-1; i++) {
                nextblock[i]=nextblock[i+1];
            }
            //making a new last block
            nextblock[4] = randgen.Next(1, 4);

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
            //this one is actually the same as shape 1 but will be rendered differently
            if (shape == 3)
            {
                live.Height = 70;
                live.Width = 70;
                if (live.X == 285)
                    live.X = 210;
            }
        }
        private void moverows()
        {
            //make it so that if you clear two rows at the same time 
            //the whole grid clears and adds a bunch to your score 
           if (rowD==true && rowC==true|| rowC==true &&rowB==true|| rowB==true && rowA==true|| rowA==true&&rowE==true)
            {//making sure it was acctually the right swuare
                if (oldsquare == 2)
                {
                    //increases score
                    realscore += 12;
                    //stops block from falling
                    gravitytimer.Enabled = false;
                    //clearing the whole grid
                    D11 = D22 = D33 = D44 = C11 = C22 = C33 = C44 = B11 = B22 = B33 = B44 = A11 = A22 = A33 = A44 = E11 = E22 = E33 = E44 = 0;
                    E1 = E2 = E3 = E4 = A1 = A2 = A3 = A4 = B1 = B2 = B3 = B4 = C1 = C2 = C3 = C4 = D1 = D2 = D3 = D4 = 0;
                    //setting all of the squares to yellow
                    D11 = D22 = D33 = D44 = 2;
                    //row by row
                    Refresh();
                    Thread.Sleep(200);
                    C11 = C22 = C33 = C44 = 2;
                    Refresh();
                    Thread.Sleep(200);
                    B11 = B22 = B33 = B44 = 2;
                    Refresh();
                    Thread.Sleep(200);
                    A11 = A22 = A33 = A44 = 2;
                    Refresh();
                    Thread.Sleep(200);
                    E11 = E22 = E33 = E44 = 2;
                    Refresh();
                    Thread.Sleep(200);
                    //flashing the grid so it all goes black
                    D11 = D22 = D33 = D44 = C11 = C22 = C33 = C44 = B11 = B22 = B33 = B44 = A11 = A22 = A33 = A44 = E11 = E22 = E33 = E44 = 0;

                    Refresh();
                    Thread.Sleep(200);
                    //then goes back to yellow 
                    D11 = D22 = D33 = D44 = C11 = C22 = C33 = C44 = B11 = B22 = B33 = B44 = A11 = A22 = A33 = A44 = E11 = E22 = E33 = E44 = 2;
                    Refresh();
                    Thread.Sleep(200);
                    //and finnaly a full clear 
                    D11 = D22 = D33 = D44 = C11 = C22 = C33 = C44 = B11 = B22 = B33 = B44 = A11 = A22 = A33 = A44 = E11 = E22 = E33 = E44 = 0;
                    E1 = E2 = E3 = E4 = A1 = A2 = A3 = A4 = B1 = B2 = B3 = B4 = C1 = C2 = C3 = C4 = D1 = D2 = D3 = D4 = 0;
                    //setting the rows to false 
                    rowE = rowA = rowB = rowC = rowD = false;
                    //letting the block fall agin
                    gravitytimer.Enabled = true;
                }
            }
                //if the bottom row is full
                if (rowD == true)
                {//manually checking if the square above is occupied then moving the value down
                    if (C1 == 1)
                        D1 = 1;
                    D11 = 0;
                    D11 = C11;
                    C11 = 0;
                    C1 = 0;
                }
                if (C2 == 1)
                {
                    D2 = 1;
                    D22 = 0;
                    D22 = C22;
                    C22 = 0;
                    C2 = 0;
                }
                if (C3 == 1)
                {
                    D3 = 1;
                    D33 = 0;
                    D33 = C33;
                    C33 = 0;
                    C3 = 0;
                }
                if (C4 == 1)
                {
                    D4 = 1;
                    D44 = 0;
                    D44 = C44;
                    C44 = 0;
                    C4 = 0;
                }
               
            if (rowD == true || rowC == true)
            {//if row d or row c is filled then same as above but upper rows
                if (B1 == 1)
                {
                    C1 = 1;
                    C11 = B11;
                    B11 = 0;
                    B1 = 0;
                }
                if (B2 == 1)
                {
                    C2 = 1;
                    C22 = B22;
                    B22 = 0;
                    B2 = 0;
                }
                if (B3 == 1)
                {
                    C3 = 1;
                    C33 = B33;
                    B33 = 0;
                    B3 = 0;
                }
                if (B4 == 1)
                {
                    C4 = 1;
                    C44 = B44;
                    B44 = 0;
                    B4 = 0;
                }
        
            }
            if (rowD == true || rowC == true || rowB == true)
            {//the pattern continues 
                if (A1 == 1)
                {
                    B1 = 1;
                    B11 = A11;
                    A11 = 0;
                    A1 = 0;
                }
                if (A2 == 1)
                {
                    B2 = 1;
                    B22 = A22;
                    A22 = 0;
                    A2 = 0;
                }
                if (A3 == 1)
                {
                    B3 = 1;
                    B33 = A33;
                    A33 = 0;
                    A3 = 0;
                }
                if (A4 == 1)
                {
                    B4 = 1;
                    B44 = A44;
                    A44 = 0;
                    A4 = 0;
                }
            
            }
            if (rowD == true || rowC == true || rowB == true || rowA == true)
            {//the pattern continues 
                if (E1 == 1)
                {
                    A1 = 1;
                    A11 = E11;
                    E11 = 0;
                    E1 = 0;
                }
                if (E2 == 1)
                {
                    A2 = 1;
                    A22 = E22;
                    E22 = 0;
                    E2 = 0;
                }
                if (E3 == 1)
                {
                    A3 = 1;
                    A33 = E33;
                    E33 = 0;
                    E3 = 0;
                }
                if (E4 == 1)
                {
                    A4 = 1;
                    A44 = E44;
                    E44 = 0;
                    E4 = 0;
                }
              
            }
            rowD = false;
            //checking if each row is filled or not 
            if (A1+A2+A3+A4 != 4)
                rowA = false;
            if (B1 + B2 + B3 + B4 != 4)
                rowB = false;
            if (C1 + C2 + C3 + C4 != 4)
                rowC = false;
            if (D1 + D2 + D3 + D4 != 4)
                rowD = false;
            if (E1 + E2 + E3 + E4 != 4)
                rowE = false;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //initializing graphics 

            Graphics g = e.Graphics;
            //what shows if you have not lost 
            if (lost == false)
            {
                BackColor = Color.Black;
                //grey box around game
                g.FillRectangle(greyBrush, 50, 20, 5, 605);
                g.FillRectangle(greyBrush, 360, 15, 5, 615);
                g.FillRectangle(greyBrush, 50, 625, 310, 5);
                g.FillRectangle(greyBrush, 50, 15, 310, 5);

                //little hashes to show top of grid 
                g.FillRectangle(greyBrush, 57, 247, 25, 1);
                g.FillRectangle(greyBrush, 57, 247, 1, 20);
                g.FillRectangle(greyBrush, 333, 247, 25, 1);
                g.FillRectangle(greyBrush, 357, 247, 1, 20);

                //dotted line 
                g.FillRectangle(greyBrush, 107, 247, 21, 1);
                g.FillRectangle(greyBrush, 153, 247, 21, 1);
                g.FillRectangle(greyBrush, 199, 247, 21, 1);
                g.FillRectangle(greyBrush, 245, 247, 21, 1);
                g.FillRectangle(greyBrush, 291, 247, 21, 1);

                //little grey line above next blocks
                g.FillRectangle(greyBrush, 370, 120, 65, 3);

                int offset = 0;
                //displaying the next 4 blocks 
                for (int i = 1; i < nextblock.Length; i++) {
                    //an int to make sure they nive down proportinslly 
                    offset += 50;
                    //as long as its not the current block
                    if (i != 1)
                    {//if tall block make ofset bigger 
                        if (nextblock[i - 1] == 2)
                            offset += 25;
                    }
                    //if next is 1x1
                    if (nextblock[i] == 1)
                        //renders mini 1x1
                    { g.FillRectangle(redBrush,375,100+offset,20,20); }
                    //same formula as the 1x1 for the other two blocks 
                    if (nextblock[i]==2) { g.FillRectangle(orangleBrush, 375, 100 + offset, 20, 45); }
                    if (nextblock[i] == 3) { g.FillRectangle(cyanBrush, 375, 100 + offset, 45, 20); } }

                //generating backround grid 
                if (E1 == 0)
                    g.FillRectangle(blackBrush, e1);
                if (E11 == 1)
                    g.FillRectangle(redBrush, e1);
                if (E11 == 2)
                    g.FillRectangle(orangleBrush, e1);
                if (E11 == 3)
                    g.FillRectangle(cyanBrush, e1);
                if (E2 == 0)
                    g.FillRectangle(blackBrush, e2);
                if (E22 == 1)
                    g.FillRectangle(redBrush, e2);
                if (E22 == 2)
                    g.FillRectangle(orangleBrush, e2);
                if (E22 == 3)
                    g.FillRectangle(cyanBrush, e2);
                if (E3 == 0)
                    g.FillRectangle(blackBrush, e3);
                if (E33 == 1)
                    g.FillRectangle(redBrush, e3);
                if (E33 == 2)
                    g.FillRectangle(orangleBrush, e3);
                if (E33 == 3)
                    g.FillRectangle(cyanBrush, e3);
                if (E4 == 0)
                    g.FillRectangle(blackBrush, e4);
                if (E44 == 1)
                    g.FillRectangle(redBrush, e4);
                if (E44 == 2)
                    g.FillRectangle(orangleBrush, e4);
                if (E44 == 3)
                    g.FillRectangle(cyanBrush, e4);


                if (A1 == 0)
                    g.FillRectangle(blackBrush, a1);
                if (A11 == 1)
                    g.FillRectangle(redBrush, a1);
                if (A11 == 2)
                    g.FillRectangle(orangleBrush, a1);
                if (A11 == 3)
                    g.FillRectangle(cyanBrush, a1);

                if (A2 == 0)
                    g.FillRectangle(blackBrush, a2);
                if (A22 == 1)
                    g.FillRectangle(redBrush, a2);
                if (A22 == 2)
                    g.FillRectangle(orangleBrush, a2);
                if (A22 == 3)
                    g.FillRectangle(cyanBrush, a2);
                if (A3 == 0)
                    g.FillRectangle(blackBrush, a3);
                if (A33 == 1)
                    g.FillRectangle(redBrush, a3);
                if (A33 == 2)
                    g.FillRectangle(orangleBrush, a3);
                if (A33 == 3)
                    g.FillRectangle(cyanBrush, a3);
                if (A4 == 0)
                    g.FillRectangle(blackBrush, a4);
                if (A44 == 1)
                    g.FillRectangle(redBrush, a4);
                if (A44 == 2)
                    g.FillRectangle(orangleBrush, a4);
                if (A44 == 3)
                    g.FillRectangle(cyanBrush, a4);
                if (B1 == 0)
                    g.FillRectangle(blackBrush, b1);
                if (B11 == 1)
                    g.FillRectangle(redBrush, b1);
                if (B11 == 2)
                    g.FillRectangle(orangleBrush, b1);
                if (B11 == 3)
                    g.FillRectangle(cyanBrush, b1);
                if (B2 == 0)
                    g.FillRectangle(blackBrush, b2);
                if (B22 == 1)
                    g.FillRectangle(redBrush, b2);
                if (B22 == 2)
                    g.FillRectangle(orangleBrush, b2);
                if (B22 == 3)
                    g.FillRectangle(cyanBrush, b2);
                if (B3 == 0)
                    g.FillRectangle(blackBrush, b3);
                if (B33 == 1)
                    g.FillRectangle(redBrush, b3);
                if (B33 == 2)
                    g.FillRectangle(orangleBrush, b3);
                if (B33 == 3)
                    g.FillRectangle(cyanBrush, b3);
                if (B4 == 0)
                    g.FillRectangle(blackBrush, b4);
                if (B44 == 1)
                    g.FillRectangle(redBrush, b4);
                if (B44 == 2)
                    g.FillRectangle(orangleBrush, b4);
                if (B44 == 3)
                    g.FillRectangle(cyanBrush, b4);

                if (C1 == 0)
                    g.FillRectangle(blackBrush, c1);
                if (C11 == 1)
                    g.FillRectangle(redBrush, c1);
                if (C11 == 2)
                    g.FillRectangle(orangleBrush, c1);
                if (C11 == 3)
                    g.FillRectangle(cyanBrush, c1);
                if (C2 == 0)
                    g.FillRectangle(blackBrush, c2);
                if (C22 == 1)
                    g.FillRectangle(redBrush, c2);
                if (C22 == 2)
                    g.FillRectangle(orangleBrush, c2);
                if (C22 == 3)
                    g.FillRectangle(cyanBrush, c2);
                if (C3 == 0)
                    g.FillRectangle(blackBrush, c3);
                if (C33 == 1)
                    g.FillRectangle(redBrush, c3);
                if (C33 == 2)
                    g.FillRectangle(orangleBrush, c3);
                if (C33 == 3)
                    g.FillRectangle(cyanBrush, c3);
                if (C4 == 0)
                    g.FillRectangle(blackBrush, c4);
                if (C44 == 1)
                    g.FillRectangle(redBrush, c4);
                if (C44 == 2)
                    g.FillRectangle(orangleBrush, c4);
                if (C44 == 3)
                    g.FillRectangle(cyanBrush, c4);

                if (D1 == 0)
                    g.FillRectangle(blackBrush, d1);
                if (D11 == 1)
                    g.FillRectangle(redBrush, d1);
                if (D11 == 2)
                    g.FillRectangle(orangleBrush, d1);
                if (D11 == 3)
                    g.FillRectangle(cyanBrush, d1);
                if (D2 == 0)
                    g.FillRectangle(blackBrush, d2);
                if (D22 == 1)
                    g.FillRectangle(redBrush, d2);
                if (D22 == 2)
                    g.FillRectangle(orangleBrush, d2);
                if (D22 == 3)
                    g.FillRectangle(cyanBrush, d2);
                if (D3 == 0)
                    g.FillRectangle(blackBrush, d3);
                if (D33 == 1)
                    g.FillRectangle(redBrush, d3);
                if (D33 == 2)
                    g.FillRectangle(orangleBrush, d3);
                if (D33 == 3)
                    g.FillRectangle(cyanBrush, d3);
                if (D4 == 0)
                    g.FillRectangle(blackBrush, d4);
                if (D44 == 1)
                    g.FillRectangle(redBrush, d4);
                if (D44 == 2)
                    g.FillRectangle(orangleBrush, d4);
                if (D44 == 3)
                    g.FillRectangle(cyanBrush, d4);

                //generating live square 
                //if 1x1 then red
                if (shape == 1)
                    g.FillRectangle(redBrush, live);
                //if 2x1 tall then orange
                if (shape == 2)
                {
                    g.FillRectangle(orangleBrush, live);
                    //giving a grid like apperance so cutting it in half
                    g.FillRectangle(blackBrush, live.X, live.Y + 70, 70, 5);
                }
                //if 1x2 wide then red
                if (shape == 3)
                {//is technically a 1x1 but with a wide overlayed above it 
                    //real live
                    g.FillRectangle(cyanBrush, live);
                    //visually live 
                    g.FillRectangle(cyanBrush, live.X, live.Y, 145, 70);
                    //black line thru the middle 
                    g.FillRectangle(blackBrush, live.X + 70, live.Y, 5, 70);
                }
            }
            if (lost == true)
            {//making all the labels visible and displaying score 
                scorelabel.Visible = true;
                displaylabel.Visible = true;
                display2label.Visible = true;
                namebox.Enabled = true;
                namebox.Visible = true;
                nextuplabel.Visible = false;
                scorelabel.Text = realscore + "";
               // leaderboardlabel.Text = "";
                namebutton.Visible = true;
                
               


            }
            
        }

        private void gravitytimer_Tick(object sender, EventArgs e)
        {
            //moving the box dow 
            live.Y += 75;
        }
        private void gameend()//when you overfill the box and the gane ends
        {//stopping the movement of the live block
            gravitytimer.Enabled = false;
           //moving it off the screen 
            live.X = 800;
            BackColor = Color.Black;
            //animation of the whole thing slowly filling up
            D11 = 1; 
            Refresh();
            Thread.Sleep(100);
            D22 = 2;
            Refresh();
            Thread.Sleep(100);
            D33 = 3;
            Refresh();
            Thread.Sleep(100);
            D44 = 1;
            Refresh();
            Thread.Sleep(100);
            C11 = 2;
            Refresh();
            Thread.Sleep(100);
            C22 = 3;
            Refresh();
            Thread.Sleep(100);
            C33 = 1;
            Refresh();
            Thread.Sleep(100);
            C44 = 2;
            Refresh();
            Thread.Sleep(100);
            B11 = 3;
            Refresh();
            Thread.Sleep(100);
            B22 = 1;
            Refresh();
            Thread.Sleep(100);
            B33 = 2;
            Refresh();
            Thread.Sleep(100);
            B44 = 3;
            Refresh();
            Thread.Sleep(100);
            A11 = 1;
            Refresh();
            Thread.Sleep(100);
            A22 = 2;
            Refresh();
            Thread.Sleep(100);
            A33 = 3;
            Refresh();
            Thread.Sleep(100);
            A44 = 1;
            Refresh();
            Thread.Sleep(100);
            E11 = 2;
            Refresh();
            Thread.Sleep(100);
            E22 = 3;
            Refresh();
            Thread.Sleep(100);
            E33 = 1;
            Refresh();
            Thread.Sleep(100);
            E44 = 2;
            Refresh();
            Thread.Sleep(100);
            Refresh();
            lost = true;
         
        

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {  //in case of frame perfect movement where the player clips thru the floor
            if (lost == false)
            {
                if (live.Y > 600)
                    returnlive();
                //movement for each shape
                //1x1 square so has many degrees of freedom 
                if (shape == 1)
                {//only works above the grid, once within can no longer move 

                    switch (e.KeyCode)
                    {
                        case Keys.A:
                            if (live.X > 60 && live.Y < 250)
                                live.X -= 75;
                            break;
                        case Keys.D:
                            if (live.X < 275 && live.Y < 250)
                                live.X += 75;
                            break;
                        case Keys.S:
                            live.Y += 75;
                            break;
                    }

                }//tall square, mostly simmilar to 1x1
                if (shape == 2)
                {


                    switch (e.KeyCode)
                    {
                        case Keys.A:
                            if (live.X > 60 && live.Y < 250)
                                live.X -= 75;
                            break;
                        case Keys.D:
                            if (live.X < 275 && live.Y < 250)
                                live.X += 75;
                            break;
                        case Keys.S:
                            live.Y += 75;
                            break;


                    }
                }
                //wide shape, cant move too far to the right so it doesnt clip out of bounds 
                if (shape == 3)
                {
                    if (live.X > 210)
                        live.X = 210;

                    switch (e.KeyCode)
                    {
                        case Keys.A:
                            if (live.X > 60 && live.Y < 250)
                                live.X -= 75;
                            break;
                        case Keys.D:
                            if (live.X < 200 && live.Y < 250)
                                live.X += 75;
                            break;
                        case Keys.S:
                            live.Y += 75;
                            realscore += 1;
                            break;


                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void namebutton_Click(object sender, EventArgs e)
        {//getting the players name

            namebutton.Enabled = false;
            namebutton.Visible = false;
            winners.Clear();//clear list before adding items read from file

            string[] lines = File.ReadAllLines(filePath);
            //read the file in, line by line into an array
            string name2;
            int score1;
            for (int i = 0; i < lines.Length; i = i + 2)
            {
                name2 = lines[i];
                //read the 'ith' line in and it will be the name

                score1 = Convert.ToInt16(lines[i + 1]);
                //the next line will be the grade
                winners.Add(new Player { Name = name2, Score = score1 });
                //make new students with the properties of name and grade as read in
            }
          //initializing the players name
            string longname = namebox.Text;
            //profanity filter thanks declan
            if (longname == "fuck" || longname == "shit" || longname == "ass" || longname == "bitch" || longname == "dick" || longname == "shit" || longname == "cum")
            { longname = "xxx"; }
            leaderboardlabel.Text = "";
            string newname;
            //if its longer than eight charachters then
            if (longname.Length > 7)
            {//making a new string at max of seven
                newname = longname.Substring(1, 7); 
            }//if else then it just swaps over as is 
           else { newname = longname; }
       
          
                
                //adding it to the list
                winners.Add(new Player { Name = newname, Score = realscore });
         
                //lists scare me, sorting players by score to show on the leaderboard
                winners.Sort((p1, p2) => p2.Score.CompareTo(p1.Score));
                for (int i = 0; i < winners.Count; i++)
                {
                    leaderboardlabel.Text += winners[i].Name + " " + winners[i].Score + "      " + "\n\n";
                }
           
          

            File.WriteAllText(filePath, ""); // clear file first
            //opening the file 
            using (StreamWriter writer = new StreamWriter(filePath))
            
            {//setting the values from the file 
                for (int i = 0; i < winners.Count; i++)
                {
                    writer.WriteLine(winners[i].Name);
                    writer.WriteLine(winners[i].Score);
                }
            }
                leaderboardlabel.Visible = true;
            
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
