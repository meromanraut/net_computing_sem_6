using System;

interface ICamera
{
    void TakePhoto();
}

interface IMusicPlayer
{
    void PlayMusic();
}

class SmartPhone : ICamera, IMusicPlayer
{
    public void TakePhoto()
    {
        Console.WriteLine("Photo taken successfully.");
    }

    public void PlayMusic()
    {
        Console.WriteLine("Music is playing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        SmartPhone phone = new SmartPhone();

        phone.TakePhoto();
        phone.PlayMusic();
    }
}