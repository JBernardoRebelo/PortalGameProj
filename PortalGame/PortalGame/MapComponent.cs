
namespace PortalGame
{
    /// <summary>
    /// Map component, has position
    /// </summary>
    public class MapComponent
    {
        /// <summary>
        /// Player's X position
        /// </summary>
        public int Xpos { get; set; }

        /// <summary>
        /// Player's Y position
        /// </summary>
        public int Ypos { get; set; }

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public MapComponent()
        {

        }

        /// <summary>
        /// Return apropriate char, represent component
        /// </summary>
        /// <returns></returns>
        public char PrintPart() => ' ';
    }
}
