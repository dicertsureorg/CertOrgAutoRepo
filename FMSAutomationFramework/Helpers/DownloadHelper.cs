using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace CertsureAutomationFramework.Helpers
{
    public static class DownloadHelper
    {
        public static bool CheckDownLoadComplete(TestContext context)
        {
            bool isDownloaded = false;
            int count = 0;
            while (count < 15)
            {
                System.Threading.Thread.Sleep(1000);
                if ((Directory.GetFiles(context.Properties["DownloadPath"].ToString()).Length == 1) 
                    && 
                    (!Directory.GetFiles(context.Properties["DownloadPath"].ToString())[0].Contains(".crdownload")))
                {
                    isDownloaded = true;
                    break;
                }
                   
                count++;
            }

            return isDownloaded;
        }
    }
}
