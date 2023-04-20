using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ebis.MAUI.Model;


namespace ebis.MAUI.Services
{
    public class BddService
    {
        private string connectionString = "server=localhost;user=root;database=ebis;port=3306;password=";

        public async Task<List<Borne>> GetBornesAsync()
        {
            List<Borne> bornes = new List<Borne>();
            MySqlConnection conn = new MySqlConnection(this.connectionString);
            try
            {
                Debug.WriteLine("Connecting to MySQL...");
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `borne` JOIN `typecharge` ON `borne`.`idBorne` = `typecharge`.`codeTypeCharge`;", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Borne borne = new Borne
                        {
                            idBorne = reader.GetInt32(0),
                            dateMiseEnService = reader.GetDateTime(1),
                            dateDerniereRevision = reader.GetDateTime(2),
                            libelleTypeCharge= reader.GetString(6)
                        };
                        bornes.Add(borne);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            conn.Close();
            Debug.WriteLine("Done.");
            return bornes;
        }
    }
}
