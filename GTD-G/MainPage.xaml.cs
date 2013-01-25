using System;
using System.Windows;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.Collections.Generic;

namespace GTD_G
{
    public partial class MainPage : PhoneApplicationPage
    {
        public List<string> ListP = new List<string>();
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/list.xaml", UriKind.Relative));
        }

        public object NameLP { get; set; }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Name") == true)
            {
                FirstListBox.Items.Add(IsolatedStorageSettings.ApplicationSettings["Name"].ToString());
            }
            else
            {
            }

            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
            base.OnNavigatedTo(e);
        }
    }
}