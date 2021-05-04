
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
            this.ListSchedule = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.HallsManager = new System.Windows.Forms.Button();
            this.FilmsManager = new System.Windows.Forms.Button();
            this.ListSortEfficiency = new System.Windows.Forms.ListBox();
            this.ListSortNotRepeat = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.CreateShedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScheduleView
            // 
            this.ScheduleView.Location = new System.Drawing.Point(1765, 482);
            this.ScheduleView.Name = "ScheduleView";
            this.ScheduleView.Size = new System.Drawing.Size(144, 26);
            this.ScheduleView.TabIndex = 1;
            this.ScheduleView.Text = "Другой вариант";
            this.ScheduleView.UseVisualStyleBackColor = true;
            this.ScheduleView.Click += new System.EventHandler(this.ScheduleView_Click);
            // 
            // ListSchedule
            // 
            this.ListSchedule.FormattingEnabled = true;
            this.ListSchedule.Location = new System.Drawing.Point(10, 10);
            this.ListSchedule.Name = "ListSchedule";
            this.ListSchedule.Size = new System.Drawing.Size(579, 1005);
            this.ListSchedule.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1765, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сортировка эффективности";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HallsManager
            // 
            this.HallsManager.Location = new System.Drawing.Point(1808, 12);
            this.HallsManager.Name = "HallsManager";
            this.HallsManager.Size = new System.Drawing.Size(80, 38);
            this.HallsManager.TabIndex = 4;
            this.HallsManager.Text = "Управление залами";
            this.HallsManager.UseVisualStyleBackColor = true;
            this.HallsManager.Click += new System.EventHandler(this.HallsManager_Click);
            // 
            // FilmsManager
            // 
            this.FilmsManager.Location = new System.Drawing.Point(1808, 56);
            this.FilmsManager.Name = "FilmsManager";
            this.FilmsManager.Size = new System.Drawing.Size(80, 38);
            this.FilmsManager.TabIndex = 5;
            this.FilmsManager.Text = "Управление фильмами";
            this.FilmsManager.UseVisualStyleBackColor = true;
            this.FilmsManager.Click += new System.EventHandler(this.FilmsManager_Click);
            // 
            // ListSortEfficiency
            // 
            this.ListSortEfficiency.FormattingEnabled = true;
            this.ListSortEfficiency.Location = new System.Drawing.Point(595, 10);
            this.ListSortEfficiency.Name = "ListSortEfficiency";
            this.ListSortEfficiency.Size = new System.Drawing.Size(579, 498);
            this.ListSortEfficiency.TabIndex = 6;
            // 
            // ListSortNotRepeat
            // 
            this.ListSortNotRepeat.FormattingEnabled = true;
            this.ListSortNotRepeat.Location = new System.Drawing.Point(595, 517);
            this.ListSortNotRepeat.Name = "listBox2";
            this.ListSortNotRepeat.Size = new System.Drawing.Size(579, 498);
            this.ListSortNotRepeat.TabIndex = 7;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(1180, 517);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(579, 498);
            this.listBox3.TabIndex = 9;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(1180, 10);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(579, 498);
            this.listBox4.TabIndex = 8;
            // 
            // CreateShedule
            // 
            this.CreateShedule.Location = new System.Drawing.Point(1765, 345);
            this.CreateShedule.Name = "CreateShedule";
            this.CreateShedule.Size = new System.Drawing.Size(126, 40);
            this.CreateShedule.TabIndex = 10;
            this.CreateShedule.Text = "Составить расписание";
            this.CreateShedule.UseVisualStyleBackColor = true;
            this.CreateShedule.Click += new System.EventHandler(this.CreateShedule_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1900, 1037);
            this.Controls.Add(this.CreateShedule);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.ListSortNotRepeat);
            this.Controls.Add(this.ListSortEfficiency);
            this.Controls.Add(this.FilmsManager);
            this.Controls.Add(this.HallsManager);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListSchedule);
            this.Controls.Add(this.ScheduleView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Movie Schedule";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Schedule_FormClosing);
            this.Resize += new System.EventHandler(this.Schedule_Resize);
            this.ResumeLayout(false);

        }

        



        #endregion
        private System.Windows.Forms.Button ScheduleView;
        private System.Windows.Forms.ListBox ListSchedule;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button HallsManager;
        private System.Windows.Forms.Button FilmsManager;
        private System.Windows.Forms.ListBox ListSortEfficiency;
        private System.Windows.Forms.ListBox ListSortNotRepeat;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button CreateShedule;
    }
}