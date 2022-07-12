using System.Collections.Generic;
using System.Numerics;
using Raylib_cs;


namespace simon_says_memory.Game.Services
{
    /// <summary>
    /// A Raylib implementation of IMouseService.
    /// </summary>
    public class RaylibMouseService : IMouseService
    {
        private Dictionary<MouseButton, Raylib_cs.MouseButton> _buttons
            = new Dictionary<MouseButton, Raylib_cs.MouseButton>() 
        {
            { MouseButton.Left, Raylib_cs.MouseButton.MOUSE_LEFT_BUTTON},
            { MouseButton.Middle, Raylib_cs.MouseButton.MOUSE_MIDDLE_BUTTON },
            { MouseButton.Right, Raylib_cs.MouseButton.MOUSE_RIGHT_BUTTON }
            // { MouseButton.Side, Raylib_cs.MouseButton.MOUSE_BUTTON_SIDE }
        };

        public RaylibMouseService()
        {
        }

        public Vector2 GetCoordinates()
        {
            float x = (float)Raylib.GetMouseX();
            float y = (float)Raylib.GetMouseY();
            return new Vector2(x, y);
        }

        public bool IsButtonDown(MouseButton button)
        {
            Raylib_cs.MouseButton raylibButton = _buttons[button];
            return Raylib.IsMouseButtonDown(raylibButton);
        }

        public bool IsButtonPressed(MouseButton button)
        {
            Raylib_cs.MouseButton raylibButton = _buttons[button];
            return Raylib.IsMouseButtonPressed(raylibButton);
        }

        public bool IsButtonReleased(MouseButton button)
        {
            Raylib_cs.MouseButton raylibButton = _buttons[button];
            return Raylib.IsMouseButtonReleased(raylibButton);
        }

        public bool IsButtonUp(MouseButton button)
        {
            Raylib_cs.MouseButton raylibButton = _buttons[button];
            return Raylib.IsMouseButtonUp(raylibButton);
        }
    }
}