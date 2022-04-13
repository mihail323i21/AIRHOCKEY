using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AirHockey.Models;

namespace AirHockey
{
    public partial class Form1 : Form
    {
        public void InitializeComponent()
        {
            this.Text = "AirHockey";
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.BackColor = Color.Aqua;
        }
    }
}