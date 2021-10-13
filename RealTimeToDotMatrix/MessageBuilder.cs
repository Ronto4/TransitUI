using System.Web;

namespace RealTimeToDotMatrix;

public class CharacterNotSupportedException : Exception
    {
        public char Character { get; }
        public CharacterNotSupportedException(char character) : base($"The given character '{character}' (ASCII: {((byte)character):x2}, UTF-32: {char.ConvertToUtf32(character.ToString(), 0)}) is not supported by the system!")
        {
            Character = character;
        }
    }
    public class NotEnoughCharactersException : Exception
    {
        public NotEnoughCharactersException() : base("The given message contains too many characters so that at least one of them cannot be displayed. Please reduce the amount of characters.") { }
    }
    static class MessageBuilder
    {
        private const char LineFeed = (char)0x0A;

        private static char[] AllowedCharacters { get; } = new char[] 
        {
            '^', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            '0', '!', '"', '$', '%', '&', '/', '(', ')', '=',
            '?', '`', 'q', 'w', 'e', 'r', 't', 'z', 'u', 'i',
            'o', 'p', '+', 'Q', 'W', 'E', 'R', 'T', 'Z', 'U',
            'I', 'O', 'P', '*', '@', 'a', 's', 'd', 'f', 'g',
            'h', 'j', 'k', 'l', '#', 'A', 'S', 'D', 'F', 'G',
            'H', 'J', 'K', 'L', '\'', '<', 'y', 'x', 'c', 'v',
            'b', 'n', 'm', ',', '.', '-', '>', 'Y', 'X', 'C',
            'V', 'B', 'N', 'M', ';', ':', '_', '|', ' ', LineFeed
        };
        private static char[] NonAliasCharacters { get; } = new char[]
        {
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'A', 'B', 'C', 'D', 'E', 'F', '%', 'H', 'R'
        };
        private static char[] SupportedCharacters { get; } = new char[]
        {
            'ü', 'ä', 'ö', 'Ä', 'Ö', 'Ü', 'ß', 'ẞ'
        };
        private static Dictionary<char, ulong> BytesForSupported { get; } = new Dictionary<char, ulong>()
        {
            {'ü', 0x3C8202843E },
            {'ö', 0x1CA222A21C },
            {'ä', 0x04AA2AAA1E },
            {'Ä', 0x1EA424A41E },
            {'Ö', 0x1CA222A21C },  // = ö
            {'Ü', 0x3C8202823C },
          //{'ß', 0x3E404A3400 },  //Alternative
            {'ß', 0x3E40542800 },  //Alternative
            {'ẞ', 0x7E8092926C }
          //{'ẞ', 0x3E404A4A34 }   //Alternative
        };
        public static string Build(string message)
        {
            message = message.Replace(Environment.NewLine, $"{LineFeed}");
            List<char> requiredCharacters = new List<char>();
            for (int i = 0; i < message.Length; i++)
            {
                if (AllowedCharacters.Contains(message[i]) == false)
                {
                    if (SupportedCharacters.Contains(message[i]) == false)
                    {
                        throw new CharacterNotSupportedException(message[i]);
                    }
                    requiredCharacters.Add(message[i]);
                }
            }
            for (int i = 0; i < requiredCharacters.Count; i++)
            {
                char replacing = '~';
                for (int j = 0; j < AllowedCharacters.Length; j++)
                {
                    if (message.Contains(AllowedCharacters[j]) == false && NonAliasCharacters.Contains(AllowedCharacters[j]) == false)
                    {
                        replacing = AllowedCharacters[j];
                        break;
                    }
                }
                if (replacing == '~')
                {
                    throw new NotEnoughCharactersException();
                }
                message = $"%CHAR {replacing} {BytesForSupported[requiredCharacters[i]].ToString("x10").ToUpper()}{LineFeed}{message}";
                message = message.Replace(requiredCharacters[i], replacing);
            }
            message = HttpUtility.UrlEncode(message);
            return message;
        }
    }
