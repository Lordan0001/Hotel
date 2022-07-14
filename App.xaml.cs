using MVVM.Exceptions;
using MVVM.Models;
using MVVM.Stores;
using MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows;

namespace MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("SingletonSean Suites");
            _navigationStore = new NavigationStore();
        }


        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new ReservationListingViewModel(_navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }



    }
}
