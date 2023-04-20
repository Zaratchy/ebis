using ebis.MAUI.JournalEntretien;
using ebis.MAUI.OperationRechargement;
using ebis.MAUI.Dashboard;
using ebis.MAUI.BadElement;
using System;

namespace ebis.MAUI.View;


public partial class BadElementPage : ContentPage
{
    public BadElementPage()
    {
        InitializeComponent();
        var viewModel = new BadElementViewModel();
        viewModel.BadElementDB();
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