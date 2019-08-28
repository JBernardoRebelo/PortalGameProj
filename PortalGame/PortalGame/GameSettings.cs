using System;

namespace PortalGame
{
    /// <summary>
    /// Set initial game
    /// </summary>
    public class GameSettings
    {
        // Instantiate Render
        private Render rndr = new Render();

        /// <summary>
        /// Set rows of game
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// Set collumns of game
        /// </summary>
        public int Colls { get; set; }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public GameSettings()
        {

        }

        /// <summary>
        /// Define dimensions of map, accepts args
        /// </summary>
        /// <param name="args"> Accepts array of strings from prompt</param>
        public void DefDimmensions(string[] args)
        {
            // Run through all console arguments...
            for (int i = 0; i < args.Length; i++)
            {
                // args[i] is "-r", assign next index argument value
                if (args[i] == "-r")
                {
                    //if (!int.TryParse(args[i + 1], out int x))
                    //{
                    //    rndr.ErrorMessage();
                    //}
                    Rows = Convert.ToInt32(args[i + 1]);
                }
                else
                {
                    rndr.ErrorMessage();
                }

                // args[i] is "-c", assign next index argument value
                if (args[i] == "-c")
                {
                    //if (!int.TryParse(args[i + 1], out int x))
                    //{
                    //    rndr.ErrorMessage();
                    //}
                    Colls = Convert.ToInt32(args[i + 1]);
                }
                else
                {
                    rndr.ErrorMessage();
                }
            }

            // Check if array lenght is valid
            CheckInput(Rows, Colls);
        }

        /// <summary>
        /// Checks if there's invalid input
        /// If there is, ask user for new dimensions
        /// </summary>
        public void StartWithInvalidInput()
        {
            // Start game through vs
            // User inserts number of rows
            if (Rows <= 0)
            {
                rndr.InsertDimensions(Rows, "row");
                Rows = Convert.ToInt32(Console.ReadLine());
            }
            // User inserts number of columns
            if (Colls <= 0)
            {
                rndr.InsertDimensions(Colls, "col");
                Colls = Convert.ToInt32(Console.ReadLine());
            }
        }

        /// <summary>
        /// Accepts given dimensions annd accepts 
        /// </summary>
        /// <param name="rows"> Accepts number of rows </param>
        /// <param name="coll"> Accepts number of collumns </param>
        private void CheckInput(int rows, int coll)
        {
            if (rows == 0 || rows == 1 || coll == 0 || coll == 1)
            {
                rndr.ErrorMessage();
                Environment.Exit(0);
            }
        }
    }
}
