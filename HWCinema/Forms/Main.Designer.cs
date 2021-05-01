
namespace HWCinema.Forms
{
    partial class Main
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
            this.ManagementHalls = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.Loading = new System.Windows.Forms.Button();
            this.Saving = new System.Windows.Forms.Button();
            this.MakeSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManagementHalls
            // 
            this.ManagementHalls.Location = new System.Drawing.Point(66, 62);
            this.ManagementHalls.Name = "ManagementHalls";
            this.ManagementHalls.Size = new System.Drawing.Size(200, 80);
            this.ManagementHalls.TabIndex = 0;
            this.ManagementHalls.Text = "Управленние залами";
            this.ManagementHalls.UseVisualStyleBackColor = true;
            this.ManagementHalls.Click += new System.EventHandler(this.Create_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(314, 62);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(200, 80);
            this.View.TabIndex = 1;
            this.View.Text = "Отобразить расписание";
            this.View.UseVisualStyleBackColor = true;
            // 
            // Loading
            // 
            this.Loading.Location = new System.Drawing.Point(314, 234);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(200, 80);
            this.Loading.TabIndex = 2;
            this.Loading.Text = "Загрузить расписание";
            this.Loading.UseVisualStyleBackColor = true;
            // 
            // Saving
            // 
            this.Saving.Location = new System.Drawing.Point(66, 234);
            this.Saving.Name = "Saving";
            this.Saving.Size = new System.Drawing.Size(200, 80);
            this.Saving.TabIndex = 3;
            this.Saving.Text = "Выгрузить расписание";
            this.Saving.UseVisualStyleBackColor = true;
            // 
            // MakeSchedule
            // 
            this.MakeSchedule.Location = new System.Drawing.Point(221, 167);
            this.MakeSchedule.Name = "MakeSchedule";
            this.MakeSchedule.Size = new System.Drawing.Size(148, 48);
            this.MakeSchedule.TabIndex = 4;
            this.MakeSchedule.Text = "Составить расписание";
            this.MakeSchedule.UseVisualStyleBackColor = true;
            this.MakeSchedule.Click += new System.EventHandler(this.MakeSchedule_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 353);
            this.Controls.Add(this.MakeSchedule);
            this.Controls.Add(this.Saving);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.View);
            this.Controls.Add(this.ManagementHalls);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManagementHalls;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button Loading;
        private System.Windows.Forms.Button Saving;
        private System.Windows.Forms.Button MakeSchedule;
    }
}