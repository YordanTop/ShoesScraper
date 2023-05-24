using System.Diagnostics;


namespace ShoesScraper
{
    internal static class MakeThread
    {
        public static void WebStart(string url)
        {
            Process.Start(new ProcessStartInfo()
            {
                FileName = "chrome.exe",
                UseShellExecute = true,
                Arguments = url
            });
        }
    }
}
