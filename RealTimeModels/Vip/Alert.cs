using RealTimeModels.Vip.JsonObjects;

namespace RealTimeModels.Vip;

public record Alert(string Message)
{
    internal Alert(AlertEntry entry) : this(entry.title)
    {
    }
}
