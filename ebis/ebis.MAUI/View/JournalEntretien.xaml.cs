using ebis.MAUI.JournalIncident;
using ebis.MAUI.OperationRechargement;
using ebis.MAUI.View;
using ebis.MAUI.ViewModel;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ebis.MAUI.JournalEntretien;


public partial class JournalEntretienPage : ContentPage
{
    public JournalEntretienPage()
    {
        InitializeComponent();
        var EntretienviewModel = new JournalEntretienViewModel();
        EntretienviewModel.JournalEntretienDB();
        this.BindingContext = EntretienviewModel;
    }

    private async void OnPage2ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
    private async void OnPage1ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JournalOperationPage());
    }

    private async void OnPage9ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JournalIncidentPage());
    }

    private async void OnPage3ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JournalEntretienPage());
    }
    private async void OnPage4ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashboardPage());
    }
    private async void OnPage10ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TechnicienPage());
    }
}