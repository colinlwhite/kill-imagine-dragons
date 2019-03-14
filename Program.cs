using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {

        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();
            var allSongs = new List<Song>();
            {
                allSongs.Add(new Song("Kanye West","Lift Off"));
                allSongs.Add(new Song("Imagine Dragons","Bleeding Out"));
                allSongs.Add(new Song("Kanye West","I Wonder"));
                allSongs.Add(new Song("Imagine Dragons","Whatever It Takes"));
                allSongs.Add(new Song("Kanye West","Good Life"));
                allSongs.Add(new Song("Imagine Dragons","Friction"));
                allSongs.Add(new Song("Kanye West","Waves"));
                allSongs.Add(new Song("Imagine Dragons","Amsterdam"));
                allSongs.Add(new Song("Kanye West","Saint Pablo"));
                allSongs.Add(new Song("Imagine Dragons","Shots"));
                allSongs.Add(new Song("Kanye West","Lost in the World"));
                allSongs.Add(new Song("Imagine Dragons","Demons"));
            }

            goodSongs = allSongs.Where(thesong => thesong.Artist != "Imagine Dragons").ToList();

            foreach(var song in goodSongs) {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }

            // Console.WriteLine("Hello World!");
        }
    }
}
