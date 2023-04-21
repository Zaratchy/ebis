using ebis.MAUI.View;
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
        await Navigation.PushAsync(new GoodElementPage());
    }

    private async void OnPage8ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NombreMoyenAccidentPage());
    }
}