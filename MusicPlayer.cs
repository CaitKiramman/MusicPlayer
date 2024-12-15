using System;
using NAudio.Wave;
using System.IO;
using System.Dynamic;
using Microsoft.VisualBasic;

class MusicPlayer
{

    private static void ChangeSong(WaveOutEvent outputDevice , int CurrentSong, List<String> Music){
        string newSong = Music[CurrentSong];
        var NewSongFile = new AudioFileReader(newSong);
        outputDevice.Init(NewSongFile);
        outputDevice.Play();
    }
    
    public static void PlayMusic(List<String> Music, int CurrentSong)
    {
    
    string filePath = @Music.First();

    if (!System.IO.File.Exists(filePath))
    {
        Console.WriteLine("Το αρχείο ήχου δεν βρέθηκε!");
        return;
    }

    try
    {
        var audioFile = new AudioFileReader(filePath);
        var outputDevice = new WaveOutEvent();
        outputDevice.Init(audioFile);
        outputDevice.Play();

        while (true){
            var key = Console.ReadKey(intercept: true);
            switch(key.Key){
                case ConsoleKey.Spacebar:
                    if(outputDevice.PlaybackState == PlaybackState.Paused){
                        outputDevice.Play();
                    }
                    else if(outputDevice.PlaybackState == PlaybackState.Playing){
                        outputDevice.Pause();
                    }
                break;

                case ConsoleKey.N:
                    outputDevice.Dispose();
                    CurrentSong = (CurrentSong + 1) % Music.Count;
                    ChangeSong( outputDevice ,  CurrentSong, Music);
                break;

                case ConsoleKey.P:
                    outputDevice.Dispose();
                    CurrentSong = (CurrentSong -1) % Music.Count;
                    
                    try{
                        if(CurrentSong == -1){
                            Console.WriteLine(Music.Count);
                            int n=(Music.Count) -1;
                            CurrentSong=n;
                        }
                        ChangeSong(outputDevice , CurrentSong, Music);
                    }
                    catch(Exception e){
                        Console.WriteLine($"Σφάλμα: {e.Message}");
                    }
                break;

                case ConsoleKey.Escape:
                    outputDevice.Dispose();
                return;

                }

              /*    ΔΕΥΤΕΡΟΣ ΤΡΟΠΟΣ ΜΕ ΠΟΛΛΑΠΛΕΣ IF
               if(key.Key == ConsoleKey.Spacebar)
                {
                    if(outputDevice.PlaybackState == PlaybackState.Paused){
                        outputDevice.Play();
                    }
                    else if(outputDevice.PlaybackState == PlaybackState.Playing){
                        outputDevice.Pause();
                    }
                }
                else if (key.Key == ConsoleKey.Escape) { break; }
                
                  */
                   
                
            }
  
       }
        catch (Exception ex)
        {
            Console.WriteLine($"Σφάλμα: {ex.Message}");
        }
        
    }
    
}

