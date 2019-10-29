using System.Numerics;

namespace PortalGame
{
    public abstract class Entity
    {
        /// <summary>
        /// Sets position
        /// </summary>
        public abstract Vector2 Position { get; set; }

        /// <summary>
        /// Sets hit points of entity
        /// </summary>
        public abstract int HP { get; set; }

        /// <summary>
        /// Return apropriate char, represent component
        /// </summary>
        /// <returns></returns>
        public abstract char PrintPart();
    }
}
