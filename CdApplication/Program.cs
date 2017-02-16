using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Albums artist = new Albums { Artist = "Nightwish" };
            Albums album = new Albums { Album = "Endless Forms most Beautiful" };
            CD song1 = new CD { Song = "Shudder before the beautiful", Time = "6:29"};
            CD song2 = new CD { Song = "Weak Fantasy", Time = "5:23" };
            CD song3 = new CD { Song = "Elan", Time = "4:45" };

            //create a Persons object
            Songs Biisit = new Songs();

            //add person object to persons collection
            Biisit.AddCD(song1);
            Biisit.AddCD(song2);
            Biisit.AddCD(song3);
                        
            //print collection
            Biisit.PrintCollection();           
        }
    }
}
