using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GymApp.ViewModels.Home
{
    public partial class AddFriendViewModel: ObservableObject
    {
        [ObservableProperty]
        private string firstName;
        [ObservableProperty]
        private string lastName;
        [ObservableProperty]
        private string email;
        [ObservableProperty]
        private string gymLoc;
        [ObservableProperty]
        private string attendanceDate;
        [ObservableProperty]
        private string attendanceHourse;
        [ObservableProperty]
        private string attendanceMinute;

        [ObservableProperty]
        private string attendance;
        [ObservableProperty]
        private string message;
        [ObservableProperty]
        private bool accept;
        [ObservableProperty]
        private bool haveHealthDisability;
        [ObservableProperty]
        private List<string> gymLocList=new();
        [ObservableProperty]
        private List<string> attendanceDateList = new();
        [ObservableProperty]
        private List<string> attendanceHList = new();
        [ObservableProperty]
        private List<string> attendanceMList = new();
        public ICommand AddBringFriendCommand { get; private set; }
        public AddFriendViewModel() {
            
            AddBringFriendCommand = new Command(async () => await AddBringFriend());
            GymLocList = new List<string>() {

           "Alpa"
           };
            AttendanceDateList = Enumerable.Range(1, 30)
             .Select(x => x.ToString())
             .ToList();
            AttendanceHList = Enumerable.Range(1, 24)
            .Select(x => x.ToString())
            .ToList();

            AttendanceMList = Enumerable.Range(1, 60)
            .Select(x => x.ToString())
            .ToList();
        }
        public async Task AddBringFriend()
        {
            
        }
    }
}
