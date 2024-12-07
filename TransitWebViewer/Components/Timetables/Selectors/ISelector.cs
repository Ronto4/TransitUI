namespace TransitWebViewer.Components.Timetables.Selectors;

public interface ISelector<out TResult>
{
    public Action<TResult> OnUpdate { init; }
}
