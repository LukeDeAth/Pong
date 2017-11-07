using System;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
     public class Player
    {
        const int movementSpeed = 3;

        public bool isUpPressed, isDownPressed;

        PictureBox paddle;
        bool? wasGoingUpLastTick;
        int numberOfTicksGoingInTheSameDirection;

        public Player(PictureBox paddleLeft)
        {
            this.paddle = paddleLeft;
        }

        internal void ProcessMove()
        {
            bool? goingUp = null;//NULL is an option
            if (isUpPressed)
            {
                goingUp = true;
            }
            if (isDownPressed)
            {
                if (goingUp.HasValue)
                {
                    goingUp = null;
                }
                else
                {
                    goingUp = false;
                }
            }
            if (wasGoingUpLastTick.HasValue)
            {
                if (!goingUp.HasValue)
                {
                    wasGoingUpLastTick = null;
                    numberOfTicksGoingInTheSameDirection = 0;
                }
                else if (wasGoingUpLastTick.Value == goingUp.Value)
                {
                    numberOfTicksGoingInTheSameDirection++;
                }
                else
                {
                    wasGoingUpLastTick = goingUp;
                    numberOfTicksGoingInTheSameDirection = 1;
                }
            }
            else if (goingUp.HasValue)
            {
                wasGoingUpLastTick = goingUp;
                numberOfTicksGoingInTheSameDirection = 1;
            }

            DoMove(goingUp);
        }

        private void DoMove(bool? goingUp)
        {
            if (goingUp.HasValue)
            {
                var speed = (int)(movementSpeed * ((float)numberOfTicksGoingInTheSameDirection / 3));
                if (goingUp.Value)
                {
                    speed *= -1;
                }
                paddle.Location = new Point(paddle.Location.X,
                    Math.Max(GameBorders.topborder,
                        Math.Min(GameBorders.bottomborder - paddle.Height, paddle.Location.Y + speed))
                    );
            }
        }
    }
}
