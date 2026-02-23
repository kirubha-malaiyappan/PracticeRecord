using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace C_Practice.Delegates
{
    
    internal class DelegatesDemo
    {

        public String DownloadCompleted()
        {
            return "Download Completed";
        }

        public void MainCall()
        {
            DelegatesDemo obj = new DelegatesDemo();
            obj.DownloadStarted(DownloadCompleted);
        }
        public void DownloadStarted(Func<string> com)
        {
            Console.WriteLine("Downloading");
            Thread.Sleep(1000);
            string result = com();
            Console.WriteLine(result);

        }


     
    }
}
