using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{

    public class Weather_Status
    {
        public string location { get; set; }
        string folder = AppDomain.CurrentDomain.BaseDirectory;
        public void weather_status(string weather)
        {
            switch (weather)
            {
                case "clear sky":
                    location = folder + "clear_sky.png";
                    break;

                case "snow":
                    location = folder + "snow.png";
                    break;

                case "light snow":
                    location = folder + "snow.png";
                    break;

                case "broken clouds":
                    location = folder + "broken_clouds.png";
                    break;

                case "Clouds":
                    location = folder + "broken_clouds.png";
                    break;

                case "scattered clouds":
                    location = folder + "broken_clouds.png";
                    break;

                case "rain":
                    location = folder + "rain";
                    break;

            }
        }
    }
}
