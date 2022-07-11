using System.Collections.Generic;
using Raylib_cs;
using simon_says_memory.Game.Casting;


namespace simon_says_memory.Game.Services
{
    /// <summary>
    /// <para>Detects player input.</para>
    /// <para>
    /// The responsibility of a KeyboardService is to indicate whether or not a key is up or down.
    /// </para>
    /// </summary>
    public class KeyboardService
    {
        private Dictionary<string, KeyboardKey> keys
                = new Dictionary<string, KeyboardKey>();

        /// <summary>
        /// Constructs a new instance of KeyboardService using the given cell size.
        /// </summary>
        public KeyboardService()
        {
            keys["Space"] = KeyboardKey.KEY_SPACE;
            keys["1"] = KeyboardKey.KEY_KP_1;
            keys["2"] = KeyboardKey.KEY_KP_2;
            keys["3"] = KeyboardKey.KEY_KP_3;
            keys["4"] = KeyboardKey.KEY_KP_4;
            keys["5"] = KeyboardKey.KEY_KP_5;
            keys["6"] = KeyboardKey.KEY_KP_6;
            keys["7"] = KeyboardKey.KEY_KP_7;
            keys["8"] = KeyboardKey.KEY_KP_8;
            keys["9"] = KeyboardKey.KEY_KP_9;
        }

        /// <summary>
        /// Checks if the given key is currently down.
        /// </summary>
        /// <param name="key">The given key (Space or 1-9)</param>
        /// <returns>True if the given key is down; false if otherwise.</returns>
        public bool IsKeyDown(string key)
        {
            KeyboardKey raylibKey = keys[key.ToLower()];
            return Raylib.IsKeyDown(raylibKey);
        }

        /// <summary>
        /// Checks if the given key is currently up.
        /// </summary>
        /// <param name="key">The given key (Space or 1-9)</param>
        /// <returns>True if the given key is up; false if otherwise.</returns>
        public bool IsKeyUp(string key)
        {
            KeyboardKey raylibKey = keys[key.ToLower()];
            return Raylib.IsKeyUp(raylibKey);
        }

    }
}