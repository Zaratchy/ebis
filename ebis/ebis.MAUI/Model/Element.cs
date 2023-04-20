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

        private int idElement;
        private string nom;
        private string status;


        public int IdElement
        {
            get { return idElement; }
            set { idElement = value; OnPropertyChanged("IdElement"); }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; OnPropertyChanged("Nom"); }
        }
        public string Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged("Status"); }
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