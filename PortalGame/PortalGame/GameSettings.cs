
namespace PortalGame
{
    /// <summary>
    /// Set initial game
    /// </summary>
    public class GameSettings
    {
        /// <summary>
        /// Set rows of game
        /// </summary>
        public int Rows{ get; set; }

        /// <summary>
        /// Set collumns of game
        /// </summary>
        public int Cols { get; set; }

        public GameSettings(int rows, int cols)
        {
            // Assign map dimensions
            Rows = rows;
            Cols = cols;
        }
    }
}
