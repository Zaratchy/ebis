using ebis.MAUI.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebis.MAUI.GoodElement
{
    public class GoodElementViewModel : BindableObject
    {
        private string connectionString = "server=localhost;user=root;database=ebis;port=3306;password=";



        public ObservableCollection<string> Resultats { get; set; }

        public GoodElementViewModel()
        {
            Resultats = new ObservableCollection<string>();
        }


        public void BadElementDB()
        {
            MySqlConnection conn = new MySqlConnection(this.connectionString);
            try
            {
                Debug.WriteLine("Connecting to MySQL...");
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT elements.nom, idBorne,DATEDIFF( DATE(NOW()),dateMiseEnService) - DATEDIFF(entretien.Date_d_entretien,Date_incident) AS DureeElement FROM borne JOIN controle ON (borne.idBorne = controle.idControle) JOIN entretien ON (entretien.IdEntretien = controle.idControle) JOIN elements ON elements.idElement = borne.idBorne WHERE year(dateMiseEnService) >= YEAR(DATE( NOW() ))-5 ORDER BY DureeElement DESC LIMIT 5;", conn);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Resultats.Add(reader.GetString(0));
                    Resultats.Add(reader.GetString(1));
                    Resultats.Add(reader.GetString(2));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            conn.Close();
            Debug.WriteLine("Done.");
        }
    }


}