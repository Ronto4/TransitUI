using System.Net;
using System.Web;

namespace RealTimeToDotMatrix;

public class DotMatrixPicture
{
    // Attributes
        public RgbColor BorderColor { get; set; }
        public RgbColor BackgroundColor { get; set; }
        public RgbColor InactivePixelColor { get; set; }
        public RgbColor ActivePixelColor { get; set; }
        public (uint cols, uint rows) Dimensions { get; set; }
        public string Message { get; set; }
        // Constructors
        public DotMatrixPicture(string? message = null, RgbColor? borderColor = null, RgbColor? backgroundColor = null, RgbColor? inactivePixelColor = null, RgbColor? activePixelColor = null, (uint c, uint r)? dimesions = null)
        {
            BorderColor = borderColor ?? RgbColor.Black;
            BackgroundColor = backgroundColor ?? RgbColor.Black;
            InactivePixelColor = inactivePixelColor ?? RgbColor.Black;
            ActivePixelColor = activePixelColor ?? RgbColor.White;
            Message = message ?? string.Empty;
            Dimensions = dimesions ?? (0, 0);
        }
        // Methods
        public string BuildUri()
        {
            string requestUri = string.Empty;
            requestUri += $@"http://avtanski.net/projects/lcd/cgi-bin/screenshot.cgi?";
            requestUri += $@"cs=custom_colors&";
            string bdcolor = $"#{BorderColor}";
            requestUri += $@"cbr={HttpUtility.UrlEncode(bdcolor)}&";
            string bgcolor = $"#{BackgroundColor}";
            requestUri += $@"cbg={HttpUtility.UrlEncode(bgcolor)}&";
            string apcolor = $"#{ActivePixelColor}";
            requestUri += $@"cap={HttpUtility.UrlEncode(apcolor)}&";
            //requestUri += $@"cip={HttpUtility.UrlEncode($"#{InactivePixelColor}"}&";
            string iacolor = $"#{InactivePixelColor}";
            requestUri += $@"cip={HttpUtility.UrlEncode(iacolor)}&";
            requestUri += $@"cols={Dimensions.cols}&";
            requestUri += $@"rows={Dimensions.rows}&";
            requestUri += $@"s=large&c=none&crow=1&ccol=1&dt=char_matrix&";
            requestUri += $@"msg={MessageBuilder.Build(Message)}";
            //requestUri = HttpUtility.UrlEncode(requestUri);
            return requestUri;
        }
        public async Task<Stream> GetPicture(string? requestUri = null)
        {
            requestUri ??= BuildUri();
            string referer = @"http://avtanski.net/projects/lcd/";
            // HttpWebRequest request = WebRequest.CreateHttp(requestUri);
            using HttpClient httpClient = new();
            httpClient.DefaultRequestHeaders.Referrer = new Uri(referer);
            return await httpClient.GetStreamAsync(requestUri);
            // request.Referer = referer;
            // HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // return response.GetResponseStream();
        }
}
