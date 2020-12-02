namespace MemoryGame
{
    partial class MemoryGame
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
            this.resetTimer = new System.Windows.Forms.Timer(this.components);
            this.gameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.sixteenthLabel = new System.Windows.Forms.Label();
            this.fifteenthLabel = new System.Windows.Forms.Label();
            this.fourteenthLabel = new System.Windows.Forms.Label();
            this.thirteenthLabel = new System.Windows.Forms.Label();
            this.twelfthLabel = new System.Windows.Forms.Label();
            this.eleventhLabel = new System.Windows.Forms.Label();
            this.tenthLabel = new System.Windows.Forms.Label();
            this.ninthLabel = new System.Windows.Forms.Label();
            this.eighthLabel = new System.Windows.Forms.Label();
            this.seventhField = new System.Windows.Forms.Label();
            this.sixthField = new System.Windows.Forms.Label();
            this.fifthField = new System.Windows.Forms.Label();
            this.fourthField = new System.Windows.Forms.Label();
            this.thirdField = new System.Windows.Forms.Label();
            this.secondField = new System.Windows.Forms.Label();
            this.firstField = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.realTimeLabel = new System.Windows.Forms.Label();
            this.nicknameTextbox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.realScoreLabel = new System.Windows.Forms.Label();
            this.topFiveTextbox = new System.Windows.Forms.TextBox();
            this.topFiveLabel = new System.Windows.Forms.Label();
            this.memoryGameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetTimer
            // 
            this.resetTimer.Interval = 750;
            this.resetTimer.Tick += new System.EventHandler(this.resetSymbols);
            // 
            // gameBoard
            // 
            this.gameBoard.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gameBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.gameBoard.ColumnCount = 4;
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.Controls.Add(this.sixteenthLabel, 3, 3);
            this.gameBoard.Controls.Add(this.fifteenthLabel, 2, 3);
            this.gameBoard.Controls.Add(this.fourteenthLabel, 1, 3);
            this.gameBoard.Controls.Add(this.thirteenthLabel, 0, 3);
            this.gameBoard.Controls.Add(this.twelfthLabel, 3, 2);
            this.gameBoard.Controls.Add(this.eleventhLabel, 2, 2);
            this.gameBoard.Controls.Add(this.tenthLabel, 1, 2);
            this.gameBoard.Controls.Add(this.ninthLabel, 0, 2);
            this.gameBoard.Controls.Add(this.eighthLabel, 3, 1);
            this.gameBoard.Controls.Add(this.seventhField, 2, 1);
            this.gameBoard.Controls.Add(this.sixthField, 1, 1);
            this.gameBoard.Controls.Add(this.fifthField, 0, 1);
            this.gameBoard.Controls.Add(this.fourthField, 3, 0);
            this.gameBoard.Controls.Add(this.thirdField, 2, 0);
            this.gameBoard.Controls.Add(this.secondField, 1, 0);
            this.gameBoard.Controls.Add(this.firstField, 0, 0);
            this.gameBoard.Location = new System.Drawing.Point(0, 0);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.RowCount = 4;
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.gameBoard.Size = new System.Drawing.Size(675, 542);
            this.gameBoard.TabIndex = 0;
            // 
            // sixteenthLabel
            // 
            this.sixteenthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixteenthLabel.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.sixteenthLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.sixteenthLabel.Location = new System.Drawing.Point(510, 405);
            this.sixteenthLabel.Name = "sixteenthLabel";
            this.sixteenthLabel.Size = new System.Drawing.Size(159, 134);
            this.sixteenthLabel.TabIndex = 15;
            this.sixteenthLabel.Text = "c";
            this.sixteenthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sixteenthLabel.Click += new System.EventHandler(this.label_Clicked);
            // 
            // fifteenthLabel
            // 
            this.fifteenthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fifteenthLabel.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.fifteenthLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.fifteenthLabel.Location = new System.Drawing.Point(342, 405);
            this.fifteenthLabel.Name = "fifteenthLabel";
            this.fifteenthLabel.Size = new System.Drawing.Size(159, 134);
            this.fifteenthLabel.TabIndex = 14;
            this.fifteenthLabel.Text = "c";
            this.fifteenthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fifteenthLabel.Click += new System.EventHandler(this.label_Clicked);
            // 
            // fourteenthLabel
            // 
            this.fourteenthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourteenthLabel.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.fourteenthLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.fourteenthLabel.Location = new System.Drawing.Point(174, 405);
            this.fourteenthLabel.Name = "fourteenthLabel";
            this.fourteenthLabel.Size = new System.Drawing.Size(159, 134);
            this.fourteenthLabel.TabIndex = 13;
            this.fourteenthLabel.Text = "c";
            this.fourteenthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fourteenthLabel.Click += new System.EventHandler(this.label_Clicked);
            // 
            // thirteenthLabel
            // 
            this.thirteenthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirteenthLabel.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.thirteenthLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.thirteenthLabel.Location = new System.Drawing.Point(6, 405);
            this.thirteenthLabel.Name = "thirteenthLabel";
            this.thirteenthLabel.Size = new System.Drawing.Size(159, 134);
            this.thirteenthLabel.TabIndex = 12;
            this.thirteenthLabel.Text = "c";
            this.thirteenthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.thirteenthLabel.Click += new System.EventHandler(this.label_Clicked);
            // 
            // twelfthLabel
            // 
            this.twelfthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twelfthLabel.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.twelfthLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.twelfthLabel.Location = new System.Drawing.Point(510, 271);
            this.twelfthLabel.Name = "twelfthLabel";
            this.twelfthLabel.Size = new System.Drawing.Size(159, 131);
            this.twelfthLabel.TabIndex = 11;
            this.twelfthLabel.Text = "c";
            this.twelfthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.twelfthLabel.Click += new System.EventHandler(this.label_Clicked);
            // 
            // eleventhLabel
            // 
            this.eleventhLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eleventhLabel.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.eleventhLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.eleventhLabel.Location = new System.Drawing.Point(342, 271);
            this.eleventhLabel.Name = "eleventhLabel";
            this.eleventhLabel.Size = new System.Drawing.Size(159, 131);
            this.eleventhLabel.TabIndex = 10;
            this.eleventhLabel.Text = "c";
            this.eleventhLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eleventhLabel.Click += new System.EventHandler(this.label_Clicked);
            // 
            // tenthLabel
            // 
            this.tenthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tenthLabel.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.tenthLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tenthLabel.Location = new System.Drawing.Point(174, 271);
            this.tenthLabel.Name = "tenthLabel";
            this.tenthLabel.Size = new System.Drawing.Size(159, 131);
            this.tenthLabel.TabIndex = 9;
            this.tenthLabel.Text = "c";
            this.tenthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tenthLabel.Click += new System.EventHandler(this.label_Clicked);
            // 
            // ninthLabel
            // 
            this.ninthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ninthLabel.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ninthLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ninthLabel.Location = new System.Drawing.Point(6, 271);
            this.ninthLabel.Name = "ninthLabel";
            this.ninthLabel.Size = new System.Drawing.Size(159, 131);
            this.ninthLabel.TabIndex = 8;
            this.ninthLabel.Text = "c";
            this.ninthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ninthLabel.Click += new System.EventHandler(this.label_Clicked);
            // 
            // eighthLabel
            // 
            this.eighthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eighthLabel.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.eighthLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.eighthLabel.Location = new System.Drawing.Point(510, 137);
            this.eighthLabel.Name = "eighthLabel";
            this.eighthLabel.Size = new System.Drawing.Size(159, 131);
            this.eighthLabel.TabIndex = 7;
            this.eighthLabel.Text = "c";
            this.eighthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.eighthLabel.Click += new System.EventHandler(this.label_Clicked);
            // 
            // seventhField
            // 
            this.seventhField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seventhField.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.seventhField.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.seventhField.Location = new System.Drawing.Point(342, 137);
            this.seventhField.Name = "seventhField";
            this.seventhField.Size = new System.Drawing.Size(159, 131);
            this.seventhField.TabIndex = 6;
            this.seventhField.Text = "c";
            this.seventhField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seventhField.Click += new System.EventHandler(this.label_Clicked);
            // 
            // sixthField
            // 
            this.sixthField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixthField.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.sixthField.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.sixthField.Location = new System.Drawing.Point(174, 137);
            this.sixthField.Name = "sixthField";
            this.sixthField.Size = new System.Drawing.Size(159, 131);
            this.sixthField.TabIndex = 5;
            this.sixthField.Text = "c";
            this.sixthField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sixthField.Click += new System.EventHandler(this.label_Clicked);
            // 
            // fifthField
            // 
            this.fifthField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fifthField.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.fifthField.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.fifthField.Location = new System.Drawing.Point(6, 137);
            this.fifthField.Name = "fifthField";
            this.fifthField.Size = new System.Drawing.Size(159, 131);
            this.fifthField.TabIndex = 4;
            this.fifthField.Text = "c";
            this.fifthField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fifthField.Click += new System.EventHandler(this.label_Clicked);
            // 
            // fourthField
            // 
            this.fourthField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourthField.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.fourthField.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.fourthField.Location = new System.Drawing.Point(510, 3);
            this.fourthField.Name = "fourthField";
            this.fourthField.Size = new System.Drawing.Size(159, 131);
            this.fourthField.TabIndex = 3;
            this.fourthField.Text = "c";
            this.fourthField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fourthField.Click += new System.EventHandler(this.label_Clicked);
            // 
            // thirdField
            // 
            this.thirdField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdField.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.thirdField.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.thirdField.Location = new System.Drawing.Point(342, 3);
            this.thirdField.Name = "thirdField";
            this.thirdField.Size = new System.Drawing.Size(159, 131);
            this.thirdField.TabIndex = 2;
            this.thirdField.Text = "c";
            this.thirdField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.thirdField.Click += new System.EventHandler(this.label_Clicked);
            // 
            // secondField
            // 
            this.secondField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondField.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.secondField.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.secondField.Location = new System.Drawing.Point(174, 3);
            this.secondField.Name = "secondField";
            this.secondField.Size = new System.Drawing.Size(159, 131);
            this.secondField.TabIndex = 1;
            this.secondField.Text = "c";
            this.secondField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.secondField.Click += new System.EventHandler(this.label_Clicked);
            // 
            // firstField
            // 
            this.firstField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstField.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.firstField.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.firstField.Location = new System.Drawing.Point(6, 3);
            this.firstField.Name = "firstField";
            this.firstField.Size = new System.Drawing.Size(159, 131);
            this.firstField.TabIndex = 0;
            this.firstField.Text = "c";
            this.firstField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.firstField.Click += new System.EventHandler(this.label_Clicked);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LimeGreen;
            this.startButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.ForeColor = System.Drawing.SystemColors.Control;
            this.startButton.Location = new System.Drawing.Point(806, 137);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(142, 44);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startGameButton);
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nicknameLabel.Location = new System.Drawing.Point(816, 61);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(123, 19);
            this.nicknameLabel.TabIndex = 2;
            this.nicknameLabel.Text = "Twój nickname";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLabel.Location = new System.Drawing.Point(802, 199);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(54, 19);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Czas:";
            // 
            // realTimeLabel
            // 
            this.realTimeLabel.AutoSize = true;
            this.realTimeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.realTimeLabel.Location = new System.Drawing.Point(911, 199);
            this.realTimeLabel.Name = "realTimeLabel";
            this.realTimeLabel.Size = new System.Drawing.Size(18, 19);
            this.realTimeLabel.TabIndex = 4;
            this.realTimeLabel.Text = "0";
            // 
            // nicknameTextbox
            // 
            this.nicknameTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nicknameTextbox.Location = new System.Drawing.Point(787, 94);
            this.nicknameTextbox.Multiline = true;
            this.nicknameTextbox.Name = "nicknameTextbox";
            this.nicknameTextbox.Size = new System.Drawing.Size(179, 27);
            this.nicknameTextbox.TabIndex = 5;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.Location = new System.Drawing.Point(802, 218);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(62, 19);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Wynik:";
            // 
            // realScoreLabel
            // 
            this.realScoreLabel.AutoSize = true;
            this.realScoreLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.realScoreLabel.Location = new System.Drawing.Point(911, 218);
            this.realScoreLabel.Name = "realScoreLabel";
            this.realScoreLabel.Size = new System.Drawing.Size(18, 19);
            this.realScoreLabel.TabIndex = 7;
            this.realScoreLabel.Text = "0";
            // 
            // topFiveTextbox
            // 
            this.topFiveTextbox.BackColor = System.Drawing.Color.LightSalmon;
            this.topFiveTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.topFiveTextbox.Enabled = false;
            this.topFiveTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topFiveTextbox.Location = new System.Drawing.Point(705, 332);
            this.topFiveTextbox.Multiline = true;
            this.topFiveTextbox.Name = "topFiveTextbox";
            this.topFiveTextbox.ReadOnly = true;
            this.topFiveTextbox.Size = new System.Drawing.Size(329, 183);
            this.topFiveTextbox.TabIndex = 9;
            // 
            // topFiveLabel
            // 
            this.topFiveLabel.AutoSize = true;
            this.topFiveLabel.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.topFiveLabel.Location = new System.Drawing.Point(831, 285);
            this.topFiveLabel.Name = "topFiveLabel";
            this.topFiveLabel.Size = new System.Drawing.Size(85, 33);
            this.topFiveLabel.TabIndex = 10;
            this.topFiveLabel.Text = "TOP 5";
            // 
            // memoryGameTimer
            // 
            this.memoryGameTimer.Interval = 1000;
            this.memoryGameTimer.Tick += new System.EventHandler(this.gameTimer);
            // 
            // MemoryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 542);
            this.Controls.Add(this.topFiveLabel);
            this.Controls.Add(this.topFiveTextbox);
            this.Controls.Add(this.realScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.nicknameTextbox);
            this.Controls.Add(this.realTimeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.nicknameLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.gameBoard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MemoryGame";
            this.Text = "MemoryGame by Damian Gul";
            this.gameBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer resetTimer;
        private System.Windows.Forms.TableLayoutPanel gameBoard;
        private System.Windows.Forms.Label sixteenthLabel;
        private System.Windows.Forms.Label fifteenthLabel;
        private System.Windows.Forms.Label fourteenthLabel;
        private System.Windows.Forms.Label thirteenthLabel;
        private System.Windows.Forms.Label twelfthLabel;
        private System.Windows.Forms.Label eleventhLabel;
        private System.Windows.Forms.Label tenthLabel;
        private System.Windows.Forms.Label ninthLabel;
        private System.Windows.Forms.Label eighthLabel;
        private System.Windows.Forms.Label seventhField;
        private System.Windows.Forms.Label sixthField;
        private System.Windows.Forms.Label fifthField;
        private System.Windows.Forms.Label fourthField;
        private System.Windows.Forms.Label thirdField;
        private System.Windows.Forms.Label secondField;
        private System.Windows.Forms.Label firstField;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label realTimeLabel;
        private System.Windows.Forms.TextBox nicknameTextbox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label realScoreLabel;
        private System.Windows.Forms.TextBox topFiveTextbox;
        private System.Windows.Forms.Label topFiveLabel;
        private System.Windows.Forms.Timer memoryGameTimer;
    }
}

