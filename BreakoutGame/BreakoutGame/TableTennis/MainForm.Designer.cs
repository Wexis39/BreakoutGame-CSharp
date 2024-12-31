namespace TableTennis
{
    partial class MainForm
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
            this.pnlLeftWall = new System.Windows.Forms.Panel();
            this.pnlRightWall = new System.Windows.Forms.Panel();
            this.pnlUpWall = new System.Windows.Forms.Panel();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.tmrBallMovement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftWall
            // 
            this.pnlLeftWall.BackColor = System.Drawing.Color.Black;
            this.pnlLeftWall.Location = new System.Drawing.Point(39, 71);
            this.pnlLeftWall.Name = "pnlLeftWall";
            this.pnlLeftWall.Size = new System.Drawing.Size(13, 507);
            this.pnlLeftWall.TabIndex = 0;
            // 
            // pnlRightWall
            // 
            this.pnlRightWall.BackColor = System.Drawing.Color.Black;
            this.pnlRightWall.Location = new System.Drawing.Point(784, 71);
            this.pnlRightWall.Name = "pnlRightWall";
            this.pnlRightWall.Size = new System.Drawing.Size(13, 507);
            this.pnlRightWall.TabIndex = 0;
            // 
            // pnlUpWall
            // 
            this.pnlUpWall.BackColor = System.Drawing.Color.Black;
            this.pnlUpWall.Location = new System.Drawing.Point(39, 62);
            this.pnlUpWall.Name = "pnlUpWall";
            this.pnlUpWall.Size = new System.Drawing.Size(758, 12);
            this.pnlUpWall.TabIndex = 0;
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.Blue;
            this.pnlPlayer.Location = new System.Drawing.Point(364, 530);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(102, 21);
            this.pnlPlayer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "SCORE :";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbScore.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbScore.Location = new System.Drawing.Point(154, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(35, 40);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "0";
            // 
            // Ball
            // 
            this.Ball.BackgroundImage = global::TableTennis.Properties.Resources.Ball;
            this.Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ball.Location = new System.Drawing.Point(399, 349);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(30, 30);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 3;
            this.Ball.TabStop = false;
            // 
            // tmrBallMovement
            // 
            this.tmrBallMovement.Enabled = true;
            this.tmrBallMovement.Interval = 25;
            this.tmrBallMovement.Tick += new System.EventHandler(this.tmrBallMovement_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(832, 636);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.pnlRightWall);
            this.Controls.Add(this.pnlUpWall);
            this.Controls.Add(this.pnlLeftWall);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BreakoutGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftWall;
        private System.Windows.Forms.Panel pnlRightWall;
        private System.Windows.Forms.Panel pnlUpWall;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer tmrBallMovement;
    }
}

