namespace SUNDERLAND_SPORTS_CLUB_BOOKING
{
    partial class Form2
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
            back_btn = new Button();
            display_btn = new Button();
            SuspendLayout();
            // 
            // back_btn
            // 
            back_btn.Location = new Point(38, 93);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(94, 29);
            back_btn.TabIndex = 0;
            back_btn.Text = "BOOK";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // display_btn
            // 
            display_btn.Location = new Point(174, 93);
            display_btn.Name = "display_btn";
            display_btn.Size = new Size(94, 29);
            display_btn.TabIndex = 1;
            display_btn.Text = "DISPLAY";
            display_btn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 204);
            Controls.Add(display_btn);
            Controls.Add(back_btn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "START SCREEN";
            ResumeLayout(false);
        }

        #endregion

        private Button back_btn;
        private Button display_btn;
    }
}