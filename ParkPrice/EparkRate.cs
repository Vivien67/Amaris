using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPrice
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum EparkRate
    {
        [Description(" ")]
        ParkRate0 = 0,
        [Description("Courte durée")]
        ParkRate1 = 1,
        [Description("Etagé")]
        ParkRate2 = 2,
        [Description("Valet Parc")]
        ParkRate3 = 3,
    }
}
