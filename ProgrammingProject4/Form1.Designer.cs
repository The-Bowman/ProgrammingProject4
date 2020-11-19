
namespace ProgrammingProject4
{
    partial class ticTacToeForm
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
            this.output1 = new System.Windows.Forms.Label();
            this.output2 = new System.Windows.Forms.Label();
            this.output3 = new System.Windows.Forms.Label();
            this.output4 = new System.Windows.Forms.Label();
            this.output6 = new System.Windows.Forms.Label();
            this.output7 = new System.Windows.Forms.Label();
            this.output8 = new System.Windows.Forms.Label();
            this.output9 = new System.Windows.Forms.Label();
            this.output5 = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // output1
            // 
            this.output1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output1.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.output1.Location = new System.Drawing.Point(31, 9);
            this.output1.Name = "output1";
            this.output1.Size = new System.Drawing.Size(110, 110);
            this.output1.TabIndex = 0;
            this.output1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output2
            // 
            this.output2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output2.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.output2.Location = new System.Drawing.Point(147, 10);
            this.output2.Name = "output2";
            this.output2.Size = new System.Drawing.Size(110, 109);
            this.output2.TabIndex = 1;
            this.output2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output3
            // 
            this.output3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output3.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.output3.Location = new System.Drawing.Point(263, 10);
            this.output3.Name = "output3";
            this.output3.Size = new System.Drawing.Size(110, 109);
            this.output3.TabIndex = 2;
            this.output3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output4
            // 
            this.output4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output4.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.output4.Location = new System.Drawing.Point(31, 127);
            this.output4.Name = "output4";
            this.output4.Size = new System.Drawing.Size(110, 109);
            this.output4.TabIndex = 3;
            this.output4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // output6
            // 
            this.output6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output6.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.output6.Location = new System.Drawing.Point(263, 127);
            this.output6.Name = "output6";
            this.output6.Size = new System.Drawing.Size(110, 109);
            this.output6.TabIndex = 5;
            this.output6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // output7
            // 
            this.output7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output7.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.output7.Location = new System.Drawing.Point(31, 245);
            this.output7.Name = "output7";
            this.output7.Size = new System.Drawing.Size(110, 109);
            this.output7.TabIndex = 6;
            this.output7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // output8
            // 
            this.output8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output8.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.output8.Location = new System.Drawing.Point(147, 245);
            this.output8.Name = "output8";
            this.output8.Size = new System.Drawing.Size(110, 109);
            this.output8.TabIndex = 7;
            this.output8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output9
            // 
            this.output9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output9.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.output9.Location = new System.Drawing.Point(263, 245);
            this.output9.Name = "output9";
            this.output9.Size = new System.Drawing.Size(110, 109);
            this.output9.TabIndex = 8;
            this.output9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // output5
            // 
            this.output5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output5.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F);
            this.output5.Location = new System.Drawing.Point(147, 127);
            this.output5.Name = "output5";
            this.output5.Size = new System.Drawing.Size(110, 109);
            this.output5.TabIndex = 9;
            this.output5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(31, 444);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 11;
            this.newGameButton.Text = "&New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(298, 444);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Location = new System.Drawing.Point(111, 382);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(181, 36);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ticTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 497);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.output5);
            this.Controls.Add(this.output9);
            this.Controls.Add(this.output8);
            this.Controls.Add(this.output7);
            this.Controls.Add(this.output6);
            this.Controls.Add(this.output4);
            this.Controls.Add(this.output3);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Name = "ticTacToeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label output1;
        private System.Windows.Forms.Label output2;
        private System.Windows.Forms.Label output3;
        private System.Windows.Forms.Label output4;
        private System.Windows.Forms.Label output6;
        private System.Windows.Forms.Label output7;
        private System.Windows.Forms.Label output8;
        private System.Windows.Forms.Label output9;
        private System.Windows.Forms.Label output5;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

