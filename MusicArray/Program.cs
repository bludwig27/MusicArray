using System;

namespace MusicArray
{
    class Program
    {
        enum Genre
        {
            Classical,
            Jazz,
            Pop,
            Metal,
            Reggae
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            //public Music(string title, string artist, string album, string length, Genre genre)
            //{
            //    Title = title;
            //    Artist = artist;
            //    Album = album;
            //    Length = length;
            //    Genre = genre;
            //}
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Please enter the song title.");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Who is the artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What album is it on?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the song length?");
                    collection[i].setLength(Console.ReadLine());
                    Console.WriteLine("What genre of music?");
                    Console.WriteLine("C - Classical\nJ - Jazz\nP - Pop\nM - Metal\nR - Reggae");
                    collection[i].setGenre(Genre.Classical);
                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'C':
                            collection[i].setGenre(Genre.Classical);
                            break;
                        case 'J':
                            collection[i].setGenre(Genre.Jazz);
                            break;
                        case 'P':
                            collection[i].setGenre(Genre.Pop);
                            break;
                        case 'M':
                            collection[i].setGenre(Genre.Metal);
                            break;
                        case 'R':
                            collection[i].setGenre(Genre.Reggae);
                            break;
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{collection[j].Display()}");
                }
            }
        }
    }
}
