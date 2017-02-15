using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdApplication
{
    class Songs
    {
        public string Album { get; set; }
        public string Artist { get; set; }

        private List<CD> songs;
        public Songs()
        {
            songs = new List<CD>();
        }
        public void AddCD(CD song)
        {
            songs.Add(song);
        }
        
        public override string ToString()
        {
            return Album + " " + Artist;
        }
        public void PrintCollection()
        {
            foreach (CD song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
    }
}
