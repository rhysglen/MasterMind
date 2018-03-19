namespace MasterMind
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.redButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.yellowButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.orangeButton = new System.Windows.Forms.Button();
            this.purpleButton = new System.Windows.Forms.Button();
            this.blackButton = new System.Windows.Forms.Button();
            this.whiteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.redButton.Location = new System.Drawing.Point(8, 437);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(40, 40);
            this.redButton.TabIndex = 0;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.Blue;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.blueButton.Location = new System.Drawing.Point(54, 437);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(40, 40);
            this.blueButton.TabIndex = 1;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Yellow;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.yellowButton.Location = new System.Drawing.Point(100, 437);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(40, 40);
            this.yellowButton.TabIndex = 2;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.greenButton.Location = new System.Drawing.Point(146, 437);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(40, 40);
            this.greenButton.TabIndex = 3;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // orangeButton
            // 
            this.orangeButton.BackColor = System.Drawing.Color.Orange;
            this.orangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orangeButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.orangeButton.Location = new System.Drawing.Point(8, 483);
            this.orangeButton.Name = "orangeButton";
            this.orangeButton.Size = new System.Drawing.Size(40, 40);
            this.orangeButton.TabIndex = 4;
            this.orangeButton.UseVisualStyleBackColor = false;
            this.orangeButton.Click += new System.EventHandler(this.orangeButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.BackColor = System.Drawing.Color.Purple;
            this.purpleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purpleButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.purpleButton.Location = new System.Drawing.Point(54, 483);
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(40, 40);
            this.purpleButton.TabIndex = 5;
            this.purpleButton.UseVisualStyleBackColor = false;
            this.purpleButton.Click += new System.EventHandler(this.purpleButton_Click);
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.blackButton.Location = new System.Drawing.Point(100, 483);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(40, 40);
            this.blackButton.TabIndex = 6;
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.White;
            this.whiteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whiteButton.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.whiteButton.Location = new System.Drawing.Point(146, 483);
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(40, 40);
            this.whiteButton.TabIndex = 7;
            this.whiteButton.UseVisualStyleBackColor = false;
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 113);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(59, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 52);
            this.label2.TabIndex = 9;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 16;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.whiteButton);
            this.Controls.Add(this.blackButton);
            this.Controls.Add(this.purpleButton);
            this.Controls.Add(this.orangeButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(425, 560);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button orangeButton;
        private System.Windows.Forms.Button purpleButton;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button whiteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer gameTimer;
    }
}
