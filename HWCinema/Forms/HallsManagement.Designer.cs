
using HWCinema.CoreFolders;

namespace HWCinema.Forms
{
    partial class HallsManagement
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
            this.components = new System.ComponentModel.Container();
            this.Halls = new System.Windows.Forms.ComboBox();
            this.HallsSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddHall = new System.Windows.Forms.Button();
            this.NameNewHall = new System.Windows.Forms.TextBox();
            this.RemoveHall = new System.Windows.Forms.Button();
            this.TimeOpenHours = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextOpening = new System.Windows.Forms.TextBox();
            this.TextClosing = new System.Windows.Forms.TextBox();
            this.TimeOpenMinutes = new System.Windows.Forms.TextBox();
            this.TimeCloseMinutes = new System.Windows.Forms.TextBox();
            this.TimeCloseHours = new System.Windows.Forms.TextBox();
            this.SetTimeWork = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.HallsSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Halls
            // 
            this.Halls.DataBindings.Add(new System.Windows.Forms.Binding("Name", this.HallsSource, "Name", true));
            this.Halls.DataSource = this.HallsSource;
            this.Halls.DisplayMember = "Name";
            this.Halls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Halls.Location = new System.Drawing.Point(12, 12);
            this.Halls.Name = "Halls";
            this.Halls.Size = new System.Drawing.Size(206, 21);
            this.Halls.TabIndex = 0;
            this.Halls.SelectedIndexChanged += new System.EventHandler(this.Halls_SelectedIndexChanged);
            // 
            // HallsSource
            // 
            this.HallsSource.AllowNew = true;
            this.HallsSource.DataMember = "Halls";
            this.HallsSource.DataSource = typeof(HWCinema.CoreFolders.Core);
            this.HallsSource.Sort = "";
            // 
            // AddHall
            // 
            this.AddHall.Location = new System.Drawing.Point(12, 153);
            this.AddHall.Name = "AddHall";
            this.AddHall.Size = new System.Drawing.Size(206, 35);
            this.AddHall.TabIndex = 1;
            this.AddHall.Text = "Внести новый зал";
            this.AddHall.UseVisualStyleBackColor = true;
            this.AddHall.Click += new System.EventHandler(this.AddHall_Click);
            // 
            // NameNewHall
            // 
            this.NameNewHall.Location = new System.Drawing.Point(12, 127);
            this.NameNewHall.Name = "NameNewHall";
            this.NameNewHall.Size = new System.Drawing.Size(206, 20);
            this.NameNewHall.TabIndex = 2;
            this.NameNewHall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameNewHall.TextChanged += new System.EventHandler(this.NameNewHall_TextChanged);
            // 
            // RemoveHall
            // 
            this.RemoveHall.Location = new System.Drawing.Point(152, 39);
            this.RemoveHall.Name = "RemoveHall";
            this.RemoveHall.Size = new System.Drawing.Size(66, 20);
            this.RemoveHall.TabIndex = 3;
            this.RemoveHall.Text = "Удалить зал";
            this.RemoveHall.UseVisualStyleBackColor = true;
            this.RemoveHall.Click += new System.EventHandler(this.RemoveHall_Click);
            // 
            // TimeOpenHours
            // 
            this.TimeOpenHours.Location = new System.Drawing.Point(236, 75);
            this.TimeOpenHours.Name = "TimeOpenHours";
            this.TimeOpenHours.Size = new System.Drawing.Size(47, 20);
            this.TimeOpenHours.TabIndex = 4;
            this.TimeOpenHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(236, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Время работы";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextOpening
            // 
            this.TextOpening.Enabled = false;
            this.TextOpening.Location = new System.Drawing.Point(236, 49);
            this.TextOpening.Name = "TextOpening";
            this.TextOpening.Size = new System.Drawing.Size(107, 20);
            this.TextOpening.TabIndex = 7;
            this.TextOpening.Text = "Открытие";
            this.TextOpening.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextClosing
            // 
            this.TextClosing.Enabled = false;
            this.TextClosing.Location = new System.Drawing.Point(236, 101);
            this.TextClosing.Name = "TextClosing";
            this.TextClosing.Size = new System.Drawing.Size(107, 20);
            this.TextClosing.TabIndex = 8;
            this.TextClosing.Text = "Закрытие";
            this.TextClosing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeOpenMinutes
            // 
            this.TimeOpenMinutes.Location = new System.Drawing.Point(299, 75);
            this.TimeOpenMinutes.Name = "TimeOpenMinutes";
            this.TimeOpenMinutes.Size = new System.Drawing.Size(44, 20);
            this.TimeOpenMinutes.TabIndex = 9;
            this.TimeOpenMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeCloseMinutes
            // 
            this.TimeCloseMinutes.Location = new System.Drawing.Point(299, 127);
            this.TimeCloseMinutes.Name = "TimeCloseMinutes";
            this.TimeCloseMinutes.Size = new System.Drawing.Size(44, 20);
            this.TimeCloseMinutes.TabIndex = 11;
            this.TimeCloseMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeCloseHours
            // 
            this.TimeCloseHours.Location = new System.Drawing.Point(236, 127);
            this.TimeCloseHours.Name = "TimeCloseHours";
            this.TimeCloseHours.Size = new System.Drawing.Size(47, 20);
            this.TimeCloseHours.TabIndex = 10;
            this.TimeCloseHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetTimeWork
            // 
            this.SetTimeWork.Location = new System.Drawing.Point(236, 153);
            this.SetTimeWork.Name = "SetTimeWork";
            this.SetTimeWork.Size = new System.Drawing.Size(107, 35);
            this.SetTimeWork.TabIndex = 12;
            this.SetTimeWork.Text = "Установить время";
            this.SetTimeWork.UseVisualStyleBackColor = true;
            this.SetTimeWork.Click += new System.EventHandler(this.SetTimeWork_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(12, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Введите название зала";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HallsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(356, 198);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SetTimeWork);
            this.Controls.Add(this.TimeCloseMinutes);
            this.Controls.Add(this.TimeCloseHours);
            this.Controls.Add(this.TimeOpenMinutes);
            this.Controls.Add(this.TextClosing);
            this.Controls.Add(this.TextOpening);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TimeOpenHours);
            this.Controls.Add(this.RemoveHall);
            this.Controls.Add(this.NameNewHall);
            this.Controls.Add(this.AddHall);
            this.Controls.Add(this.Halls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(1490, 100);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 237);
            this.MinimumSize = new System.Drawing.Size(372, 237);
            this.Name = "HallsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Halls Management";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.HallsSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Halls;
        private System.Windows.Forms.Button AddHall;
        private System.Windows.Forms.TextBox NameNewHall;
        private System.Windows.Forms.BindingSource HallsSource;
        private System.Windows.Forms.Button RemoveHall;
        private System.Windows.Forms.TextBox TimeOpenHours;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextOpening;
        private System.Windows.Forms.TextBox TextClosing;
        private System.Windows.Forms.TextBox TimeOpenMinutes;
        private System.Windows.Forms.TextBox TimeCloseMinutes;
        private System.Windows.Forms.TextBox TimeCloseHours;
        private System.Windows.Forms.Button SetTimeWork;
        private System.Windows.Forms.TextBox textBox2;
    }
}