using ebis.MAUI.ViewModel;
using System;

namespace ebis.MAUI.View;


public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        var viewModel = new StatViewModel();
        viewModel.SelectToDatabase();
        this.BindingContext = viewModel;
    }
}