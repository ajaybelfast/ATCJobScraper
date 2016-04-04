using System;
using System.Net;
using System.Timers;

namespace WebsiteScraper
{
    class getPage
    {
        public static void SaveAndSearchPageContents(string search, Timer timer)
        {
            string result;
            WebClient client = new WebClient();

            result = client.DownloadString("http://www.airservicesaustralia.com/careers/air-traffic-controller/");
            if (!result.Contains(search))
            {
                Console.WriteLine("Could not find your searchstring - looks like it is now open :)");
                Email.sendEmail("JOB is now open", "Your search string was not found - this indicates that the JOB is now open");
                timer.Stop();
            }
            else
            {
                Console.WriteLine("Looks like it is still not open :( keep looking");
                Email.sendEmail("JOB is still closed", "Your search string was found - this indicates that the JOB is still closed");
            }
            Console.WriteLine("You should have received an email \n");
        }
    }
}