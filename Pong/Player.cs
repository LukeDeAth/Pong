using System;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
     public class Player
    {
        const int movementSpeed = 3;

        public bool isUpPressed, isDownPressed;

        public PictureBox paddle;
        Label scoreLabel;
        bool? wasGoingUpLastTick;
        int numberOfTicksGoingInTheSameDirection;
        int _score;
        public int score
        {
            get
            {
                return _score;
            }
            set
            {
                _score = value;
                scoreLabel.Text = score.ToString();
            }
        }

        public Player(PictureBox paddleLeft, Label scoreLabel)
        {
            this.paddle = paddleLeft;
            this.scoreLabel = scoreLabel;
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
                    Math.Max(GameBorders.topBorder,
                        Math.Min(GameBorders.bottomBorder - paddle.Height, paddle.Location.Y + speed))
                    );
            }
        }
    }
}
