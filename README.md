# MusicPlayer
Music Player Console Application (C#)

This project is a simple music player application built with C# using the NAudio library for audio playback. It allows users to play, pause, skip, and go back through a list of MP3 files directly from the console.

Features:
Play/Pause: Toggle between play and pause states using the spacebar.
Next Song: Skip to the next song in the list by pressing the "N" key.
Previous Song: Go back to the previous song by pressing the "P" key.
Exit: Close the application with the Escape key.
How It Works:
The application loads a list of music files and starts playing the first song.
The user can control playback using keyboard shortcuts:
Spacebar: Toggle play/pause.
N: Play the next song.
P: Play the previous song.
Escape: Exit the application.
The music is played using the NAudio library’s WaveOutEvent and AudioFileReader classes.
Requirements:
.NET (Core or Framework)
NAudio library (for handling audio playback)
