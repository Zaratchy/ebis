using ebis.MAUI.ViewModel;
using System;
using System.Security.Cryptography.X509Certificates;

namespace ebis.MAUI.OperationRechargement;


public partial class JournalOperationPage : ContentPage
{
    public JournalOperationPage()
    {
        InitializeComponent();
        var OpRechargeviewModel = new JournalOperationViewModel();
        OpRechargeviewModel.OperationRechargementDB();
        this.BindingContext = OpRechargeviewModel;
    }
}