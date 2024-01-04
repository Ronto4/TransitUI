using RealTimeModels.Vip;

namespace RealTimeDataCrawler.Vip;

public static class Crawler
{
    private static string RequestUri =>
        @"https://www.swp-potsdam.de/internetservice/services/passageInfo/stopPassages/stop?stop=%STOP_ID%&mode=departure&language=de";

    public static async Task<Station> GetFromWeb(int stopId, CancellationToken cancellationToken) =>
        await GetFromWeb(stopId, RequestUri, cancellationToken);

    public static async Task<Station> GetFromWeb(int stopId, string requestUri, CancellationToken cancellationToken)
    {
        var jsonString = await GetJsonSource(stopId, requestUri, cancellationToken);
        return Station.GetFromJsonString(jsonString);
    }

    public static async Task<string> GetJsonSource(int stopId, CancellationToken cancellationToken) =>
        await GetJsonSource(stopId, RequestUri, cancellationToken);

    public static async Task<string> GetJsonSource(int stopId, string requestUri, CancellationToken cancellationToken)
    {
        var url = requestUri.Replace("%STOP_ID%", stopId.ToString());
        return await DownloadString(url, cancellationToken);
        // using HttpClient httpClient = new();
        // var response = await httpClient.GetAsync(RequestUri.Replace("%STOP_ID%", stopId.ToString()), cancellationToken);
        // response.EnsureSuccessStatusCode();
        // return await response.Content.ReadAsStringAsync(cancellationToken);
    }

    // Source: https://stackoverflow.com/a/76582825
    private static async Task<string> DownloadString(string url, CancellationToken cancellationToken)
    {
        HttpClient httpClient = new();
        var content = await httpClient.GetStringAsync(url, cancellationToken);
        return content;
    }
}
