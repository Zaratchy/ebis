        using ebis.MAUI.ViewModel;
using System;

namespace ebis.MAUI;


public partial class MainPage : ContentPage
{
    async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Technician());
    }


    public MainPage()
    {
        InitializeComponent();
        var viewModel = new StatViewModel();
        viewModel.SelectToDatabase();
        this.BindingContext = viewModel;
    }
}