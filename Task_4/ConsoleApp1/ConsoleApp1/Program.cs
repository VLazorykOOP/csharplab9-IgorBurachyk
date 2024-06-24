using System;
using System.Collections;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public int DurationInSeconds { get; set; }

    public Song(string title, string artist, int duration)
    {
        Title = title;
        Artist = artist;
        DurationInSeconds = duration;
    }

    public override string ToString()
    {
        return $"{Title} - {Artist} ({DurationInSeconds} seconds)";
    }
}

public class MusicAlbum
{
    public string Title { get; set; }
    private Hashtable songs = new Hashtable();

    public MusicAlbum(string title)
    {
        Title = title;
    }

    public void AddSong(string title, string artist, int duration)
    {
        Song newSong = new Song(title, artist, duration);
        songs.Add(title, newSong);
    }

    public void RemoveSong(string title)
    {
        songs.Remove(title);
    }

    public void DisplayAlbumInfo()
    {
        Console.WriteLine($"Музичний альбом: {Title}");
        foreach (DictionaryEntry entry in songs)
        {
            Console.WriteLine(entry.Value);
        }
        Console.WriteLine();
    }

    public bool ContainsArtist(string artist)
    {
        foreach (DictionaryEntry entry in songs)
        {
            Song song = (Song)entry.Value;
            if (song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    public void DisplaySongsByArtist(string artist)
    {
        Console.WriteLine($"Пісні виконавця '{artist}':");
        foreach (DictionaryEntry entry in songs)
        {
            Song song = (Song)entry.Value;
            if (song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(song);
            }
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        MusicAlbum bestSongsOf90s = new MusicAlbum("Best songs of 90's");
        bestSongsOf90s.AddSong("Smells Like Teen Spirit", "Nirvana", 301);
        bestSongsOf90s.AddSong("Wonderwall", "Oasis", 258);
        bestSongsOf90s.AddSong("Baby One More Time", "Britney Spears", 211);
        bestSongsOf90s.AddSong("Gangsta's Paradise", "Coolio", 246);

        bestSongsOf90s.DisplayAlbumInfo();

        // Search songs by artist
        string searchArtist = "Britney Spears";
        if (bestSongsOf90s.ContainsArtist(searchArtist))
        {
            bestSongsOf90s.DisplaySongsByArtist(searchArtist);
        }
        else
        {
            Console.WriteLine($"Виконавець '{searchArtist}' не знайдений в альбомі '{bestSongsOf90s.Title}'.");
        }
    }
}
