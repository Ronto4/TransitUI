using Timetable;

namespace VipTimetable;

public static class Cities
{
    public static City Potsdam { get; } = new() { Name = "Potsdam" };
    public static City Berlin { get; } = new() { Name = "Berlin" };
    public static City Leest { get; } = new() { Name = "Leest" };
    public static City Töplitz { get; } = new() { Name = "Töplitz" };
    public static City NeuTöplitz { get; } = new() { Name = "Neu Töplitz" };
    public static City BergholzRehbrücke { get; } = new() { Name = "Bergholz-Rehbrücke" };
}
