namespace projet_tic_tac_toe
{
    partial class affiche_games
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(affiche_games));
            this.label1 = new System.Windows.Forms.Label();
            this.xo_btn = new System.Windows.Forms.RadioButton();
            this.snake_btn = new System.Windows.Forms.RadioButton();
            this.play_btn = new System.Windows.Forms.Button();
            this.annul_btn = new System.Windows.Forms.Button();
            this.quitt_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova Extra Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(81, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to our space";
            // 
            // xo_btn
            // 
            this.xo_btn.AutoSize = true;
            this.xo_btn.BackColor = System.Drawing.Color.Transparent;
            this.xo_btn.Font = new System.Drawing.Font("Old Antic Outline", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.xo_btn.ForeColor = System.Drawing.Color.Gold;
            this.xo_btn.Location = new System.Drawing.Point(39, 123);
            this.xo_btn.Name = "xo_btn";
            this.xo_btn.Size = new System.Drawing.Size(207, 46);
            this.xo_btn.TabIndex = 1;
            this.xo_btn.TabStop = true;
            this.xo_btn.Text = "Tic Tac Toe";
            this.xo_btn.UseVisualStyleBackColor = false;
            // 
            // snake_btn
            // 
            this.snake_btn.AutoSize = true;
            this.snake_btn.BackColor = System.Drawing.Color.Transparent;
            this.snake_btn.Font = new System.Drawing.Font("Old Antic Outline", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.snake_btn.ForeColor = System.Drawing.Color.Cyan;
            this.snake_btn.Location = new System.Drawing.Point(39, 214);
            this.snake_btn.Name = "snake_btn";
            this.snake_btn.Size = new System.Drawing.Size(132, 46);
            this.snake_btn.TabIndex = 2;
            this.snake_btn.TabStop = true;
            this.snake_btn.Text = "Snake";
            this.snake_btn.UseVisualStyleBackColor = false;
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.play_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.play_btn.Location = new System.Drawing.Point(521, 96);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(106, 40);
            this.play_btn.TabIndex = 4;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // annul_btn
            // 
            this.annul_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.annul_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annul_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.annul_btn.Location = new System.Drawing.Point(521, 166);
            this.annul_btn.Name = "annul_btn";
            this.annul_btn.Size = new System.Drawing.Size(106, 40);
            this.annul_btn.TabIndex = 5;
            this.annul_btn.Text = "Annuler";
            this.annul_btn.UseVisualStyleBackColor = false;
            this.annul_btn.Click += new System.EventHandler(this.annul_btn_Click);
            // 
            // quitt_btn
            // 
            this.quitt_btn.BackColor = System.Drawing.Color.DarkBlue;
            this.quitt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitt_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quitt_btn.Location = new System.Drawing.Point(521, 242);
            this.quitt_btn.Name = "quitt_btn";
            this.quitt_btn.Size = new System.Drawing.Size(106, 40);
            this.quitt_btn.TabIndex = 6;
            this.quitt_btn.Text = "Quitter";
            this.quitt_btn.UseVisualStyleBackColor = false;
            this.quitt_btn.Click += new System.EventHandler(this.quitt_btn_Click);
            // 
            // affiche_games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet_tic_tac_toe.Properties.Resources.games;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 366);
            this.Controls.Add(this.quitt_btn);
            this.Controls.Add(this.annul_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.snake_btn);
            this.Controls.Add(this.xo_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "affiche_games";
            this.Text = "                                                                       games";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton xo_btn;
        private System.Windows.Forms.RadioButton snake_btn;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button annul_btn;
        private System.Windows.Forms.Button quitt_btn;
    }
}