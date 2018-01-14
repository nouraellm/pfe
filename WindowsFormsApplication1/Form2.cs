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
    public partial class Form2 : Form
    {
        public Form2()
        {
           
            InitializeComponent();
        }
        Class1 c = new Class1();

        private SqlCommand cmd;
        private SqlDataAdapter adapt = new SqlDataAdapter();
        private DataSet data = new DataSet();

        private void Form2_Load(object sender, EventArgs e)
        {
            btnsave.Enabled = false;
            btnprint.Enabled = false;
            c.da_intervention.Fill(c.ds, "int");
            for (int i = 0; i < c.ds.Tables["int"].Rows.Count; i++)
            {
                comboBox1.Items.Add(c.ds.Tables["int"].Rows[i][0].ToString());
            }
            c.ds.Tables["int"].Clear();

        }
        CrystalReport2 ex = new CrystalReport2();
        private void btn_affiche_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() != "")
            {
                cmd = new SqlCommand("chammpes", c.cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter p = new SqlParameter("@id", SqlDbType.VarChar, 15, "@id");
                p.Value = comboBox1.Text;
                cmd.Parameters.Add(p);
                adapt.SelectCommand = cmd;
                adapt.Fill(data, "Examain");

                if (data.Tables["Examain"].Rows[0][18].ToString() == "Termine")
                {
                    data.Tables["Examain"].Rows[0][18] = "- Matériel testé certifié en état de marche";
                }
                if (data.Tables["Examain"].Rows[0][18].ToString() == "En Cours")
                {
                    data.Tables["Examain"].Rows[0][18] = "- Matériel envoyé pour suite de maintenance";
                }
                if (data.Tables["Examain"].Rows[0][18].ToString() == "Reforme")
                {
                    data.Tables["Examain"].Rows[0][18] = "- Matériel reforme";
                }
                if (data.Tables["Examain"].Rows[0][18].ToString() == "Reforme")
                {
                    data.Tables["Examain"].Rows[0][18] = "- Maintenance Annule";
                }


                //dataGridView1.DataSource = data.Tables["Examain"];

                ex.SetDataSource(data.Tables["Examain"]);
                crystalReportViewer1.ReportSource = ex;
                crystalReportViewer1.Refresh();

                btnprint.Enabled = true;
                btnsave.Enabled = true;
                data.Clear();
            }
            else
            {
                MessageBox.Show("saisir N° ");
            }


           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            string filename = "";
            SaveFileDialog savePdf = new SaveFileDialog();
            savePdf.Filter = "Fichiers PDF(*.pdf)|*.pdf";
            savePdf.FileName = "fiche " + DateTime.Now.Date.ToString("dd-MM-yyyy");
            if (savePdf.ShowDialog() == DialogResult.OK)
            {
                filename = savePdf.FileName;
                ex.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, filename);
            }
            
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
             
            this.crystalReportViewer1.PrintReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
