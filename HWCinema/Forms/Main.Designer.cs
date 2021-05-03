
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
            this.Loading = new System.Windows.Forms.Button();
            this.Saving = new System.Windows.Forms.Button();
            this.CreateSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Loading
            // 
            this.Loading.Location = new System.Drawing.Point(44, 168);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(200, 80);
            this.Loading.TabIndex = 2;
            this.Loading.Text = "Загрузить расписание";
            this.Loading.UseVisualStyleBackColor = true;
            this.Loading.Click += new System.EventHandler(this.Loading_Click);
            // 
            // Saving
            // 
            this.Saving.Location = new System.Drawing.Point(312, 168);
            this.Saving.Name = "Saving";
            this.Saving.Size = new System.Drawing.Size(200, 80);
            this.Saving.TabIndex = 3;
            this.Saving.Text = "Выгрузить расписание";
            this.Saving.UseVisualStyleBackColor = true;
            this.Saving.Click += new System.EventHandler(this.Saving_Click);
            // 
            // CreateSchedule
            // 
            this.CreateSchedule.Location = new System.Drawing.Point(182, 36);
            this.CreateSchedule.Name = "CreateSchedule";
            this.CreateSchedule.Size = new System.Drawing.Size(200, 80);
            this.CreateSchedule.TabIndex = 4;
            this.CreateSchedule.Text = "Составить расписание";
            this.CreateSchedule.UseVisualStyleBackColor = true;
            this.CreateSchedule.Click += new System.EventHandler(this.CreateSchedule_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 353);
            this.Controls.Add(this.CreateSchedule);
            this.Controls.Add(this.Saving);
            this.Controls.Add(this.Loading);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Loading;
        private System.Windows.Forms.Button Saving;
        private System.Windows.Forms.Button CreateSchedule;
    }
}