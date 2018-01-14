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
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            

             
                if (txt_utilisateur.Text.Trim() == "" || txt_motpass.Text.Trim()=="")
                {
                    MessageBox.Show("saisie nom et mot de passe");
                }
                else
                {
                    c.da_login.Fill(c.ds, "pass");
                    Boolean find = false;
                   
                    for (int i = 0; i < c.ds.Tables["pass"].Rows.Count; i++)
                    {
                        if (txt_utilisateur.Text.ToLower() == c.ds.Tables["pass"].Rows[i][0].ToString() && txt_motpass.Text.ToLower() == c.ds.Tables["pass"].Rows[i][1].ToString())
                        {
                            find = true;
                           
                            break;
                        }
                    }

                    if (find == true)
                    {
                        Form_accueil f1 = new Form_accueil();
                        f1.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect");
                        txt_motpass.Text = "";
                    }
                }
               
            
        }

         

        private void label3_MouseEnter(object sender, EventArgs e)
        {
           
            
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            
             label3.Cursor = Cursors.Default;
             Font font = new Font("Microsoft Sans Serif", 10,FontStyle.Bold );

             this.label3.Font = font;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Cursor = Cursors.Hand;
            Font font = new Font("Microsoft Sans Serif", 10,FontStyle.Bold  | FontStyle.Underline);

            this.label3.Font = font;


        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_nouveauProfile f1 = new Form_nouveauProfile();
           f1.FormBorderStyle = FormBorderStyle.None;

           f1.Top = 0;
           f1.Left = 0;
           f1.Size = f1.ClientSize;
           f1.Dock = DockStyle.Fill;
           f1.BringToFront();
            f1.Show();
           
        }
    }
}
