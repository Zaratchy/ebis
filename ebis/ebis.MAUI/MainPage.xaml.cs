namespace ebis.MAUI;

using ebis.MAUI.ViewModel;
using Microsoft.Maui.Controls;
using MySql.Data.MySqlClient;
using System;

public partial class MainPage : ContentPage
{
   

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new BornesViewModel();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        string connectionString = "server=localhost;user=root;database=ebis;port=3306;password=";
        using MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        string message = connection.State == System.Data.ConnectionState.Open
            ? "Connexion réussie à MySQL en local!"
            : "Impossible de se connecter à MySQL en local.";

        DisplayAlert("Connexion MySQL", message, "OK");
    }
   

}

