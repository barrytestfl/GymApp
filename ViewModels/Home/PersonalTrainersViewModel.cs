using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GymApp.Models.Personal;
using GymApp.Views.Home;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.ViewModels.Home
{
   public partial class PersonalTrainersViewModel: ObservableObject
    {
        [ObservableProperty]
        private List<PersonalTrainer> personalTrainers = new();

        [RelayCommand]
        public static async Task MoreInfo(PersonalTrainer model)
        {
            PersonalTrainerInfoViewModel nextViewModel = Application.Current.Handler.MauiContext.Services.GetService<PersonalTrainerInfoViewModel>();
            nextViewModel.PersonalTrainers = model;
             PersonalTrainerInfoPage nextPage = new(nextViewModel);
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(nextPage);
            });
        }
        public PersonalTrainersViewModel() {
            PersonalTrainers=new List<PersonalTrainer> {
                new PersonalTrainer(){FirstName="Ali",LastName="Samadi",Address="",Email="AliS15@gmail.com",Phone="00445587777",GymLoc="Alpi" },
                new PersonalTrainer(){FirstName="Reza",LastName="Khani",Address="",Email="Reza.KK@gmail.com",Phone="00445587777",GymLoc="Alpi" },
            
            };
        }
    }
}
