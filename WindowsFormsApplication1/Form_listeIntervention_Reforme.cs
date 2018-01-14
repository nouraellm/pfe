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
    public partial class Form_listeIntervention_Reforme : Form
    {
        public Form_listeIntervention_Reforme()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();

        private void Form_listeIntervention_Reforme_Load(object sender, EventArgs e)
        {
            c.da3 = new SqlDataAdapter("select * from intervention where etat='Reforme'", c.cnx);
            c.da3.Fill(c.ds, "int_r");
            dataGridView1.DataSource = c.ds.Tables["int_r"];

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
        }
    }
}
