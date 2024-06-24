namespace projet_tic_tac_toe
{
    partial class mach_face_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mach_face_1));
            this.label1 = new System.Windows.Forms.Label();
            this.play1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.back_ret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player  :";
            // 
            // play1
            // 
            this.play1.BackColor = System.Drawing.Color.Salmon;
            this.play1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play1.Location = new System.Drawing.Point(151, 86);
            this.play1.Name = "play1";
            this.play1.Size = new System.Drawing.Size(295, 27);
            this.play1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "(play with X)";
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.Location = new System.Drawing.Point(406, 191);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(134, 63);
            this.start_btn.TabIndex = 7;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // back_ret
            // 
            this.back_ret.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back_ret.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_ret.Location = new System.Drawing.Point(46, 191);
            this.back_ret.Name = "back_ret";
            this.back_ret.Size = new System.Drawing.Size(134, 63);
            this.back_ret.TabIndex = 8;
            this.back_ret.Text = "Return";
            this.back_ret.UseVisualStyleBackColor = false;
            this.back_ret.Click += new System.EventHandler(this.back_ret_Click);
            // 
            // mach_face_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(650, 341);
            this.Controls.Add(this.back_ret);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.play1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mach_face_1";
            this.Text = "mach_face_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox play1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button back_ret;
    }
}