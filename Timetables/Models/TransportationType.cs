// ReSharper disable InconsistentNaming
namespace Timetables.Models;

// The exact numeric values are used for natural sorting of lines. Change with care!
public enum TransportationType
{
    LongDistanceTrains = 10,
    RegionalTrains = 20,
    SBahn = 30,
    UBahn = 40,
    Tram = 50,
    Bus = 60,
    Ferry = 70,
}
