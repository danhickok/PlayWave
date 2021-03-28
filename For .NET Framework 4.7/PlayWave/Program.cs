using System;
using System.Media;

namespace PlayWave
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No .WAV file given");
                return;
            }

            try
            {
                using (var player = new SoundPlayer())
                {
                    player.SoundLocation = args[0];
                    player.PlaySync();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
