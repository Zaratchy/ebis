﻿using MySql.Data.MySqlClient;
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
    public class JournalIncidentViewModel : BindableObject
    {
        private string connectionString = "server=localhost;user=root;database=ebis;port=3306;password=";

        public ObservableCollection<string> Resultats { get; set; }

        public JournalIncidentViewModel()
        {
            Resultats = new ObservableCollection<string>();
        }

        public void JournalIncidentDB()
        {
            MySqlConnection conn = new MySqlConnection(this.connectionString);
            try
            {
                Debug.WriteLine("Connecting to MySQL...");
                conn.Open();
                MySqlCommand command = new MySqlCommand("SELECT idBorne, libelleControle, details, Date_incident FROM borne \r\nJOIN controle ON borne.idBorne = controle.idControle order by Date_incident DESC;", conn);

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Resultats.Add(reader.GetString(0));
                    Resultats.Add(reader.GetString(1));
                    Resultats.Add(reader.GetString(2));
                    Resultats.Add(reader.GetString(3));
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