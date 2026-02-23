using System;
using System.Collections.Generic;
using System.Text;

namespace C_Practice.Delegates
{
    public delegate String DownloadCompletedCallBack();
    internal class DelegatesDemo
    {

        public String DownloadCompleted()
        {
            return "Download Completed";
        }

        public void MainCall()
        {
            DelegatesDemo obj = new DelegatesDemo();
            DownloadCompletedCallBack callBack = DownloadCompleted;
            obj.DownloadStarted(callBack);
        }
        public void DownloadStarted(DownloadCompletedCallBack com)
        {
            Console.WriteLine("Downloading");
            Thread.Sleep(1000);
            string result = com();


        }




     
    }
}
