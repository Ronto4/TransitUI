using RealTimeModels.Vip;

namespace RealTimeDataCrawler.Vip;

public static class Crawler
{
    private static string RequestUri =>
        @"https://www.swp-potsdam.de/internetservice/services/passageInfo/stopPassages/stop?stop=%STOP_ID%&mode=departure&language=de";

    public static async Task<Station> GetFromWeb(int stopId, CancellationToken cancellationToken)
    {
        var jsonString = await GetJsonSource(stopId, cancellationToken);
        return Station.GetFromJsonString(jsonString);
    }

    public static async Task<string> GetJsonSource(int stopId, CancellationToken cancellationToken)
    {
        using HttpClient httpClient = new();
        var response = await httpClient.GetAsync(RequestUri.Replace("%STOP_ID%", stopId.ToString()), cancellationToken);
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadAsStringAsync(cancellationToken);
    }
}
