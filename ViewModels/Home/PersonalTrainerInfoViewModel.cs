using CommunityToolkit.Mvvm.ComponentModel;
using GymApp.Models.Personal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.ViewModels.Home
{
   public partial class PersonalTrainerInfoViewModel: ObservableObject
    {
        [ObservableProperty]
        private PersonalTrainer personalTrainers;
        public PersonalTrainerInfoViewModel()
        {
            PersonalTrainers=new PersonalTrainer();
        }
    }
}
