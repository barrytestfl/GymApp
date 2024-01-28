using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Models.Deals
{
    public class DealsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int DayLeft { get; set; }
        public int Offer { get; set; }
        public DateTime From { get; set; }
        public DateTime End { get; set; }
    }
}
