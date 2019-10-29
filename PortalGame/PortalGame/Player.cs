using System.Numerics;

namespace PortalGame
{
    /// <summary>
    /// Player, all properties
    /// </summary>
    public class Player : Entity
    {
        /// <summary>
        /// Player HP
        /// </summary>
        public override int HP { get; set; }

        /// <summary>
        /// Defines player's position
        /// </summary>
        public override Vector2 Position { get; set; }

        /// <summary>
        /// Orange portal possession
        /// </summary>
        public bool OrPortal { get; set; }

        /// <summary>
        /// Blue portal possession
        /// </summary>
        public bool BluePortal { get; set; }

        /// <summary>
        /// Set maxHp
        /// </summary>
        private static int maxHP = 100;

        public Player(int x, int y)
        {
            // Initialize hp
            HP = maxHP;

            // Initialize position
            Position = new Vector2(x, y);

            // Initialize portals' possession as true
            OrPortal = true;
            BluePortal = true;
        }

        /// <summary>
        /// Return apropriate char, represent component
        /// </summary>
        /// <returns></returns>
        public override char PrintPart() => 'P';
    }
}
