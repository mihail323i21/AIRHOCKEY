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
        private Image RedPlayerSprite;
        
        public Form1()
        {
            InitializeComponent();
            Init();
            
        }

        private void Init()
        {
            RedPlayerSprite = new Bitmap("C:\\projects c#\\AIRHOCKEY\\AIRHOCKEY\\bin\\RedPlayer.png");

            var redPlayer = new Player(100, 100, RedPlayerSprite);
            Invalidate();
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            
            g.DrawImage(RedPlayerSprite, new PointF(Width / 2.65f, Height / 14f));
        }
    }
}