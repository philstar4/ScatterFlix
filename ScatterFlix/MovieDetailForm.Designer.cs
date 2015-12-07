namespace ScatterFlix
{
    partial class MovieDetailForm
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
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblOverallRating = new System.Windows.Forms.Label();
            this.lblYourRating = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblSubgenres = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblCast = new System.Windows.Forms.Label();
            this.imgMoviePoster = new System.Windows.Forms.PictureBox();
            this.btnWatchList = new System.Windows.Forms.Button();
            this.txtRuntime = new System.Windows.Forms.Label();
            this.txtSubgenres = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.Label();
            this.txtCast = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgMoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(16, 16);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(136, 29);
            this.lblMovieTitle.TabIndex = 0;
            this.lblMovieTitle.Text = "movieTitle";
            // 
            // lblOverallRating
            // 
            this.lblOverallRating.AutoSize = true;
            this.lblOverallRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallRating.Location = new System.Drawing.Point(232, 56);
            this.lblOverallRating.Name = "lblOverallRating";
            this.lblOverallRating.Size = new System.Drawing.Size(127, 20);
            this.lblOverallRating.TabIndex = 1;
            this.lblOverallRating.Text = "Overall Rating:";
            // 
            // lblYourRating
            // 
            this.lblYourRating.AutoSize = true;
            this.lblYourRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourRating.Location = new System.Drawing.Point(232, 128);
            this.lblYourRating.Name = "lblYourRating";
            this.lblYourRating.Size = new System.Drawing.Size(110, 20);
            this.lblYourRating.TabIndex = 2;
            this.lblYourRating.Text = "Your Rating:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(232, 200);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(78, 20);
            this.lblDirector.TabIndex = 3;
            this.lblDirector.Text = "Director:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(232, 240);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 20);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(232, 280);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(64, 20);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Genre:";
            // 
            // lblSubgenres
            // 
            this.lblSubgenres.AutoSize = true;
            this.lblSubgenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubgenres.Location = new System.Drawing.Point(232, 320);
            this.lblSubgenres.Name = "lblSubgenres";
            this.lblSubgenres.Size = new System.Drawing.Size(101, 20);
            this.lblSubgenres.TabIndex = 6;
            this.lblSubgenres.Text = "Subgenres:";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuntime.Location = new System.Drawing.Point(232, 360);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(81, 20);
            this.lblRuntime.TabIndex = 7;
            this.lblRuntime.Text = "Runtime:";
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCast.Location = new System.Drawing.Point(472, 56);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(51, 20);
            this.lblCast.TabIndex = 8;
            this.lblCast.Text = "Cast:";
            // 
            // imgMoviePoster
            // 
            this.imgMoviePoster.Location = new System.Drawing.Point(16, 64);
            this.imgMoviePoster.Name = "imgMoviePoster";
            this.imgMoviePoster.Size = new System.Drawing.Size(176, 256);
            this.imgMoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMoviePoster.TabIndex = 9;
            this.imgMoviePoster.TabStop = false;
            // 
            // btnWatchList
            // 
            this.btnWatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWatchList.Location = new System.Drawing.Point(16, 352);
            this.btnWatchList.Name = "btnWatchList";
            this.btnWatchList.Size = new System.Drawing.Size(176, 31);
            this.btnWatchList.TabIndex = 10;
            this.btnWatchList.Text = "Add to Watch List";
            this.btnWatchList.UseVisualStyleBackColor = true;
            // 
            // txtRuntime
            // 
            this.txtRuntime.AutoSize = true;
            this.txtRuntime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuntime.Location = new System.Drawing.Point(344, 360);
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.Size = new System.Drawing.Size(62, 20);
            this.txtRuntime.TabIndex = 15;
            this.txtRuntime.Text = "runtime";
            // 
            // txtSubgenres
            // 
            this.txtSubgenres.AutoSize = true;
            this.txtSubgenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubgenres.Location = new System.Drawing.Point(344, 320);
            this.txtSubgenres.Name = "txtSubgenres";
            this.txtSubgenres.Size = new System.Drawing.Size(84, 20);
            this.txtSubgenres.TabIndex = 14;
            this.txtSubgenres.Text = "subgenres";
            // 
            // txtGenre
            // 
            this.txtGenre.AutoSize = true;
            this.txtGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenre.Location = new System.Drawing.Point(344, 280);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(50, 20);
            this.txtGenre.TabIndex = 13;
            this.txtGenre.Text = "genre";
            // 
            // txtYear
            // 
            this.txtYear.AutoSize = true;
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(344, 240);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(39, 20);
            this.txtYear.TabIndex = 12;
            this.txtYear.Text = "year";
            // 
            // txtDirector
            // 
            this.txtDirector.AutoSize = true;
            this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Location = new System.Drawing.Point(344, 200);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(62, 20);
            this.txtDirector.TabIndex = 11;
            this.txtDirector.Text = "director";
            // 
            // txtCast
            // 
            this.txtCast.AutoSize = true;
            this.txtCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCast.Location = new System.Drawing.Point(472, 80);
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(39, 20);
            this.txtCast.TabIndex = 16;
            this.txtCast.Text = "cast";
            // 
            // MovieDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 420);
            this.Controls.Add(this.txtCast);
            this.Controls.Add(this.txtRuntime);
            this.Controls.Add(this.txtSubgenres);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.btnWatchList);
            this.Controls.Add(this.imgMoviePoster);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.lblSubgenres);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblYourRating);
            this.Controls.Add(this.lblOverallRating);
            this.Controls.Add(this.lblMovieTitle);
            this.Name = "MovieDetailForm";
            this.Text = "MovieDetail";
            ((System.ComponentModel.ISupportInitialize)(this.imgMoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblOverallRating;
        private System.Windows.Forms.Label lblYourRating;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblSubgenres;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.PictureBox imgMoviePoster;
        private System.Windows.Forms.Button btnWatchList;
        private System.Windows.Forms.Label txtRuntime;
        private System.Windows.Forms.Label txtSubgenres;
        private System.Windows.Forms.Label txtGenre;
        private System.Windows.Forms.Label txtYear;
        private System.Windows.Forms.Label txtDirector;
        private System.Windows.Forms.Label txtCast;
    }
}