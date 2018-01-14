using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Class1
    {

        public SqlConnection cnx = new SqlConnection(@"data source=.\SQLEXPRESS ; initial catalog = base1 ; integrated security = true ");
        public SqlDataAdapter da3;
        public SqlDataAdapter da4;
        public SqlDataAdapter da_client;//da
        public SqlDataAdapter da_Commercial;//da1
        public SqlDataAdapter da_intervenant;//da2
        public SqlDataAdapter da_intervention;//da3
        public SqlDataAdapter da_materiel;
        public SqlDataAdapter da_panne;
        public SqlDataAdapter da_login;

        public DataSet ds = new DataSet();
          

        public Class1()
        {
            this.da_client = new SqlDataAdapter("select * from Client", cnx);
            this.da_Commercial = new SqlDataAdapter("select * from Commercial", cnx);
            this.da_intervenant = new SqlDataAdapter("select * from Intervenant", cnx);
            this.da_intervention = new SqlDataAdapter("select * from intervention", cnx);
            this.da_materiel = new SqlDataAdapter("select * from Materiel", cnx);
            this.da_panne = new SqlDataAdapter("select * from panne", cnx);
            this.da_login = new SqlDataAdapter("select * from authentification", cnx);
        }
    }
}
