using System;
using System.Collections.Generic;
using System.Numerics;

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
            Player player;

            // Instantiate list of Mapcomponent
            List<MapComponent> mapComps = new List<MapComponent>();
            Wall wall = new Wall(RetRand(0, row), col);

            // Instantiate objects (walls, turrets and exit)
            mapComps.Add(wall);

            // Instantiate Player in collum 0 and random row
            player = new Player(RetRand(0, row), 0);

            // Random spawn - must be oposite side of exit

            // Call loop
            Loop(row, col, player, mapComps);
        }

        // Runs gameloop
        private void Loop
            (int row, int col, Player player, List<MapComponent> mapComps)
        {
            // While player is alive runs
            while (player.HP > 90)
            {
                Console.Clear();
                // Print board
                rMap.PrintBoard(col, row);

                // Place Components - fills map
                foreach (MapComponent mc in mapComps)
                {
                    rMap.FillMap(mc);
                }

                rMap.PlaceComps(mapComps);

                player.HP--;
            }
        }

        /// <param name="x"> Minimum number </param>
        /// <param name="y"> Maximum number </param>
        /// <returns> Number beetween the given params </returns>
        private int RetRand(int x, int y)
        {
            return rnd.Next(x, y);
        }
    }
}
