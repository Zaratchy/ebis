using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebis.MAUI.Model
{
    public class TypeCharge : INotifyPropertyChanged
    {

        private int CodeTypeCharge;
        private String LibelleTypeCharge;
        private int PuissanceTypeCharge;


        public int codeTypeCharge
        {
            get { return CodeTypeCharge; }
            set { CodeTypeCharge = value; OnPropertyChanged("codeTypeCharge"); }
        }
        public String libelleTypeCharge
        {
            get { return LibelleTypeCharge; }
            set { LibelleTypeCharge = value; OnPropertyChanged("libelleTypeCharge"); }
        }
        public int puissanceTypeCharge
        {
            get { return PuissanceTypeCharge; }
            set { PuissanceTypeCharge = value; OnPropertyChanged("puissanceTypeCharge"); }
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