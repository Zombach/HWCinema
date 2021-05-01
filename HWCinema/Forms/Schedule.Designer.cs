
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
            this.NameMovie = new System.Windows.Forms.ComboBox();
            this.CountFilms = new System.Windows.Forms.NumericUpDown();
            this.TimeFilm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CountFilms)).BeginInit();
            this.SuspendLayout();
            // 
            // NameMovie
            // 
            this.NameMovie.FormattingEnabled = true;
            this.NameMovie.Location = new System.Drawing.Point(193, 69);
            this.NameMovie.Name = "NameMovie";
            this.NameMovie.Size = new System.Drawing.Size(286, 21);
            this.NameMovie.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.CountFilms.Location = new System.Drawing.Point(74, 71);
            this.CountFilms.Name = "numericUpDown1";
            this.CountFilms.Size = new System.Drawing.Size(56, 20);
            this.CountFilms.TabIndex = 1;
            this.CountFilms.ValueChanged += new System.EventHandler(this.CountFilms_ValueChanged);
            // 
            // TimeFilm
            // 
            this.TimeFilm.Location = new System.Drawing.Point(509, 69);
            this.TimeFilm.Name = "TimeFilm";
            this.TimeFilm.Size = new System.Drawing.Size(120, 20);
            this.TimeFilm.TabIndex = 2;
            this.TimeFilm.Text = "00";
            this.TimeFilm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeFilm);
            this.Controls.Add(this.CountFilms);
            this.Controls.Add(this.NameMovie);
            this.Name = "Schedule";
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.CountFilms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NameMovie;
        private System.Windows.Forms.NumericUpDown CountFilms;
        private System.Windows.Forms.TextBox TimeFilm;
    }
}