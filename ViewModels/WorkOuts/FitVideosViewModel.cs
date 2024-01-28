using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GymApp.Models.Video;
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
    public partial class FitVideosViewModel : ObservableObject
    {
        private ObservableCollection<Category> categories = new();
        public ObservableCollection<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                OnPropertyChanged(nameof(Categories));
            }
        }
        private ObservableCollection<Video> recommended = new();
        public ObservableCollection<Video> Recommended
        {
            get => recommended;
            set
            {
                recommended = value;
                OnPropertyChanged(nameof(Recommended));
            }
        }
        public FitVideosViewModel() {
            LoadData();
                  }
        public void LoadData()
        {
            
                Categories.Add(new Category() { Id = 0, Title = "cardio", Img = "fitness.png" });
                Categories.Add(new Category() { Id = 0, Title = "cardio", Img = "sports.png" });
                Categories.Add(new Category() { Id = 0, Title = "cardio", Img = "weight.png" });

                Recommended.Add(new Video() { Id = 0, CategoryId = 1, Title = "push pull", PartName = "8", VideoType = "strngth", Description = "", Duration = TimeOnly.FromDateTime(DateTime.Now.AddMinutes(20)), Img = "fitnesskg.png" });
                Recommended.Add(new Video() { Id = 0, CategoryId = 1, Title = "push pull", PartName = "8", VideoType = "strngth", Description = "", Duration = TimeOnly.FromDateTime(DateTime.Now.AddMinutes(20)), Img = "fitness.png" });
                Recommended.Add(new Video() { Id = 0, CategoryId = 1, Title = "push pull", PartName = "8", VideoType = "strngth", Description = "", Duration = TimeOnly.FromDateTime(DateTime.Now.AddMinutes(20)), Img = "weight.png" });

            
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
