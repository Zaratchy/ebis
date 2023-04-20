using ebis.MAUI.Model;
using ebis.MAUI.Services;
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

        public ObservableCollection<Borne> Bornes { get; }

        BddService service;

        public StatViewModel(BddService service)
        {

            this.service = service;

            Bornes = new ObservableCollection<Borne>();

            var bornes = service.GetBornesAsync().Result;


            foreach (var borne in bornes)
            {
                Bornes.Add(borne);
            }
        }
            
        
    }
}