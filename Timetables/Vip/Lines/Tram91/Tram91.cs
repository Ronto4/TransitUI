namespace Timetables.Vip.Lines.Tram91;

internal class Tram91 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [new Tram91From20240102()];
}
