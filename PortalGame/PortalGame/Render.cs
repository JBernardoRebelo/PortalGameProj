
using System;
using System.Threading;
using static System.Console;

namespace PortalGame
{
    /// <summary>
    /// Outputs information to user
    /// </summary>
    public class Render
    {
        /// <summary>
        /// Case dimensions are bellow or equal to 0
        /// Accepts a number of rows and collumns
        /// </summary>
        /// <param name="rows"> Rows given </param>
        /// <param name="cols"> Collumns given</param>
        /// <returns></returns>
        public int InsertDimensions(int rows, int cols)
        {
            int row;
            int col;

            Write("Please insert number of");
            if(rows <= 0)
            {
                Write("Rows: ");
                row = Convert.ToInt32(ReadLine());
                return row;
            }
            if(cols <= 0)
            {
                Write("Collumns: ");
                col = Convert.ToInt32(ReadLine());
                return col;
            }
            else
            {
                return rows;
            }
        }
    }
}
