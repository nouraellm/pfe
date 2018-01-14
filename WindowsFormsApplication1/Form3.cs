using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
          Class1 c = new Class1();
        private void Form3_Load(object sender, EventArgs e)
        {
            btnsave.Enabled = false;
            btnprint.Enabled = false;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            c.da_client.Fill(c.ds,"cli");
            for (int i = 0; i < c.ds.Tables["cli"].Rows.Count; i++)
            {
                comboBox1.Items.Add(c.ds.Tables["cli"].Rows[i][0].ToString() + "   " + c.ds.Tables["cli"].Rows[i][1].ToString());
            }

            c.ds.Tables["cli"].Clear();
            

        }
       
        private SqlCommand cmd;
        private SqlDataAdapter adapt = new SqlDataAdapter();
        private DataSet data = new DataSet();
        CrystalReport3 ex = new CrystalReport3();
        CrystalReport4 ex1 = new CrystalReport4();
        CrystalReport5 ex2 = new CrystalReport5();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    
                    cmd = new SqlCommand("Fiche", c.cnx);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("@dated", SqlDbType.DateTime, 10, "@dated");
                    SqlParameter p2 = new SqlParameter("@datef", SqlDbType.DateTime, 10, "@datef");
                    p1.Value = dateTimePicker1.Value;
                    p2.Value = dateTimePicker2.Value;
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    adapt.SelectCommand = cmd;
                    adapt.Fill(data, "Examain");

                    ex.SetDataSource(data.Tables["Examain"]);
                    crystalReportViewer1.ReportSource = ex;
                    crystalReportViewer1.Refresh();
                    btnsave.Enabled = true;
                    btnprint.Enabled = true;
                    data.Clear();
                }
                if (radioButton2.Checked)
                {
                    if (comboBox1.Text.Trim() != "")
                    {
                        string num = comboBox1.Text.Substring(0, 7);
                        cmd = new SqlCommand("Fiche2", c.cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p1 = new SqlParameter("@idclii", SqlDbType.VarChar, 15, "@idclii");
                        SqlParameter p2 = new SqlParameter("@dated", SqlDbType.DateTime, 10, "@dated");
                        SqlParameter p3 = new SqlParameter("@datef", SqlDbType.DateTime, 10, "@datef");
                        p1.Value = num;
                        p2.Value = dateTimePicker4.Value;
                        p3.Value = dateTimePicker3.Value; ;
                        cmd.Parameters.Add(p1);
                        cmd.Parameters.Add(p2);
                        cmd.Parameters.Add(p3);
                        adapt.SelectCommand = cmd;
                        adapt.Fill(data, "Examain1");

                        ex1.SetDataSource(data.Tables["Examain1"]);
                        crystalReportViewer1.ReportSource = ex1;
                        crystalReportViewer1.Refresh();
                        btnsave.Enabled = true;
                        btnprint.Enabled = true;
                        data.Clear();
                    }
                    else
                    {
                        MessageBox.Show("saisir client");
                    }
                }
                if (radioButton3.Checked)
                {
                    if (comboBox1.Text.Trim() != "")
                    {

                        string num = comboBox1.Text.Substring(0, 7);

                        cmd = new SqlCommand("Fiche1", c.cnx);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p1 = new SqlParameter("@idcli", SqlDbType.VarChar, 15, "@idcli");

                        p1.Value = num;
                        cmd.Parameters.Add(p1);
                        adapt.SelectCommand = cmd;
                        adapt.Fill(data, "Examain2");

                        ex2.SetDataSource(data.Tables["Examain2"]);
                        crystalReportViewer1.ReportSource = ex2;
                        crystalReportViewer1.Refresh();
                        btnsave.Enabled = true;
                        btnprint.Enabled = true;
                        data.Clear();
                    }
                    else
                    {
                        MessageBox.Show("saisir client");
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("erreur : "+ee.ToString());
                
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
            panel3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = true;
            panel3.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog savePdf = new SaveFileDialog();
            savePdf.Filter = "Fichiers PDF(*.pdf)|*.pdf";
            savePdf.FileName = "fiche statistique " + DateTime.Now.Date.ToString("dd-MM-yyyy");
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
    }
}
