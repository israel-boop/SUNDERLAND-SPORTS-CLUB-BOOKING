﻿namespace SUNDERLAND_SPORTS_CLUB_BOOKING
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
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(10, 99);
            progressBar1.Margin = new Padding(3, 2, 3, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(393, 9);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 195);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SPLASH SCREEN";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}