
namespace HWCinema.Forms
{
    partial class ScheduleManager
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
            this.NameMovie = new System.Windows.Forms.ComboBox();
            this.FilmsSource = new System.Windows.Forms.BindingSource(this.components);
            this.CountFilms = new System.Windows.Forms.NumericUpDown();
            this.TextTimeMinutes = new System.Windows.Forms.TextBox();
            this.TimeFilm = new System.Windows.Forms.NumericUpDown();
            this.SaveSchedule = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FilmsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountFilms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // NameMovie
            // 
            this.NameMovie.DataBindings.Add(new System.Windows.Forms.Binding("Name", this.FilmsSource, "Name", true));
            this.NameMovie.DataSource = this.FilmsSource;
            this.NameMovie.DisplayMember = "Name";
            this.NameMovie.FormattingEnabled = true;
            this.NameMovie.Location = new System.Drawing.Point(83, 38);
            this.NameMovie.Name = "NameMovie";
            this.NameMovie.Size = new System.Drawing.Size(286, 21);
            this.NameMovie.TabIndex = 0;
            this.NameMovie.SelectedIndexChanged += new System.EventHandler(this.NameMovie_SelectedIndexChanged);
            this.NameMovie.TextUpdate += new System.EventHandler(this.NameMovie_TextChanged);
            this.NameMovie.Click += new System.EventHandler(this.NameMovie_Click);
            // 
            // FilmsSource
            // 
            this.FilmsSource.AllowNew = true;
            this.FilmsSource.DataMember = "Films";
            this.FilmsSource.DataSource = typeof(HWCinema.CoreFolders.Core);
            this.FilmsSource.Sort = "";
            // 
            // CountFilms
            // 
            this.CountFilms.Location = new System.Drawing.Point(12, 38);
            this.CountFilms.Maximum = new decimal(new int[] {
            840,
            0,
            0,
            0});
            this.CountFilms.Name = "CountFilms";
            this.CountFilms.Size = new System.Drawing.Size(56, 20);
            this.CountFilms.TabIndex = 1;
            this.CountFilms.ValueChanged += new System.EventHandler(this.CountFilms_ValueChanged);
            // 
            // TextTimeMinutes
            // 
            this.TextTimeMinutes.Location = new System.Drawing.Point(375, 12);
            this.TextTimeMinutes.Name = "TextTimeMinutes";
            this.TextTimeMinutes.Size = new System.Drawing.Size(66, 20);
            this.TextTimeMinutes.TabIndex = 3;
            this.TextTimeMinutes.Text = "Минут";
            this.TextTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeFilm
            // 
            this.TimeFilm.Location = new System.Drawing.Point(375, 38);
            this.TimeFilm.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.TimeFilm.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimeFilm.Name = "TimeFilm";
            this.TimeFilm.Size = new System.Drawing.Size(66, 20);
            this.TimeFilm.TabIndex = 4;
            this.TimeFilm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeFilm.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimeFilm.ValueChanged += new System.EventHandler(this.TimeFilm_ValueChanged);
            // 
            // SaveSchedule
            // 
            this.SaveSchedule.Location = new System.Drawing.Point(157, 89);
            this.SaveSchedule.Name = "SaveSchedule";
            this.SaveSchedule.Size = new System.Drawing.Size(140, 30);
            this.SaveSchedule.TabIndex = 7;
            this.SaveSchedule.Text = "Сохранить изменения";
            this.SaveSchedule.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Минут";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Минут";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScheduleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(452, 134);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveSchedule);
            this.Controls.Add(this.TimeFilm);
            this.Controls.Add(this.TextTimeMinutes);
            this.Controls.Add(this.CountFilms);
            this.Controls.Add(this.NameMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Location = new System.Drawing.Point(1440, 800);
            this.MaximumSize = new System.Drawing.Size(468, 173);
            this.MinimumSize = new System.Drawing.Size(468, 173);
            this.Name = "ScheduleManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Schedule Manager";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.FilmsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountFilms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NameMovie;
        private System.Windows.Forms.NumericUpDown CountFilms;
        private System.Windows.Forms.TextBox TextTimeMinutes;
        private System.Windows.Forms.NumericUpDown TimeFilm;
        private System.Windows.Forms.BindingSource FilmsSource;
        private System.Windows.Forms.Button SaveSchedule;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}