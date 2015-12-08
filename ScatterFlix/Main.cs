using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScatterFlix
{
    public partial class Main : Preferences
    {
        public Main()
        {
            InitializeComponent();
        }

        //search button
        public override void okButton_Click(object sender, EventArgs e)
        {
            if(fieldsEmpty())
            {

            }
        }

        public override void cancelButton_Click(object sender, EventArgs e)
        {
            clearSearchFields();
        }

        private void clearSearchFields()
        {
            titleBox.Clear();
            actorBox.SelectedIndex = -1;
            directorBox.SelectedIndex = -1;
            yearBox.SelectedIndex = -1;
            genreBox.SelectedIndex = -1;
            ratingSlider.Value = 0;
        }

        private bool fieldsEmpty()
        {
            if((titleBox.Text == "") && (actorBox.SelectedIndex == -1) 
                && (directorBox.SelectedIndex == -1) && (yearBox.SelectedIndex == -1) 
                && (genreBox.SelectedIndex == -1) && (ratingSlider.Value == 0))
            {
                return true;
            }
            return false;
        }
    }
}
