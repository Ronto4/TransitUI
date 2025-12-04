namespace VipTimetable.Lines.Tram91;

internal class Tram91 : ICompleteLine
{
    public IEnumerable<ILineInstance> LineInstances { get; } = [
        new Tram91From20240102(),
        new Tram91From20240205(),
        new Tram91From20240211(),
        new Tram91From20240610(),
        new Tram91From20241021Until20241102(),
        new Tram91From20241104(),
        new Tram91From20241215(),
        new Tram91From20250110Until20250112(),
        new Tram91From20250203(),
    ];
}
