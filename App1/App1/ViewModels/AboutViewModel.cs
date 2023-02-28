using App1.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Inicio";
            //Command = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            StartCommand = new Command(OnStartClick);
        }

        public async void OnStartClick(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(ItemsPage)}");
        }

        public Command StartCommand { get; }
    }
}