using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Rach
{
    public class RachDate
    {

        public String addHoursToUTCDate(int offset)
        {
            return DateTimeOffset.UtcNow.AddHours(10).ToString("dd/MM/yyyy");
        }
        public String addHoursToUTCTime(int offset)
        {
            return DateTimeOffset.UtcNow.AddHours(10).ToString("h:mm tt");
        }

    }




}
