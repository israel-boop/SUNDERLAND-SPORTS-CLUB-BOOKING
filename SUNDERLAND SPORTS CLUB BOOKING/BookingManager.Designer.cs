namespace SUNDERLAND_SPORTS_CLUB_BOOKING
{
    partial class BookingManager
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
            textBox1 = new TextBox();
            label1 = new Label();
            BookingsList = new DataGridView();
            managerNotificationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)BookingsList).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 52);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 3;
            label1.Text = "Filter";
            // 
            // BookingsList
            // 
            BookingsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingsList.Location = new Point(81, 88);
            BookingsList.Name = "BookingsList";
            BookingsList.RowTemplate.Height = 25;
            BookingsList.Size = new Size(524, 361);
            BookingsList.TabIndex = 5;
            // 
            // managerNotificationLabel
            // 
            managerNotificationLabel.AutoSize = true;
            managerNotificationLabel.Location = new Point(312, 22);
            managerNotificationLabel.Name = "managerNotificationLabel";
            managerNotificationLabel.Size = new Size(33, 15);
            managerNotificationLabel.TabIndex = 6;
            managerNotificationLabel.Text = "Filter";
            // 
            // BookingManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 481);
            Controls.Add(managerNotificationLabel);
            Controls.Add(BookingsList);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "BookingManager";
            Text = "BookingManager";
            Load += BookingManager_Load;
            ((System.ComponentModel.ISupportInitialize)BookingsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private DataGridView BookingsList;
        private Label managerNotificationLabel;
    }
}