namespace PongPong
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backGround = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.PictureBox();
            this.gameBall = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.result = new System.Windows.Forms.Label();
            this.loseLabel = new System.Windows.Forms.Label();
            this.backGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).BeginInit();
            this.SuspendLayout();
            // 
            // backGround
            // 
            this.backGround.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backGround.Controls.Add(this.loseLabel);
            this.backGround.Controls.Add(this.result);
            this.backGround.Controls.Add(this.gameBall);
            this.backGround.Controls.Add(this.gamePanel);
            this.backGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backGround.Location = new System.Drawing.Point(0, 0);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(800, 450);
            this.backGround.TabIndex = 0;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Red;
            this.gamePanel.Location = new System.Drawing.Point(300, 378);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(199, 25);
            this.gamePanel.TabIndex = 0;
            this.gamePanel.TabStop = false;
            // 
            // gameBall
            // 
            this.gameBall.BackColor = System.Drawing.Color.Blue;
            this.gameBall.Location = new System.Drawing.Point(353, 189);
            this.gameBall.Name = "gameBall";
            this.gameBall.Size = new System.Drawing.Size(50, 50);
            this.gameBall.TabIndex = 1;
            this.gameBall.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Arial Black", 15.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(620, 9);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(168, 44);
            this.result.TabIndex = 2;
            this.result.Text = "Result: 0";
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loseLabel.Location = new System.Drawing.Point(223, 116);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(344, 70);
            this.loseLabel.TabIndex = 3;
            this.loseLabel.Text = "You LOSE!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backGround);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.backGround.ResumeLayout(false);
            this.backGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backGround;
        private System.Windows.Forms.PictureBox gameBall;
        private System.Windows.Forms.PictureBox gamePanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label loseLabel;
    }
}

