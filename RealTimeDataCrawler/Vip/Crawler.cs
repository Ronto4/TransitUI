using RealTimeModels.Vip;
using System.Net;

namespace RealTimeDataCrawler.Vip;

public static class Crawler
{
    private static string RequestUri { get; } = @"https://www.swp-potsdam.de/internetservice/services/passageInfo/stopPassages/stop?stop=%STOP_ID%&mode=departure&language=de";

    public static async Task<Station> GetFromWeb(int stopId = 61)
    {
        var jsonString = await GetJsonSource(stopId);
        return Station.GetFromJsonString(jsonString);
    }

    public static async Task<string> GetJsonSource(int stopId = 61)
    {
        using HttpClient httpClient = new();
        return await httpClient.GetStringAsync(RequestUri.Replace("%STOP_ID%", stopId.ToString()));
    }
}
