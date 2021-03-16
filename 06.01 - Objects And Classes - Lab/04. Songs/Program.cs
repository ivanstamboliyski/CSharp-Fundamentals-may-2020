using System;
using System.Collections.Generic;

namespace _04.Songs
{
    class Program
    {
        static void Main()
        {
            int songsNumber = int.Parse(Console.ReadLine());

            List<Song> allSongs = new List<Song>();

            for (int i = 0; i < songsNumber; i++)
            {
                string[] inputData = Console.ReadLine().Split("_");

                string type = inputData[0];
                string name = inputData[1];
                string time = inputData[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                allSongs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in allSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in allSongs)
                {
                    if (typeList == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}
