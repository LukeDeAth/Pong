namespace Pong
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paddleLeft = new System.Windows.Forms.PictureBox();
            this.paddleRight = new System.Windows.Forms.PictureBox();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
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
            this.aBall.Location = new System.Drawing.Point(553, 364);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(22, 22);
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1144, 726);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.paddleRight);
            this.Controls.Add(this.paddleLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.paddleLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddleRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox paddleLeft;
        private System.Windows.Forms.PictureBox paddleRight;
        private System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.Timer Timer;
    }
}

