namespace projet_tic_tac_toe
{
    partial class snake_face_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snake_face_1));
            this.label1 = new System.Windows.Forms.Label();
            this.quit_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(188, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Snake Game";
            // 
            // quit_btn
            // 
            this.quit_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.quit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quit_btn.Location = new System.Drawing.Point(136, 270);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(160, 54);
            this.quit_btn.TabIndex = 1;
            this.quit_btn.Text = "Quitter";
            this.quit_btn.UseVisualStyleBackColor = false;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.OliveDrab;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start_btn.Location = new System.Drawing.Point(454, 270);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(160, 54);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(58, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Player";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FloralWhite;
            this.player.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player.ForeColor = System.Drawing.SystemColors.Desktop;
            this.player.Location = new System.Drawing.Point(246, 180);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(295, 27);
            this.player.TabIndex = 4;
            // 
            // snake_face_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet_tic_tac_toe.Properties.Resources.snake;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "snake_face_1";
            this.Text = "Jeu de Snake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player;
    }
}