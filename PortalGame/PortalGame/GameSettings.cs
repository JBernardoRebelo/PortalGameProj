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
            // Go through array, get the information needed to start program
            for (int i = 0; i < args.Length; i++)
            {
                // Get rows
                if (args[i] == "-r")
                {
                    // Convert string to int
                    Rows = TryConversion(args[i + 1]);
                }
                // Get collumns
                if (args[i] == "-c")
                {
                    Colls = TryConversion(args[i + 1]);
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
                Rows = TryConversion(Console.ReadLine());
            }
            // User inserts number of columns
            if (Colls <= 0)
            {
                rndr.InsertDimensions(Colls, "col");
                Colls = TryConversion(Console.ReadLine());
            }
        }

        /// <summary>
        /// Check console arguments' length, returns bool
        /// </summary>
        /// <param name="args"> Accepts array of strings args</param>
        public bool ArgLengthCheck(string[] args)
        {
            // Start through console
            if (args.Length > 4) return true;
            else return false;
        }

        /// <summary>
        /// Accepts given dimensions annd accepts 
        /// </summary>
        /// <param name="rows"> Accepts number of rows </param>
        /// <param name="coll"> Accepts number of collumns </param>
        private void CheckInput(int rows, int coll)
        {
            if (rows <= 1 || coll <= 1)
            {
                rndr.ErrorMessage();
            }
        }

        /// <summary>
        /// Method to use try catch
        /// </summary>
        /// <param name="s"> Accepts a string </param>
        /// <returns> Returns converted string to int </returns>
        private int TryConversion(string s)
        {
            int i;

            // Convert s to int, assign i to default if program crashes
            try { i = Convert.ToInt32(s); }
            catch { i = default; }

            return i;
        }
    }
}
