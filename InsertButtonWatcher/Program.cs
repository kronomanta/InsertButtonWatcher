using InsertButtonWatcher.Logging;
using System;
namespace InsertButtonWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (SystrayManager systrayManager = new SystrayManager())
                {
                    systrayManager.CloseClicked += System.Windows.Forms.Application.Exit;
                    systrayManager.Display();

                    InsertWatcher watcher = new InsertWatcher();

                    watcher.Start();

                    System.Windows.Forms.Application.Run();

                    watcher.Stop();
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogException(ex);
            }
        }
    }
}
