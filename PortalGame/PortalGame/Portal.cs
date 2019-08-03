using System;

namespace PortalGame
{
    public class Portal : MapComponent
    {
        /// <summary>
        /// Defines color of portal
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Portal constructor
        /// Accepts a color and position in X and Y
        /// </summary>
        /// <param name="color"> Define color </param>
        /// <param name="x"> Define Xpos </param>
        /// <param name="y"> Define Ypos </param>
        public Portal(Color color, int x, int y)
        {
            // Initialize position and portal's color
            Ypos = y;
            Xpos = x;
            Color = color;
        }

        /// <summary>
        /// Output portal char with respective color
        /// </summary>
        /// <param name="portal"></param>
        /// <returns></returns>
        public char PrintPart(Portal portal)
        {
            // Orange portal print
            if (portal.Color == Color.Orange)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return 'O';
            }
            // Blue portal
            else if (portal.Color == Color.Blue)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                return 'O';
            }
            else
            {
                return ' ';
            }
        }
    }
}
