using System;
using System.Collections.Generic;
using System.Text;

namespace PortalGame
{
    class RenderMap : Render
    {
        /// <summary>
        /// Normalize object's position to be printed on console
        /// *REUSED CODE*
        /// </summary>
        /// <param name="x"> Object's Xpos value. </param>
        /// <param name="y"> Object's Ypos value. </param>
        /// <returns> Integer array that contains a normalized. </returns>
        private static int[] NormalizePosition(int x, int y) =>
            new int[2] { x * 4 - 2, y * 2 - 1 };

        /// <summary>
        /// Overload Accepts and draws component in map
        /// *REUSED CODE*
        /// </summary>
        /// <param name="mapComp"> Specific map component to be printed
        /// on board. </param>
        public void FillMap(MapComponent mapComp)
        {
            int[] normalizedPos = NormalizePosition(mapComp.Xpos, mapComp.Ypos);
            Console.SetCursorPosition(normalizedPos[0], normalizedPos[1]);
            Console.WriteLine(mapComp.PrintPart());
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
                Console.Write("-");
            }

            // New line
            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write("|   ");
                }

                Console.WriteLine('|');

                for (int k = 0; k < col * 4 + 1; k++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();
            }
        }
    }
}
