using System;
using System.Timers;

namespace WebsiteScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchText = "are now closed";

            Timer timer = new Timer();
            timer.Interval = 36000000;
            timer.Enabled = true;

            //Initial call to do the check before entering Timer loop
            WebRequestResponse.sendWebRequest();
            getPage.SaveAndSearchPageContents(searchText, timer);

            //Timer loop to check every 10 hours
            timer.Elapsed +=  (object sender, ElapsedEventArgs e) => 
            {
                WebRequestResponse.sendWebRequest();
                getPage.SaveAndSearchPageContents(searchText, timer);
            };
            
            //Readline to keep the console application alive
            Console.ReadLine();
        }
    }
}