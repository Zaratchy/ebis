using ebis.MAUI.JournalEntretien;
using ebis.MAUI.OperationRechargement;
using ebis.MAUI.ViewModel;
using System;

namespace ebis.MAUI.View;


public partial class TechnicienPage : ContentPage
{
    public TechnicienPage()
    {
        InitializeComponent();
        var viewModel = new TechnicienViewModel();
        viewModel.SelectToDatabase();
        this.BindingContext = viewModel;

    }
    private async void OnPage1ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JournalOperationPage());
    }

    private async void OnPage2ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void OnPage3ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JournalEntretienPage());
    }
    private async void OnPage4ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new DashboardPage());
    }
}