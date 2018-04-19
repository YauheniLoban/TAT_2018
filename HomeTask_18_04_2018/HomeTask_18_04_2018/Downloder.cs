using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HomeTask_18_04_2018
{
    class Downloder
    {
        List<FileInformation> downloadList;

       public Downloder (List<FileInformation> DownloadList)
        {
            downloadList = DownloadList;
        }

        public void DownloadAllFile()
        {
            List<TaskAwaiter> awaiterList = new List<TaskAwaiter>();

            Console.WriteLine("downloading files started");
            foreach(FileInformation next in downloadList)
            {
                awaiterList.Add(StartDownloading(next).GetAwaiter());
            }

            foreach(TaskAwaiter awaiter in awaiterList)
            {
                awaiter.GetResult();
            }
        }

        static async Task StartDownloading(FileInformation file)
        {
            Console.WriteLine("Starting download: " + file.fileName);
            string time = await Task.Run(() => Downloding(file));
            Console.WriteLine("Download file :" + file.fileName + " completed in time: " + time);
        }

        static string Downloding(FileInformation file)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            WebClient myWebClient = new WebClient();
            myWebClient.DownloadFile(file.url,file.fileName);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string timeInFormat= String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds);
            return timeInFormat;
        }
   }
}
