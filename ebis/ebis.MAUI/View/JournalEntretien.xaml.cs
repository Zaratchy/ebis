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
}