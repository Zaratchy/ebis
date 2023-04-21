using ebis.MAUI.ViewModel;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ebis.MAUI.NbrMoyAccident;


public partial class NombreMoyenAccidentPage : ContentPage
{
    public NombreMoyenAccidentPage()
    {
        InitializeComponent();
        var EntretienviewModel = new NbrAccidentViewModel();
        EntretienviewModel.NbrAccidentDB();
        this.BindingContext = EntretienviewModel;
    }
}