using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pokladna
{
    public class SqlDotaz : Irepos    
    {
        private string connectString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Pokladna; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void vytvorTest(List<PoklZaznam>vychoziZaznam) 
        {
            using (SqlConnection connect = new SqlConnection(connectString))
            {
                string dotaz= "CREATE TABLE [dbo].PokladniZaznam([IdPokladniZaznam] INT NOT NULL PRIMARY KEY IDENTITY(1,1),[CisloDokladu] INT NOT NULL,[Datum] DATETIME NOT NULL,[PopisZaznamu] VARCHAR(150) NOT NULL,[Castka] FLOAT NOT NULL,[Zustatek] FLOAT NOT NULL,[Poznamka] VARCHAR(150) NULL);";
                foreach (var z in vychoziZaznam) 
                {
                    dotaz += $"insert into PokladniZaznam(CisloDokladu, Datum,PopisZaznamu,Castka, Zustatek,Poznamka)" + $"values({z.CisloDokladu},{z.Datum.ToString("yyyyMMdd")},{z.PopisZaznamu},{z.Castka},{z.Zustatek},{z.Poznamka})";

                }
                using (SqlCommand sqlComm = new SqlCommand(dotaz, connect))
                {
                    connect.Open();
                    sqlComm.ExecuteNonQuery();  

                    connect.Close();
                }
                
            }
        }
        public List<PoklZaznam> NactiMesic(int rok, int mesic)
        {
            throw new NotImplementedException();
        }

        public List<PoklZaznam> NactiVse()
        {
            List<PoklZaznam> result = new List<PoklZaznam>();

            using (SqlConnection connect = new SqlConnection(connectString))
            {
                using (SqlCommand command = new SqlCommand("select * from PokladniZaznam",connect)) 
                {
                    connect.Open();
                    using (SqlDataReader datareader = command.ExecuteReader()) 
                    {
                        while (datareader.Read()) 
                        {
                            result.Add(new PoklZaznam(Convert.ToInt32(datareader["IdPokladniZaznam"]), Convert.ToInt32(datareader["CisloDokladu"]),Convert.ToDateTime(datareader["Datum"]), datareader["PopisZaznamu"].ToString(),Convert.ToDouble(datareader["Castka"]), Convert.ToDouble(datareader["Zustatek"]), datareader["Poznamka"].ToString()));
                        }
                    }


                    connect.Close();
                }
            }
            return result;  
        }

        public PoklZaznam NactiZaznam(int idPoklZaznam)
        {
            throw new NotImplementedException();
        }

        public void SmazZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public void UpravZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public PoklZaznam VytvorZaznam(PoklZaznam PoklZaznam)
        {
            throw new NotImplementedException();
        }
    }
}
