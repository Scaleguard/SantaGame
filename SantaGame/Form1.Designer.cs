namespace SantaGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.HouseTwo = new System.Windows.Forms.PictureBox();
            this.House = new System.Windows.Forms.PictureBox();
            this.Tree = new System.Windows.Forms.PictureBox();
            this.Moon = new System.Windows.Forms.PictureBox();
            this.Snowflake = new System.Windows.Forms.PictureBox();
            this.Santa = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.playAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HouseTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.House)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snowflake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-2, 392);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(474, 101);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // HouseTwo
            // 
            this.HouseTwo.Image = ((System.Drawing.Image)(resources.GetObject("HouseTwo.Image")));
            this.HouseTwo.Location = new System.Drawing.Point(-2, 299);
            this.HouseTwo.Name = "HouseTwo";
            this.HouseTwo.Size = new System.Drawing.Size(118, 116);
            this.HouseTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HouseTwo.TabIndex = 1;
            this.HouseTwo.TabStop = false;
            // 
            // House
            // 
            this.House.Image = ((System.Drawing.Image)(resources.GetObject("House.Image")));
            this.House.Location = new System.Drawing.Point(128, 299);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(132, 116);
            this.House.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.House.TabIndex = 1;
            this.House.TabStop = false;
            // 
            // Tree
            // 
            this.Tree.Image = ((System.Drawing.Image)(resources.GetObject("Tree.Image")));
            this.Tree.Location = new System.Drawing.Point(285, 220);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(89, 174);
            this.Tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree.TabIndex = 2;
            this.Tree.TabStop = false;
            // 
            // Moon
            // 
            this.Moon.Image = ((System.Drawing.Image)(resources.GetObject("Moon.Image")));
            this.Moon.Location = new System.Drawing.Point(-2, -2);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(111, 85);
            this.Moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Moon.TabIndex = 3;
            this.Moon.TabStop = false;
            // 
            // Snowflake
            // 
            this.Snowflake.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Snowflake.Image = ((System.Drawing.Image)(resources.GetObject("Snowflake.Image")));
            this.Snowflake.Location = new System.Drawing.Point(160, 12);
            this.Snowflake.Name = "Snowflake";
            this.Snowflake.Size = new System.Drawing.Size(100, 71);
            this.Snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Snowflake.TabIndex = 4;
            this.Snowflake.TabStop = false;
            // 
            // Santa
            // 
            this.Santa.Image = ((System.Drawing.Image)(resources.GetObject("Santa.Image")));
            this.Santa.Location = new System.Drawing.Point(9, 157);
            this.Santa.Name = "Santa";
            this.Santa.Size = new System.Drawing.Size(77, 57);
            this.Santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Santa.TabIndex = 5;
            this.Santa.TabStop = false;
            this.Santa.Click += new System.EventHandler(this.Santa_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Fancy Card Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score.Location = new System.Drawing.Point(261, 12);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(113, 58);
            this.Score.TabIndex = 6;
            this.Score.Text = "Score:";
            this.Score.Click += new System.EventHandler(this.Santa_Click);
            // 
            // playAgain
            // 
            this.playAgain.Font = new System.Drawing.Font("ONE PIECE", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playAgain.Location = new System.Drawing.Point(136, 157);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(124, 80);
            this.playAgain.TabIndex = 7;
            this.playAgain.Text = "Play Again";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 492);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Santa);
            this.Controls.Add(this.Snowflake);
            this.Controls.Add(this.Moon);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.House);
            this.Controls.Add(this.HouseTwo);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HouseTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.House)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Snowflake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox HouseTwo;
        private System.Windows.Forms.PictureBox House;
        private System.Windows.Forms.PictureBox Tree;
        private System.Windows.Forms.PictureBox Moon;
        private System.Windows.Forms.PictureBox Snowflake;
        private System.Windows.Forms.PictureBox Santa;
        private System.Windows.Forms.Timer timer1;
        
    }
}

