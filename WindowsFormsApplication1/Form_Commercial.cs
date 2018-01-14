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
    public partial class Form_Commercial : Form
    {
        public Form_Commercial()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();

        int count;
        string num;

        public void mat()
        {
            count = 0;
            c.da_Commercial.Fill(c.ds, "com");
            if (c.ds.Tables["com"].Rows.Count > 0)
            {
                for (int i = 0; i < c.ds.Tables["com"].Rows.Count; i++)
                {
                    count = i + 1;
                    num = "C" + count.ToString("0000");

                    if (c.ds.Tables["com"].Rows[i][0].ToString() != num.ToString())
                    {
                        break;
                    }
                    if (count == c.ds.Tables["com"].Rows.Count)
                    {
                        count = c.ds.Tables["com"].Rows.Count + 1;
                        num = "C" + count.ToString("0000");
                    }
                }
            }
            else
            {
                count = 1;
                num = "C" + count.ToString("0000");
            }
            cmpmat.Text = num.ToString();
            c.ds.Tables["com"].Clear();
        }
        

        private void Form_Commercial_Load(object sender, EventArgs e)
        { 
            //remplir text num
           mat();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c.da_Commercial.Fill(c.ds, "com");
                DataRow dr = c.ds.Tables["com"].NewRow();
                // Vérifier txtnom et txtprenom  n'est pas vide
                if (cmpmat.Text=="" || txtnom.Text == "" || txtprenom.Text== "")
                {
                    MessageBox.Show("la saisie de matricule nom et prenom  est obligatoire");

                }
                else
                {

                    dr[0] = cmpmat.Text;
                    dr[1] = txtnom.Text;
                    dr[2] = txtprenom.Text;
                    dr[3] = txtadresse.Text;
                    dr[4] = txtemail.Text;
                    dr[5] = txttele.Text;

                    c.ds.Tables["com"].Rows.Add(dr);
                    

                    SqlCommandBuilder cb = new SqlCommandBuilder(c.da_Commercial);
                    c.da_Commercial.Update(c.ds, "com");
                    c.ds.Tables["com"].Clear();
                    //actualiser les textbox
                    txtnom.Clear();
                    txtprenom.Clear();
                    txtadresse.Clear();
                    txtemail.Clear();
                    txttele.Clear();

                    mat();

                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("erreur : " + ee.ToString());
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {  
                 try
                 {
                     
                     if (checkBox1.Checked)
                     {
                         if (cmpmat.Text == "")
                         {
                             MessageBox.Show("saisie matricule");
                         }
                         else
                         {
                             c.da_Commercial.Fill(c.ds, "com");
                             for (int i = 0; i < c.ds.Tables["com"].Rows.Count; i++)
                             {
                                 if (c.ds.Tables["com"].Rows[i][0].ToString() == cmpmat.Text)
                                 {
                                     DialogResult res = MessageBox.Show("voulez vous Modifier cette Commercial", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                     if (res == DialogResult.Yes)
                                     {
                                         c.ds.Tables["com"].Rows[i][1] = txtnom.Text;
                                         c.ds.Tables["com"].Rows[i][2] = txtprenom.Text;
                                         c.ds.Tables["com"].Rows[i][3] = txtadresse.Text;
                                         c.ds.Tables["com"].Rows[i][4] = txtemail.Text;
                                         c.ds.Tables["com"].Rows[i][5] = txttele.Text;
                                         SqlCommandBuilder cb = new SqlCommandBuilder(c.da_Commercial);
                                         c.da_Commercial.Update(c.ds, "com");

                                         txtnom.Clear();
                                         txtprenom.Clear();
                                         txtadresse.Clear();
                                         txtemail.Clear();
                                         txttele.Clear();
                                         cmpmat.Enabled = false;
                                         checkBox1.Checked = false;
                                         mat();
                                     }

                                 }
                             }
                         }
                         c.ds.Tables["com"].Clear();
                     }
                    
                 }
                 catch (Exception ee)
                 {

                     MessageBox.Show("erreur : "+ee.ToString());
                 }
         
        }

        private void cmpmat_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.da_Commercial.Fill(c.ds, "com");
            for (int i = 0; i < c.ds.Tables["com"].Rows.Count; i++)
            {
                if (c.ds.Tables["com"].Rows[i][0].ToString() == cmpmat.Text)
                {
                    txtnom.Text = c.ds.Tables["com"].Rows[i][1].ToString();
                    txtprenom.Text = c.ds.Tables["com"].Rows[i][2].ToString();
                    txtadresse.Text = c.ds.Tables["com"].Rows[i][3].ToString();
                    txtemail.Text = c.ds.Tables["com"].Rows[i][4].ToString();
                    txttele.Text = c.ds.Tables["com"].Rows[i][5].ToString();
                }
            }
            c.ds.Tables["com"].Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
            if (checkBox1.Checked)
            { 
                c.da_Commercial.Fill(c.ds, "com");
                cmpmat.Enabled = true;
                cmpmat.Items.Clear();
                for (int i = 0; i < c.ds.Tables["com"].Rows.Count; i++)
                {
                    cmpmat.Items.Add(c.ds.Tables["com"].Rows[i][0]);
                }
                cmpmat.Text = "";
                c.ds.Tables["com"].Clear();
            }
            else
            {
                cmpmat.Items.Clear();
                cmpmat.Enabled = false;
                txtnom.Clear();
                txtprenom.Clear();
                txtadresse.Clear();
                txtemail.Clear();
                txttele.Clear();
                mat();
            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (cmpmat.Text == "")
                {
                    MessageBox.Show("saisie matricule");
                }
                else
                {
                    c.da_Commercial.Fill(c.ds, "com");
                    Boolean find = false;
                    int p = -1;
                    for (int i = 0; i < c.ds.Tables["com"].Rows.Count; i++)
                    {
                        if (cmpmat.Text == c.ds.Tables["com"].Rows[i][0].ToString())
                        {
                            find = true;
                            p = i;
                            break;
                        }
                    }

                    if (find == true && p != -1)
                    {
                        DialogResult res = MessageBox.Show("voulez vous supprimer cette client", "supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {
                            c.ds.Tables["com"].Rows[p].Delete();
                            SqlCommandBuilder cb = new SqlCommandBuilder(c.da_Commercial);
                            c.da_Commercial.Update(c.ds, "com");

                            find = false;
                            p = -1;

                            c.ds.Tables["com"].Clear();
                            checkBox1.Checked = false;
                        }
                    }
                }

            }
        }
    }
}
