using System;
using simon_says_memory.Game.Directing;
using simon_says_memory.Game.Services;
using simon_says_memory.Game.Casting;
using simon_says_memory.Game.Scripting;

namespace simon_says_memory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the services
            RaylibServiceFactory serviceFactory = new RaylibServiceFactory();

            Cast cast = new Cast();
            Script script = new Script();
            //add the shapes to the cast

            // start the game
            Director director = new Director(serviceFactory);
            director.StartGame(cast, script);
        }
    }
}