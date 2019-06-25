namespace DartsScoreTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtbScore = new System.Windows.Forms.RichTextBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNewLeg = new System.Windows.Forms.Button();
            this.lblScoreLeft = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.lblTurnsLeft = new System.Windows.Forms.Label();
            this.lblAVGText = new System.Windows.Forms.Label();
            this.lblAVG = new System.Windows.Forms.Label();
            this.lblLegs = new System.Windows.Forms.Label();
            this.lblStanding = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbScore
            // 
            this.rtbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbScore.Location = new System.Drawing.Point(27, 69);
            this.rtbScore.Margin = new System.Windows.Forms.Padding(4);
            this.rtbScore.Name = "rtbScore";
            this.rtbScore.Size = new System.Drawing.Size(264, 114);
            this.rtbScore.TabIndex = 0;
            this.rtbScore.Text = "";
            this.rtbScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbScore_KeyPress);
            // 
            // btnScore
            // 
            this.btnScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.Black;
            this.btnScore.Location = new System.Drawing.Point(26, 212);
            this.btnScore.Margin = new System.Windows.Forms.Padding(1);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(265, 75);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "Submit";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(450, 18);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(171, 91);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "501";
            // 
            // btnNewLeg
            // 
            this.btnNewLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLeg.ForeColor = System.Drawing.Color.Black;
            this.btnNewLeg.Location = new System.Drawing.Point(26, 315);
            this.btnNewLeg.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewLeg.Name = "btnNewLeg";
            this.btnNewLeg.Size = new System.Drawing.Size(265, 75);
            this.btnNewLeg.TabIndex = 3;
            this.btnNewLeg.Text = "New Leg";
            this.btnNewLeg.UseVisualStyleBackColor = true;
            this.btnNewLeg.Click += new System.EventHandler(this.btnNewLeg_Click);
            // 
            // lblScoreLeft
            // 
            this.lblScoreLeft.AutoSize = true;
            this.lblScoreLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreLeft.ForeColor = System.Drawing.Color.White;
            this.lblScoreLeft.Location = new System.Drawing.Point(340, 59);
            this.lblScoreLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreLeft.Name = "lblScoreLeft";
            this.lblScoreLeft.Size = new System.Drawing.Size(93, 24);
            this.lblScoreLeft.TabIndex = 4;
            this.lblScoreLeft.Text = "Score left:";
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurns.ForeColor = System.Drawing.Color.White;
            this.lblTurns.Location = new System.Drawing.Point(456, 167);
            this.lblTurns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(96, 69);
            this.lblTurns.TabIndex = 5;
            this.lblTurns.Text = "12";
            // 
            // lblTurnsLeft
            // 
            this.lblTurnsLeft.AutoSize = true;
            this.lblTurnsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnsLeft.ForeColor = System.Drawing.Color.White;
            this.lblTurnsLeft.Location = new System.Drawing.Point(343, 190);
            this.lblTurnsLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurnsLeft.Name = "lblTurnsLeft";
            this.lblTurnsLeft.Size = new System.Drawing.Size(98, 24);
            this.lblTurnsLeft.TabIndex = 6;
            this.lblTurnsLeft.Text = "Turns Left:";
            // 
            // lblAVGText
            // 
            this.lblAVGText.AutoSize = true;
            this.lblAVGText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVGText.ForeColor = System.Drawing.Color.White;
            this.lblAVGText.Location = new System.Drawing.Point(343, 294);
            this.lblAVGText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAVGText.Name = "lblAVGText";
            this.lblAVGText.Size = new System.Drawing.Size(86, 24);
            this.lblAVGText.TabIndex = 7;
            this.lblAVGText.Text = "Average:";
            // 
            // lblAVG
            // 
            this.lblAVG.AutoSize = true;
            this.lblAVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAVG.ForeColor = System.Drawing.Color.White;
            this.lblAVG.Location = new System.Drawing.Point(456, 264);
            this.lblAVG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAVG.Name = "lblAVG";
            this.lblAVG.Size = new System.Drawing.Size(126, 69);
            this.lblAVG.TabIndex = 8;
            this.lblAVG.Text = "avg";
            // 
            // lblLegs
            // 
            this.lblLegs.AutoSize = true;
            this.lblLegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegs.ForeColor = System.Drawing.Color.White;
            this.lblLegs.Location = new System.Drawing.Point(454, 362);
            this.lblLegs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegs.Name = "lblLegs";
            this.lblLegs.Size = new System.Drawing.Size(148, 138);
            this.lblLegs.TabIndex = 10;
            this.lblLegs.Text = "0 - 0\r\n0 - 0";
            // 
            // lblStanding
            // 
            this.lblStanding.AutoSize = true;
            this.lblStanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStanding.ForeColor = System.Drawing.Color.White;
            this.lblStanding.Location = new System.Drawing.Point(343, 387);
            this.lblStanding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStanding.Name = "lblStanding";
            this.lblStanding.Size = new System.Drawing.Size(56, 72);
            this.lblStanding.TabIndex = 9;
            this.lblStanding.Text = "Legs:\r\n\r\nSets:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Black;
            this.btnNewGame.Location = new System.Drawing.Point(18, 29);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(175, 75);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat.ForeColor = System.Drawing.Color.White;
            this.lblFormat.Location = new System.Drawing.Point(23, 33);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(197, 20);
            this.lblFormat.TabIndex = 12;
            this.lblFormat.Text = "Input Format: score.darts";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(16, 210);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 75);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Game";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(16, 119);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(1);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(177, 75);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load Last Game";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFormat);
            this.groupBox1.Controls.Add(this.rtbScore);
            this.groupBox1.Controls.Add(this.btnScore);
            this.groupBox1.Controls.Add(this.lblScore);
            this.groupBox1.Controls.Add(this.btnNewLeg);
            this.groupBox1.Controls.Add(this.lblLegs);
            this.groupBox1.Controls.Add(this.lblScoreLeft);
            this.groupBox1.Controls.Add(this.lblStanding);
            this.groupBox1.Controls.Add(this.lblTurns);
            this.groupBox1.Controls.Add(this.lblAVG);
            this.groupBox1.Controls.Add(this.lblTurnsLeft);
            this.groupBox1.Controls.Add(this.lblAVGText);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(235, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 508);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "gbMain";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNewGame);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 508);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "gbGameMenu";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(947, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbScore;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnNewLeg;
        private System.Windows.Forms.Label lblScoreLeft;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.Label lblTurnsLeft;
        private System.Windows.Forms.Label lblAVGText;
        private System.Windows.Forms.Label lblAVG;
        private System.Windows.Forms.Label lblLegs;
        private System.Windows.Forms.Label lblStanding;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

