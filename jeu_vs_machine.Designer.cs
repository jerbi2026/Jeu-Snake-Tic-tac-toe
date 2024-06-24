namespace projet_tic_tac_toe
{
    partial class jeu_vs_machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jeu_vs_machine));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.res_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(689, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "machine";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.n9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.n8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.n7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.n5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.n4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.n3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.n2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.n1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.n6, 2, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Navy;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(862, 331);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // n9
            // 
            this.n9.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.Location = new System.Drawing.Point(577, 223);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(281, 104);
            this.n9.TabIndex = 8;
            this.n9.Text = "*";
            this.n9.UseVisualStyleBackColor = true;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n8
            // 
            this.n8.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.Location = new System.Drawing.Point(290, 223);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(281, 104);
            this.n8.TabIndex = 7;
            this.n8.Text = "*";
            this.n8.UseVisualStyleBackColor = true;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n7
            // 
            this.n7.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.Location = new System.Drawing.Point(3, 223);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(281, 104);
            this.n7.TabIndex = 6;
            this.n7.Text = "*";
            this.n7.UseVisualStyleBackColor = true;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n5
            // 
            this.n5.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.Location = new System.Drawing.Point(290, 113);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(281, 104);
            this.n5.TabIndex = 4;
            this.n5.Text = "*";
            this.n5.UseVisualStyleBackColor = true;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n4
            // 
            this.n4.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.Location = new System.Drawing.Point(3, 113);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(281, 104);
            this.n4.TabIndex = 3;
            this.n4.Text = "*";
            this.n4.UseVisualStyleBackColor = true;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n3
            // 
            this.n3.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.Location = new System.Drawing.Point(577, 3);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(281, 104);
            this.n3.TabIndex = 2;
            this.n3.Text = "*";
            this.n3.UseVisualStyleBackColor = true;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n2
            // 
            this.n2.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.Location = new System.Drawing.Point(290, 3);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(281, 104);
            this.n2.TabIndex = 1;
            this.n2.Text = "*";
            this.n2.UseVisualStyleBackColor = true;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n1
            // 
            this.n1.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.Location = new System.Drawing.Point(3, 3);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(281, 104);
            this.n1.TabIndex = 0;
            this.n1.Text = "*";
            this.n1.UseVisualStyleBackColor = true;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n6
            // 
            this.n6.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.Location = new System.Drawing.Point(577, 113);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(281, 104);
            this.n6.TabIndex = 5;
            this.n6.Text = "*";
            this.n6.UseVisualStyleBackColor = true;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // res_btn
            // 
            this.res_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.res_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.res_btn.Location = new System.Drawing.Point(574, 443);
            this.res_btn.Name = "res_btn";
            this.res_btn.Size = new System.Drawing.Size(128, 55);
            this.res_btn.TabIndex = 5;
            this.res_btn.Text = "Restart";
            this.res_btn.UseVisualStyleBackColor = false;
            this.res_btn.Click += new System.EventHandler(this.res_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.quit_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.quit_btn.Location = new System.Drawing.Point(138, 443);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(128, 55);
            this.quit_btn.TabIndex = 6;
            this.quit_btn.Text = "Quitter";
            this.quit_btn.UseVisualStyleBackColor = false;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // jeu_vs_machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::projet_tic_tac_toe.Properties.Resources.Sans_titre1;
            this.ClientSize = new System.Drawing.Size(890, 542);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.res_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "jeu_vs_machine";
            this.Text = "jeu_vs_machine";
       
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button res_btn;
        private System.Windows.Forms.Button quit_btn;
    }
}