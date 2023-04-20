using ebis.MAUI.ViewModel;
using System;

namespace ebis.MAUI.View;


public partial class MainPage : ContentPage
{
    public MainPage(StatViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}