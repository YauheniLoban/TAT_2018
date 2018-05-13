using System;
using System.Web.Services;

namespace HomeTask11
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class DateConverterWebService : System.Web.Services.WebService
    {
        /// <summary>
        /// Counts the number of days from the beginning of our era to the current date
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        [WebMethod()]
        public int CountThePastNumberOfDays(int day, int month, int year)
        {
            DateTime dateValue;
            string dateString = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            if (DateTime.TryParse(dateString, out dateValue))
            {
                DateTime currentDate = new DateTime(year, month, day);
                return Convert.ToInt32((currentDate - DateTime.MinValue).TotalDays);              
            }
            else
            {
                throw new ArgumentException("Invalid parameters for date");
            }
        }
    }
}
