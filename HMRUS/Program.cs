using System;
using HMRUS.Domain;
using System.Speech.Synthesis;


namespace HMRUS
{
    class Program
    {
        static void Main()
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Welcome to horrormovies are us!");
            Menu menu = new Menu();
            menu.MainMenu();
        }
    }
}
