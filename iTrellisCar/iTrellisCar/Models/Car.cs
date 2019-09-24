using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTrellisCar.Models
{
    public class Car
    {
        public string _id { get; set; }
        public string make { get; set; }
        public string year { get; set; }
        public string color { get; set; }
        public int? price { get; set; }
        public bool hasSunroof { get; set; }
        public bool isFourWheelDrive { get; set; }
        public bool hasLowMiles { get; set; }
        public bool hasPowerWindows { get; set; }
        public bool hasNavigation { get; set; }
        public bool hasHeatedSeats { get; set; }
        public bool isAutomatic { get; set; }
    }
}
