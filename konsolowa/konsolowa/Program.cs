using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***********************************************
nazwa funkcji: showAlbums   
opis funkcji: celem tej funkcji jest wypisać albumy   
parametry: lista z klasy album   

zwracany typ i opis: zwaraca albumy zapisane w pliku txt do listy
autor: Michał Sławski 5D                

 
 *********************************************** */

namespace konsolowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Album> albums = ReadAlbumFromFile("Data.txt");
            showAlbums(albums);

            Console.ReadLine(); 
        }
        private static List<Album> ReadAlbumFromFile(string filePath)
        {
            List<Album> albums = new List<Album>();
            using (StreamReader r = new StreamReader(filePath))
            {
                string line;
                //string parts;
                while ((line = r.ReadLine()) != null)
                {
                    //parts = line;
                    Album album = new Album();
                    album.artist = line;
                    album.album = r.ReadLine();
                    album.songsNumber = r.ReadLine();
                    album.year = uint.Parse(r.ReadLine());
                    album.downloadNumber = int.Parse(r.ReadLine());
                    album.newLine = r.ReadLine();
                    albums.Add(album);
                }
            }

            return albums;
        }
        private static void showAlbums(List<Album> albums) 
        {
            for (int i = 0; i < albums.Count; i++) 
            {
                Album album = albums[i];
                Console.WriteLine(album.artist);
                Console.WriteLine(album.album);
                Console.WriteLine(album.songsNumber);
                Console.WriteLine(album.year);
                Console.WriteLine(album.downloadNumber);
                Console.WriteLine(album.newLine);
                Console.WriteLine();
               
            }
        }
       
    }
}
