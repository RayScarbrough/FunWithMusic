using System;

namespace FunWithMusic
{
    class Program
    {
        enum Genre
        {
            Rock,
            Pop,
            HipHop,
            Jazz,
            Classical
            
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private int Length; 
            private Genre? Genre; 

            // Parameterized constructor
            public Music(string Title, string Artist, string Album, int Length, Genre genre)
            {
                this.Title = Title;
                this.Artist = Artist;
                this.Album = Album;
                this.Length = Length;
                this.Genre = genre;
            }

            
            public void setTitle(string title)
            {
                Title = title;
            }

           
            public void setLength(int length)
            {
                Length = length;
            }

            
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your first song?");
            string tempTitle1 = Console.ReadLine();
            Console.WriteLine("Who is the artist of the first song?");
            string tempArtist1 = Console.ReadLine();
            Console.WriteLine("What is the name of the album the first song is on?");
            string tempAlbum1 = Console.ReadLine();
            Console.Write("Enter the length of the first song (in seconds): ");
            int tempLength1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the genre of the first song?");
            Console.WriteLine("R - Rock\nP - Pop\nH - HipHop\nJ - Jazz\nC - Classical");
            Genre tempGenre1 = Genre.Rock;
            char g1 = char.Parse(Console.ReadLine());
            switch (g1)
            {
                case 'R':
                    tempGenre1 = Genre.Rock;
                    break;
                case 'P':
                    tempGenre1 = Genre.Pop;
                    break;
                case 'H':
                    tempGenre1 = Genre.HipHop;
                    break;
                case 'J':
                    tempGenre1 = Genre.Jazz;
                    break;
                case 'C':
                    tempGenre1 = Genre.Classical;
                    break;
            }

            Music firstSong = new Music(tempTitle1, tempArtist1, tempAlbum1, tempLength1, tempGenre1);

            Console.WriteLine("What is the title of your second song?");
            string tempTitle2 = Console.ReadLine(); 
            Console.Write("Enter the length of the second song (in seconds): ");
            int tempLength2 = int.Parse(Console.ReadLine());

            Music moreMusic = firstSong; 

            moreMusic.setTitle(tempTitle2); 
            moreMusic.setLength(tempLength2); 
            Console.WriteLine("\nFirst Song:\n" + firstSong.Display());
            Console.WriteLine("\nSecond Song:\n" + moreMusic.Display());
        }
    }
}
