using System;
using System.Collections.Generic;

namespace PortalGame
{
    /// <summary>
    /// Runs game
    /// </summary>
    public class GameManager
    {
        // Instantiate objects, class level
        Render render = new Render();
        RenderMap rMap = new RenderMap();
        Random rnd = new Random();

        /// <summary>
        /// Constructor
        /// </summary>
        public GameManager()
        {

        }

        /// <summary>
        /// Starts game with coordenates given
        /// </summary>
        /// <param name="row"> Accepts nº of rows </param>
        /// <param name="col"> Accepts nº of collumns </param>
        public void StartGame(int row, int col)
        {
            // Instantiate list of IMapcomponent
            List<MapComponent> mapComps = new List<MapComponent>();

            // Instantiate objects (walls, turrets and exit)

            // Instantiate Player
            // Random spawn - must be oposite side of exit

            // Call loop
            GameManager.Loop(row, col, Player player, mapComps);
        }

        // Runs gameloop
        private void Loop(int row, int col, Player player, List<MapComponent> mapComps)
        {
            foreach(MapComponent mc in mapComps)
            {
                // Print grid
                // Place components
            }
        }

        // Test
        private int LvlPos(int x, int y)
        {
            return rnd.Next();
        }
    }
}
