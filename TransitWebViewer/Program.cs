using System.Diagnostics;
using DotMatrixDisplay;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RealTimeDataCrawler.Vip;
using SixLabors.ImageSharp.PixelFormats;
using TransitWebViewer;
using RealTimeToDotMatrix.Vip;

// Rgb24 BackgroundColor  = new(0x23, 0x29, 0x23); 
// Rgb24 InactivePixelColor  = new(0x23, 0x2d, 0x23);
// Rgb24 ActivePixelColor  = new(0xd1, 0x5a, 0x1a);
//
// Stopwatch sw = new();
// var StopId = 1;
// const string ApiUrl = "https://localhost:7020/api/vip/%STOP_ID%/json";
// var cancellationToken = new CancellationToken();
// sw.Start();
// var station = await Crawler.GetFromWeb(StopId, ApiUrl, cancellationToken);
// Console.WriteLine($"Time for download: {sw.ElapsedMilliseconds} ms");
// sw.Restart();
// var (pages, dimensions) = await RealTimeToDotMatrix.Vip.RealTimeToDotMatrix.GetPages(station, cancellationToken);
// Console.WriteLine($"Time for page generation: {sw.ElapsedMilliseconds} ms");
// sw.Restart();
// var DotMatrixCanvas = new DotMatrixCanvas<Rgb24>(dimensions, BackgroundColor, InactivePixelColor, ActivePixelColor);
// Console.WriteLine($"Time for matrix generation: {sw.ElapsedMilliseconds} ms");
// sw.Restart();
// var firstPage = pages[0];
// Console.WriteLine(firstPage);
// DotMatrixCanvas.WriteText(firstPage, null, sw);
// Console.WriteLine($"Time for writing: {sw.ElapsedMilliseconds} ms");
// sw.Restart();
// // RefreshDotMatrix();
// Console.WriteLine(DotMatrixCanvas.ToBase64());
// Console.WriteLine($"Time for refreshing: {sw.ElapsedMilliseconds} ms");
// sw.Restart();

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)});

await builder.Build().RunAsync();
