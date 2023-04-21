using ebis.MAUI.ViewModel;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ebis.MAUI.JournalIncident;


public partial class JournalIncidentPage : ContentPage
{
    public JournalIncidentPage()
    {
        InitializeComponent();
        var EntretienviewModel = new JournalIncidentViewModel();
        EntretienviewModel.JournalIncidentDB();
        this.BindingContext = EntretienviewModel;
    }
}