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
    public partial class Form_Intervention : Form
    {
        public Form_Intervention()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        int count;
        string nn;
        public void num()
        {
            count = 0;
            c.da_intervention.Fill(c.ds, "intr");

            if (c.ds.Tables["intr"].Rows.Count > 0)
            {

                for (int i = 0; i < c.ds.Tables["intr"].Rows.Count; i++)
                {

                    count = i + 1;
                    nn = count.ToString("000000") + "/" + DateTime.Now.Year;

                    if (c.ds.Tables["intr"].Rows[i][0].ToString() != nn.ToString())
                    {
                        break;
                    }
                    if (count == c.ds.Tables["intr"].Rows.Count)
                    {
                        count = c.ds.Tables["intr"].Rows.Count + 1;
                        nn = count.ToString("000000") + "/" + DateTime.Now.Year;
                    }
                }
            }
            else
            {
                count = 1;
                nn = count.ToString("000000") + "/" + DateTime.Now.Year;
            }
            
            cmbn.Text = nn.ToString();
            c.ds.Tables["intr"].Clear();

        }
         
        public void vid()
        {
            checkBox1.Checked = false;
            cmbn.Enabled = false;
            cmbclient.Text = "";
            cmbCommercial.Text = "";
            cmbtyp.Text = "";
            cmblieu.Text = "";
            rbinformatique.Checked = false;
            rbtechnique.Checked = false;
            txtserie.Text="";
            cmbtype.Text = "";
            txtmarque.Clear();
            txtmodele.Clear();
            txtdesignation.Clear();
            cmbIntervenant.Text = "";
            txtdefault_signale.Clear();
            txtdefault_constates.Clear();
            txttaches_effectuees.Clear();
            cmbetat.Text = "";
        }
        private void Form_Intervention_Load(object sender, EventArgs e)
        {
            
             
            // panne
            p_default_signale.Visible = true;
            p_default_constates.Visible = false;
            p_taches_effectuees.Visible = false;
            btn_precedent.Enabled = false;

           
            num();

             

        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            //lancer form client
            Form_client f1 = new Form_client();
            f1.Show();
        }

        private void btnCommercial_Click(object sender, EventArgs e)
        {
            //lancer form Commercial
            Form_Commercial f2 = new Form_Commercial();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lancer form intervenant
            Form_Intervenant f3 = new Form_Intervenant();
            f3.Show();
        }
        int categorie;
        private void rbtechnique_CheckedChanged(object sender, EventArgs e)
        {
            //remplir list des materiel technique
            categorie = 2;
            cmbtype.Items.Clear();
            cmbtype.Text = "";
            cmbtype.Items.Add("photocopieur");
            cmbtype.Items.Add("TV");
            cmbtype.Items.Add("fax");
             
            
        }

        private void rbinformatique_CheckedChanged(object sender, EventArgs e)
        {
            //remplir list des materiel informatique
            categorie = 1;
            cmbtype.Items.Clear();
            cmbtype.Text = "";
            cmbtype.Items.Add("pc bureau");
            cmbtype.Items.Add("pc portable");
            cmbtype.Items.Add("imprimante");
            
            
        }

        Boolean var = false;
         
        private void txtserie_TextChanged(object sender, EventArgs e)
        {

            c.da3 = new SqlDataAdapter("select * from Materiel  where num_s like('" + txtserie.Text + "')", c.cnx);

            c.da3.Fill(c.ds, "mat");

            if (c.ds.Tables["mat"].Rows.Count > 0)
            {
                //MessageBox.Show("exit");
                if (txtserie.Text == c.ds.Tables["mat"].Rows[0][0].ToString())
                {
                    if (Convert.ToInt16(c.ds.Tables["mat"].Rows[0][1].ToString()) == 1)
                    {
                        rbinformatique.Checked = true;
                    }
                    if (Convert.ToInt16(c.ds.Tables["mat"].Rows[0][1].ToString()) == 2)
                    {
                        rbtechnique.Checked = true;
                    }
                    cmbtype.Text = c.ds.Tables["mat"].Rows[0][2].ToString();
                    txtmarque.Text = c.ds.Tables["mat"].Rows[0][3].ToString();
                    txtmodele.Text = c.ds.Tables["mat"].Rows[0][4].ToString();
                    txtdesignation.Text = c.ds.Tables["mat"].Rows[0][5].ToString();

                    var = true;
                    c.ds.Tables["mat"].Clear();
                }
                else
                {
                    cmbtype.Text = "";
                    txtmodele.Text = "";
                    txtmarque.Text = "";
                    txtdesignation.Text = "";

                    var = false;
                }

            }
            else
            {
                cmbtype.Text = "";
                txtmodele.Text = "";
                txtmarque.Text = "";
                txtdesignation.Text = "";

                var = false;
            }
             
        }

        private void btn_precedent_Click(object sender, EventArgs e)
        {
            if (p_taches_effectuees.Visible == true)
            {
                p_default_signale.Visible = false;
                p_default_constates.Visible = true;
                p_taches_effectuees.Visible = false;
                btn_suivant.Enabled = true;
            }
            else
                if (p_default_constates.Visible == true)
                {
                    p_default_signale.Visible = true;
                    p_default_constates.Visible = false;
                    p_taches_effectuees.Visible = false;
                    btn_precedent.Enabled = false;
                    btn_suivant.Enabled = true;
                }

        }

        private void btn_suivant_Click(object sender, EventArgs e)
        {
            if (p_default_signale.Visible == true)
            {
                p_default_signale.Visible = false;
                p_default_constates.Visible = true;
                p_taches_effectuees.Visible = false;
                btn_precedent.Enabled = true;
            }
            else
                if (p_default_constates.Visible == true)
                {
                    p_default_signale.Visible = false;
                    p_default_constates.Visible = false;
                    p_taches_effectuees.Visible = true;
                    btn_suivant.Enabled = false;
                    btn_precedent.Enabled = true;
                }

        }
        string num_cli;
        string num_com;
        string num_int;

        private void btnajouter_Click(object sender, EventArgs e)
        {
           
   
            try
            {
                // ajouter materiel
                if (txtserie.Text != "")
                {
                    if (var == false)
                    {
                        c.da_materiel.Fill(c.ds, "mat");
                        DataRow dr = c.ds.Tables["mat"].NewRow();
                        dr[0] = txtserie.Text;
                        if (categorie == 1 || categorie == 2)
                        {
                            dr[1] = categorie;
                        }

                        dr[2] = cmbtype.Text;
                        dr[3] = txtmarque.Text;
                        dr[4] = txtmodele.Text;

                        c.ds.Tables["mat"].Rows.Add(dr);


                        SqlCommandBuilder cb = new SqlCommandBuilder(c.da_materiel);
                        c.da_materiel.Update(c.ds, "mat");
                        c.ds.Tables["mat"].Clear();


                    }
                }



                c.da_intervention.Fill(c.ds, "intr");
                DataRow dr1 = c.ds.Tables["intr"].NewRow();
                dr1[0] = cmbn.Text;
                if (cmbclient.Text.Trim() != "")
                {
                    num_cli = cmbclient.Text.Substring(0, 7);
                    dr1[1] = num_cli.ToString();
                }
                if (cmbCommercial.Text.Trim() != "")
                {
                    num_com = cmbCommercial.Text.Substring(0, 5);
                    dr1[2] = num_com.ToString();
                }
                if (cmbIntervenant.Text.Trim() != "")
                {
                    num_int = cmbIntervenant.Text.Substring(0, 5);
                    dr1[3] = num_int.ToString();
                }
                if (txtserie.Text.Trim() != "")
                {
                    dr1[4] = txtserie.Text;
                }
                dr1[5] = dtpdate.Value.ToShortDateString();
                dr1[6] = dtpheure.Value.ToShortTimeString();
                if (cmblieu.Text.Trim() != "")
                {
                    dr1[7] = cmblieu.Text;
                }
                if (cmbtyp.Text.Trim() != "")
                {
                    dr1[8] = cmbtyp.Text;
                }
                dr1[9] = dtpdate_d.Value.ToShortDateString();
                dr1[10] = dtpheure_d.Value.ToShortTimeString();
                dr1[11] = dtpdate_f.Value.ToShortDateString();
                dr1[12] = dtpheure_f.Value.ToShortTimeString();
                if (cmbetat.Text.Trim() != null)
                {
                    dr1[13] = cmbetat.Text;
                }


                c.ds.Tables["intr"].Rows.Add(dr1);

                SqlCommandBuilder cb1 = new SqlCommandBuilder(c.da_intervention);
                c.da_intervention.Update(c.ds, "intr");
                c.ds.Tables["intr"].Clear();

                c.da_panne.Fill(c.ds, "pan");
                DataRow dr2 = c.ds.Tables["pan"].NewRow();
                dr2[1] = cmbn.Text;
                if (txtserie.Text.Trim() != "")
                {
                    dr2[2] = txtserie.Text;
                }
                dr2[3] = txtdefault_signale.Text;
                dr2[4] = txtdefault_constates.Text;
                dr2[5] = txttaches_effectuees.Text;
                c.ds.Tables["pan"].Rows.Add(dr2);
                SqlCommandBuilder cb2 = new SqlCommandBuilder(c.da_panne);
                c.da_panne.Update(c.ds, "pan");
                c.ds.Tables["pan"].Clear();
           

                num();
                vid();
          
               
               }
            catch (Exception ee)
            {

                MessageBox.Show("erreur "+ee.ToString());
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cmbn.Enabled = true;
                cmbn.Items.Clear();
                c.da_intervention.Fill(c.ds, "intr");
                for (int i = 0; i < c.ds.Tables["intr"].Rows.Count; i++)
                {
                    cmbn.Items.Add(c.ds.Tables["intr"].Rows[i][0]);
                }

                cmbn.Text = "";
                c.ds.Tables["intr"].Clear();
            }
            else
            {
                cmbn.Items.Clear();
                num();
                vid();

            }
        }

        private void cmbn_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                c.da_intervention.Fill(c.ds, "intr");

                for (int i = 0; i < c.ds.Tables["intr"].Rows.Count; i++)
                {
                    if (c.ds.Tables["intr"].Rows[i][0].ToString() == cmbn.Text)
                    {
                        cmbclient.Text = c.ds.Tables["intr"].Rows[i][1].ToString();
                        cmbCommercial.Text = c.ds.Tables["intr"].Rows[i][2].ToString();
                        cmbIntervenant.Text = c.ds.Tables["intr"].Rows[i][3].ToString();
                        txtserie.Text = Convert.ToString(c.ds.Tables["intr"].Rows[i][4].ToString());
                        dtpdate.Text = c.ds.Tables["intr"].Rows[i][5].ToString();
                        dtpheure.Text = c.ds.Tables["intr"].Rows[i][6].ToString();
                        cmblieu.Text = c.ds.Tables["intr"].Rows[i][7].ToString();
                        cmbtyp.Text = c.ds.Tables["intr"].Rows[i][8].ToString();
                        dtpdate_d.Text = c.ds.Tables["intr"].Rows[i][9].ToString();
                        dtpheure_d.Text = c.ds.Tables["intr"].Rows[i][10].ToString();
                        dtpdate_f.Text = c.ds.Tables["intr"].Rows[i][11].ToString();
                        dtpheure_f.Text = c.ds.Tables["intr"].Rows[i][12].ToString();
                        cmbetat.Text = c.ds.Tables["intr"].Rows[i][13].ToString();

                    }
                }

                c.da_panne.Fill(c.ds, "pan");
                for (int i = 0; i < c.ds.Tables["pan"].Rows.Count; i++)
                {
                    if (c.ds.Tables["pan"].Rows[i][1].ToString() == cmbn.Text)
                    {

                        txtdefault_signale.Text = c.ds.Tables["pan"].Rows[i][3].ToString();
                        txtdefault_constates.Text = c.ds.Tables["pan"].Rows[i][4].ToString();
                        txttaches_effectuees.Text = c.ds.Tables["pan"].Rows[i][5].ToString();

                    }
                }
                c.ds.Tables["intr"].Clear();
                c.ds.Tables["pan"].Clear();
            }
            catch (Exception ee)
            {

                MessageBox.Show("erreur : " + ee.ToString());
            }
           
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                if (cmbn.Text == "")
                {
                    MessageBox.Show("saisie N°");
                }
                else
                {
                   DialogResult res = MessageBox.Show("voulez vous Modifier cette intervention", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        { 
                            c.da_intervention.Fill(c.ds, "intr");
                            for (int i = 0; i < c.ds.Tables["intr"].Rows.Count; i++)
                            {
 
                                if (c.ds.Tables["intr"].Rows[i][0].ToString() == cmbn.Text)
                                {

                                    if (cmbclient.Text.Trim() != "")
                                    {

                                        c.ds.Tables["intr"].Rows[i][1] = cmbclient.Text.Substring(0, 7); ;
                                    }

                                    if (cmbCommercial.Text.Trim() != "")
                                    {

                                        c.ds.Tables["intr"].Rows[i][2] = cmbCommercial.Text.Substring(0, 5);
                                    }
                                    if (cmbIntervenant.Text.Trim() != "")
                                    {

                                        c.ds.Tables["intr"].Rows[i][3] = cmbIntervenant.Text.Substring(0, 5);
                                    }
                                    if (txtserie.Text.Trim() != "")
                                    {
                                        c.ds.Tables["intr"].Rows[i][4] = txtserie.Text;
                                    }

                                    c.ds.Tables["intr"].Rows[i][5] = dtpdate.Value.ToShortDateString();
                                    c.ds.Tables["intr"].Rows[i][6] = dtpheure.Value.ToShortTimeString();
                                    if (cmblieu.Text != "")
                                    {
                                        c.ds.Tables["intr"].Rows[i][7] = cmblieu.Text;
                                    }
                                    if (cmbtyp.Text != "")
                                    {
                                        c.ds.Tables["intr"].Rows[i][8] = cmbtyp.Text;
                                    }
                                    c.ds.Tables["intr"].Rows[i][9] = dtpdate_d.Value.ToShortDateString();
                                    c.ds.Tables["intr"].Rows[i][10] = dtpheure_d.Value.ToShortTimeString();
                                    c.ds.Tables["intr"].Rows[i][11] = dtpdate_f.Value.ToShortDateString();
                                    c.ds.Tables["intr"].Rows[i][12] = dtpheure_f.Value.ToShortTimeString();
                                    if (cmbetat.Text != null)
                                    {
                                        c.ds.Tables["intr"].Rows[i][13] = cmbetat.Text;
                                    }

 

                                }
                            

                            }  
                            SqlCommandBuilder cb3 = new SqlCommandBuilder(c.da_intervention);
                                c.da_intervention.Update(c.ds, "intr");
                                c.ds.Tables["intr"].Clear();


                                if (txtserie.Text != "")
                                {
                                    c.da_materiel.Fill(c.ds, "matt");
                                    if (var == false)
                                    {

                                        DataRow dr = c.ds.Tables["matt"].NewRow();
                                        dr[0] = txtserie.Text;
                                        if (categorie == 1 || categorie == 2)
                                        {
                                            dr[1] = categorie;
                                        }

                                        dr[2] = cmbtype.Text;
                                        dr[3] = txtmarque.Text;
                                        dr[4] = txtmodele.Text;

                                        c.ds.Tables["matt"].Rows.Add(dr);

                                    }
                                    else
                                    {

                                        for (int j = 0; j < c.ds.Tables["matt"].Rows.Count; j++)
                                        {
                                            if (c.ds.Tables["matt"].Rows[j][0].ToString() == txtserie.Text)
                                            {
                                                c.ds.Tables["matt"].Rows[j][1] = categorie;
                                                c.ds.Tables["matt"].Rows[j][2] = cmbtype.Text;
                                                c.ds.Tables["matt"].Rows[j][3] = txtmarque.Text;
                                                c.ds.Tables["matt"].Rows[j][4] = txtmodele.Text;
                                                c.ds.Tables["matt"].Rows[j][5] = txtdesignation.Text;
                                            }
                                        }


                                    }
                                    SqlCommandBuilder cb4 = new SqlCommandBuilder(c.da_materiel);
                                    c.da_materiel.Update(c.ds, "matt");
                                    c.ds.Tables["matt"].Clear();

                                }

                                c.da_panne.Fill(c.ds, "pan");

                                for (int k = 0; k < c.ds.Tables["pan"].Rows.Count; k++)
                                {
                                    if (c.ds.Tables["pan"].Rows[k][1].ToString() == cmbn.Text)
                                    {
                                        c.ds.Tables["pan"].Rows[k][2] = txtserie.Text;
                                        c.ds.Tables["pan"].Rows[k][3] = txtdefault_signale.Text;
                                        c.ds.Tables["pan"].Rows[k][4] = txtdefault_constates.Text;
                                        c.ds.Tables["pan"].Rows[k][5] = txttaches_effectuees.Text;

                                    }
                                }

                                SqlCommandBuilder cb5 = new SqlCommandBuilder(c.da_panne);
                                c.da_panne.Update(c.ds, "pan");
                                c.ds.Tables["pan"].Clear();

                                vid();
                                num();
                    }
                }
            }
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (cmbn.Text == "")
                {
                    MessageBox.Show("saisie matricule");
                }
                else
                {
                    c.da_intervention.Fill(c.ds, "intr");
                    Boolean find = false;
                    int p = -1;
                    for (int i = 0; i < c.ds.Tables["intr"].Rows.Count; i++)
                    {
                        if (cmbn.Text == c.ds.Tables["intr"].Rows[i][0].ToString())
                        {
                            find = true;
                            p = i;
                            break;
                        }
                    }

                    if (find == true && p != -1)
                    {
                        DialogResult res = MessageBox.Show("voulez vous Modifier cette intervention", "Modifier", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == DialogResult.Yes)
                        {

                            c.ds.Tables["intr"].Rows[p].Delete();
                            SqlCommandBuilder cb6 = new SqlCommandBuilder(c.da_intervention);
                            c.da_intervention.Update(c.ds, "intr");
                        
                            find = false;
                            p = -1;

                            c.ds.Tables["intr"].Clear();
                            checkBox1.Checked = false;
                        }
                    }
                }
            }
        }

        

        //remplir liste client
    
        private void cmbclient_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (cmbclient.Items.Count > 0)
                        {
                            for (int i = cmbclient.Items.Count - 1; i >= 0; i--)
                            {
                                cmbclient.Items.RemoveAt(i);
                            }
                        }
                        c.da_client.Fill(c.ds, "cli");

                        for (int i = 0; i < c.ds.Tables["cli"].Rows.Count; i++)
                        {
                            cmbclient.Items.Add(c.ds.Tables["cli"].Rows[i][0].ToString() + "   " + c.ds.Tables["cli"].Rows[i][1].ToString());
                        }

                        c.ds.Tables["cli"].Clear();
        }

        //remplir liste Commercial
        private void cmbCommercial_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbCommercial.Items.Count > 0)
            {

                for (int i = cmbCommercial.Items.Count - 1; i >= 0; i--)
                {
                    cmbCommercial.Items.RemoveAt(i);
                }
            }
            c.da_Commercial.Fill(c.ds, "com");

            for (int i = 0; i < c.ds.Tables["com"].Rows.Count; i++)
            {
                cmbCommercial.Items.Add(c.ds.Tables["com"].Rows[i][0].ToString() + " " + c.ds.Tables["com"].Rows[i][1].ToString() + " " + c.ds.Tables["com"].Rows[i][2].ToString());
            }
            c.ds.Tables["com"].Clear();
        }



        //remplir liste Intervenant
        private void cmbIntervenant_MouseClick(object sender, MouseEventArgs e)
        {
            if (cmbIntervenant.Items.Count > 0)
            {

                for (int i = cmbIntervenant.Items.Count - 1; i >= 0; i--)
                {
                    cmbIntervenant.Items.RemoveAt(i);
                }
            }
            c.da_intervenant.Fill(c.ds, "int");

            for (int i = 0; i < c.ds.Tables["int"].Rows.Count; i++)
            {
                cmbIntervenant.Items.Add(c.ds.Tables["int"].Rows[i][0].ToString() + " " + c.ds.Tables["int"].Rows[i][1].ToString() + " " + c.ds.Tables["int"].Rows[i][2].ToString());
            }
            c.ds.Tables["int"].Clear();
        }

       

         
       

       

        
    }
}
