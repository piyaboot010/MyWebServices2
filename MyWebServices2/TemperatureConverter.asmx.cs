using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyWebServices2
{
    /// <summary>
    /// Summary description for TemperatureConverter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TemperatureConverter : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string FirstName, string LastName)
        {
            return "Hello World !" +FirstName +LastName;
        }

        [WebMethod]
        public double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = 0; fahrenheit = ((((celsius) * 9) / 5) + 32);
            return fahrenheit;
        }
        [WebMethod]
        public double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = 0; celsius = ((((fahrenheit) - 32) / 9) * 5);
            return celsius;
        }
    }
}
