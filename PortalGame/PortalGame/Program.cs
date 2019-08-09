using System;

namespace PortalGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Instantiate classes
            Render rndr = new Render();
            GameSettings gs = new GameSettings();
            GameManager gm = new GameManager();

            Console.WriteLine("Hellooooo"); // Debug

            // Start through console
            if (args.Length > 4)
            {
                // Get map dimensions from console
                gs.DefDimmensions(args);
            }

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

            //############################################

            Console.WriteLine("Number of rows: "+ gs.Rows);
            Console.WriteLine("Number of columns: "+ gs.Colls);


            //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

            // Game manager gets coordenates given

        }
    }
}
