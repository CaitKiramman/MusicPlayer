using System;
using NAudio.Wave;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       
       List <String> Music = new List<string>();
       Music.Add("E:/C#/NewProject/music.mp3");
       Music.Add("E:/C#/NewProject/PaintTheTownBlue.mp3");
       Music.Add("E:/C#/NewProject/DynastiesandDystopia.mp3");
       int CurrentSong = 0;

       MusicPlayer.PlayMusic(Music, CurrentSong);
       
    }
}
