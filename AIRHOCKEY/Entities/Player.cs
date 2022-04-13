using System.Drawing;

namespace AirHockey.Models
{
    public class Player
    {
        public int posX;
        public int posY;

        public int idleFrames;
        public int motionFrames;
        
        public Image redPlayer;

        public Player(int posX, int posY, int idleFrames, int motionFrames, Image redPlayer)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.motionFrames = motionFrames;
            this.redPlayer = redPlayer;
        }

        public void Move(int dirX, int dirY)
        {
            posX += dirX;
            posY += dirY;
        }
    }
}