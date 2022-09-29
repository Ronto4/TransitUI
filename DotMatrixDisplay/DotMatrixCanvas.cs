using System.Diagnostics;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Bmp;
// Does not work in the browser
// using SixLabors.ImageSharp.Formats.Tiff;
using SixLabors.ImageSharp.PixelFormats;

namespace DotMatrixDisplay;

public class DotMatrixCanvas<TColor> where TColor : unmanaged, IPixel<TColor>
{
    private const int PixelPerDotMatrixPixel = 12;
    private const int GapBetweenDotMatrixPixels = 2;
    private const int DotMatrixPixelsPerCharacterHorizontal = 5;
    private const int DotMatrixPixelsPerCharacterVertical = 8;
    private const int GapPixelsHorizontal = 12;
    private const int GapPixelsVertical = 10;

    private const int CharacterWidth = PixelPerDotMatrixPixel * DotMatrixPixelsPerCharacterHorizontal +
                                       (DotMatrixPixelsPerCharacterHorizontal - 1) * GapBetweenDotMatrixPixels;

    private const int CharacterHeight = PixelPerDotMatrixPixel * DotMatrixPixelsPerCharacterVertical +
                                        (DotMatrixPixelsPerCharacterVertical - 1) * GapBetweenDotMatrixPixels;
    private Image<TColor> Canvas { get; }
    private int Width { get; }
    private int Height { get; }
    private TColor InactivePixelColor { get; }
    private TColor ActivePixelColor { get; }
    private DotMatrixCharacter?[,] Characters { get; set; }

    /// <summary>
    /// Initialize a new canvas for a dot-matrix-display
    /// </summary>
    /// <param name="width">The number of characters horizontally</param>
    /// <param name="height">The number of characters vertically</param>
    /// <param name="backgroundColor">The color between the characters</param>
    /// <param name="inactivePixelColor">The color used for pixels that are not illuminated</param>
    /// <param name="activePixelColor">The color used for pixels that are illuminated</param>
    public DotMatrixCanvas(int width, int height, TColor backgroundColor, TColor inactivePixelColor,
        TColor activePixelColor)
    {
        if (width < 1 || height < 1)
            throw new ArgumentOutOfRangeException(nameof(width), "At least on row and column is required.");
        var (pixelWidth, pixelHeight) = PixelsForCharacterDimensions(width, height);
        Canvas = new Image<TColor>(pixelWidth, pixelHeight, backgroundColor);
        Width = width;
        Height = height;
        InactivePixelColor = inactivePixelColor;
        ActivePixelColor = activePixelColor;
        Characters = new DotMatrixCharacter?[height, width];
        WriteCharacters();
    }

    private static (int pixelWidth, int pixelHeight) PixelsForCharacterPosition(int width, int height)
    {
        static int PixelForCharacters(int characters, int dotMatrixPixel, int gapPixel) =>
            (dotMatrixPixel /* dotMatrixPixel dot matrix pixels per character */ *
             PixelPerDotMatrixPixel +
             (dotMatrixPixel - 1) * GapBetweenDotMatrixPixels +
             gapPixel /* gapPixel pixels space between characters */) * characters;

        var pixelWidth = PixelForCharacters(width, DotMatrixPixelsPerCharacterHorizontal, GapPixelsHorizontal);
        var pixelHeight = PixelForCharacters(height, DotMatrixPixelsPerCharacterVertical, GapPixelsVertical);
        return (pixelWidth, pixelHeight);
    }

    private static (int pixelWidth, int pixelHeight) PixelsForCharacterDimensions(int width, int height)
    {
        static int PixelForCharacters(int characters, int dotMatrixPixel, int gapPixel) =>
            (dotMatrixPixel /* dotMatrixPixel dot matrix pixels per character */ *
             PixelPerDotMatrixPixel +
             (dotMatrixPixel - 1) * GapBetweenDotMatrixPixels +
             gapPixel /* gapPixel pixels space between characters */) * characters - gapPixel /* Ignore last gap */;

        var pixelWidth = PixelForCharacters(width, DotMatrixPixelsPerCharacterHorizontal, GapPixelsHorizontal);
        var pixelHeight = PixelForCharacters(height, DotMatrixPixelsPerCharacterVertical, GapPixelsVertical);
        return (pixelWidth, pixelHeight);
    }

    public void SaveToStream(Stream target)
    {
        Stopwatch sw = new();
        sw.Start();
        Canvas.SaveAsPng(target);
        sw.Stop();
        Console.WriteLine($"Saving took {sw.Elapsed} for {Canvas.Width} * {Canvas.Height}");
    }

    public string ToBase64()
    {
        var sw = new Stopwatch();
        sw.Start();
        var result = Canvas.ToBase64String(BmpFormat.Instance);
        sw.Stop();
        Console.WriteLine($"Simple took {sw.Elapsed}");
        return result;
        // using var stream = new MemoryStream();
        // SaveToStream(stream);
        // return Convert.ToBase64String(stream.ToArray());
    }

    private void WriteCharacters()
    {
        for (var width = 0; width < Width; width++)
        {
            for (var height = 0; height < Height; height++)
            {
                var character = Characters[height, width];
                WriteCharacter(character ?? DotMatrixCharacter.EmptyPixel, width, height);
            }
        }
    }

    private void WriteCharacter(DotMatrixCharacter character, int horizontalPosition, int verticalPosition)
    {
        var (pixelHorizontal, pixelVertical) = PixelsForCharacterPosition(horizontalPosition, verticalPosition);
        ulong bitFieldPosition = 1;
        for (var y = pixelVertical;
             y < pixelVertical + CharacterHeight;
             y += PixelPerDotMatrixPixel + GapBetweenDotMatrixPixels)
        {
            for (var x = pixelHorizontal;
                 x < pixelHorizontal + CharacterWidth;
                 x += PixelPerDotMatrixPixel + GapBetweenDotMatrixPixels)
            {
                WriteDotMatrixPixel(
                    character.ActivePixels.HasFlag((Pixels) bitFieldPosition) ? ActivePixelColor : InactivePixelColor,
                    x, y);
                bitFieldPosition <<= 1;
            }
        }
    }

    private void WriteDotMatrixPixel(TColor color, int horizontalPixel, int verticalPixel)
    {
        for (var x = horizontalPixel; x < horizontalPixel + PixelPerDotMatrixPixel; x++)
        for (var y = verticalPixel; y < verticalPixel + PixelPerDotMatrixPixel; y++)
        {
            Canvas[x, y] = color;
        }
    }

    public void WriteText(List<List<DotMatrixCharacter>> text)
    {
        if (text.Count > Height || !text.TrueForAll(line => line.Count <= Width))
        {
            throw new ArgumentOutOfRangeException(nameof(text));
        }

        Characters = new DotMatrixCharacter?[Height, Width];
        for (var lineIndex = 0; lineIndex < text.Count; lineIndex++)
        {
            for (var columnIndex = 0; columnIndex < text[lineIndex].Count; columnIndex++)
            {
                Characters[lineIndex, columnIndex] = text[lineIndex][columnIndex];
            }
        }
        WriteCharacters();
    }
}
