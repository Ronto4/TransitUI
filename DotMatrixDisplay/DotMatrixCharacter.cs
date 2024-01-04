namespace DotMatrixDisplay;

public readonly record struct DotMatrixCharacter
{
    public required Pixels ActivePixels { get; init; }

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
            'A',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Bounds |
                               Pixels.Row2Bounds | Pixels.Row3Bounds | Pixels.Row4 | Pixels.Row5Bounds |
                               Pixels.Row6Bounds
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
            'B',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col0 | Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 |
                               Pixels.Row1Bounds | Pixels.Row2Bounds | Pixels.Row3Col0 | Pixels.Row3Col1 |
                               Pixels.Row3Col2 | Pixels.Row3Col3 | Pixels.Row4Bounds | Pixels.Row5Bounds |
                               Pixels.Row6Col0 | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
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
            'C',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Bounds |
                               Pixels.Row2Col0 | Pixels.Row3Col0 | Pixels.Row4Col0 | Pixels.Row5Bounds |
                               Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
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
            'D',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col0 | Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row1Col0 | Pixels.Row1Col3 |
                               Pixels.Row2Bounds | Pixels.Row3Bounds | Pixels.Row4Bounds | Pixels.Row5Col0 |
                               Pixels.Row5Col3 | Pixels.Row6Col0 | Pixels.Row6Col1 | Pixels.Row6Col2
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
            'E',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0 | Pixels.Row1Col0 | Pixels.Row2Col0 | Pixels.Row3Col0 | Pixels.Row3Col1 |
                               Pixels.Row3Col2 | Pixels.Row3Col3 | Pixels.Row4Col0 | Pixels.Row5Col0 | Pixels.Row6
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
            'F',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0 | Pixels.Row1Col0 | Pixels.Row2Col0 | Pixels.Row3Col0 | Pixels.Row3Col1 |
                               Pixels.Row3Col2 | Pixels.Row3Col3 | Pixels.Row4Col0 | Pixels.Row5Col0 | Pixels.Row6Col0
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
            'G',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Bounds |
                               Pixels.Row2Col0 | Pixels.Row3Col0 | Pixels.Row3Col2 | Pixels.Row3Col3 | Pixels.Row3Col4 |
                               Pixels.Row4Bounds | Pixels.Row5Bounds | Pixels.Row6Col1 | Pixels.Row6Col2 |
                               Pixels.Row6Col3 | Pixels.Row6Col4
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
            'H',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Bounds | Pixels.Row1Bounds | Pixels.Row2Bounds | Pixels.Row3 |
                               Pixels.Row4Bounds | Pixels.Row5Bounds | Pixels.Row6Bounds
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
            'I',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Col2 | Pixels.Row2Col2 |
                               Pixels.Row3Col2 | Pixels.Row4Col2 | Pixels.Row5Col2 | Pixels.Row6Col1 | Pixels.Row6Col2 |
                               Pixels.Row6Col3
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
            'J',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row0Col4 | Pixels.Row1Col3 | Pixels.Row2Col3 |
                               Pixels.Row3Col3 | Pixels.Row4Col3 | Pixels.Row5Col0 | Pixels.Row5Col3 | Pixels.Row6Col1 |
                               Pixels.Row6Col2
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
            'K',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Bounds | Pixels.Row1Col0 | Pixels.Row1Col3 | Pixels.Row2Col0 |
                               Pixels.Row2Col2 | Pixels.Row3Col0 | Pixels.Row3Col1 | Pixels.Row4Col0 | Pixels.Row4Col2 |
                               Pixels.Row5Col0 | Pixels.Row5Col3 | Pixels.Row6Bounds
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
            'L',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col0 | Pixels.Row1Col0 | Pixels.Row2Col0 | Pixels.Row3Col0 | Pixels.Row4Col0 |
                               Pixels.Row5Col0 | Pixels.Row6
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
            'M',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Bounds | Pixels.Row1Col0 | Pixels.Row1Col1 | Pixels.Row1Col3 |
                               Pixels.Row1Col4 | Pixels.Row2Col0 | Pixels.Row2Col2 | Pixels.Row2Col4 | Pixels.Row3Col0 |
                               Pixels.Row3Col2 | Pixels.Row3Col4 | Pixels.Row4Bounds | Pixels.Row5Bounds |
                               Pixels.Row6Bounds
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
            'N',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Bounds | Pixels.Row1Bounds | Pixels.Row2Col0 | Pixels.Row2Col1 |
                               Pixels.Row2Col4 | Pixels.Row3Col0 | Pixels.Row3Col2 | Pixels.Row3Col4 | Pixels.Row4Col0 |
                               Pixels.Row4Col3 | Pixels.Row4Col4 | Pixels.Row5Bounds | Pixels.Row6Bounds
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
            'O',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Bounds |
                               Pixels.Row2Bounds | Pixels.Row3Bounds | Pixels.Row4Bounds | Pixels.Row5Bounds |
                               Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
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
            'P',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col0 | Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 |
                               Pixels.Row1Bounds | Pixels.Row2Bounds | Pixels.Row3Col0 | Pixels.Row3Col1 |
                               Pixels.Row3Col2 | Pixels.Row3Col3 | Pixels.Row4Col0 | Pixels.Row5Col0 | Pixels.Row6Col0
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
            'Q',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Bounds |
                               Pixels.Row2Bounds | Pixels.Row3Bounds | Pixels.Row4Col0 | Pixels.Row4Col2 |
                               Pixels.Row4Col4 | Pixels.Row5Col0 | Pixels.Row5Col3 | Pixels.Row6Col1 | Pixels.Row6Col2 |
                               Pixels.Row6Col4
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
            'R',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col0 | Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 |
                               Pixels.Row1Bounds | Pixels.Row2Bounds | Pixels.Row3Col0 | Pixels.Row3Col1 |
                               Pixels.Row3Col2 | Pixels.Row3Col3 | Pixels.Row4Col0 | Pixels.Row4Col2 | Pixels.Row5Col0 |
                               Pixels.Row5Col3 | Pixels.Row6Col0 | Pixels.Row6Col4
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
            'S',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row0Col4 | Pixels.Row1Col0 |
                               Pixels.Row2Col0 | Pixels.Row3Col1 | Pixels.Row3Col2 | Pixels.Row3Col3 | Pixels.Row4Col4 |
                               Pixels.Row5Col4 | Pixels.Row6Col0 | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
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
            'T',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0 | Pixels.Row1Col2 | Pixels.Row2Col2 | Pixels.Row3Col2 | Pixels.Row4Col2 |
                               Pixels.Row5Col2 | Pixels.Row6Col2
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
            'U',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Bounds | Pixels.Row1Bounds | Pixels.Row2Bounds | Pixels.Row3Bounds |
                               Pixels.Row4Bounds | Pixels.Row5Bounds | Pixels.Row6Col1 | Pixels.Row6Col2 |
                               Pixels.Row6Col3
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
            'V',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Bounds | Pixels.Row1Bounds | Pixels.Row2Bounds | Pixels.Row3Bounds |
                               Pixels.Row4Bounds | Pixels.Row5Col1 | Pixels.Row5Col3 | Pixels.Row6Col2
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
            'W',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Bounds | Pixels.Row1Bounds | Pixels.Row2Bounds | Pixels.Row3Col0 |
                               Pixels.Row3Col2 | Pixels.Row3Col4 | Pixels.Row4Col0 | Pixels.Row4Col2 | Pixels.Row4Col4 |
                               Pixels.Row5Col0 | Pixels.Row5Col2 | Pixels.Row5Col4 | Pixels.Row6Col1 | Pixels.Row6Col3
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
            'X',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Bounds | Pixels.Row1Bounds | Pixels.Row2Col1 | Pixels.Row2Col3 |
                               Pixels.Row3Col2 | Pixels.Row4Col1 | Pixels.Row4Col3 | Pixels.Row5Bounds |
                               Pixels.Row6Bounds
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
            'Y',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Bounds | Pixels.Row1Bounds | Pixels.Row2Bounds | Pixels.Row3Col1 |
                               Pixels.Row3Col3 | Pixels.Row4Col2 | Pixels.Row5Col2 | Pixels.Row6Col2
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
        },
        {
            'Z',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0 | Pixels.Row1Col4 | Pixels.Row2Col3 | Pixels.Row3Col2 | Pixels.Row4Col1 |
                               Pixels.Row5Col0 | Pixels.Row6
            }
        },
        {
            ' ',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.None
            }
        },
        {
            '0',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Bounds |
                               Pixels.Row2Col0 | Pixels.Row2Col3 | Pixels.Row2Col4 | Pixels.Row3Col0 | Pixels.Row3Col2 |
                               Pixels.Row3Col4 | Pixels.Row4Bounds | Pixels.Row4Col1 | Pixels.Row5Bounds |
                               Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            '1',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col2 | Pixels.Row1Col1 | Pixels.Row1Col2 | Pixels.Row2Col2 | Pixels.Row3Col2 | Pixels.Row4Col2 |
                               Pixels.Row5Col2 | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            '2',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Bounds |
                               Pixels.Row2Col4 | Pixels.Row3Col3 | Pixels.Row4Col2 | Pixels.Row5Col1 | Pixels.Row6
            }
        },
        {
            '3',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0 | Pixels.Row1Col3 | Pixels.Row2Col2 | Pixels.Row3Col3 | Pixels.Row4Col4 |
                               Pixels.Row5Bounds | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            '4',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col3 | Pixels.Row1Col2 | Pixels.Row1Col3 | Pixels.Row2Col1 | Pixels.Row2Col3 |
                               Pixels.Row3Col0 | Pixels.Row3Col3 | Pixels.Row4 | Pixels.Row5Col3 | Pixels.Row6Col3
            }
        },
        {
            '5',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0 | Pixels.Row1Col0 | Pixels.Row2Col0 | Pixels.Row2Col1 | Pixels.Row2Col2 |
                               Pixels.Row2Col3 | Pixels.Row3Col4 | Pixels.Row4Col4 | Pixels.Row5Bounds |
                               Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            '6',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Col1 | Pixels.Row2Col0 | Pixels.Row3Col0 |
                               Pixels.Row3Col1 | Pixels.Row3Col2 | Pixels.Row3Col3 | Pixels.Row4Bounds |
                               Pixels.Row5Bounds | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col3
            }
        },
        {
            '7',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0 | Pixels.Row1Col4 | Pixels.Row2Col3 | Pixels.Row3Col2 | Pixels.Row4Col1 |
                               Pixels.Row5Col1 | Pixels.Row6Col1
            }
        },
        {
            '8',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Bounds |
                               Pixels.Row2Bounds | Pixels.Row3Col1 | Pixels.Row3Col2 | Pixels.Row3Col3 |
                               Pixels.Row4Bounds | Pixels.Row5Bounds | Pixels.Row6Col1 | Pixels.Row6Col2 |
                               Pixels.Row6Col3
            }
        },
        {
            '9',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Bounds |
                               Pixels.Row2Bounds | Pixels.Row3Col1 | Pixels.Row3Col2 | Pixels.Row3Col3 |
                               Pixels.Row3Col4 | Pixels.Row4Col4 | Pixels.Row5Col3 | Pixels.Row6Col1 | Pixels.Row6Col2
            }
        },
        {
            '-',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row3
            }
        },
        {
            '|',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col2 | Pixels.Row1Col2 | Pixels.Row2Col2 | Pixels.Row3Col2 | Pixels.Row4Col2 | Pixels.Row5Col2 | Pixels.Row6Col2
            }
        },
        {
            '.',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row5Col1 | Pixels.Row5Col2 | Pixels.Row6Col1 | Pixels.Row6Col2
            }
        },
        {
            '/',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row1Col4 | Pixels.Row2Col3 | Pixels.Row3Col2 | Pixels.Row4Col1 | Pixels.Row5Col0
            }
        },
        {
            ',',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row4Col1 | Pixels.Row4Col2 | Pixels.Row5Col2 | Pixels.Row6Col1
            }
        },
        {
            ';',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row1Col1 | Pixels.Row1Col2 | Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row4Col1 | Pixels.Row4Col2 | Pixels.Row5Col2 | Pixels.Row6Col1
            }
        },
        {
            ':',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row1Col1 | Pixels.Row1Col2 | Pixels.Row2Col1 | Pixels.Row2Col2 | Pixels.Row4Col1 | Pixels.Row4Col2 | Pixels.Row5Col1 | Pixels.Row5Col2
            }
        },
        {
            '_',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row6
            }
        },
        {
            '#',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col3 | Pixels.Row1Col1 | Pixels.Row1Col3 | Pixels.Row2 | Pixels.Row3Col1 | Pixels.Row3Col3 | Pixels.Row4 | Pixels.Row5Col1 | Pixels.Row5Col3 | Pixels.Row6Col1 | Pixels.Row6Col3
            }
        },
        {
            '\'',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row1Col2 | Pixels.Row3Col1
            }
        },
        {
            '+',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row1Col2 | Pixels.Row2Col2 | Pixels.Row3 | Pixels.Row4Col2 | Pixels.Row5Col2
            }
        },
        {
            '*',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row1Col2 | Pixels.Row2Col0 | Pixels.Row2Col2 | Pixels.Row2Col4 | Pixels.Row3Col1 | Pixels.Row3Col2 | Pixels.Row3Col3 | Pixels.Row4Col0 | Pixels.Row4Col2 | Pixels.Row4Col3 | Pixels.Row5Col2
            }
        },
        {
            '<',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col3 | Pixels.Row1Col2 | Pixels.Row2Col1 | Pixels.Row3Col0 | Pixels.Row4Col1 | Pixels.Row5Col2 | Pixels.Row6Col3
            }
        },
        {
            '>',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row1Col2 | Pixels.Row2Col3 | Pixels.Row3Col4 | Pixels.Row4Col3 | Pixels.Row5Col2 | Pixels.Row6Col1
            }
        },
        {
            '%',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col0 | Pixels.Row0Col1 | Pixels.Row1Bounds | Pixels.Row1Col1 | Pixels.Row2Col3 | Pixels.Row3Col2 | Pixels.Row4Col1 | Pixels.Row5Bounds | Pixels.Row5Col3 | Pixels.Row6Col3 | Pixels.Row6Col4
            }
        },
        {
            '&',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row1Col0 | Pixels.Row1Col3 | Pixels.Row2Col0 | Pixels.Row2Col2 | Pixels.Row3Col1 | Pixels.Row4Bounds | Pixels.Row4Col2 | Pixels.Row5Col0 | Pixels.Row5Col3 | Pixels.Row6Col1 | Pixels.Row6Col2 | Pixels.Row6Col4
            }
        },
        {
            '"',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col3 | Pixels.Row1Col1 | Pixels.Row1Col3 | Pixels.Row2Col1 | Pixels.Row2Col3
            }
        },
        {
            '!',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col2 | Pixels.Row1Col2 | Pixels.Row2Col2 | Pixels.Row3Col2 | Pixels.Row6Col2
            }
        },
        {
            '?',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row0Col2 | Pixels.Row0Col3 | Pixels.Row1Bounds | Pixels.Row2Col4 | Pixels.Row3Col3 | Pixels.Row4Col2 | Pixels.Row6Col2
            }
        },
        {
            '=',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row2 | Pixels.Row4
            }
        },
        {
            '(',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col3 | Pixels.Row1Col2 | Pixels.Row2Col1 | Pixels.Row3Col1 | Pixels.Row4Col1 | Pixels.Row5Col2 | Pixels.Row6Col3
            }
        },
        {
            ')',
            new DotMatrixCharacter
            {
                ActivePixels = Pixels.Row0Col1 | Pixels.Row1Col2 | Pixels.Row2Col3 | Pixels.Row3Col3 | Pixels.Row4Col3 | Pixels.Row5Col2 | Pixels.Row6Col1
            }
        },
        {
            'ö',
            new DotMatrixCharacter
            {
                ActivePixels = (Pixels)0x1CA222A21C
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
    Row0 = Row0Col0 | Row0Col1 | Row0Col2 | Row0Col3 | Row0Col4,
    Row0Bounds = Row0Col0 | Row0Col4,
    Row1Col0 = (ulong)1 << 5,
    Row1Col1 = (ulong)1 << 6,
    Row1Col2 = (ulong)1 << 7,
    Row1Col3 = (ulong)1 << 8,
    Row1Col4 = (ulong)1 << 9,
    Row1 = Row1Col0 | Row1Col1 | Row1Col2 | Row1Col3 | Row1Col4,
    Row1Bounds = Row1Col0 | Row1Col4,
    Row2Col0 = (ulong)1 << 10,
    Row2Col1 = (ulong)1 << 11,
    Row2Col2 = (ulong)1 << 12,
    Row2Col3 = (ulong)1 << 13,
    Row2Col4 = (ulong)1 << 14,
    Row2 = Row2Col0 | Row2Col1 | Row2Col2 | Row2Col3 | Row2Col4,
    Row2Bounds = Row2Col0 | Row2Col4,
    Row3Col0 = (ulong)1 << 15,
    Row3Col1 = (ulong)1 << 16,
    Row3Col2 = (ulong)1 << 17,
    Row3Col3 = (ulong)1 << 18,
    Row3Col4 = (ulong)1 << 19,
    Row3 = Row3Col0 | Row3Col1 | Row3Col2 | Row3Col3 | Row3Col4,
    Row3Bounds = Row3Col0 | Row3Col4,
    Row4Col0 = (ulong)1 << 20,
    Row4Col1 = (ulong)1 << 21,
    Row4Col2 = (ulong)1 << 22,
    Row4Col3 = (ulong)1 << 23,
    Row4Col4 = (ulong)1 << 24,
    Row4 = Row4Col0 | Row4Col1 | Row4Col2 | Row4Col3 | Row4Col4,
    Row4Bounds = Row4Col0 | Row4Col4,
    Row5Col0 = (ulong)1 << 25,
    Row5Col1 = (ulong)1 << 26,
    Row5Col2 = (ulong)1 << 27,
    Row5Col3 = (ulong)1 << 28,
    Row5Col4 = (ulong)1 << 29,
    Row5 = Row5Col0 | Row5Col1 | Row5Col2 | Row5Col3 | Row5Col4,
    Row5Bounds = Row5Col0 | Row5Col4,
    Row6Col0 = (ulong)1 << 30,
    Row6Col1 = (ulong)1 << 31,
    Row6Col2 = (ulong)1 << 32,
    Row6Col3 = (ulong)1 << 33,
    Row6Col4 = (ulong)1 << 34,
    Row6 = Row6Col0 | Row6Col1 | Row6Col2 | Row6Col3 | Row6Col4,
    Row6Bounds = Row6Col0 | Row6Col4,
    Row7Col0 = (ulong)1 << 35,
    Row7Col1 = (ulong)1 << 36,
    Row7Col2 = (ulong)1 << 37,
    Row7Col3 = (ulong)1 << 38,
    Row7Col4 = (ulong)1 << 39,
    Row7 = Row7Col0 | Row7Col1 | Row7Col2 | Row7Col3 | Row7Col4,
    Row7Bounds = Row7Col0 | Row7Col4,
}
