using RealTimeModels.Vip.JsonObjects;

namespace RealTimeModels.Vip;

public class Alert
{
    // Attributes
    public string Message { get; }
    // Constructors
    public Alert(string message)
    {
        Message = message;
    }
    internal Alert(AlertEntry entry)
    {
        Message = entry.title;
    }
}
