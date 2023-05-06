using MusicLyrics.Helpers;
using MusicLyrics.Services;

namespace MusicLyrics.src
{
    public static class LyricsFinder
    {
        /// <summary>
        /// Find the lyrics of the requested song by the author and the name of the song
        /// </summary>
        /// <param name="Author">The person who created the song</param>
        /// <param name="Song">The name of the song</param>
        /// <returns>The lyrics of the song</returns>
        public static string FindLyrics(string Author, string Song)
        {
            string linkSong = TextsFormat.GeniusFormat(Author, Song);
            string lyrics = GeniusService.FetchLyrics(linkSong);
            return lyrics;
        }
        /// <summary>
        /// Find the lyrics of the requested song by the link of Genius
        /// </summary>
        /// <param name="GeniusLink">The link of the song</param>
        /// <returns>The lyrics of the song</returns>
        public static string FindLyrics(string GeniusLink)
        {
            string lyrics = GeniusService.FetchLyrics(GeniusLink);
            return lyrics;
        }

        /// <summary>
        /// Find the lyrics of the requested song by the author and the name of the song
        /// </summary>
        /// <param name="Author">The person who created the song</param>
        /// <param name="Song">The name of the song</param>
        /// <returns>The lyrics of the song</returns>
        public static async Task<string> FindLyricsAsync(string Author, string Song)
        {
            string linkSong = TextsFormat.GeniusFormat(Author, Song);
            string lyrics = await GeniusService.FetchLyricsAsync(linkSong);
            return lyrics;
        }

        /// <summary>
        /// Find the lyrics of the requested song by the link of Genius
        /// </summary>
        /// <param name="GeniusLink">The link of the song</param>
        /// <returns>The lyrics of the song</returns>
        public static async Task<string> FindLyricsAsync(string GeniusLink)
        {
            string lyrics = await GeniusService.FetchLyricsAsync(GeniusLink);
            return lyrics;
        }
    }
}
