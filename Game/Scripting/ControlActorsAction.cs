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
        private KeyboardService keyboardService;


        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public ControlActorsAction(KeyboardService keyboardService)
        {
            this.keyboardService = keyboardService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            // Space
            if (keyboardService.IsKeyDown("Space"))
            {
                    
            }

            // sprite 1
            if (keyboardService.IsKeyDown("1"))
            {

            }

            // sprite 2
            if (keyboardService.IsKeyDown("2"))
            {

            }

            // sprite 3
            if (keyboardService.IsKeyDown("3"))
            {

            }

            //sprite 4
             if (keyboardService.IsKeyDown("4"))
            {

            }

            // sprite 5
            if (keyboardService.IsKeyDown("5"))
            {
               
            }

            // sprite 6
            if (keyboardService.IsKeyDown("6"))
            {
                
            }

            // sprite 7
            if (keyboardService.IsKeyDown("7"))
            {

            }

            // sprite 8
            if (keyboardService.IsKeyDown("8"))
            {

            }

            // sprite 9
            if (keyboardService.IsKeyDown("9"))
            {

            }
            
            
        }

    }
}