namespace Pong
{
    partial class PongForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PongForm));
            this.paddleLeft = new System.Windows.Forms.PictureBox();
            this.paddleRight = new System.Windows.Forms.PictureBox();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paddleLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            this.SuspendLayout();
            // 
            // paddleLeft
            // 
            this.paddleLeft.Image = ((System.Drawing.Image)(resources.GetObject("paddleLeft.Image")));
            this.paddleLeft.Location = new System.Drawing.Point(12, 273);
            this.paddleLeft.Name = "paddleLeft";
            this.paddleLeft.Size = new System.Drawing.Size(22, 202);
            this.paddleLeft.TabIndex = 0;
            this.paddleLeft.TabStop = false;
            // 
            // paddleRight
            // 
            this.paddleRight.Image = ((System.Drawing.Image)(resources.GetObject("paddleRight.Image")));
            this.paddleRight.Location = new System.Drawing.Point(1110, 273);
            this.paddleRight.Name = "paddleRight";
            this.paddleRight.Size = new System.Drawing.Size(22, 202);
            this.paddleRight.TabIndex = 1;
            this.paddleRight.TabStop = false;
            // 
            // aBall
            // 
            this.aBall.Image = ((System.Drawing.Image)(resources.GetObject("aBall.Image")));
            this.aBall.Location = new System.Drawing.Point(540, 364);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(22, 22);
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            this.aBall.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(487, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayer2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPlayer2.Location = new System.Drawing.Point(469, 47);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(45, 51);
            this.labelPlayer2.TabIndex = 4;
            this.labelPlayer2.Text = "0";
            this.labelPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayer1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPlayer1.Location = new System.Drawing.Point(588, 47);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(45, 51);
            this.labelPlayer1.TabIndex = 5;
            this.labelPlayer1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(531, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 51);
            this.label4.TabIndex = 6;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1144, 726);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.paddleRight);
            this.Controls.Add(this.paddleLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PongForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.paddleLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paddleLeft;
        private System.Windows.Forms.PictureBox paddleRight;
        private System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlayer2;
        private System.Windows.Forms.Label labelPlayer1;
        private System.Windows.Forms.Label label4;
    }
}

