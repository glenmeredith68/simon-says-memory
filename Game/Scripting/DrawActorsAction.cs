using System.Collections.Generic;
using simon_says_memory.Game.Casting;
using simon_says_memory.Game.Services;


namespace simon_says_memory.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            //call each sprite
            
            
            videoService.ClearBuffer();
            //use DrawActors here
            videoService.FlushBuffer();
        }
    }
}