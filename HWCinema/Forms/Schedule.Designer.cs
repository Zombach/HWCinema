
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
            this.components = new System.ComponentModel.Container();
            this.NameMovie = new System.Windows.Forms.ComboBox();
            this.FilmsSource = new System.Windows.Forms.BindingSource(this.components);
            this.CountFilms = new System.Windows.Forms.NumericUpDown();
            this.TextTimeMinutes = new System.Windows.Forms.TextBox();
            this.TimeFilm = new System.Windows.Forms.NumericUpDown();
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
            this.NameMovie.Location = new System.Drawing.Point(193, 69);
            this.NameMovie.Name = "NameMovie";
            this.NameMovie.Size = new System.Drawing.Size(286, 21);
            this.NameMovie.TabIndex = 0;
            this.NameMovie.SelectedIndexChanged += new System.EventHandler(this.NameMovie_SelectedIndexChanged);
            this.NameMovie.TextUpdate += new System.EventHandler(this.NameMovie_TextChanged);
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
            this.CountFilms.Location = new System.Drawing.Point(74, 71);
            this.CountFilms.Name = "CountFilms";
            this.CountFilms.Size = new System.Drawing.Size(56, 20);
            this.CountFilms.TabIndex = 1;
            this.CountFilms.ValueChanged += new System.EventHandler(this.CountFilms_ValueChanged);
            // 
            // TextTimeMinutes
            // 
            this.TextTimeMinutes.Location = new System.Drawing.Point(590, 71);
            this.TextTimeMinutes.Name = "TextTimeMinutes";
            this.TextTimeMinutes.Size = new System.Drawing.Size(64, 20);
            this.TextTimeMinutes.TabIndex = 3;
            this.TextTimeMinutes.Text = "Минут";
            this.TextTimeMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeFilm
            // 
            this.TimeFilm.Location = new System.Drawing.Point(517, 72);
            this.TimeFilm.Name = "TimeFilm";
            this.TimeFilm.Size = new System.Drawing.Size(56, 20);
            this.TimeFilm.TabIndex = 4;
            this.TimeFilm.ValueChanged += new System.EventHandler(this.TimeFilm_ValueChanged);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeFilm);
            this.Controls.Add(this.TextTimeMinutes);
            this.Controls.Add(this.CountFilms);
            this.Controls.Add(this.NameMovie);
            this.Name = "Schedule";
            this.Text = "Schedule";
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
    }
}