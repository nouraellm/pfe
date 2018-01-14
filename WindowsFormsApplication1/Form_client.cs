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
    public partial class Form_client : Form
    {
        public Form_client()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();

        int count;
        string num;

        
        public void mat()
        {
            count = 0;
            c.da_client.Fill(c.ds, "cli");
            if (c.ds.Tables["cli"].Rows.Count > 0)
            {
                for (int i = 0; i < c.ds.Tables["cli"].Rows.Count; i++)
                {
                    count = i + 1;
                    num = "CL" + count.ToString("00000");

                    if (c.ds.Tables["cli"].Rows[i][0].ToString() != num.ToString())
                    {
                        break;
                    }
                    if (count == c.ds.Tables["cli"].Rows.Count)
                    {
                        count = c.ds.Tables["cli"].Rows.Count + 1;
                        num = "CL" + count.ToString("00000");
                    }
                }

            }
            else
            {
                count = 1;
                num = "CL" + count.ToString("00000");
            }

            cmpmat.Text = num.ToString();
            c.ds.Tables["cli"].Clear();

        }
        private void Form_client_Load(object sender, EventArgs e)
        { 
            mat();   
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {

            try
            {
                // Vérifier txtraisonsociale  n'est pas vide
                if (cmpmat.Text == "" || txtraisonsociale.Text == "")
                {
                    MessageBox.Show("la saisie de matricule et raison sociale est obligatoire");

                }
                else
                {
                    c.da_client.Fill(c.ds, "cli");
                    DataRow dr = c.ds.Tables["cli"].NewRow();
                    dr[0] = cmpmat.Text;
                    dr[1] = txtraisonsociale.Text;
                    dr[2] = txtadresse.Text;
                    dr[3] = txtemail.Text;
                    dr[4] = txttele.Text;
                    c.ds.Tables["cli"].Rows.Add(dr);
                    


                    SqlCommandBuilder cb = new SqlCommandBuilder(c.da_client);
                    c.da_client.Update(c.ds, "cli");

                    //actualiser les textbox
                    txtraisonsociale.Clear();
                    txtadresse.Clear();
                    txtemail.Clear();
                    txttele.Clear();

                    count = c.ds.Tables["cli"].Rows.Count + 1;
                    c.ds.Tables["cli"].Clear();
                    mat();

                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("erreur : " + ee.ToString());
            }    
        }


        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                c.da_client.Fill(c.ds, "cli");
                cmpmat.Enabled = true;
                cmpmat.Items.Clear();
                for (int i = 0; i < c.ds.Tables["cli"].Rows.Count; i++)
                {
                    cmpmat.Items.Add(c.ds.Tables["cli"].Rows[i][0]);
                }
                cmpmat.Text = "";
                c.ds.Tables["cli"].Clear();
            }
            else {
                cmpmat.Enabled = false;
                txtraisonsociale.Clear();
                txtadresse.Clear();
                txtemail.Clear();
                txttele.Clear();
                mat();
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
                        c.da_client.Fill(c.ds, "cli");
                        for (int i = 0; i < c.ds.Tables["cli"].Rows.Count; i++)
                        {
                            if (c.ds.Tables["cli"].Rows[i][0].ToString() == cmpmat.Text)
                            {
                                DialogResult res = MessageBox.Show("voulez vous Modifier cette client", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                if (res == DialogResult.Yes)
                                {

                                    c.ds.Tables["cli"].Rows[i][1] = txtraisonsociale.Text;
                                    c.ds.Tables["cli"].Rows[i][2] = txtadresse.Text;
                                    c.ds.Tables["cli"].Rows[i][3] = txtemail.Text;
                                    c.ds.Tables["cli"].Rows[i][4] = txttele.Text;
                                    SqlCommandBuilder cb = new SqlCommandBuilder(c.da_client);
                                    c.da_client.Update(c.ds, "cli");
                                    txtraisonsociale.Clear();
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
                    c.ds.Tables["cli"].Clear();
                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("erreur : "+ee.ToString());
            }
            
        }

        private void cmpmat_SelectedIndexChanged(object sender, EventArgs e)
        {
            c.da_client.Fill(c.ds, "cli");
            for (int i = 0; i < c.ds.Tables["cli"].Rows.Count; i++)
            {
                if (c.ds.Tables["cli"].Rows[i][0].ToString() == cmpmat.Text)
                {
                    txtraisonsociale.Text = c.ds.Tables["cli"].Rows[i][1].ToString();
                    txtadresse.Text = c.ds.Tables["cli"].Rows[i][2].ToString();
                    txtemail.Text = c.ds.Tables["cli"].Rows[i][3].ToString();
                    txttele.Text = c.ds.Tables["cli"].Rows[i][4].ToString();
                }
            }
            c.ds.Tables["cli"].Clear();
        }

        private void btnsupprime_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (cmpmat.Text == "")
                {
                    MessageBox.Show("saisie matricule");
                }
                else
                {
                    c.da_client.Fill(c.ds, "cli");
                    Boolean find = false;
                    int p = -1;
                    for (int i = 0; i < c.ds.Tables["cli"].Rows.Count; i++)
                    {
                        if (cmpmat.Text == c.ds.Tables["cli"].Rows[i][0].ToString())
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
                            c.ds.Tables["cli"].Rows[p].Delete();
                            SqlCommandBuilder cb = new SqlCommandBuilder(c.da_client);
                            c.da_client.Update(c.ds, "cli");
                      
                            find = false;
                            p = -1;

                            c.ds.Tables["cli"].Clear();
                            checkBox1.Checked = false;


                        }
                    }
                }
               
            }
        }

      
 

         
             

        }
    }

