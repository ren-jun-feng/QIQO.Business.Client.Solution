﻿using QIQO.Business.Module.Account.ViewModels;
using System.Windows.Controls;

namespace QIQO.Business.Module.Account.Views
{
    /// <summary>
    /// Interaction logic for AccountHomeView.xaml
    /// </summary>
    public partial class AccountHomeView : UserControl
    {
        public AccountHomeView(AccountHomeViewModel view_model)
        {
            InitializeComponent();
            DataContext = view_model;
        }
    }
}
