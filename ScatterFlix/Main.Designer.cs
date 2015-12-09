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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.prefsButton = new System.Windows.Forms.Button();
            this.watchListCheckBox = new System.Windows.Forms.CheckBox();
            this.mainMoviesList = new System.Windows.Forms.ListView();
            this.movieTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.movieScatter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ratingSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieScatter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 362);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.Text = "Search Criteria";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(670, 513);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Size = new System.Drawing.Size(10, 14);
            this.okButton.Text = "Search";
            this.okButton.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(14, 410);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(73, 409);
            this.titleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // actorLabel
            // 
            this.actorLabel.Location = new System.Drawing.Point(14, 445);
            this.actorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // actorBox
            // 
            this.actorBox.Location = new System.Drawing.Point(73, 444);
            this.actorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // directorBox
            // 
            this.directorBox.Location = new System.Drawing.Point(73, 481);
            this.directorBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // directorLabel
            // 
            this.directorLabel.Location = new System.Drawing.Point(14, 482);
            this.directorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(336, 409);
            this.yearBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(286, 410);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(336, 444);
            this.genreBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // genreLabel
            // 
            this.genreLabel.Location = new System.Drawing.Point(286, 446);
            this.genreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // ratingSlider
            // 
            this.ratingSlider.Location = new System.Drawing.Point(336, 482);
            this.ratingSlider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // ratingLabel
            // 
            this.ratingLabel.Location = new System.Drawing.Point(286, 482);
            this.ratingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.LightCoral;
            this.cancelButton.Location = new System.Drawing.Point(471, 430);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Size = new System.Drawing.Size(193, 40);
            this.cancelButton.Text = "Reset";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // prefsButton
            // 
            this.prefsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prefsButton.Location = new System.Drawing.Point(471, 476);
            this.prefsButton.Name = "prefsButton";
            this.prefsButton.Size = new System.Drawing.Size(193, 40);
            this.prefsButton.TabIndex = 15;
            this.prefsButton.Text = "Default Preferences";
            this.prefsButton.UseVisualStyleBackColor = false;
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
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.GreenYellow;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(471, 382);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(193, 42);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "SEARCH!";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // movieScatter
            // 
            chartArea1.AxisX.Maximum = 2010D;
            chartArea1.AxisX.Minimum = 1900D;
            chartArea1.AxisX.Title = "Year";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Rating";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.movieScatter.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.movieScatter.Legends.Add(legend1);
            this.movieScatter.Location = new System.Drawing.Point(17, 13);
            this.movieScatter.Margin = new System.Windows.Forms.Padding(2);
            this.movieScatter.Name = "movieScatter";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "movies";
            this.movieScatter.Series.Add(series1);
            this.movieScatter.Size = new System.Drawing.Size(441, 344);
            this.movieScatter.TabIndex = 21;
            this.movieScatter.Text = "chart1";
            this.movieScatter.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(689, 539);
            this.Controls.Add(this.movieScatter);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.mainMoviesList);
            this.Controls.Add(this.watchListCheckBox);
            this.Controls.Add(this.prefsButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.Controls.SetChildIndex(this.searchButton, 0);
            this.Controls.SetChildIndex(this.movieScatter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ratingSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieScatter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prefsButton;
        private System.Windows.Forms.CheckBox watchListCheckBox;
        private System.Windows.Forms.ListView mainMoviesList;
        private System.Windows.Forms.ColumnHeader movieTitle;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart movieScatter;
    }
}
