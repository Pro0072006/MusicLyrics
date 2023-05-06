using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MusicLyrics.src.Helpers
{
    internal class TextsFormat
    {
        private static readonly string GeniusUrl = "https://genius.com/";

        public static string GeniusFormat(string Author, string Song)
        {
            string finalAuthor = Author
                .TrimStart()
                .TrimEnd()
                .Replace(' ', '-');

            string finalSong = Song
                .TrimStart()
                .TrimEnd()
                .Replace(' ', '-');

            return $"{GeniusUrl}{finalAuthor}-{finalSong}-lyrics";
        }

        public static string LyricFormat(string letter)
        {
            string htmlPattern = @"<.*?>";
            string patternLetter = @"&#x27;";

            string newLetter = letter
                .Replace("<br>", "\n")
                .Replace("</div>", "\n")
                .Replace("&quot;", string.Empty);

            newLetter = Regex.Replace(newLetter, htmlPattern, string.Empty);
            newLetter = Regex.Replace(newLetter, patternLetter, "'");

            newLetter += "\n\n**Powered by: Pro0072006**";

            return newLetter;
        }
    }
}
