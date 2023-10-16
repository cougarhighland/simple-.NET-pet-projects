using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Solution
{
    internal class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void Start()
        {
 
            collectAlbumInfo();
            showAlbumInfo();

        }

        public void collectAlbumInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Starting the Album program!");
            Console.WriteLine();
            Console.WriteLine("What is the name of the your favorit music album?");
            albumName = Console.ReadLine();
            Console.WriteLine("What is the name of the Artist or Band for " + albumName+" ?");
            artistName = Console.ReadLine();
            Console.WriteLine("How many tracks does " + albumName + " have?");
            numOfTracks = int.Parse(Console.ReadLine());
        }

        public void showAlbumInfo()
        {
            Console.WriteLine("Album Name: " + albumName);
            Console.WriteLine("Artist/Band: " + artistName);
            Console.WriteLine("Number of Tracks: " + numOfTracks);
            Console.WriteLine("Enjoy listening!");
        }
    }
}
