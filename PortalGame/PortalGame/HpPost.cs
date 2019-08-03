
namespace PortalGame
{
    public class HpPost : MapComponent
    {
        /// <summary>
        /// HP post offers
        /// </summary>
        public int HP { get; set; }

        public HpPost(int hp)
        {
            // Set hp
            HP = hp;
        }
    }
}
