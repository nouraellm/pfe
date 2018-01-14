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
    public partial class Form_logo : Form
    {
        public Form_logo()
        {
            InitializeComponent();
        }


        int i=0;
        private void Form_logo_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(i==3)
            {
                Form_login f1 = new Form_login();
                f1.Show();
                timer1.Stop();
                this.Hide();
            }
            i++;

        }
    }
}
