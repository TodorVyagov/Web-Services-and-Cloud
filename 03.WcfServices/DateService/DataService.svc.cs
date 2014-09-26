using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDateService
{
    public class DataService : IDataService
    {
        public string GetDayOfWeek(DateTime date, CultureInfo cultureInfo)
        {
            string dayOfWeek = date.ToString("dddd", cultureInfo);
            return dayOfWeek;
        }
    }
}
