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
        Player player1, player2;
        Ball ball;

        public Form1()
        {
            InitializeComponent();
            player1 = new Player(paddleLeft);
            player2 = new Player(paddleRight);
            ball = new Ball(aBall);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player1.ProcessMove();
            player2.ProcessMove();
            ball.ProcessMove();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKeys(e, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKeys(e, false);
        }

        private void CheckKeys(KeyEventArgs e, bool isDown)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player1.isUpPressed = isDown;
                    break;
                case Keys.S:
                    player1.isDownPressed = isDown;
                    break; 

                case Keys.Up:
                    player2.isUpPressed = isDown;
                    break;
                case Keys.Down:
                    player2.isDownPressed = isDown;
                    break;
            }
        }

    }
}
