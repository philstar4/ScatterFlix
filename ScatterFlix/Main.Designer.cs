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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.okButton.Location = new System.Drawing.Point(471, 381);
            this.okButton.Size = new System.Drawing.Size(193, 40);
            this.okButton.Text = "Search";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Default Preferences";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(471, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(193, 338);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(689, 539);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
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
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.listView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ratingSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}
