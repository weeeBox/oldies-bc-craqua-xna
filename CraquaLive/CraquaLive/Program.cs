using System;

namespace CraquaLive
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (CraquaGame game = new CraquaGame())
            {
                game.Run();
            }
        }
    }
#endif
}

