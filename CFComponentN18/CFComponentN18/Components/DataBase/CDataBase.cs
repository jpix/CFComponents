using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlServerCe;



namespace CFComponentN18
{
    public class CDataBase
    {

        private string m_ConnectionString;
        public string ConnectionString
        {
            get { return m_ConnectionString; }
            set { m_ConnectionString = value; }
        }


        // default ctor
        public CDataBase()
        {
           
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            m_ConnectionString = "Data Source =" + path + "\\dataX_2018.sdf; Password ='pHuS7ured+aw'";
                
        }

               
       
        public DataSet GetRegionsFromSDF_V2()
        {


            string query = "SELECT DISTINCT [codice_regione],[denominazione_regione] FROM [comuni_2018] ORDER BY [denominazione_regione] ASC";

            SqlCeConnection conn = new SqlCeConnection(m_ConnectionString);

            SqlCeCommand cmd = new SqlCeCommand(query, conn);

            conn.Open();

            DataSet ds = new DataSet();

            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

            da.Fill(ds);

            conn.Close();
            da.Dispose();

            return ds;

        }


        public DataSet GetProvinceFromSDF_V2(int indexRegione)
        {

            string query =
                "SELECT DISTINCT [codice_regione],[codice_provincia], LTRIM(REPLACE([denominazione_citta_metropolitana] +[denominazione_provincia], '-', ' ')) as provincia FROM[comuni_2018] " +

                " where codice_regione =" + indexRegione.ToString() + " ORDER BY provincia ASC";


            SqlCeConnection conn = new SqlCeConnection(m_ConnectionString);
            
            SqlCeCommand cmd = new SqlCeCommand(query, conn);

            conn.Open();
            
            DataSet ds = new DataSet();
            
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

            da.Fill(ds);
            

            conn.Close();
            da.Dispose();

            return ds;
        }



        public DataSet GetComuniFromSDF_V2(int indexRegione, int indexProvincia)
        {


            string query =
                "SELECT[id_progressivo],[denominazione_in_italiano],[codice_catastale_del_comune], [sigla_automobilistica] FROM[comuni_2018] " +
                " WHERE codice_provincia = " + indexProvincia.ToString() +
                " ORDER BY denominazione_in_italiano ASC ";


            SqlCeConnection conn = new SqlCeConnection(m_ConnectionString);
            
            SqlCeCommand cmd = new SqlCeCommand(query, conn);

            conn.Open();
            
            DataSet ds = new DataSet();
            
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

            da.Fill(ds);

            conn.Close();
            da.Dispose();

            return ds;

        }



        public DataSet GetComuneDataFromSDF_V2(int indexComune)
        {


            string query =
               " SELECT[id_progressivo], [denominazione_in_italiano], [codice_catastale_del_comune],[sigla_automobilistica] FROM[comuni_2018] "
               +
               " WHERE id_progressivo = " + indexComune.ToString();

            SqlCeConnection conn = new SqlCeConnection(m_ConnectionString);
            
            SqlCeCommand cmd = new SqlCeCommand(query, conn);

            conn.Open();
            
            DataSet ds = new DataSet();
            
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);

            da.Fill(ds);
            
            conn.Close();
            da.Dispose();

            return ds;

        }



    


   }
}
