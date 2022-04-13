using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirHockey.Models;

namespace AirHockey
{
    public partial class Form1 : Form
    {
        public Image PlayerSprite;
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        
        public void Init()
        {
            PlayerSprite = new Bitmap("Models\\pictures\\RedPlayer.png");

            var player = new Player(100, 100, RedPlayer.idleFrames, RedPlayer.motionFrames, PlayerSprite);
            Invalidate();
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            
            g.DrawImage(PlayerSprite, new PointF(10,10));
        }
    }
}