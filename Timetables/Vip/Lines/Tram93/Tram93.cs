namespace Timetables.Vip.Lines.Tram93;

internal class Tram93 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } =
        [new Tram93From20240102(), new Tram93From20240826Until20240831()];
}
