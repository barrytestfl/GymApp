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

namespace GymApp.ViewModels.WorkOuts
{
   public partial class RecordWorkOutsViewModel : ObservableObject
    {
        private ObservableCollection<FilterRecord> filterRecords = new();
        public ObservableCollection<FilterRecord> FilterRecords
        {
            get => filterRecords;
            set
            {
                filterRecords = value;
                OnPropertyChanged(nameof(FilterRecords));
            }
        }
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
        public RecordWorkOutsViewModel()
        {
            LoadData();
        }
        public void LoadData()
        {
             
                GymClasses.Add(new GymClass() { Location = "Th", SpotLeft = 1, Title = "Test 1", UserId = 1, StartTime = new DateTime(2024, 1, 1), TotalTime = 45 });
                FilterRecords.Add(new FilterRecord() { Id = 0, Title = "workout", IsSelected = true });
                FilterRecords.Add(new FilterRecord() { Id = 0, Title = "weekly" });
                FilterRecords.Add(new FilterRecord() { Id = 0, Title = "monthly" });
                FilterRecords.Add(new FilterRecord() { Id = 0, Title = "yearly" });
 
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
