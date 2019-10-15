
namespace PortalGame
{
    /// <summary>
    /// Player, all properties
    /// </summary>
    public class Player : IMapComponent
    {
        /// <summary>
        /// Player HP
        /// </summary>
        public int HP { get; set; }

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
            Xpos = x;
            Ypos = y;

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
