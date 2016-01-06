using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteScraper
{
    class WebRequestResponse
    {
        public static void sendWebRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.airservicesaustralia.com/careers/air-traffic-controller/");
            Console.WriteLine(DateTime.Now.ToString() + " - Webrequest triggered");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response == null || response.StatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine("Website had a problem - nothing was returned in the response OR response was not 200 OK :(");
            }
            else
            {
                Console.WriteLine("Website returned a 200 OK");
            }

            response.Close();
        }
    }
}