using Timetable;

namespace VipTimetable.Lines
{

    internal interface ILineInstance
    {
        public DateOnly ValidFrom { get; }

        public DateOnly? ValidUntilInclusive() =>
            ValidityMode() is Timetable.ValidityMode.OnlyOnThisDay ? ValidFrom : null;

        public ValidityMode ValidityMode() => Timetable.ValidityMode.Regular;
        public Line Line { get; }
    }
    public union Test(int, string);
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
    public sealed class UnionAttribute : Attribute;

    public interface IUnion
    {
        object? Value { get; }
    }
}
