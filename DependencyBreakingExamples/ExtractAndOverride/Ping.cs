using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DependencyBreakingExamples.ExtractAndOverride
{
    public class Pinger
    {
        public bool Ping(string url)
        {
            var webClient = new WebClient();
            try
            {
                webClient.DownloadString(url);
            }
            catch (WebException)
            {
                return false;
            }
            return true;
        }
    }
}
