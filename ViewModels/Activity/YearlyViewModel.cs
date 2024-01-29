using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GymApp.Models.Classes;
using GymApp.ViewModels.Accounts;
using GymApp.ViewModels.Notifications;
using GymApp.Views.Accounts;
using GymApp.Views.Notifications;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.ViewModels.Activity
{
   public partial class YearlyViewModel : ObservableObject
    {
        private ObservableCollection<GymClass> gymClasses = new();
        public ObservableCollection<GymClass> GymClasses
        {
            get => gymClasses;
            set
            {
                gymClasses = value;
                OnPropertyChanged(nameof(GymClasses));
            }
        }

        public YearlyViewModel() {
            LoadData();
        }
        public void LoadData()
        {
           

                GymClasses.Add(new GymClass() { Location = "Th", SpotLeft = 1, Title = "Test 1", UserId = 1, StartTime = new DateTime(2024, 1, 1), TotalTime = 45 });
                GymClasses.Add(new GymClass() { Location = "Lon", SpotLeft = 1, Title = "Test 1", UserId = 1, StartTime = new DateTime(2024, 2, 1), TotalTime = 35 });
                GymClasses.Add(new GymClass() { Location = "Gty", SpotLeft = 1, Title = "Test 1", UserId = 1, StartTime = new DateTime(2024, 3, 1), TotalTime = 24 }); 

             
        }
        [RelayCommand]
        public async Task Account()
        {
            AccountViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<AccountViewModel>();
            AccountPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }

        [RelayCommand]
        public async Task NotificationCenter()
        {
            NotificationCenterViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<NotificationCenterViewModel>();
            NotificationCenterPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
    }
   
}
 
