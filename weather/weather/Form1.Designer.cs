namespace weather
{
    partial class F_Weather
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
            this.label1 = new System.Windows.Forms.Label();
            this.L_Time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T_City = new System.Windows.Forms.TextBox();
            this.B_Search = new System.Windows.Forms.Button();
            this.L_Info = new System.Windows.Forms.Label();
            this.P_main = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.P_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(127)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(39, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "wellcom";
            // 
            // L_Time
            // 
            this.L_Time.AutoSize = true;
            this.L_Time.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Time.Location = new System.Drawing.Point(40, 119);
            this.L_Time.Name = "L_Time";
            this.L_Time.Size = new System.Drawing.Size(85, 33);
            this.L_Time.TabIndex = 2;
            this.L_Time.Text = "month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label2.Location = new System.Drawing.Point(193, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "city : ";
            // 
            // T_City
            // 
            this.T_City.Location = new System.Drawing.Point(247, 612);
            this.T_City.Name = "T_City";
            this.T_City.Size = new System.Drawing.Size(100, 22);
            this.T_City.TabIndex = 5;
            // 
            // B_Search
            // 
            this.B_Search.Location = new System.Drawing.Point(353, 612);
            this.B_Search.Name = "B_Search";
            this.B_Search.Size = new System.Drawing.Size(75, 23);
            this.B_Search.TabIndex = 6;
            this.B_Search.Text = "search";
            this.B_Search.UseVisualStyleBackColor = true;
            this.B_Search.Click += new System.EventHandler(this.B_Search_Click);
            // 
            // L_Info
            // 
            this.L_Info.AutoSize = true;
            this.L_Info.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.L_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(185)))), ((int)(((byte)(210)))));
            this.L_Info.Location = new System.Drawing.Point(241, 386);
            this.L_Info.Name = "L_Info";
            this.L_Info.Size = new System.Drawing.Size(0, 39);
            this.L_Info.TabIndex = 8;
            // 
            // P_main
            // 
            this.P_main.Image = global::weather.Properties.Resources.photo_2024_10_11_20_39_54;
            this.P_main.Location = new System.Drawing.Point(681, -2);
            this.P_main.Name = "P_main";
            this.P_main.Size = new System.Drawing.Size(351, 651);
            this.P_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_main.TabIndex = 0;
            this.P_main.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(419, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // F_Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.L_Info);
            this.Controls.Add(this.B_Search);
            this.Controls.Add(this.T_City);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Weather";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "weather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox P_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox T_City;
        private System.Windows.Forms.Button B_Search;
        private System.Windows.Forms.Label L_Info;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

