
using System;
using System.Windows.Forms;

namespace HWCinema.Forms
{
    partial class FilmsManager
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
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
            this.NameMovie.Location = new System.Drawing.Point(9, 38);
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
            this.CountFilms.Location = new System.Drawing.Point(9, 77);
            this.CountFilms.Maximum = new decimal(new int[] {
            840,
            0,
            0,
            0});
            this.CountFilms.Name = "CountFilms";
            this.CountFilms.Size = new System.Drawing.Size(86, 20);
            this.CountFilms.TabIndex = 1;
            this.CountFilms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CountFilms.ValueChanged += new System.EventHandler(this.CountFilms_ValueChanged);
            // 
            // TextTimeMinutes
            // 
            this.TextTimeMinutes.Location = new System.Drawing.Point(106, 101);
            this.TextTimeMinutes.Name = "TextTimeMinutes";
            this.TextTimeMinutes.Size = new System.Drawing.Size(88, 20);
            this.TextTimeMinutes.TabIndex = 3;
            this.TextTimeMinutes.Text = "Длительность";
            this.TextTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeFilm
            // 
            this.TimeFilm.Location = new System.Drawing.Point(9, 102);
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
            this.TimeFilm.Size = new System.Drawing.Size(86, 20);
            this.TimeFilm.TabIndex = 4;
            this.TimeFilm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeFilm.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.TimeFilm.ValueChanged += new System.EventHandler(this.TimeFilm_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Колличество";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Список фильмов";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(205, 95);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(226, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Прокатный";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FilmsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(304, 134);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TimeFilm);
            this.Controls.Add(this.TextTimeMinutes);
            this.Controls.Add(this.CountFilms);
            this.Controls.Add(this.NameMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Location = new System.Drawing.Point(1530, 800);
            this.MaximumSize = new System.Drawing.Size(320, 173);
            this.MinimumSize = new System.Drawing.Size(320, 173);
            this.Name = "FilmsManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Films Manager";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScheduleManager_FormClosing);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private CheckBox checkBox1;
        private TextBox textBox3;
    }
}