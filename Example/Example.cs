using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicLyrics.src;

namespace MusicLyrics.Example
{
    internal class Example
    {
        private async Task Lyrics()
        {
            string lyrics = await LyricsFinder.FindLyricsAsync("Autor", "Cancion");
        }
    }
}
