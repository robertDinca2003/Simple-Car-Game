namespace CarRacer
{
    partial class Game
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
            this.timerCloack = new System.Windows.Forms.Timer(this.components);
            this.rightBorder = new System.Windows.Forms.PictureBox();
            this.leftBorder = new System.Windows.Forms.PictureBox();
            this.GameName = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.BestScoreLabel = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorder)).BeginInit();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerCloack
            // 
            this.timerCloack.Tick += new System.EventHandler(this.timerCloack_Tick);
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.White;
            this.rightBorder.Location = new System.Drawing.Point(1000, 1);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(15, 1877);
            this.rightBorder.TabIndex = 3;
            this.rightBorder.TabStop = false;
            this.rightBorder.Visible = false;
            // 
            // leftBorder
            // 
            this.leftBorder.BackColor = System.Drawing.Color.White;
            this.leftBorder.Location = new System.Drawing.Point(34, 1);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(15, 1877);
            this.leftBorder.TabIndex = 4;
            this.leftBorder.TabStop = false;
            this.leftBorder.Visible = false;
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.BackColor = System.Drawing.Color.Red;
            this.GameName.Font = new System.Drawing.Font("Montserrat Black", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameName.ForeColor = System.Drawing.Color.Gold;
            this.GameName.Location = new System.Drawing.Point(60, 148);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(839, 199);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "Car Racer";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Red;
            this.btnStartGame.Font = new System.Drawing.Font("Montserrat Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.ForeColor = System.Drawing.Color.Gold;
            this.btnStartGame.Location = new System.Drawing.Point(261, 627);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(421, 103);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // BestScoreLabel
            // 
            this.BestScoreLabel.AutoSize = true;
            this.BestScoreLabel.Font = new System.Drawing.Font("Montserrat Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestScoreLabel.ForeColor = System.Drawing.Color.Gold;
            this.BestScoreLabel.Location = new System.Drawing.Point(94, 912);
            this.BestScoreLabel.Name = "BestScoreLabel";
            this.BestScoreLabel.Size = new System.Drawing.Size(296, 61);
            this.BestScoreLabel.TabIndex = 2;
            this.BestScoreLabel.Text = "Best Score:";
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.label3);
            this.panelGame.Controls.Add(this.btn_back);
            this.panelGame.Controls.Add(this.label2);
            this.panelGame.Controls.Add(this.BestScoreLabel);
            this.panelGame.Controls.Add(this.btnStartGame);
            this.panelGame.Controls.Add(this.GameName);
            this.panelGame.Location = new System.Drawing.Point(48, 1);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(946, 1500);
            this.panelGame.TabIndex = 5;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Red;
            this.btn_back.Enabled = false;
            this.btn_back.Font = new System.Drawing.Font("Montserrat Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Gold;
            this.btn_back.Location = new System.Drawing.Point(261, 736);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(421, 103);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back To Meniu";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(32, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current Score: ";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(157, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(584, 99);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Score";
            this.label3.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1058, 1444);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.rightBorder);
            this.MaximumSize = new System.Drawing.Size(1080, 1500);
            this.MinimumSize = new System.Drawing.Size(1080, 1500);
            this.Name = "Game";
            this.Text = "CarRacer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.rightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftBorder)).EndInit();
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerCloack;
        private System.Windows.Forms.PictureBox rightBorder;
        private System.Windows.Forms.PictureBox leftBorder;
        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label BestScoreLabel;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label3;
    }
}

