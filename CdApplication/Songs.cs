using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdApplication
{
    class Songs
    {
        private List<CD> songs;
        public Songs()
        {
            songs = new List<CD>();
        }
         public void AddCD(CD song)
        {
            songs.Add(song);
        }


        private List<Albums> albums;
        public Albums()
        {
            albums = new List<Albums>();
        }
        public void AddSongs(Albums album)
        {
            albums.Add(album);
        }

        public void PrintCollection()
        {
            Console.WriteLine(albums.ToString());
            foreach (CD song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
