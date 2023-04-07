namespace WordGuessApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guessWord = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guessInput = new System.Windows.Forms.TextBox();
            this.quessBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessWord
            // 
            this.guessWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(182)))), ((int)(((byte)(83)))));
            this.guessWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guessWord.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guessWord.ForeColor = System.Drawing.Color.White;
            this.guessWord.Location = new System.Drawing.Point(12, 9);
            this.guessWord.Name = "guessWord";
            this.guessWord.Size = new System.Drawing.Size(465, 48);
            this.guessWord.TabIndex = 0;
            this.guessWord.Text = "A P P L E";
            this.guessWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(93, 111);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 360);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // guessInput
            // 
            this.guessInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guessInput.Location = new System.Drawing.Point(162, 486);
            this.guessInput.MaxLength = 5;
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(160, 33);
            this.guessInput.TabIndex = 2;
            this.guessInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quessBtn
            // 
            this.quessBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.quessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quessBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quessBtn.ForeColor = System.Drawing.Color.White;
            this.quessBtn.Location = new System.Drawing.Point(194, 525);
            this.quessBtn.Name = "quessBtn";
            this.quessBtn.Size = new System.Drawing.Size(95, 31);
            this.quessBtn.TabIndex = 3;
            this.quessBtn.Text = "Guess";
            this.quessBtn.UseVisualStyleBackColor = false;
            this.quessBtn.Click += new System.EventHandler(this.quessBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 60);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(465, 23);
            this.progressBar.TabIndex = 4;
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Location = new System.Drawing.Point(223, 86);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(42, 15);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "mm:ss";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(489, 663);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.quessBtn);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guessWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label guessWord;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox guessInput;
        private Button quessBtn;
        private ProgressBar progressBar;
        private Label timeLbl;
    }
}