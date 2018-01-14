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
    public partial class Form_listeIntervention_parCli : Form
    {
        public Form_listeIntervention_parCli()
        {
            InitializeComponent();
        }

        Class1 c = new Class1();
        string st;
        string stt;

        private void Form2_Load(object sender, EventArgs e)
        {
            c.da_client.Fill(c.ds, "cli1");

            for (int i = 0; i < c.ds.Tables["cli1"].Rows.Count; i++)
            {
                comboBox1.Items.Add(c.ds.Tables["cli1"].Rows[i][0].ToString() + "   " + c.ds.Tables["cli1"].Rows[i][1].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            



            
                try
                {
                    st = comboBox1.Text;
                    c.ds.Clear();
                    stt = st.Substring(0, 7);
                    c.da4 = new SqlDataAdapter("select * from intervention where num_cli = '" + stt + "'", c.cnx);
                    c.da4.Fill(c.ds, "int_c");

                    dataGridView1.DataSource = c.ds.Tables["int_c"];

                    dataGridView1.Columns[0].HeaderText = "N°";
                    dataGridView1.Columns[1].HeaderText = "Matricule Client";
                    dataGridView1.Columns[2].HeaderText = "Matricule Commercial";
                    dataGridView1.Columns[3].HeaderText = "Matricule Intervenant";
                    dataGridView1.Columns[4].HeaderText = "s/n Materiel";
                    dataGridView1.Columns[5].HeaderText = "Date d'appel";
                    dataGridView1.Columns[6].HeaderText = "Heure d'appel";
                    dataGridView1.Columns[7].HeaderText = "Lieu";
                    dataGridView1.Columns[8].HeaderText = "Type";
                    dataGridView1.Columns[9].HeaderText = "Date début";
                    dataGridView1.Columns[10].HeaderText = "Heure début";
                    dataGridView1.Columns[11].HeaderText = "Date Fin";
                    dataGridView1.Columns[12].HeaderText = "Heure fin";
                    dataGridView1.Columns[13].HeaderText = "Etat";


                    int nbr_annule = 0;
                    int nbr_termine = 0;
                    int nbr_encours = 0;
                    int nbr_reforme = 0;
                    
                    for (int i = 0; i < c.ds.Tables["int_c"].Rows.Count; i++)
                    {
                        if (c.ds.Tables["int_c"].Rows[i][13].ToString() == "Termine")
                        {
                            nbr_termine += 1;
                        }

                        if (c.ds.Tables["int_c"].Rows[i][13].ToString() == "En Cours")
                        {
                            nbr_encours += 1;
                        }

                        if (c.ds.Tables["int_c"].Rows[i][13].ToString() == "Annule")
                        {
                            nbr_annule += 1;
                        }

                        if (c.ds.Tables["int_c"].Rows[i][13].ToString() == "Reforme")
                        {
                            nbr_reforme += 1;
                        }
                    }
                   
                    lbl_termine.Text = nbr_termine.ToString();
                    lbl_encours.Text = nbr_encours.ToString();
                    lbl_annule.Text = nbr_annule.ToString();
                    lbl_reforme.Text = nbr_reforme.ToString();
                   

                }
                catch (Exception ee)
                {

                    MessageBox.Show("erreur " + ee.ToString());
                }
        }
    }
}
