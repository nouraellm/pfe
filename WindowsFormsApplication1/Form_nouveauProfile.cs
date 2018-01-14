using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form_nouveauProfile : Form
    {
        public Form_nouveauProfile()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        private void btn_annuler_Click(object sender, EventArgs e)
        {
            Form_login fl = new Form_login();
            fl.Show();
            this.Visible = false;
        }

      

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (txt_nom.Text.Trim() == "")
            {
                MessageBox.Show("sisair nom Nom d''Utilisateur");
                txt_password1.Text = "";
                txt_password2.Text = "";
            }
            else
                if (txt_password1.Text != txt_password2.Text)
                {
                    MessageBox.Show("Mot de passe incorrect");
                    txt_password1.Text = "";
                    txt_password2.Text = "";
                }
                else
                {
                    c.da_login.Fill(c.ds, "pass");
                
                  
                    Boolean find = false;
                    
                    for (int i = 0; i < c.ds.Tables["pass"].Rows.Count; i++)
                    {
                        if (txt_nom.Text.ToLower() == c.ds.Tables["pass"].Rows[i][0].ToString())
                        {
                            find = true;
                             
                            break;
                        }
                    }

                    if (find == true)
                    {
                        MessageBox.Show("ce nom déja exit");

                    }
                    else
                    {
                        DataRow dr = c.ds.Tables["pass"].NewRow();
                        dr[0] = txt_nom.Text.ToLower();
                        dr[1] = txt_password1.Text.ToLower();
                        c.ds.Tables["pass"].Rows.Add(dr);

                        SqlCommandBuilder cb = new SqlCommandBuilder(c.da_login);
                        c.da_login.Update(c.ds, "pass");
                        txt_nom.Text = "";
                        txt_password1.Text = "";
                        txt_password2.Text = "";
                    }

                    c.ds.Tables["pass"].Clear();
                }
         
        }

        
            
    }
}
