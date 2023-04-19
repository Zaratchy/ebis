using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebis.MAUI.Model
{
    public class Element : INotifyPropertyChanged
    {

        private int IdElement;
        private string Nom;
        private string Status;


        public int idElement
        {
            get { return IdElement; }
            set { IdElement = value; OnPropertyChanged("idElement"); }
        }
        public string nom
        {
            get { return Nom; }
            set { Nom = value; OnPropertyChanged("nom"); }
        }
        public string status
        {
            get { return Status; }
            set { Status = value; OnPropertyChanged("status"); }
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