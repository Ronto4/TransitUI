using System.Diagnostics;
using System.IO;

namespace Animator;

public static class GifCreator
{
    private static readonly Random Random = new();

    private static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[Random.Next(s.Length)]).ToArray());
    }

    public static async Task<Stream> ConvertImageStreamsToGifStream(IEnumerable<Stream> streams,
        CancellationToken cancellationToken)
    {
        var randomPathPart = RandomString(64);
        var rootPath = $"/tmp/pngs/{randomPathPart}";
        Directory.CreateDirectory(rootPath);
        await Task.WhenAll(streams.Select(async (stream, index) =>
        {
            await using var fs = File.Create($"{rootPath}/{index.ToString().PadLeft(8, '0')}.png");
            await stream.CopyToAsync(fs, cancellationToken);
        }));
        ProcessStartInfo psi = new()
        {
            FileName = "convert",
            Arguments = $"-delay 500 -loop 0 {rootPath}/*.png {rootPath}/out.gif"
        };
        var process = Process.Start(psi);
        if (process is null)
        {
            throw new Exception($"Process not started");
        }

        await process.WaitForExitAsync(cancellationToken);
        var gifFs = File.OpenRead($"{rootPath}/out.gif");
        return gifFs;
    }
}
