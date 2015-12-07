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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Preferences";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(14, 57);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 15);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(73, 56);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(180, 20);
            this.titleBox.TabIndex = 2;
            // 
            // actorLabel
            // 
            this.actorLabel.AutoSize = true;
            this.actorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorLabel.Location = new System.Drawing.Point(14, 92);
            this.actorLabel.Name = "actorLabel";
            this.actorLabel.Size = new System.Drawing.Size(37, 15);
            this.actorLabel.TabIndex = 3;
            this.actorLabel.Text = "Actor:";
            // 
            // actorBox
            // 
            this.actorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actorBox.FormattingEnabled = true;
            this.actorBox.Location = new System.Drawing.Point(73, 91);
            this.actorBox.Name = "actorBox";
            this.actorBox.Size = new System.Drawing.Size(180, 21);
            this.actorBox.Sorted = true;
            this.actorBox.TabIndex = 4;
            // 
            // directorBox
            // 
            this.directorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directorBox.FormattingEnabled = true;
            this.directorBox.Location = new System.Drawing.Point(73, 128);
            this.directorBox.Name = "directorBox";
            this.directorBox.Size = new System.Drawing.Size(180, 21);
            this.directorBox.Sorted = true;
            this.directorBox.TabIndex = 5;
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorLabel.Location = new System.Drawing.Point(14, 129);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(53, 15);
            this.directorLabel.TabIndex = 6;
            this.directorLabel.Text = "Director:";
            // 
            // yearBox
            // 
            this.yearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(336, 56);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(83, 21);
            this.yearBox.Sorted = true;
            this.yearBox.TabIndex = 7;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(286, 57);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(35, 15);
            this.yearLabel.TabIndex = 8;
            this.yearLabel.Text = "Year:";
            // 
            // genreBox
            // 
            this.genreBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreBox.FormattingEnabled = true;
            this.genreBox.Location = new System.Drawing.Point(336, 91);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(83, 21);
            this.genreBox.TabIndex = 9;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.Location = new System.Drawing.Point(286, 93);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(44, 15);
            this.genreLabel.TabIndex = 10;
            this.genreLabel.Text = "Genre:";
            // 
            // ratingSlider
            // 
            this.ratingSlider.Location = new System.Drawing.Point(336, 129);
            this.ratingSlider.Name = "ratingSlider";
            this.ratingSlider.Size = new System.Drawing.Size(83, 45);
            this.ratingSlider.TabIndex = 11;
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.Location = new System.Drawing.Point(286, 129);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(46, 15);
            this.ratingLabel.TabIndex = 12;
            this.ratingLabel.Text = "Rating:";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(257, 171);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(344, 171);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(443, 209);
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
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Default Preferences";
            ((System.ComponentModel.ISupportInitialize)(this.ratingSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label actorLabel;
        private System.Windows.Forms.ComboBox actorBox;
        private System.Windows.Forms.ComboBox directorBox;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox genreBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TrackBar ratingSlider;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

