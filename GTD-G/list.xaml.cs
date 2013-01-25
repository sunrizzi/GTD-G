using System;
using Microsoft.Phone.Controls;
using System.IO.IsolatedStorage;
using System.Windows;

namespace GTD_G
{
    public partial class list : PhoneApplicationPage
    {
        int[] Cents = {-2, -1, 0, 1, 2};

   public list()
        {
            InitializeComponent();           
            Summ.ItemsSource = Cents;
        }

        public void ApplicationBarMenuItem_Click(object sender, EventArgs e)
        {
            String nulltext = NameToDo.Text.ToString();
            if (string.IsNullOrEmpty(NameToDo.Text))
            {
                MessageBox.Show("Нужно заполнить название!");
            }
            else
            {

                String NameTo = NameToDo.Text.ToString();
                IsolatedStorageSettings.ApplicationSettings["Name"] = NameTo;

                int Sum = (int)Summ.SelectedItem;
                IsolatedStorageSettings.ApplicationSettings["Value"] = Sum;
                IsolatedStorageSettings.ApplicationSettings.Save();
                NavigationService.GoBack();
            }
        }
        public object stringint { get; set; }
    }
}