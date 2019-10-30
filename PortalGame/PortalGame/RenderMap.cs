using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace PortalGame
{
    public class RenderMap : Render
    { 
        /// <summary>
        /// Overload Accepts and draws component in map
        /// *REUSED CODE*
        /// </summary>
        /// <param name="mc"> Specific map component to be printed
        /// on board. </param>
        public void FillMap(MapComponent mc)
        {
            int[] normalizedPos = NormalizePosition(mc.Xpos, mc.Ypos);
            SetCursorPosition(normalizedPos[0], normalizedPos[1]);
            WriteLine(mc.PrintPart());
        }

        public void PlaceEntities(Entity entity)
        {
            // Define position
            int[] normalizedPosP = NormalizePosition
                ((int)entity.Position.X, (int)entity.Position.Y);
            SetCursorPosition(normalizedPosP[0], normalizedPosP[1]);

            // Print player char
            if(entity is Player)
            {
                Player p = entity as Player;
                WriteLine(p.PrintPart());
            }
        }

        // To print all the level's components
        public void PlaceComps(List<MapComponent> mapComp)
        {

        }

        /// <summary>
        /// Prints board, accepts args converted from console
        /// *REUSED*
        /// </summary>
        /// <param name="col"> GameSettings Collums value. </param>
        /// <param name="rows"> GameSettings Row value. </param>
        public void PrintBoard(int rows, int col)
        {
            //Console.Clear();
            // For cicle to print map
            for (int k = 0; k < col * 4 + 1; k++)
            {
                Write("~");
            }

            // New line
            WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Write("|   ");
                }

                WriteLine('|');

                for (int k = 0; k < col * 4 + 1; k++)
                {
                    Write("-");
                }
                WriteLine();
            }
        }

        /// <summary>
        /// Normalize object's position to be printed on console
        /// *REUSED CODE*
        /// </summary>
        /// <param name="x"> Object's Xpos value. </param>
        /// <param name="y"> Object's Ypos value. </param>
        /// <returns> Integer array that contains a normalized. </returns>
        private static int[] NormalizePosition(int x, int y)
        {
            return new int[2] { x * 4 - 2, y * 2 - 1 };
        }
    }
}
