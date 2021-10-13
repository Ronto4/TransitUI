namespace RealTimeToDotMatrix;

public struct RgbColor
{
    // Attributes
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }
    // Defaults
    public static RgbColor Black => new RgbColor { R = 0x00, G = 0x00, B = 0x00 };
    public static RgbColor White => new RgbColor { R = 0xff, G = 0xff, B = 0xff };
    public static RgbColor Red => new RgbColor { R = 0xff, G = 0x00, B = 0x00 };
    public static RgbColor Green => new RgbColor { R = 0x00, G = 0xff, B = 0x00 };
    public static RgbColor Blue => new RgbColor { R = 0x00, G = 0x00, B = 0xff };
    // Transit defaults
    public static RgbColor Border => Black;
    public static RgbColor Background => new RgbColor { R = 0x23, G = 0x29, B = 0x23 };
    public static RgbColor InactivePixels => new RgbColor { R = 0x23, G = 0x2d, B = 0x23 };
    public static RgbColor ActivePixels => new RgbColor { R = 0xd1, G = 0x5a, B = 0x1a };
    // Methods
    public override string ToString() => $"{R:x2}{G:x2}{B:x2}";
    // Conversions
    public static implicit operator (byte R, byte G, byte B)(RgbColor color) => (color.R, color.G, color.B);
    public static implicit operator RgbColor((byte R, byte G, byte B) color) => new RgbColor { R = color.R, G = color.G, B = color.B };
    public static implicit operator uint(RgbColor color) => (((uint)color.R) << 16) | (((uint)color.G) << 8) | color.B;
    public static implicit operator RgbColor(uint color) => new RgbColor { R = (byte)(color >> 16), G = (byte)((color >> 8) & 0xff), B = (byte)(color & 0xff) }; 
}
