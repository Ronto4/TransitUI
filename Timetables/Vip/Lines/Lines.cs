namespace Timetables.Vip.Lines;

internal static class Lines
{
    public static Dictionary<string, ICompleteLine> LinesById { get; } = new()
    {
        ["bus603"] = new Bus603.Bus603(),
        ["bus605"] = new Bus605.Bus605(),
        ["bus609"] = new Bus609.Bus609(),
        ["bus612"] = new Bus612.Bus612(),
        ["bus616"] = new Bus616.Bus616(),
        ["bus638"] = new Bus638.Bus638(),
        ["tram91"] = new Tram91.Tram91(),
        ["tram92"] = new Tram92.Tram92(),
        ["tram93"] = new Tram93.Tram93(),
        ["tram94"] = new Tram94.Tram94(),
        ["tram96"] = new Tram96.Tram96(),
        ["tram98"] = new Tram98.Tram98(),
        ["tram99"] = new Tram99.Tram99(),
    };
}
