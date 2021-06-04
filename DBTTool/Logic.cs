using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBTTool
{
    public class Methoden
    {
        public static double BerechneDownloadZeit(int einheit, double datensize, double internetspeed)
        {
            switch (einheit)
            {
                case 0: // Byte
                    datensize = datensize / 1000000;
                    break;
                case 1: // KB
                    datensize = datensize / 1000;
                    break;
                case 2: // MB
                    break;
                case 3: // GB
                    datensize = datensize * 1000;
                    break;
                case 4: // TB
                    datensize = datensize * 1000000;
                    break;
            }

            return datensize / internetspeed;
        }

        public static string Speedcheck()
        {
            Stopwatch watch = new Stopwatch();

            using (var client = new WebClient())
            {
                watch.Start();
                Uri downloadlink = new Uri("https://firl.online/download25");
                client.DownloadData(downloadlink);
                watch.Stop();
            }

            var speed = Math.Round(25000000 / watch.Elapsed.TotalSeconds / (1000 * 1000), 2);
            return speed.ToString();
        }
    }
}
