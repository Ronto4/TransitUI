using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace TransitWeb.Models;

public class TransitStopIdFormModel
{
    // Const
    // private const string UrlMainPart = @"https://transit.ronto4.dynv6.net";
    private const string UrlMainPart = @"http://localhost";//:3654";

    private const string Port = "3654";
    // Attributes
    [DisplayName("ID der Haltestelle")]
    public int StopId { get; set; }

    private string BaseStationUri => $@"{UrlMainPart}:{Port}/api/Transit/vip/{StopId}/";
    public string? RequestUri => StatusCode == HttpStatusCode.OK ? $@"{BaseStationUri}dotmatrix" : null;
    public string? InfoUri =>StatusCode == HttpStatusCode.OK ? $@"{BaseStationUri}info" : null;
    public string? JsonUri =>StatusCode == HttpStatusCode.OK ? $@"{BaseStationUri}json" : null;
    public string CheckUri => $@"{UrlMainPart}/api/Transit/vip/{StopId}";
    public HttpStatusCode StatusCode { get; set; }

    // Methods
    public async Task<HttpStatusCode> CheckIfStopExists()
    {
        StatusCode = await GetStatusCode(CheckUri);
        return StatusCode;
    }
    
    private static async Task<HttpStatusCode> GetStatusCode(string url)
    {
        try
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            return response.StatusCode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"URL: `{url}`");
            Console.WriteLine(ex);
            throw;
        }
    }
}
