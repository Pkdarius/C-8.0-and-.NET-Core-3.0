using static System.Console;
namespace PacktLibrary
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            WriteLine("DVD player is pausing.");
        }
        public void Play()
        {
            WriteLine("DVD player is playing.");
        }
    }
}