using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSFlyWebAPI.extensions
{
    public static class ConverterExtensions
    {
        public static Models.FlightM ConvertToFlightM (this EFCoreApp2021.Flight f)
        {
            Models.FlightM fM = new Models.FlightM();
            fM.Date = f.Date;
            fM.Departure = f.Departure;
            fM.Destination = f.Destination;
            fM.FlightNo = f.FlightNo;
            return fM;

        }

        public static EFCoreApp2021.Flight ConvertToFlightEF (this Models.FlightM f)
        {
            EFCoreApp2021.Flight fM = new EFCoreApp2021.Flight();
            fM.Date = f.Date;
            fM.Departure = f.Departure;
            fM.Destination = f.Destination;
            fM.FlightNo = f.FlightNo;
            return fM;
        }
    }
}
