using System;
using simon_says_memory.Game.Casting;
using Microsoft.VisualBasic;

namespace simon_says_memory
{
    public class Sprites
    {
        // chair
        public static string sprite1 = 'https://www.spritecatalog.com/sprite/d0wj2k.png';

        // bookshelf
        public static string sprite2 = 'https://www.spritecatalog.com/sprite/y3rhp5.png';

        // window
        public static string3 = 'https://www.spritecatalog.com/sprite/9dtys7.png';
        
        public static int MAX_X = 900;
        public static int MAX_Y = 600;

        public static int FRAME_RATE = 15;
        public static int FONT_SIZE = 15;
        public static string CAPTION = "Simon Says";

        public static Color RED = new Color(255, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color YELLOW = new Color(255, 255, 0);
        public static Color GREEN = new Color(0, 255, 0);

    }
}