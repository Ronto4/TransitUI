using RealTimeModels.Vip;
using System.Net;

namespace RealTimeDataCrawler.Vip;

public static class Crawler
{
    private static string RequestUri { get; } = @"https://www.swp-potsdam.de/internetservice/services/passageInfo/stopPassages/stop?stop=%STOP_ID%&mode=departure&language=de";
    
    public static Station GetFromWeb(int stopId = 61)
    {
        string jsonString = GetJsonSource(stopId);
        return Station.GetFromJsonString(jsonString);
    }

    public static string GetJsonSource(int stopId = 61)
    {
        using WebClient wc = new WebClient();
        return wc.DownloadString(RequestUri.Replace("%STOP_ID%", stopId.ToString()));
    }
}
