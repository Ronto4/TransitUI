using System.Net;

namespace TransitWeb.Models;

public class ApiErrorViewModel
{
    public HttpStatusCode HttpStatus { get; set; }
    public string ErrorMessage { get; set; }
    public ApiErrorViewModel(WebException ex) {
        ErrorMessage = ex.Message;
        HttpStatus = (ex.Response as HttpWebResponse)?.StatusCode ?? HttpStatusCode.InternalServerError;
    }
}
