using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebServices2
{
    public partial class ConverterClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
             double celcius = Double.Parse(txtCelcius.Text);
            C2F.TemperatureConverterSoapClient client = new C2F.TemperatureConverterSoapClient();
            double farenhite = client.CelsiusToFahrenheit(celcius);
             lbTextFarenhite.Text = "Fahrenheit is " + celcius 
           // Converter.TemperatureConverterSoapClient client = new Converter.TemperatureConverterSoapClient();
           // lbResult.Text = client.CelsiusToFahrenheit(Double.Parse(txtCelcius.Text)).ToString();
        }
    }
}