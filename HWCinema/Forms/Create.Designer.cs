
using HWСinema.CoreFolders;

namespace HWСinema.Forms
{
    partial class Create
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
            this.CoreSource = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.CoreSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Halls
            // 
            this.Halls.DataBindings.Add(new System.Windows.Forms.Binding("Name", this.CoreSource, "Name", true));
            this.Halls.DataSource = this.CoreSource;
            this.Halls.DisplayMember = "Name";
            this.Halls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Halls.Location = new System.Drawing.Point(12, 12);
            this.Halls.Name = "Halls";
            this.Halls.Size = new System.Drawing.Size(206, 21);
            this.Halls.TabIndex = 0;
            this.Halls.SelectedIndexChanged += new System.EventHandler(this.Halls_SelectedIndexChanged);
            // 
            // CoreSource
            // 
            this.CoreSource.AllowNew = false;
            this.CoreSource.DataMember = "Halls";
            this.CoreSource.Sort = "";
            // 
            // AddHall
            // 
            this.AddHall.Location = new System.Drawing.Point(12, 228);
            this.AddHall.Name = "AddHall";
            this.AddHall.Size = new System.Drawing.Size(206, 35);
            this.AddHall.TabIndex = 1;
            this.AddHall.Text = "Внести новый зал";
            this.AddHall.UseVisualStyleBackColor = true;
            this.AddHall.Click += new System.EventHandler(this.AddHall_Click);
            // 
            // NameNewHall
            // 
            this.NameNewHall.Location = new System.Drawing.Point(12, 202);
            this.NameNewHall.Name = "NameNewHall";
            this.NameNewHall.Size = new System.Drawing.Size(206, 20);
            this.NameNewHall.TabIndex = 2;
            this.NameNewHall.Text = "Введите название зала";
            this.NameNewHall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameNewHall.TextChanged += new System.EventHandler(this.NameNewHall_TextChanged);
            // 
            // RemoveHall
            // 
            this.RemoveHall.Location = new System.Drawing.Point(224, 12);
            this.RemoveHall.Name = "RemoveHall";
            this.RemoveHall.Size = new System.Drawing.Size(66, 43);
            this.RemoveHall.TabIndex = 3;
            this.RemoveHall.Text = "Удалить зал";
            this.RemoveHall.UseVisualStyleBackColor = true;
            this.RemoveHall.Click += new System.EventHandler(this.RemoveHall_Click);
            // 
            // TimeOpenHours
            // 
            this.TimeOpenHours.Location = new System.Drawing.Point(346, 116);
            this.TimeOpenHours.Name = "TimeOpenHours";
            this.TimeOpenHours.Size = new System.Drawing.Size(47, 20);
            this.TimeOpenHours.TabIndex = 4;
            this.TimeOpenHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(346, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Время работы";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextOpening
            // 
            this.TextOpening.Enabled = false;
            this.TextOpening.Location = new System.Drawing.Point(346, 90);
            this.TextOpening.Name = "TextOpening";
            this.TextOpening.Size = new System.Drawing.Size(107, 20);
            this.TextOpening.TabIndex = 7;
            this.TextOpening.Text = "Открытие";
            this.TextOpening.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextClosing
            // 
            this.TextClosing.Enabled = false;
            this.TextClosing.Location = new System.Drawing.Point(346, 142);
            this.TextClosing.Name = "TextClosing";
            this.TextClosing.Size = new System.Drawing.Size(107, 20);
            this.TextClosing.TabIndex = 8;
            this.TextClosing.Text = "Закрытие";
            this.TextClosing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeOpenMinutes
            // 
            this.TimeOpenMinutes.Location = new System.Drawing.Point(409, 116);
            this.TimeOpenMinutes.Name = "TimeOpenMinutes";
            this.TimeOpenMinutes.Size = new System.Drawing.Size(44, 20);
            this.TimeOpenMinutes.TabIndex = 9;
            this.TimeOpenMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeCloseMinutes
            // 
            this.TimeCloseMinutes.Location = new System.Drawing.Point(409, 168);
            this.TimeCloseMinutes.Name = "TimeCloseMinutes";
            this.TimeCloseMinutes.Size = new System.Drawing.Size(44, 20);
            this.TimeCloseMinutes.TabIndex = 11;
            this.TimeCloseMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeCloseHours
            // 
            this.TimeCloseHours.Location = new System.Drawing.Point(346, 168);
            this.TimeCloseHours.Name = "TimeCloseHours";
            this.TimeCloseHours.Size = new System.Drawing.Size(47, 20);
            this.TimeCloseHours.TabIndex = 10;
            this.TimeCloseHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetTimeWork
            // 
            this.SetTimeWork.Location = new System.Drawing.Point(333, 194);
            this.SetTimeWork.Name = "SetTimeWork";
            this.SetTimeWork.Size = new System.Drawing.Size(136, 35);
            this.SetTimeWork.TabIndex = 12;
            this.SetTimeWork.Text = "Установить время";
            this.SetTimeWork.UseVisualStyleBackColor = true;
            this.SetTimeWork.Click += new System.EventHandler(this.SetTimeWork_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 292);
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
            this.Name = "Create";
            this.Text = "Create";
            ((System.ComponentModel.ISupportInitialize)(this.CoreSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Halls;
        private System.Windows.Forms.Button AddHall;
        private System.Windows.Forms.TextBox NameNewHall;
        private System.Windows.Forms.BindingSource CoreSource;
        private System.Windows.Forms.Button RemoveHall;
        private System.Windows.Forms.TextBox TimeOpenHours;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextOpening;
        private System.Windows.Forms.TextBox TextClosing;
        private System.Windows.Forms.TextBox TimeOpenMinutes;
        private System.Windows.Forms.TextBox TimeCloseMinutes;
        private System.Windows.Forms.TextBox TimeCloseHours;
        private System.Windows.Forms.Button SetTimeWork;
    }
}