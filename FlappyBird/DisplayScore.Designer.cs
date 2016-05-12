namespace FlappyBird
{
    partial class DisplayScore
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbTextScore = new System.Windows.Forms.Label();
            this.lbTextBest = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbBest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(25, 132);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(127, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTextScore
            // 
            this.lbTextScore.AutoSize = true;
            this.lbTextScore.Location = new System.Drawing.Point(64, 22);
            this.lbTextScore.Name = "lbTextScore";
            this.lbTextScore.Size = new System.Drawing.Size(107, 13);
            this.lbTextScore.TabIndex = 2;
            this.lbTextScore.Text = "Your current score is:";
            // 
            // lbTextBest
            // 
            this.lbTextBest.AutoSize = true;
            this.lbTextBest.Location = new System.Drawing.Point(64, 74);
            this.lbTextBest.Name = "lbTextBest";
            this.lbTextBest.Size = new System.Drawing.Size(94, 13);
            this.lbTextBest.TabIndex = 3;
            this.lbTextBest.Text = "Your best score is:";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(97, 46);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(41, 13);
            this.lbScore.TabIndex = 4;
            this.lbScore.Text = "label1";
            // 
            // lbBest
            // 
            this.lbBest.AutoSize = true;
            this.lbBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBest.Location = new System.Drawing.Point(97, 102);
            this.lbBest.Name = "lbBest";
            this.lbBest.Size = new System.Drawing.Size(41, 13);
            this.lbBest.TabIndex = 5;
            this.lbBest.Text = "label1";
            // 
            // DisplayScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 167);
            this.Controls.Add(this.lbBest);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbTextBest);
            this.Controls.Add(this.lbTextScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.MaximizeBox = false;
            this.Name = "DisplayScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTextScore;
        private System.Windows.Forms.Label lbTextBest;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Label lbBest;
    }
}