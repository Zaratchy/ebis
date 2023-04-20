using ebis.MAUI.JournalEntretien;
using ebis.MAUI.OperationRechargement;
using ebis.MAUI.Dashboard;
using System;

namespace ebis.MAUI.View;


public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
        var viewModel = new DashViewModel();
        viewModel.DashboardDB();
        this.BindingContext = viewModel;

    }
    private async void OnPage5ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void OnPage6ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BadElementPage());
    }

    private async void OnPage7ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new JournalEntretienPage());
    }
}