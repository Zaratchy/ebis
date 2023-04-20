<<<<<<< HEAD
﻿using ebis.MAUI.Model;
using ebis.MAUI.Services;
=======
﻿using ebis.MAUI.View;
>>>>>>> feature/journalentretien
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
    public class StatViewModel : BindableObject
    {
        private string connectionString = "server=localhost;user=root;database=ebis;port=3306;password=";

<<<<<<< HEAD
        public ObservableCollection<Borne> Bornes { get; }
=======
        

        public ObservableCollection<string> Resultats { get; set; }
>>>>>>> feature/journalentretien

        BddService service;

        public StatViewModel(BddService service)
        {

<<<<<<< HEAD
            this.service = service;

            Bornes = new ObservableCollection<Borne>();

            var bornes = service.GetBornesAsync().Result;


            foreach (var borne in bornes)
=======
      
        public void SelectToDatabase()
        {
            MySqlConnection conn = new MySqlConnection(this.connectionString);
            try
>>>>>>> feature/journalentretien
            {
                Bornes.Add(borne);
            }
        }
            
        
    }


}