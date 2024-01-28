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

namespace GymApp.ViewModels.Classes
{
   public partial  class GymClassesViewModel : ObservableObject
    {

         
        private ObservableCollection<GymWeek> gymWeeks=new(); 
        public ObservableCollection<GymWeek> GymWeeks
        {
            get => gymWeeks;
            set {
                 gymWeeks = value;
                 OnPropertyChanged(nameof (GymWeeks));
                }
        }

        private ObservableCollection<GymClass> gymClasses=new(); 
        public ObservableCollection<GymClass> GymClasses
        {
            get => gymClasses;
            set
            {
                gymClasses = value;
                OnPropertyChanged(nameof(GymClasses));
            }
        }
   
        public GymClassesViewModel() {

            LoadData();
        }
        public void LoadData()
        {
            
                GymWeeks.Add(new GymWeek() { WeekDay = DateTime.Now.AddDays(-1) });
                GymWeeks.Add(new GymWeek() { WeekDay = DateTime.Now.AddDays(1) });
                GymWeeks.Add(new GymWeek() { WeekDay = DateTime.Now.AddDays(2), IsSelected = true });
                GymWeeks.Add(new GymWeek() { WeekDay = DateTime.Now.AddDays(3) });
                GymWeeks.Add(new GymWeek() { WeekDay = DateTime.Now.AddDays(4) });
                GymWeeks.Add(new GymWeek() { WeekDay = DateTime.Now.AddDays(5) });
                GymWeeks.Add(new GymWeek() { WeekDay = DateTime.Now.AddDays(6) });
                GymWeeks.Add(new GymWeek() { WeekDay = DateTime.Now.AddDays(7) });
                GymWeeks.Add(new GymWeek() { WeekDay = DateTime.Now.AddDays(8) });

                GymClasses.Add(new GymClass() { Location = "Th", SpotLeft = 1, Title = "Test 1", UserId = 1, StartTime = DateTime.Now, TotalTime = 45 });
                GymClasses.Add(new GymClass() { Location = "Lon", SpotLeft = 1, Title = "Test 1", UserId = 1, StartTime = DateTime.Now, TotalTime = 45 });
                GymClasses.Add(new GymClass() { Location = "Gty", SpotLeft = 1, Title = "Test 1", UserId = 1, StartTime = DateTime.Now, TotalTime = 45 });
                GymClasses.Add(new GymClass() { Location = "Bobs", SpotLeft = 1, Title = "Test 1", UserId = 1, StartTime = DateTime.Now, TotalTime = 45 });

            
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
