using System.Diagnostics;
using System.IO;

namespace Animator;

public static class GifCreator
{
    private static Random random = new Random();
    public static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, length)
        .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public static Stream ConvertImageStreamsToGifStream(IEnumerable<Stream> streams)
    {
        string randomPathPart = RandomString(64);
        string rootPath = $"/tmp/pngs/{randomPathPart}";
        Directory.CreateDirectory(rootPath);
        for (int i = 0; i < streams.Count(); i++)
        {
            using FileStream fs = File.Create($"{rootPath}/{i.ToString().PadLeft(8, '0')}.png");
            streams.ElementAt(i).CopyTo(fs);
        }
        ProcessStartInfo psi = new()
        {
            FileName = "convert",
            Arguments = $"-delay 500 -loop 0 {rootPath}/*.png {rootPath}/out.gif"
        };
        Process? process = Process.Start(psi);
        if (process is null)
        {
            throw new Exception($"Process not started");
        }
        process.WaitForExit();
        // return $"{rootPath}/out.gif";
        FileStream gifFS = File.OpenRead($"{rootPath}/out.gif");
        return gifFS;
    }
}
