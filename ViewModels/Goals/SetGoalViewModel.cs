using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.ViewModels.Goals
{
    public partial class SetGoalViewModel: ObservableObject
    {
        [ObservableProperty]
        private string typeGoal;
        [ObservableProperty]
        private bool isWeekly;

        [ObservableProperty]
        private int dayPerWeek;

        [ObservableProperty]
        private List<string>days;

        [ObservableProperty]
        private List<string> week;
        [ObservableProperty]
        private bool isColories;

        [ObservableProperty]
        private int coloriPerWeek;
        [ObservableProperty]
        private List<string> coloriesPerWeek;
        [ObservableProperty]
        private string title;
        [ObservableProperty]
        private bool isWorkout;

        [ObservableProperty]
        private string hours;
        [ObservableProperty]
        private List<string> hoursPerWeek;
        [ObservableProperty]
        private bool isDistance;

        [ObservableProperty]
        private int distancePerWeek;
        [ObservableProperty]
        private List<string> distance;
        public  SetGoalViewModel() {

            Days = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7"
            };

            ColoriesPerWeek = new List<string>()
            {
                "300",
                "600",
                "900",
                "1200",
                
            };

            HoursPerWeek = new List<string>()
            {
                "00:30",
                "01:00",
                "01:30",
                "02:00",

            };

            Week = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7"
            };

        Distance= new List<string>() { 
        "3",
        "8",
        "15",
        "30"
        };
        }
    }
}
