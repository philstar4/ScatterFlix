using System.IO;
using System.Xml.Linq;

namespace ScatterFlix
{
    partial class Preferences
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.actorLabel = new System.Windows.Forms.Label();
            this.actorBox = new System.Windows.Forms.ComboBox();
            this.directorBox = new System.Windows.Forms.ComboBox();
            this.directorLabel = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreBox = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.ratingSlider = new System.Windows.Forms.TrackBar();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ratingSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Preferences";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(21, 88);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(50, 22);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(110, 86);
            this.titleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(268, 26);
            this.titleBox.TabIndex = 2;
            // 
            // actorLabel
            // 
            this.actorLabel.AutoSize = true;
            this.actorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorLabel.Location = new System.Drawing.Point(21, 142);
            this.actorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actorLabel.Name = "actorLabel";
            this.actorLabel.Size = new System.Drawing.Size(57, 22);
            this.actorLabel.TabIndex = 3;
            this.actorLabel.Text = "Actor:";
            // 
            // actorBox
            // 
            this.actorBox.FormattingEnabled = true;
            this.actorBox.Location = new System.Drawing.Point(110, 140);
            this.actorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actorBox.Name = "actorBox";
            this.actorBox.Size = new System.Drawing.Size(268, 28);
            this.actorBox.Sorted = true;
            this.actorBox.TabIndex = 4;
            // 
            // directorBox
            // 
            this.directorBox.FormattingEnabled = true;
            this.directorBox.Location = new System.Drawing.Point(110, 197);
            this.directorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.directorBox.Name = "directorBox";
            this.directorBox.Size = new System.Drawing.Size(268, 28);
            this.directorBox.Sorted = true;
            this.directorBox.TabIndex = 5;
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorLabel.Location = new System.Drawing.Point(21, 198);
            this.directorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(78, 22);
            this.directorLabel.TabIndex = 6;
            this.directorLabel.Text = "Director:";
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(504, 86);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(122, 28);
            this.yearBox.Sorted = true;
            this.yearBox.TabIndex = 7;
            this.yearBox.Validating += new System.ComponentModel.CancelEventHandler(this.yearBox_Validating);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(429, 88);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(53, 22);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Year:";
            // 
            // genreBox
            // 
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(504, 140);
            this.genreBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(122, 28);
            this.genreBox.TabIndex = 9;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(429, 143);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(65, 22);
            this.genreLabel.TabIndex = 10;
            this.genreLabel.Text = "Genre:";
            // 
            // ratingSlider
            // 
            this.ratingSlider.Location = new System.Drawing.Point(504, 198);
            this.ratingSlider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ratingSlider.Name = "ratingSlider";
            this.ratingSlider.Size = new System.Drawing.Size(124, 69);
            this.ratingSlider.TabIndex = 11;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(429, 198);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(67, 22);
            this.ratingLabel.TabIndex = 12;
            this.ratingLabel.Text = "Rating:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(386, 263);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 35);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(516, 263);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 35);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(664, 322);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.ratingSlider);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.directorBox);
            this.Controls.Add(this.actorBox);
            this.Controls.Add(this.actorLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Preferences";
            this.Text = "Default Preferences";
            ((System.ComponentModel.ISupportInitialize)(this.ratingSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button okButton;
        protected System.Windows.Forms.Label titleLabel;
        protected System.Windows.Forms.TextBox titleBox;
        protected System.Windows.Forms.Label actorLabel;
        protected System.Windows.Forms.ComboBox actorBox;
        protected System.Windows.Forms.ComboBox directorBox;
        protected System.Windows.Forms.Label directorLabel;
        protected System.Windows.Forms.ComboBox yearBox;
        protected System.Windows.Forms.Label yearLabel;
        protected System.Windows.Forms.ComboBox genreBox;
        protected System.Windows.Forms.Label genreLabel;
        protected System.Windows.Forms.TrackBar ratingSlider;
        protected System.Windows.Forms.Label ratingLabel;
        protected System.Windows.Forms.Button cancelButton;
    }
}

