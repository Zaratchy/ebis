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

namespace ebis.MAUI.ViewModel
{
    public class NbrAccidentViewModel : BindableObject
    {
        private string connectionString = "server=localhost;user=root;database=ebis;port=3306;password=";



        public ObservableCollection<string> Resultats { get; set; }

        public NbrAccidentViewModel()
        {
            Resultats = new ObservableCollection<string>();
        }


        public void NbrAccidentDB()
        {
            MySqlConnection conn = new MySqlConnection(this.connectionString);
            try
            {
                Debug.WriteLine("Connecting to MySQL...");
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 1\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 2\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 3\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 4\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 5\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 6\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 7\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 8\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 9\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 10\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 11\r\nUNION\r\nSELECT COUNT(Date_incident) \r\nFROM controle\r\nWHERE month(Date_incident) = 12;", conn);

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