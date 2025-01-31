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
        ["bus639"] = new Bus639.Bus639(),
        ["bus690"] = new Bus690.Bus690(),
        ["bus691"] = new Bus691.Bus691(),
        ["bus692"] = new Bus692.Bus692(),
        ["bus693"] = new Bus693.Bus693(),
        ["bus694"] = new Bus694.Bus694(),
        ["bus695"] = new Bus695.Bus695(),
        ["bus696"] = new Bus696.Bus696(),
        ["bus697"] = new Bus697.Bus697(),
        ["bus698"] = new Bus698.Bus698(),
        ["bus699"] = new Bus699.Bus699(),
        ["busX5"] = new BusX5.BusX5(),
        ["busN14"] = new BusN14.BusN14(),
        ["busN15"] = new BusN15.BusN15(),
        ["tram91"] = new Tram91.Tram91(),
        ["tram92"] = new Tram92.Tram92(),
        ["tram93"] = new Tram93.Tram93(),
        ["tram94"] = new Tram94.Tram94(),
        ["tram96"] = new Tram96.Tram96(),
        ["tram98"] = new Tram98.Tram98(),
        ["tram99"] = new Tram99.Tram99(),
    };
}
