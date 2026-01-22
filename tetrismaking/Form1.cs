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
    {
        
       //just a title screen, not much past two buttons to show the rules and the game
        public Form1()
        {
           
            InitializeComponent();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
                
            }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            }
        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }
        private void leftrighttimer_Tick(object sender, EventArgs e)
        {
           
        }
        private void timer1_Tick(object sender, EventArgs e)
        {





        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {



        }

        private void startbutton_Click(object sender, EventArgs e)
        {//showing the game itself and hiding this form
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
         
            

        }

        private void rulesbutton_Click(object sender, EventArgs e)
        {
            //showing the rules form
        Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
        }
    }
}
