using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebis.MAUI.Model
{
    public class Borne : INotifyPropertyChanged
    {

        private int IdBorne;
        private DateTime DateMiseEnService;
        private DateTime DateDerniereRevision;


        public int idBorne
        {
            get { return IdBorne; }
            set { IdBorne = value; OnPropertyChanged("idBorne"); }
        }
        public DateTime dateMiseEnService
        {
            get { return DateMiseEnService; }
            set { DateMiseEnService = value; OnPropertyChanged("dateMiseEnService"); }
        }
        public DateTime dateDerniereRevision
        {
            get { return DateDerniereRevision; }
            set { DateDerniereRevision = value; OnPropertyChanged("dateDerniereRevision"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}