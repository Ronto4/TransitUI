namespace Timetables.Vip.Lines;

internal static class Lines
{
    public static Dictionary<string, ICompleteLine> LinesById { get; } = new()
    {
        ["tram91"] = new Tram91.Tram91(),
        ["tram92"] = new Tram92.Tram92(),
        ["tram93"] = new Tram93.Tram93(),
        ["tram94"] = new Tram94.Tram94(),
    };
}
