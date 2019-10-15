﻿using System;

namespace PortalGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Instantiate classes
            GameSettings gs = new GameSettings();
            Render rndr = new Render();
            GameManager gm = new GameManager();

            Console.WriteLine("Hellooooo"); // Debug

            // Define dimensions of map
            gs.DefDimmensions(args);

            // While dimensions are invalid ask for new ones
            while (gs.Rows <= 0 || gs.Colls <= 0 ||
                gs.Rows <= 0 && gs.Colls <= 0)
            {
                // Ask new dimensions and proceed with game
                gs.StartWithInvalidInput();
            }


            //############################################

            Console.WriteLine("Number of rows: " + gs.Rows);
            Console.WriteLine("Number of columns: " + gs.Colls);


            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            // Game manager gets coordenates given and starts game
            gm.StartGame(gs.Rows, gs.Colls);
        }
    }
}
