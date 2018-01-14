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
    public partial class Form_accueil : Form
    {
        public Form_accueil()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Horlage f_h = new Horlage();
            f_h.TopLevel = false;
            this.panel4.Controls.Add(f_h);
            f_h.FormBorderStyle = FormBorderStyle.None;

            f_h.Top = 0;
            f_h.Left = 0;
            f_h.Size = f_h.ClientSize;
            f_h.Dock = DockStyle.Fill;
            f_h.BringToFront();
            f_h.Show();



        }

 

 
  

        

   

        private void panel7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.emsin.ma");
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/EMSINtaza");
        }

    

       
 

        private void Form_accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void accueilToolStripMenuItem1A_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.Text = "Accueil";
        }

        private void interventionToolStripMenuItemBB_Click(object sender, EventArgs e)
        {
            Form_Intervention f1 = new Form_Intervention();
            f1.TopLevel = false;
            this.panel1.Controls.Add(f1);
            f1.FormBorderStyle = FormBorderStyle.None;

            f1.Top = 0;
            f1.Left = 0;
            f1.Size = f1.ClientSize;
            f1.Dock = DockStyle.Fill;
            f1.BringToFront();
            f1.Show();
            this.Text = "Intervention"; 
        }

        private void clientToolStripMenuItemBBB_Click(object sender, EventArgs e)
        {
            Form_client f2 = new Form_client();
            f2.TopLevel = false;
            this.panel1.Controls.Add(f2);
            f2.FormBorderStyle = FormBorderStyle.None;

            f2.Top = 0;
            f2.Left = 0;
            f2.Size = f2.ClientSize;
            f2.Dock = DockStyle.Fill;
            f2.BringToFront();
            f2.Show();
            this.Text = "Client";
        }

        private void commercialToolStripMenuItem2BBBB_Click(object sender, EventArgs e)
        {
            Form_Commercial f3 = new Form_Commercial();
            f3.TopLevel = false;
            this.panel1.Controls.Add(f3);
            f3.FormBorderStyle = FormBorderStyle.None;

            f3.Top = 0;
            f3.Left = 0;
            f3.Size = f3.ClientSize;
            f3.Dock = DockStyle.Fill;
            f3.BringToFront();
            f3.Show();
            this.Text = "Commercial";
        }

        private void intervenantToolStripMenuItem2BBBBB_Click(object sender, EventArgs e)
        {
            Form_Intervenant f4 = new Form_Intervenant();
            f4.TopLevel = false;
            this.panel1.Controls.Add(f4);
            f4.FormBorderStyle = FormBorderStyle.None;

            f4.Top = 0;
            f4.Left = 0;
            f4.Size = f4.ClientSize;
            f4.Dock = DockStyle.Fill;
            f4.BringToFront();
            f4.Show();
            this.Text = "Intervenant";
        }

        private void enCoursToolStripMenuItem1CA_Click(object sender, EventArgs e)
        {
            Form_listeIntervention_encours f8 = new Form_listeIntervention_encours();
            f8.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(f8);
            f8.FormBorderStyle = FormBorderStyle.None;

            f8.Top = 0;
            f8.Left = 0;
            f8.Size = f8.ClientSize;
            f8.Dock = DockStyle.Fill;
            f8.BringToFront();
            f8.Show();
            this.Text = "Liste Intervention EnCours";
        }

        private void termineToolStripMenuItem1CAA_Click(object sender, EventArgs e)
        {
            Form_listeIntervention_termine f9 = new Form_listeIntervention_termine();
            f9.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(f9);
            f9.FormBorderStyle = FormBorderStyle.None;

            f9.Top = 0;
            f9.Left = 0;
            f9.Size = f9.ClientSize;
            f9.Dock = DockStyle.Fill;
            f9.BringToFront();
            f9.Show();
            this.Text = "Liste Intervention terminé";
        }

        private void annuleToolStripMenuItem1CAAA_Click(object sender, EventArgs e)
        {
            Form_listeIntervention_Annule f10 = new Form_listeIntervention_Annule();
            f10.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(f10);
            f10.FormBorderStyle = FormBorderStyle.None;

            f10.Top = 0;
            f10.Left = 0;
            f10.Size = f10.ClientSize;
            f10.Dock = DockStyle.Fill;
            f10.BringToFront();
            f10.Show();
            this.Text = "Liste intervention Annule";
        }

        private void reformeToolStripMenuItem1CAAAA_Click(object sender, EventArgs e)
        {
            Form_listeIntervention_Reforme f11 = new Form_listeIntervention_Reforme();
            f11.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(f11);
            f11.FormBorderStyle = FormBorderStyle.None;

            f11.Top = 0;
            f11.Left = 0;
            f11.Size = f11.ClientSize;
            f11.Dock = DockStyle.Fill;
            f11.BringToFront();
            f11.Show();
            this.Text = "Liste Intervention Reforme";
        }

        private void parClientToolStripMenuItem1CAAAAA_Click(object sender, EventArgs e)
        {
            Form_listeIntervention_parCli f13 = new Form_listeIntervention_parCli();
            f13.TopLevel = false;
            this.splitContainer1.Panel2.Controls.Add(f13);
            f13.FormBorderStyle = FormBorderStyle.None;

            f13.Top = 0;
            f13.Left = 0;
            f13.Size = f13.ClientSize;
            f13.Dock = DockStyle.Fill;
            f13.BringToFront();
            f13.Show();
            this.Text = "liste Intervention par client";
      
                
        }

        private void IntervenantToolStripMenuItem2CCC_Click(object sender, EventArgs e)
        {
            Form_listeIntervenant f6 = new Form_listeIntervenant();
            f6.TopLevel = false;
            this.panel1.Controls.Add(f6);
            f6.FormBorderStyle = FormBorderStyle.None;

            f6.Top = 0;
            f6.Left = 0;
            f6.Size = f6.ClientSize;
            f6.Dock = DockStyle.Fill;
            f6.BringToFront();
            f6.Show();
            this.Text = "Liste Intervenant";
        }

        private void clientToolStripMenuItemCCCC_Click(object sender, EventArgs e)
        {
            Form_listeClient f5 = new Form_listeClient();
            f5.TopLevel = false;
            this.panel1.Controls.Add(f5);
            f5.FormBorderStyle = FormBorderStyle.None;

            f5.Top = 0;
            f5.Left = 0;
            f5.Size = f5.ClientSize;
            f5.Dock = DockStyle.Fill;
            f5.BringToFront();
            f5.Show();
            this.Text = "Liste Client";
        }

        private void commercialToolStripMenuItem2CCCCC_Click(object sender, EventArgs e)
        {
            Form_listeCommercial f7 = new Form_listeCommercial();
            f7.TopLevel = false;
            this.panel1.Controls.Add(f7);
            f7.FormBorderStyle = FormBorderStyle.None;

            f7.Top = 0;
            f7.Left = 0;
            f7.Size = f7.ClientSize;
            f7.Dock = DockStyle.Fill;
            f7.BringToFront();
            f7.Show();
            this.Text = "Liste Commerial";

        }

        private void ficheInterventionToolStripMenuItem1DD_Click(object sender, EventArgs e)
        {
            Form2 f14 = new Form2();
            f14.TopLevel = false;
            this.panel1.Controls.Add(f14);
            f14.FormBorderStyle = FormBorderStyle.None;

            f14.Top = 0;
            f14.Left = 0;
            f14.Size = f14.ClientSize;
            f14.Dock = DockStyle.Fill;
            f14.BringToFront();
            f14.Show();
            this.Text = "Imprimer Fiche d'intervention";
        }

        private void ficheStatistiqueToolStripMenuItem1DDD_Click(object sender, EventArgs e)
        {
            Form3 f15 = new Form3();
            f15.TopLevel = false;
            this.panel1.Controls.Add(f15);
            f15.FormBorderStyle = FormBorderStyle.None;

            f15.Top = 0;
            f15.Left = 0;
            f15.Size = f15.ClientSize;
            f15.Dock = DockStyle.Fill;
            f15.BringToFront();
            f15.Show();
            this.Text = "Imprimer Fiche statique";
        }

        private void aboutToolStripMenuItemE_Click(object sender, EventArgs e)
        {
            Form_about f9 = new Form_about();
            f9.Show();
        }

        private void quitterToolStripMenuItem1F_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        
    }
}
