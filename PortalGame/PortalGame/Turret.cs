
namespace PortalGame
{
    public class Turret : MapComponent
    {
        /// <summary>
        /// Max damage of turret
        /// </summary>
        public int Maxdamage { get; set; }

        public Turret()
        {

        }


        /// <summary>
        /// Return apropriate char, represent component
        /// </summary>
        /// <returns></returns>
        public new char PrintPart() => 'T';
    }
}
