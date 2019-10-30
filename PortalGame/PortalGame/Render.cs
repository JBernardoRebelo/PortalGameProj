using System;
using System.Collections.Generic;
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
        /// Accepts a dimension and a parameter to pick
        /// </summary>
        /// <param name="dim"> Dim given </param>
        /// <param name="param"> Parameter given </param>
        /// <returns></returns>
        public void InsertDimensions(int dim, string param)
        {
            Write("Please insert number of ");
            if (dim <= 0 && param == "row")
            {
                Write("Rows: ");
            }
            else if (dim <= 0 && param == "col")
            {
                Write("Collumns: ");
            }
        }

        /// <summary>
        /// Outputs an error message
        /// </summary>
        public void ErrorMessage()
        {
            WriteLine("Your input was invalid...");
            Thread.Sleep(3000);
        }
    }
}
