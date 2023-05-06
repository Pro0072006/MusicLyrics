using HtmlAgilityPack;
using ScrapySharp.Extensions;
using MusicLyrics.Helpers;

namespace MusicLyrics.src.Services
{
    internal static class GeniusService
    {
        private static readonly HtmlWeb Oweb = new();

        public static string FetchLyrics(string link)
        {
            string lyrics = string.Empty;
            HtmlDocument document = new();

            try
            {
                document = Oweb.Load(link);
            }
            catch
            {
                return "Error con el servidor, intentelo mas tarde";
            }

            HtmlNode[] lyricsNode = document.DocumentNode.CssSelect("[class='Lyrics__Container-sc-1ynbvzw-6 YYrds']").ToArray();

            foreach (var node in lyricsNode)
            {
                lyrics += node.InnerHtml;
            }

            lyrics = TextsFormat.LyricFormat(lyrics);

            return lyrics;
        }

        public static async Task<string> FetchLyricsAsync(string link)
        {
            string lyrics = string.Empty;
            HtmlDocument document = new();

            try
            {
                document = await Oweb.LoadFromWebAsync(link);
            }
            catch
            {
                return "Error con el servidor, intentelo mas tarde";
            }

            HtmlNode[] lyricsNode = document.DocumentNode.CssSelect("[class='Lyrics__Container-sc-1ynbvzw-5 Dzxov']").ToArray();

            foreach (var node in lyricsNode)
            {
                lyrics += node.InnerHtml;
            }

            lyrics = TextsFormat.LyricFormat(lyrics);

            return lyrics;
        }
    }
}
