using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebis.MAUI.ViewModel
{
    public class JournalEntretienViewModel : BindableObject
    {
        private string connectionString = "server=localhost;user=root;database=ebis;port=3306;password=";

        public ObservableCollection<string> Resultats { get; set; }

        public JournalEntretienViewModel()
        {
            Resultats = new ObservableCollection<string>();
        }

        public void JournalEntretienDB()
        {
            MySqlConnection conn = new MySqlConnection(this.connectionString);
            try
            {
                Debug.WriteLine("Connecting to MySQL...");
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT borne.idBorne, station.adresseRue, station.Ville, technicien.nom, technicien.prenom, entretien.Date_d_entretien, elements.nom, elements.status FROM borne\r\nINNER JOIN station ON station.idStation = borne.id_Station \r\nINNER JOIN entretien ON entretien.IdEntretien = borne.entretien\r\nINNER JOIN technicien ON technicien.idTechnicien = entretien.id_Technicien \r\nINNER JOIN elements ON elements.id_Borne = borne.idBorne;", conn);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Resultats.Add(reader.GetString(0));
                    Resultats.Add(reader.GetString(1));
                    Resultats.Add(reader.GetString(2));
                    Resultats.Add(reader.GetString(3));
                    Resultats.Add(reader.GetString(4));
                    Resultats.Add(reader.GetString(5));
                    Resultats.Add(reader.GetString(6));
                    Resultats.Add(reader.GetString(7));
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