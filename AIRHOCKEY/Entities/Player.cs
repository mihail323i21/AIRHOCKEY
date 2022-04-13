using System.Drawing;

namespace AirHockey.Models
{
    public class Player
    {
        public int posX;
        public int posY;
        public int idleFrames;
        public int motionFrames;
        public Image player;

        public Player(int posX, int posY, Image player)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = 3;
            this.motionFrames = 10;
            this.player = player;
        }

        public void Move(int dirX, int dirY)
        {
            posX += dirX;
            posY += dirY;
        }
    }
}