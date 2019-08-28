using System;

namespace PortalGame
{
    public class Program
    {
        // Instantiate classes
        Render rndr = new Render();
        GameManager gm = new GameManager();

        private static void Main(string[] args)
        {
            // Instantiate classes
            GameSettings gs = new GameSettings();
            Program prog = new Program();

            Console.WriteLine("Hellooooo"); // Debug

            // Check length of args
            if(prog.ArgLengthCheck(args))
            {
                gs.DefDimmensions(args);
            }
            else
            {
                // Ask new dimensions and proceed with game
                gs.StartWithInvalidInput();
            }

            //############################################

            Console.WriteLine("Number of rows: " + gs.Rows);
            Console.WriteLine("Number of columns: " + gs.Colls);


            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            // Game manager gets coordenates given

        }

        /// <summary>
        /// Check console arguments' length
        /// </summary>
        /// <param name="args"> Accepts array of strings args</param>
        private bool ArgLengthCheck(string[] args)
        {
            // Start through console
            if (args.Length > 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
