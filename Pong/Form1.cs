using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        const int movementSpeed = 3;
        bool isUpPressed, isDownPressed;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isUpPressed)
            {
                paddleLeft.Location = new Point(paddleLeft.Location.X, paddleLeft.Location.Y - movementSpeed);
            } 
            if (isDownPressed)
            {
                paddleLeft.Location = new Point(paddleLeft.Location.X, paddleLeft.Location.Y + movementSpeed);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                isUpPressed = true;
            } else if (e.KeyCode == Keys.Down)
              {
                isDownPressed = true;
              }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                isUpPressed = false;
            }
        }
    }
}
