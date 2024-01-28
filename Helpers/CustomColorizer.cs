using DevExpress.Maui.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    public class CustomColorizer : ICustomPointColorizer
    {
        Color ICustomPointColorizer.GetColor(ColoredPointInfo info)
        {
            switch (info.DateTimeArgument.Month)
            {
                case 12:
                case 1:
                case 2:
                default:
                    return Color.FromHex("#5982db");
                case 3:
                case 4:
                case 5:
                    return Color.FromHex("#755dd9");
                case 6:
                case 7:
                case 8:
                    return Color.FromHex("#9b57d3");
                case 9:
                case 10:
                case 11:
                    return Color.FromHex("#92278f");
            }
        }
        public ILegendItemProvider GetLegendItemProvider()
        {
            return null;
        }
    }
}
