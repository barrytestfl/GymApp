using CommunityToolkit.Mvvm.ComponentModel;
using GymApp.Models.Deals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.ViewModels.Deals
{
    public partial class AllDealsViewModel: ObservableObject
    {
        [ObservableProperty]
        private List<string> category;
        [ObservableProperty]
        private List<DealsModel> allDeals;

        [ObservableProperty]
        private List<DealsModel> savedDeals;
        public AllDealsViewModel() { 
        Category = new List<string>()
        {
            "all","New ","Test"
        };
            AllDeals = new List<DealsModel>()
            {
                new DealsModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    CategoryName = "Test",
                    Name = "Test",
                    DayLeft = 1,
                    Offer=1,
                    From=DateTime.Now,
                    End=DateTime.Now.AddDays(20),
                },
                new DealsModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    CategoryName = "Test",
                    Name = "Test",
                    DayLeft = 1,
                    Offer=1,
                    From=DateTime.Now,
                    End=DateTime.Now.AddDays(20),
                },
                new DealsModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    CategoryName = "Test",
                    Name = "Test",
                    DayLeft = 1,
                    Offer=1,
                    From=DateTime.Now,
                    End=DateTime.Now.AddDays(20),
                },
                new DealsModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    CategoryName = "Test",
                    Name = "Test",
                    DayLeft = 1,
                    Offer=1,
                    From=DateTime.Now,
                    End=DateTime.Now.AddDays(20),
                },
                new DealsModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    CategoryName = "Test",
                    Name = "Test",
                    DayLeft = 1,
                    Offer=1,
                    From=DateTime.Now,
                    End=DateTime.Now.AddDays(20),
                },
                new DealsModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    CategoryName = "Test",
                    Name = "Test",
                    DayLeft = 1,
                    Offer=1,
                    From=DateTime.Now,
                    End=DateTime.Now.AddDays(20),
                },
                new DealsModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    CategoryName = "Test",
                    Name = "Test",
                    DayLeft = 1,
                    Offer=1,
                    From=DateTime.Now,
                    End=DateTime.Now.AddDays(20),
                },
                new DealsModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    CategoryName = "Test",
                    Name = "Test",
                    DayLeft = 1,
                    Offer=1,
                    From=DateTime.Now,
                    End=DateTime.Now.AddDays(20),
                },
            };
            SavedDeals = new List<DealsModel>()
            {
                
                new DealsModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    CategoryName = "Test",
                    Name = "Test",
                    DayLeft = 1,
                    Offer=1,
                    From=DateTime.Now,
                    End=DateTime.Now.AddDays(20),
                },
                new DealsModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    CategoryName = "Test",
                    Name = "Test",
                    DayLeft = 1,
                    Offer=1,
                    From=DateTime.Now,
                    End=DateTime.Now.AddDays(20),
                },
              
            };

        }
    }
}
