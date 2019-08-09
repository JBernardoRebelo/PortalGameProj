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
        public int Rows{ get; set; }

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
        public void DefDimmensions(string[]args)
        {
            // Run through all console arguments...
            for (int i = 0; i < args.Length; i++)
            {
                // args[i] is "-r", assign next index argument value
                if (args[i] == "-r")
                {
                    if (!int.TryParse(args[i + 1], out int x))
                    {
                        rndr.ErrorMessage();
                    }

                    Rows = Convert.ToInt32(args[i + 1]);
                }

                // args[i] is "-c", assign next index argument value
                if (args[i] == "-c")
                {
                    if (!int.TryParse(args[i + 1], out int x))
                    {
                        rndr.ErrorMessage();
                    }

                    Colls = Convert.ToInt32(args[i + 1]);
                }
            }

            // Check if array lenght is valid
            CheckInput(Rows, Colls);
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
