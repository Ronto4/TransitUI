using RealTimeModels.Vip;

namespace RealTimeToDotMatrix.Vip;

public static class RealTimeToDotMatrix
{
    private static uint MinimalCols => 32;
    private static uint MaximalCols => 64;
    private static uint MaximalRows => 16;
    private static uint UsableRows => MaximalRows - 6;

    private static char[] LineBreakCharacters { get; } =
    {
        ' ', '/', '-'
    };
    private static void AddAlertToList(string message, List<string> lines, int cols)
    {
        while (message.Length > cols)
        {
            message = message.Trim();
            string prevMessage = message;
            for (int i = cols - 1; i >= 0; i--)
            {
                int index = Array.IndexOf(LineBreakCharacters, message[i]);
                if (index == -1)
                    continue;

                lines.Add(message.Substring(0, i + 1));
                message = message.Substring(i + 1);
                break;
            }
            if (message != prevMessage)
                continue;

            //// IndexIi because of https://github.com/dotnet/csharplang/discussions/2574
            //int indexIi = Array.IndexOf(LineBreakCharacters, message[cols]);
            if (message[cols] != ' ')
                throw new Exception($"Sequence too long.");

            lines.Add(message.Substring(0, cols + 1));
            message = message.Substring(cols + 1);
        }
        message = message.Trim();
        lines.Add($"{message}");
    }
    
    private static void AddHeaderToPage(Station station, List<string> emptyPage, int cols, int gap)
    {
        emptyPage.Add(station.StationName);
        emptyPage.Add(new string('-', cols));
        emptyPage.Add($"Linie | Ziel/Richtung %GAP% | Abf.");
        emptyPage[^1] = emptyPage[^1].Replace("%GAP%", new string(' ', cols - emptyPage[^1].Length + "%GAP%".Length));
        emptyPage.Add($"------|-{new string('-', gap)}-|-----");
    }

    private static void AddFooterToPage(List<string> page, int cols, DateTime time, int pageNumber, int pageCount)
    {
        while(page.Count < MaximalRows - 2)
            page.Add("");
        page.Add(new string('-', cols));
        page.Add($"Seite {pageNumber}/{pageCount}%GAP%{time:dd.MM.yyyy HH:mm:ss}");
        page[^1] = page[^1].Replace("%GAP%", new string(' ', cols - page[^1].Length + "%GAP%".Length));
    }

    private static void AddDestinationToPage(List<string> page, RealTimeEntry realTimeEntry, int maxDirectionWidth)
    {
        string destinationLine = string.Empty;
        string lineNumber =
            realTimeEntry.PatternText is string && string.IsNullOrWhiteSpace(realTimeEntry.PatternText!) == false
                ? realTimeEntry.PatternText!
                : realTimeEntry.Route.LineName;
        destinationLine += lineNumber.Length switch
        {
            0 => $"  ??  ",
            1 => $"   {lineNumber}  ",
            2 => $"  {lineNumber}  ",
            3 => $" {lineNumber}  ",
            4 => $"{lineNumber}  ",
            5 => $"{lineNumber} ",
            6 => $"{lineNumber}",
            _ => $"??????"
        };
        destinationLine += "| ";
        destinationLine += realTimeEntry.Direction;
        destinationLine += new string(' ', maxDirectionWidth - realTimeEntry.Direction.Length);
        destinationLine += " |";
        string mixedTime = realTimeEntry.MixedTime;
        mixedTime = mixedTime.Replace("%UNIT_MIN%", "");
        mixedTime = mixedTime.Trim();
        destinationLine += mixedTime.Length switch
        {
            0 => $"  ?  ",
            1 => $"  {mixedTime}  ",
            2 => $" {mixedTime}  ",
            3 => $" {mixedTime} ",
            4 => $" {mixedTime}",
            5 => $"{mixedTime}",
            _ => $"?????"
        };
        page.Add(destinationLine);
        if (realTimeEntry.Vias is null)
            return;
        foreach (var via in realTimeEntry.Vias)
        {
            string viaLine = $"{new string(' ', 6)}| {via}{new string(' ', maxDirectionWidth - via.Length)} |";
            page.Add(viaLine);
        }
    }
    private static (string[] messages, (uint cols, uint rows) dimensions) GenerateTarget(Station station)
    {
        int pageCount = station.Alerts.Count + 1;
        List<List<RealTimeEntry>> pagedEntries = new(pageCount);
        int currentPositionOnPage = 0;
        pagedEntries.Add(new List<RealTimeEntry>());
        int maxDestinationWidth = 0;
        foreach (var realTimeEntry in station.Actual)
        {
            int localLength = (realTimeEntry.Vias?.Count ?? 0) + 1;
            currentPositionOnPage += localLength;
            if (currentPositionOnPage > UsableRows)
            {
                pageCount++;
                currentPositionOnPage = localLength;
                pagedEntries.Add(new List<RealTimeEntry>());
            }
            pagedEntries[^1].Add(realTimeEntry);
            maxDestinationWidth = realTimeEntry.Vias is not null
                ? realTimeEntry.Vias.Select(via => via.Length).Append(realTimeEntry.Direction.Length).Append(maxDestinationWidth).Max()
                : Math.Max(realTimeEntry.Direction.Length, maxDestinationWidth);
        }

        int targetCols = maxDestinationWidth + 15;
        if (station.StationName.Length > targetCols)
        {
            targetCols = station.StationName.Length;
            maxDestinationWidth = targetCols - 15;
        }

        List<List<string>> pages = new(pageCount);
        int alert = 0;
        foreach (var stationAlert in station.Alerts)
        {
            alert++;
            List<string> page = new();
            AddHeaderToPage(station, page, targetCols, maxDestinationWidth);
            page.Add($"Hinweis {alert}/{station.Alerts.Count}:");
            AddAlertToList(stationAlert.Message, page, targetCols);
            pages.Add(page);
            AddFooterToPage(page, targetCols, DateTime.Now, pages.Count, pageCount);
        }

        foreach (var pagedEntry in pagedEntries)
        {
            List<string> page = new();
            AddHeaderToPage(station, page, targetCols, maxDestinationWidth);
            foreach (var realTimeEntry in pagedEntry)
            {
                AddDestinationToPage(page, realTimeEntry, maxDestinationWidth);
            }
            pages.Add(page);
            AddFooterToPage(page, targetCols, DateTime.Now, pages.Count, pageCount);
        }

        return (pages.Select(page => string.Join(Environment.NewLine, page)).ToArray(), ((uint)targetCols, MaximalRows));
    }
    public static Stream Convert(Station station)
    {
        var (messages, dimensions) = GenerateTarget(station);
        var pictures = messages.Select(message => new DotMatrixPicture(message, RgbColor.Border, RgbColor.Background, RgbColor.InactivePixels, RgbColor.ActivePixels, dimensions));
        // DotMatrixPicture picture = new DotMatrixPicture(message, RgbColor.Border, RgbColor.Background, RgbColor.InactivePixels, RgbColor.ActivePixels, dimensions);
        Stream gif = Animator.GifCreator.ConvertImageStreamsToGifStream(pictures.Select(picture => picture.GetPicture()));
        return gif;
        
        // return pictures.ElementAt(0).GetPicture();
        //return string.Join($"{Environment.NewLine}NEW_LINE{Environment.NewLine}", messages);
    }
}
