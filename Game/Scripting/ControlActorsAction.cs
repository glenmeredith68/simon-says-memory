using simon_says_memory.Game.Casting;
using simon_says_memory.Game.Services;


namespace simon_says_memory.Game.Scripting
{
    /// <summary>
    /// <para>An input action that controls the snake.</para>
    /// <para>
    /// The responsibility of ControlActorsAction is to get the direction and move the snake's head.
    /// </para>
    /// </summary>
    public class ControlActorsAction : Action
    {
        private RaylibKeyboardService keyboardService;


        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(RaylibKeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // Space
            if (keyboardService.IsKeyDown(KeyboardKey.Space))
            {
                //start or restart game
            }

            // sprite 1
            if (keyboardService.IsKeyDown(KeyboardKey.One))
            {
                //select
            }

            // sprite 2
            if (keyboardService.IsKeyDown(KeyboardKey.Two))
            {

            }

            // sprite 3
            if (keyboardService.IsKeyDown(KeyboardKey.Three))
            {

            }

            //sprite 4
             if (keyboardService.IsKeyDown(KeyboardKey.Four))
            {

            }

            // sprite 5
            if (keyboardService.IsKeyDown(KeyboardKey.Five))
            {
               
            }
            
            
        }

    }
}