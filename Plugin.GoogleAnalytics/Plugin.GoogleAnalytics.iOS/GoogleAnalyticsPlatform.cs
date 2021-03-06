using System;
using System.Threading;

namespace Plugin.GoogleAnalytics
{
    public partial class GoogleAnalytics
    {
        static GoogleAnalytics()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Current.Tracker.SendException(e.ExceptionObject as Exception, true);
            Thread.Sleep(1000); //delay
        }
    }
}