using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AirHockey.Models;

namespace AirHockey
{
    public partial class Form1 : Form
    {
        public new const int Width = 400;
        public new const int Height = 600;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(Width, Height);
            this.Name = "Form1";
            this.Text = "AirHockey";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);
        }
    }
}