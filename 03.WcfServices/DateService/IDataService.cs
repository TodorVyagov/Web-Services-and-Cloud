namespace WcfDateService
{
    using System;
    using System.Globalization;
    using System.ServiceModel;

    [ServiceContract]
    public interface IDataService
    {

        [OperationContract]
        string GetDayOfWeek(DateTime date, CultureInfo cultureInfo);
    }
}
