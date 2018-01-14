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
    public partial class Form_listeIntervenant : Form
    {
        public Form_listeIntervenant()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();
        private void Form_listeIntervenant_Load(object sender, EventArgs e)
        {
            
            c.da_intervenant.Fill(c.ds, "int");
            dataGridView1.DataSource = c.ds.Tables["int"];

            dataGridView1.Columns[0].HeaderText = "Matricule";
            dataGridView1.Columns[1].HeaderText = "Nom";
            dataGridView1.Columns[2].HeaderText = "Prenom";
            dataGridView1.Columns[3].HeaderText = "Adresse";
            dataGridView1.Columns[4].HeaderText = "E-mail";
            dataGridView1.Columns[5].HeaderText = "Telephone";
        }
    }
}
