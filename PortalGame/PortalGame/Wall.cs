using System;
using System.Collections.Generic;
using System.Text;

namespace PortalGame
{
    public class Wall : MapComponent
    {
        public Wall (int x, int y)
        {
            Xpos = x;
            Ypos = y;
        }

        /// <summary>
        /// Return apropriate char, represent component
        /// </summary>
        /// <returns></returns>
        public override char PrintPart() => 'W';
    }
}
