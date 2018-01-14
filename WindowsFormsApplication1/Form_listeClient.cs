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
    public partial class Form_listeClient : Form
    {
        public Form_listeClient()
        {
            InitializeComponent();
        }
        Class1 c = new Class1();

        private void Form_listeClient_Load(object sender, EventArgs e)
        {
             
          
            c.da_client.Fill(c.ds,"Cli");
            //DataGridViewColumn column = dataGridView1.Columns[0];
            //column.Width = 60;
            dataGridView1.DataSource = c.ds.Tables["cli"];

            dataGridView1.Columns[0].HeaderText = "Matricule";
            dataGridView1.Columns[1].HeaderText = "Raison Sociale";
            dataGridView1.Columns[2].HeaderText = "Adresse";
            dataGridView1.Columns[3].HeaderText = "E-mail";
            dataGridView1.Columns[4].HeaderText = "Telephone";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
