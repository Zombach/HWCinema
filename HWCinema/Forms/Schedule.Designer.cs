
namespace HWCinema.Forms
{
    partial class Schedule
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
            this.ScheduleView = new System.Windows.Forms.Button();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ScheduleView
            // 
            this.ScheduleView.Location = new System.Drawing.Point(1578, 982);
            this.ScheduleView.Name = "ScheduleView";
            this.ScheduleView.Size = new System.Drawing.Size(144, 26);
            this.ScheduleView.TabIndex = 1;
            this.ScheduleView.Text = "Другой вариант";
            this.ScheduleView.UseVisualStyleBackColor = true;
            this.ScheduleView.Click += new System.EventHandler(this.ScheduleView_Click);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(10, 10);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(1419, 1005);
            this.ListBox.TabIndex = 2;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1904, 1021);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.ScheduleView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Movie Schedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Schedule_FormClosing);
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Button ScheduleView;
        private System.Windows.Forms.ListBox ListBox;
    }
}