using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    public class Ball
    {
        private PictureBox ball;
        int xSpeed, ySpeed;

        public Ball(PictureBox aBall)
        {
            this.ball = aBall;
            xSpeed = 1;
            ySpeed = 2;
        }

        internal void ProcessMove()
        {
            var bottom = GameBorders.bottomborder - ball.Height;
            ball.Location = new Point(ball.Location.X + xSpeed, 
                Math.Max(GameBorders.topborder, Math.Min(bottom, ball.Location.Y + ySpeed)));

            if(ball.Location)
        }
    }
}
