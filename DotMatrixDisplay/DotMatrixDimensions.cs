namespace DotMatrixDisplay;

public readonly record struct DotMatrixDimensions
{
    public required int Width { get; init; }
    public required int Height { get; init; }
}
