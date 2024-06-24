namespace projet_tic_tac_toe
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.bestfriend = new System.Windows.Forms.CheckBox();
            this.machine = new System.Windows.Forms.CheckBox();
            this.play_btn = new System.Windows.Forms.Button();
            this.annul_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Tic Tac Toe";
            // 
            // bestfriend
            // 
            this.bestfriend.Appearance = System.Windows.Forms.Appearance.Button;
            this.bestfriend.AutoSize = true;
            this.bestfriend.BackColor = System.Drawing.Color.Beige;
            this.bestfriend.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestfriend.ForeColor = System.Drawing.Color.DarkBlue;
            this.bestfriend.Location = new System.Drawing.Point(37, 157);
            this.bestfriend.Name = "bestfriend";
            this.bestfriend.Size = new System.Drawing.Size(252, 45);
            this.bestfriend.TabIndex = 1;
            this.bestfriend.Text = "Vs your bestfriend";
            this.bestfriend.UseVisualStyleBackColor = false;
            // 
            // machine
            // 
            this.machine.Appearance = System.Windows.Forms.Appearance.Button;
            this.machine.AutoSize = true;
            this.machine.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.machine.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine.ForeColor = System.Drawing.Color.DarkBlue;
            this.machine.Location = new System.Drawing.Point(37, 220);
            this.machine.Name = "machine";
            this.machine.Size = new System.Drawing.Size(168, 45);
            this.machine.TabIndex = 2;
            this.machine.Text = "Vs machine";
            this.machine.UseVisualStyleBackColor = false;
            // 
            // play_btn
            // 
            this.play_btn.BackColor = System.Drawing.Color.Violet;
            this.play_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_btn.Location = new System.Drawing.Point(469, 305);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(132, 48);
            this.play_btn.TabIndex = 3;
            this.play_btn.Text = "Play";
            this.play_btn.UseVisualStyleBackColor = false;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // annul_btn
            // 
            this.annul_btn.BackColor = System.Drawing.Color.Fuchsia;
            this.annul_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annul_btn.Location = new System.Drawing.Point(292, 305);
            this.annul_btn.Name = "annul_btn";
            this.annul_btn.Size = new System.Drawing.Size(132, 48);
            this.annul_btn.TabIndex = 4;
            this.annul_btn.Text = "Annuler";
            this.annul_btn.UseVisualStyleBackColor = false;
            this.annul_btn.Click += new System.EventHandler(this.annul_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.BackColor = System.Drawing.Color.Purple;
            this.quit_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.Location = new System.Drawing.Point(111, 305);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(132, 48);
            this.quit_btn.TabIndex = 5;
            this.quit_btn.Text = "Quitter";
            this.quit_btn.UseVisualStyleBackColor = false;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet_tic_tac_toe.Properties.Resources.téléchargement;
            this.ClientSize = new System.Drawing.Size(704, 446);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.annul_btn);
            this.Controls.Add(this.play_btn);
            this.Controls.Add(this.machine);
            this.Controls.Add(this.bestfriend);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox bestfriend;
        private System.Windows.Forms.CheckBox machine;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button annul_btn;
        private System.Windows.Forms.Button quit_btn;
    }
}

