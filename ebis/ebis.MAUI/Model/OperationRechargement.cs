using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebis.MAUI.Model
{
    public class OperationRechargement : INotifyPropertyChanged
    {

<<<<<<< HEAD
        private int NumOperation;
=======
        private int numOperation;
>>>>>>> feature/journalentretien
        private DateTime DateHeureDebut;
        private DateTime DateHeureFin;
        private int NbrKwH;


<<<<<<< HEAD
        public int numOperation
        {
            get { return NumOperation; }
            set { NumOperation = value; OnPropertyChanged("numOperation"); }
=======
        public int NumOperation
        {
            get { return numOperation; }
            set { numOperation = value; OnPropertyChanged("NumOperation"); }
>>>>>>> feature/journalentretien
        }
        public DateTime dateHeureDebut
        {
            get { return DateHeureDebut; }
            set { DateHeureDebut = value; OnPropertyChanged("dateHeureDebut"); }
        }
        public DateTime dateHeureFin
        {
            get { return DateHeureFin; }
            set { DateHeureFin = value; OnPropertyChanged("dateHeureFin"); }
        }

        public int nbrKwH
        {
            get { return NbrKwH; }
            set { NbrKwH = value; OnPropertyChanged("nbrKwH"); }
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