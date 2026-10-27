namespace DotMatrixDisplay;

public readonly record struct DotMatrixDimensions
{
    public required uint Width { get; init; }
    public required uint Height { get; init; }
}
