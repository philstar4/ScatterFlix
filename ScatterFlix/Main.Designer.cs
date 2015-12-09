namespace ScatterFlix
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
            this.prefsButton = new System.Windows.Forms.Button();
            this.watchListCheckBox = new System.Windows.Forms.CheckBox();
            this.mainMoviesList = new System.Windows.Forms.ListView();
            this.movieTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ratingSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.Text = "Search Criteria";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(670, 513);
            this.okButton.Size = new System.Drawing.Size(10, 14);
            this.okButton.Text = "Search";
            this.okButton.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(14, 410);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(73, 409);
            // 
            // actorLabel
            // 
            this.actorLabel.Location = new System.Drawing.Point(14, 445);
            // 
            // actorBox
            // 
            this.actorBox.Location = new System.Drawing.Point(73, 444);
            // 
            // directorBox
            // 
            this.directorBox.Location = new System.Drawing.Point(73, 481);
            // 
            // directorLabel
            // 
            this.directorLabel.Location = new System.Drawing.Point(14, 482);
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(336, 409);
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(286, 410);
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(336, 444);
            // 
            // genreLabel
            // 
            this.genreLabel.Location = new System.Drawing.Point(286, 446);
            // 
            // ratingSlider
            // 
            this.ratingSlider.Location = new System.Drawing.Point(336, 482);
            // 
            // ratingLabel
            // 
            this.ratingLabel.Location = new System.Drawing.Point(286, 482);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(471, 430);
            this.cancelButton.Size = new System.Drawing.Size(193, 40);
            this.cancelButton.Text = "Reset";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // prefsButton
            // 
            this.prefsButton.Location = new System.Drawing.Point(471, 476);
            this.prefsButton.Name = "prefsButton";
            this.prefsButton.Size = new System.Drawing.Size(193, 40);
            this.prefsButton.TabIndex = 15;
            this.prefsButton.Text = "Default Preferences";
            this.prefsButton.UseVisualStyleBackColor = true;
            this.prefsButton.Click += new System.EventHandler(this.prefsButton_Click);
            // 
            // watchListCheckBox
            // 
            this.watchListCheckBox.AutoSize = true;
            this.watchListCheckBox.Location = new System.Drawing.Point(188, 370);
            this.watchListCheckBox.Name = "watchListCheckBox";
            this.watchListCheckBox.Size = new System.Drawing.Size(77, 17);
            this.watchListCheckBox.TabIndex = 18;
            this.watchListCheckBox.Text = "Watch List";
            this.watchListCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainMoviesList
            // 
            this.mainMoviesList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.mainMoviesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.movieTitle});
            this.mainMoviesList.FullRowSelect = true;
            this.mainMoviesList.GridLines = true;
            this.mainMoviesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.mainMoviesList.Location = new System.Drawing.Point(471, 13);
            this.mainMoviesList.MultiSelect = false;
            this.mainMoviesList.Name = "mainMoviesList";
            this.mainMoviesList.ShowGroups = false;
            this.mainMoviesList.Size = new System.Drawing.Size(193, 345);
            this.mainMoviesList.TabIndex = 19;
            this.mainMoviesList.UseCompatibleStateImageBehavior = false;
            this.mainMoviesList.View = System.Windows.Forms.View.Details;
            this.mainMoviesList.DoubleClick += new System.EventHandler(this.mainMoviesList_MovieDoubleClicked);
            // 
            // movieTitle
            // 
            this.movieTitle.Text = "";
            this.movieTitle.Width = 189;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 42);
            this.button1.TabIndex = 20;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(689, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainMoviesList);
            this.Controls.Add(this.watchListCheckBox);
            this.Controls.Add(this.prefsButton);
            this.Name = "Main";
            this.Text = "ScatterFlix";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.Controls.SetChildIndex(this.titleBox, 0);
            this.Controls.SetChildIndex(this.actorLabel, 0);
            this.Controls.SetChildIndex(this.actorBox, 0);
            this.Controls.SetChildIndex(this.directorBox, 0);
            this.Controls.SetChildIndex(this.directorLabel, 0);
            this.Controls.SetChildIndex(this.yearBox, 0);
            this.Controls.SetChildIndex(this.yearLabel, 0);
            this.Controls.SetChildIndex(this.genreBox, 0);
            this.Controls.SetChildIndex(this.genreLabel, 0);
            this.Controls.SetChildIndex(this.ratingSlider, 0);
            this.Controls.SetChildIndex(this.ratingLabel, 0);
            this.Controls.SetChildIndex(this.okButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.prefsButton, 0);
            this.Controls.SetChildIndex(this.watchListCheckBox, 0);
            this.Controls.SetChildIndex(this.mainMoviesList, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ratingSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prefsButton;
        private System.Windows.Forms.CheckBox watchListCheckBox;
        private System.Windows.Forms.ListView mainMoviesList;
        private System.Windows.Forms.ColumnHeader movieTitle;
        private System.Windows.Forms.Button button1;
    }
}
