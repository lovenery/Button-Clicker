namespace CsharpHomework1
{
    partial class Homework1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Restart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberselector = new System.Windows.Forms.NumericUpDown();
            this.NewGame = new System.Windows.Forms.Button();
            this.HSlabel = new System.Windows.Forms.Label();
            this.Slabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numberselector)).BeginInit();
            this.SuspendLayout();
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Restart.Location = new System.Drawing.Point(423, 535);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(250, 50);
            this.Restart.TabIndex = 1;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Highest Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(536, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Score";
            // 
            // numberselector
            // 
            this.numberselector.Location = new System.Drawing.Point(274, 551);
            this.numberselector.Name = "numberselector";
            this.numberselector.Size = new System.Drawing.Size(143, 29);
            this.numberselector.TabIndex = 4;
            this.numberselector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewGame
            // 
            this.NewGame.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NewGame.Location = new System.Drawing.Point(12, 535);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(256, 50);
            this.NewGame.TabIndex = 7;
            this.NewGame.Text = "NewGame";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // HSlabel
            // 
            this.HSlabel.AutoSize = true;
            this.HSlabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.HSlabel.Location = new System.Drawing.Point(216, 13);
            this.HSlabel.Name = "HSlabel";
            this.HSlabel.Size = new System.Drawing.Size(42, 31);
            this.HSlabel.TabIndex = 8;
            this.HSlabel.Text = "00";
            // 
            // Slabel
            // 
            this.Slabel.AutoSize = true;
            this.Slabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slabel.Location = new System.Drawing.Point(631, 9);
            this.Slabel.Name = "Slabel";
            this.Slabel.Size = new System.Drawing.Size(42, 31);
            this.Slabel.TabIndex = 9;
            this.Slabel.Text = "00";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 399);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(661, 130);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Exit.Location = new System.Drawing.Point(264, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(251, 35);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(18, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 346);
            this.panel1.TabIndex = 12;
            // 
            // Homework1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(685, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Slabel);
            this.Controls.Add(this.HSlabel);
            this.Controls.Add(this.NewGame);
            this.Controls.Add(this.numberselector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Restart);
            this.Name = "Homework1";
            this.Text = "Homework1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberselector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberselector;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label HSlabel;
        private System.Windows.Forms.Label Slabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
    }
}

