using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tetrismaking
{
    public partial class Form3 : Form
    {// a rules form, has a label to show the rules and then a button to close itslef and to reshow form 1
        public Form3()
        {
            InitializeComponent();
        }

        private void returnbutton_Click(object sender, EventArgs e)
        {//closes itslef
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Close();
        }
    }
}
