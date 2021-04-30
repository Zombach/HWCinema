
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
            this.TimeOpen = new System.Windows.Forms.TextBox();
            this.TimeClose = new System.Windows.Forms.TextBox();
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
            // TimeOpen
            // 
            this.TimeOpen.Location = new System.Drawing.Point(611, 95);
            this.TimeOpen.Name = "TimeOpen";
            this.TimeOpen.Size = new System.Drawing.Size(107, 20);
            this.TimeOpen.TabIndex = 4;
            // 
            // TimeClose
            // 
            this.TimeClose.Location = new System.Drawing.Point(611, 121);
            this.TimeClose.Name = "TimeClose";
            this.TimeClose.Size = new System.Drawing.Size(107, 20);
            this.TimeClose.TabIndex = 5;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeClose);
            this.Controls.Add(this.TimeOpen);
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
        private System.Windows.Forms.TextBox TimeOpen;
        private System.Windows.Forms.TextBox TimeClose;
    }
}