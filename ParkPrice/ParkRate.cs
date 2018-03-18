using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrice
{
    /// <summary>
    /// Parking Rate Class
    /// </summary>
    public class ParkRate
    {
        public ParkRate(EparkRate eparkRate)
        {
            Name = eparkRate.ToDescriptionString();

            switch (eparkRate)
            {
                case EparkRate.ParkRate0:
                    throw new Exception("Le Forfait n'est pas défini");
                case EparkRate.ParkRate1:
                    PriceFor20Minutes = 6;
                    MaxPricePerDay = 37;
                    break;
                case EparkRate.ParkRate2:
                    PriceFor20Minutes = 6;
                    MaxPricePerDay = 30;
                    break;
                case EparkRate.ParkRate3:
                    PriceFor20Minutes = 12;
                    MaxPricePerDay = 42;
                    break;
                default:
                    throw new Exception("Le Forfait n'est pas défini");
            }
        }

        /// <summary>
        /// Price Rate Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price for a period of 20 minutes
        /// </summary>
        public int PriceFor20Minutes { get; set; }

        /// <summary>
        /// Maximum price per day
        /// </summary>
        public int MaxPricePerDay { get; set; }

        /// <summary>
        /// Calculate price of parking for a given park rate
        /// </summary>
        /// <param name="parkDuration">Park Duration</param>
        /// <returns>Price of park</returns>
        public int CalculatePrice(TimeSpan parkDuration)
        {
            int price = 0;

            price = parkDuration.Days * MaxPricePerDay;

            double periode20MinutesDble = (double)(parkDuration.Hours*60+parkDuration.Minutes) / 20;

            int periode20MinutesInt = (int)periode20MinutesDble;

            if (periode20MinutesDble > periode20MinutesInt)
                periode20MinutesInt++;

            price += Math.Min(periode20MinutesInt * PriceFor20Minutes, MaxPricePerDay);

            return price;
        }
    }
}
