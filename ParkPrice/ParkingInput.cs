using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrice
{
    /// <summary>
    /// User input Class
    /// </summary>
    public class ParkingInput
    {
        public ParkingInput()
        {
        }

        public ParkingInput(int days, int hours, int minutes,EparkRate eParkRate)
        {
            Days = days;
            Hours = hours;
            Minutes = minutes;
            ParkRate = eParkRate;
        }

        /// <summary>
        /// Days duration of parking
        /// </summary>
        public int Days { get; set; }
        
        /// <summary>
        /// Hours duration of parking
        /// </summary>
        public int Hours { get; set; }
       
        /// <summary>
        /// Minutes duration of parking
        /// </summary>
        public int Minutes { get; set; }

        /// <summary>
        /// Park rate
        /// </summary>
        public EparkRate ParkRate { get; set; }

        /// <summary>
        /// Park Duration
        /// </summary>
        public TimeSpan ParkDuration { get { return new TimeSpan(Days,Hours, Minutes, 0); } }
    }
}

