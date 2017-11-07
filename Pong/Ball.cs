using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    public class Ball
    {
        private PictureBox ballPictureBox, ballModel;
        PongForm form;
        Random rand = new Random();
        Player leftsidePlayer, rightsidePlayer;
        int xSpeed, ySpeed;

        public Ball(PongForm form, PictureBox aBallModel, Player leftsidePlayer, Player rightsidePlayer)
        {
            ballModel = aBallModel;
            this.ballPictureBox = new PictureBox();
            this.ballPictureBox.Image = aBallModel.Image;
            this.ballPictureBox.Visible = true;
            this.ballPictureBox.Size = aBallModel.Size;
            form.Controls.Add(ballPictureBox);
            this.form = form;
            this.leftsidePlayer = leftsidePlayer;
            this.rightsidePlayer = rightsidePlayer; 
            ResetBall();
        }

        internal bool ProcessMove()
        {
            DoMove();
            var bottom = GameBorders.bottomBorder - ballPictureBox.Height;

            if (ballPictureBox.Location.Y >= bottom || ballPictureBox.Location.Y <= GameBorders.topBorder)
            {
                ySpeed *= -1;
            }

            if (ballPictureBox.Location.X <= GameBorders.leftBorder)
            {
                Score(leftsidePlayer);
                return true;
            }
            else if (ballPictureBox.Location.X >= GameBorders.rightBorder - ballPictureBox.Width)
            {
                Score(rightsidePlayer);
                return true;
            }

            if (leftsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds)
                || rightsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds))
            {
                xSpeed *= -1;
                //ySpeed *= 2;

                form.ballList.Add(new Ball(form, ballModel, leftsidePlayer, rightsidePlayer));

                while (leftsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds)
                        || rightsidePlayer.paddle.Bounds.IntersectsWith(ballPictureBox.Bounds))
                {
                    DoMove();
                }
            }
            return false;
        }

        private int DoMove()
        {
            var bottom = GameBorders.bottomBorder - ballPictureBox.Height;
            ballPictureBox.Location = new Point(ballPictureBox.Location.X + xSpeed,
                Math.Max(GameBorders.topBorder, Math.Min(bottom, ballPictureBox.Location.Y + ySpeed)));
            return bottom;
        }

        private void Score(Player winningPlayer)
        {
            winningPlayer.score++;
            form.Controls.Remove(ballPictureBox);
        }

        private void ResetBall()
        {
            ballPictureBox.Location = new Point((GameBorders.leftBorder + GameBorders.rightBorder) / 2,
                            (GameBorders.topBorder + GameBorders.bottomBorder) / 2);
            do
            {
                xSpeed = rand.Next(-3, 3);
                ySpeed = rand.Next(-3, 3);
            } while (Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 1 || Math.Abs(xSpeed) <= 1);
        }
    }
}
