using System;

namespace PortalGame
{
    public class Program
    {
        // Instantiate classes
        Render rndr = new Render();
        GameSettings gs = new GameSettings();
        GameManager gm = new GameManager();

        private static void Main(string[] args)
        {
            // Instantiate program
            Program prog = new Program();

            Console.WriteLine("Hellooooo"); // Debug

            // Check length of args
            prog.ArgLengthCheck(args);

            // Ask new dimensions and proceed with game
            prog.StartWithInvalidInput();

            //############################################

            Console.WriteLine("Number of rows: "+ prog.gs.Rows);
            Console.WriteLine("Number of columns: "+ prog.gs.Colls);


            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            // Game manager gets coordenates given

        }

        /// <summary>
        /// Check console arguments' length
        /// </summary>
        /// <param name="args"> Accepts array of strings args</param>
        private void ArgLengthCheck(string[] args)
        {
            // Start through console
            if (args.Length > 4)
            {
                // Get map dimensions from console
                gs.DefDimmensions(args);
            }
        }

        /// <summary>
        /// Checks if there's invalid input
        /// If there is, ask user for new dimensions
        /// </summary>
        private void StartWithInvalidInput()
        {
            // Start game through vs
            // User inserts number of rows
            if (gs.Rows <= 0)
            {
                rndr.InsertDimensions(gs.Rows, "row");
                gs.Rows = Convert.ToInt32(Console.ReadLine());
            }
            // User inserts number of columns
            if (gs.Colls <= 0)
            {
                rndr.InsertDimensions(gs.Colls, "col");
                gs.Colls = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
