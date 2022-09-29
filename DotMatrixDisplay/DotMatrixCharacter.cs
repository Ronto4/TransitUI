namespace DotMatrixDisplay;

public class DotMatrixCharacter
{
    public Pixels ActivePixels { get; private init; }

    public static DotMatrixCharacter EmptyPixel { get; } = new() {ActivePixels = Pixels.None};

    public static Dictionary<char, DotMatrixCharacter> DotMatrixCharacters = new()
    {
        {
            'a',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row2Col3 | Pixels.Row3Col4 | Pixels.Row4Col1 |
                               Pixels.Row4Col2 | Pixels.Row4Col3 | Pixels.Row4Col4 | Pixels.Row5Col0 | Pixels.Row5Col4 |
                               Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3 | Pixels.Row6Col4
            }
        },
        {
            'b',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col0 | Pixels.Row1Col0 | Pixels.Row2Col0 | Pixels.Row2Col2 | Pixels.Row2Col3 |
                               Pixels.Row3Col0 | Pixels.Row3Col1 | Pixels.Row3Col4 | Pixels.Row4Col0 | Pixels.Row4Col4 |
                               Pixels.Row5Col0 | Pixels.Row5Col4 | Pixels.Row6Col0 | Pixels.Row6Col1 | Pixels.Row6Col2 |
                               Pixels.Row6Col3
            }
        },
        {
            'c',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row2Col3 | Pixels.Row3Col0 | Pixels.Row4Col0 |
                               Pixels.Row5Col0 | Pixels.Row5Col4 | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            'd',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col4 | Pixels.Row1Col4 | Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row2Col4 |
                               Pixels.Row3Col0 | Pixels.Row3Col3 | Pixels.Row3Col4 | Pixels.Row4Col0 | Pixels.Row4Col4 |
                               Pixels.Row5Col0 | Pixels.Row5Col4 | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3 |
                               Pixels.Row6Col4
            }
        },
        {
            'e',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row2Col3 | Pixels.Row3Col0 | Pixels.Row3Col4 |
                               Pixels.Row4Col0 | Pixels.Row4Col1 | Pixels.Row4Col2 | Pixels.Row4Col3 | Pixels.Row4Col4 |
                               Pixels.Row5Col0 | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            'f',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Col1 | Pixels.Row1Col4 | Pixels.Row2Col1 |
                               Pixels.Row3Col0 | Pixels.Row3Col1 | Pixels.Row3Col2 | Pixels.Row4Col1 | Pixels.Row5Col1 |
                               Pixels.Row6Col1
            }
        },
        {
            'g',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row1Col1 | Pixels.Row1Col2 | Pixels.Row1Col3 | Pixels.Row1Col4 | Pixels.Row2Col0 |
                               Pixels.Row2Col4 | Pixels.Row3Col0 | Pixels.Row3Col4 | Pixels.Row4Col1 | Pixels.Row4Col2 |
                               Pixels.Row4Col3 | Pixels.Row4Col4 | Pixels.Row5Col4 | Pixels.Row6Col1 | Pixels.Row6Col2 |
                               Pixels.Row6Col3
            }
        },
        {
            'h',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col0 | Pixels.Row1Col0 | Pixels.Row2Col0 | Pixels.Row2Col2 | Pixels.Row2Col3 |
                               Pixels.Row3Col0 | Pixels.Row3Col1 | Pixels.Row3Col4 | Pixels.Row4Col0 | Pixels.Row4Col4 |
                               Pixels.Row5Col0 | Pixels.Row5Col4 | Pixels.Row6Col0 | Pixels.Row6Col4
            }
        },
        {
            'i',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col2 | Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row3Col2 | Pixels.Row4Col2 |
                               Pixels.Row5Col2 | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            'j',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col3 | Pixels.Row2Col2 | Pixels.Row2Col3 | Pixels.Row3Col3 | Pixels.Row4Col3 |
                               Pixels.Row5Col0 | Pixels.Row5Col3 | Pixels.Row6Col1 | Pixels.Row6Col2
            }
        },
        {
            'k',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col0 | Pixels.Row1Col0 | Pixels.Row2Col0 | Pixels.Row2Col3 | Pixels.Row3Col0 |
                               Pixels.Row3Col2 | Pixels.Row4Col0 | Pixels.Row4Col1 | Pixels.Row5Col0 | Pixels.Row5Col2 |
                               Pixels.Row6Col0 | Pixels.Row6Col3
            }
        },
        {
            'l',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row1Col2 | Pixels.Row2Col2 | Pixels.Row3Col2 |
                               Pixels.Row4Col2 | Pixels.Row5Col2 | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            'm',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col0 | Pixels.Row2Col1 | Pixels.Row2Col3 | Pixels.Row3Col0 | Pixels.Row3Col2 |
                               Pixels.Row3Col4 | Pixels.Row4Col0 | Pixels.Row4Col2 | Pixels.Row4Col4 | Pixels.Row5Col0 |
                               Pixels.Row5Col4 | Pixels.Row6Col0 | Pixels.Row6Col4
            }
        },
        {
            'n',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col0 | Pixels.Row2Col2 | Pixels.Row2Col3 | Pixels.Row3Col0 | Pixels.Row3Col1 |
                               Pixels.Row3Col4 | Pixels.Row4Col0 | Pixels.Row4Col4 | Pixels.Row5Col0 | Pixels.Row5Col4 |
                               Pixels.Row6Col0 | Pixels.Row6Col4
            }
        },
        {
            'o',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row2Col3 | Pixels.Row3Col0 | Pixels.Row3Col4 |
                               Pixels.Row4Col0 | Pixels.Row4Col4 | Pixels.Row5Col0 | Pixels.Row5Col4 | Pixels.Row6Col1 |
                               Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            'p',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col0 | Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row2Col3 | Pixels.Row3Col0 |
                               Pixels.Row3Col4 | Pixels.Row4Col0 | Pixels.Row4Col1 | Pixels.Row4Col2 | Pixels.Row4Col3 |
                               Pixels.Row5Col0 | Pixels.Row6Col0
            }
        },
        {
            'q',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row2Col4 | Pixels.Row3Col0 | Pixels.Row3Col3 |
                               Pixels.Row3Col4 | Pixels.Row4Col1 | Pixels.Row4Col2 | Pixels.Row4Col3 | Pixels.Row4Col4 |
                               Pixels.Row5Col4 | Pixels.Row6Col4
            }
        },
        {
            'r',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col0 | Pixels.Row2Col2 | Pixels.Row2Col3 | Pixels.Row3Col0 | Pixels.Row3Col1 |
                               Pixels.Row3Col4 | Pixels.Row4Col0 | Pixels.Row5Col0 | Pixels.Row6Col0
            }
        },
        {
            's',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row2Col3 | Pixels.Row3Col0 | Pixels.Row4Col1 |
                               Pixels.Row4Col2 | Pixels.Row4Col3 | Pixels.Row5Col4 | Pixels.Row6Col0 | Pixels.Row6Col1 |
                               Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            't',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row1Col1 | Pixels.Row2Col0 | Pixels.Row2Col1 | Pixels.Row2Col2 |
                               Pixels.Row3Col1 | Pixels.Row4Col1 | Pixels.Row5Col1 | Pixels.Row5Col4 | Pixels.Row6Col2 |
                               Pixels.Row6Col3
            }
        },
        {
            'u',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col0 | Pixels.Row2Col4 | Pixels.Row3Col0 | Pixels.Row3Col4 | Pixels.Row4Col0 |
                               Pixels.Row4Col4 | Pixels.Row5Col0 | Pixels.Row5Col3 | Pixels.Row5Col4 | Pixels.Row6Col1 |
                               Pixels.Row6Col2 | Pixels.Row6Col4
            }
        },
        {
            'v',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col0 | Pixels.Row2Col4 | Pixels.Row3Col0 | Pixels.Row3Col4 | Pixels.Row4Col0 |
                               Pixels.Row4Col4 | Pixels.Row5Col1 | Pixels.Row5Col3 | Pixels.Row6Col2
            }
        },
        {
            'w',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col0 | Pixels.Row2Col4 | Pixels.Row3Col0 | Pixels.Row3Col4 | Pixels.Row4Col0 |
                               Pixels.Row4Col2 | Pixels.Row4Col4 | Pixels.Row5Col0 | Pixels.Row5Col2 | Pixels.Row5Col4 |
                               Pixels.Row6Col1 | Pixels.Row6Col3
            }
        },
        {
            'x',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col0 | Pixels.Row2Col4 | Pixels.Row3Col1 | Pixels.Row3Col3 | Pixels.Row4Col2 |
                               Pixels.Row5Col1 | Pixels.Row5Col3 | Pixels.Row6Col0 | Pixels.Row6Col4
            }
        },
        {
            'y',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col0 | Pixels.Row2Col4 | Pixels.Row3Col0 | Pixels.Row3Col4 | Pixels.Row4Col1 |
                               Pixels.Row4Col2 | Pixels.Row4Col3 | Pixels.Row4Col4 | Pixels.Row5Col4 | Pixels.Row6Col1 |
                               Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            'z',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2Col0 | Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row2Col3 | Pixels.Row2Col4 |
                               Pixels.Row3Col3 | Pixels.Row4Col2 | Pixels.Row5Col1 | Pixels.Row6Col0 | Pixels.Row6Col1 |
                               Pixels.Row6Col2 | Pixels.Row6Col3 | Pixels.Row6Col4
            }
        }
    };
}

[Flags]
public enum Pixels : ulong
{
    None = 0,
    Row0Col0 = (ulong)1 << 0,
    Row0Col1 = (ulong)1 << 1,
    Row0Col2 = (ulong)1 << 2,
    Row0Col3 = (ulong)1 << 3,
    Row0Col4 = (ulong)1 << 4,
    Row1Col0 = (ulong)1 << 5,
    Row1Col1 = (ulong)1 << 6,
    Row1Col2 = (ulong)1 << 7,
    Row1Col3 = (ulong)1 << 8,
    Row1Col4 = (ulong)1 << 9,
    Row2Col0 = (ulong)1 << 10,
    Row2Col1 = (ulong)1 << 11,
    Row2Col2 = (ulong)1 << 12,
    Row2Col3 = (ulong)1 << 13,
    Row2Col4 = (ulong)1 << 14,
    Row3Col0 = (ulong)1 << 15,
    Row3Col1 = (ulong)1 << 16,
    Row3Col2 = (ulong)1 << 17,
    Row3Col3 = (ulong)1 << 18,
    Row3Col4 = (ulong)1 << 19,
    Row4Col0 = (ulong)1 << 20,
    Row4Col1 = (ulong)1 << 21,
    Row4Col2 = (ulong)1 << 22,
    Row4Col3 = (ulong)1 << 23,
    Row4Col4 = (ulong)1 << 24,
    Row5Col0 = (ulong)1 << 25,
    Row5Col1 = (ulong)1 << 26,
    Row5Col2 = (ulong)1 << 27,
    Row5Col3 = (ulong)1 << 28,
    Row5Col4 = (ulong)1 << 29,
    Row6Col0 = (ulong)1 << 30,
    Row6Col1 = (ulong)1 << 31,
    Row6Col2 = (ulong)1 << 32,
    Row6Col3 = (ulong)1 << 33,
    Row6Col4 = (ulong)1 << 34,
    Row7Col0 = (ulong)1 << 35,
    Row7Col1 = (ulong)1 << 36,
    Row7Col2 = (ulong)1 << 37,
    Row7Col3 = (ulong)1 << 38,
    Row7Col4 = (ulong)1 << 39,
}
