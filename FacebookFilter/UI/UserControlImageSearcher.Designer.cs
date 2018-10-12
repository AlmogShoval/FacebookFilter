namespace UI
{
    public partial class UserControlImageSearcher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(string.Empty);
            this.checkBoxUserTaggedWith = new System.Windows.Forms.CheckedListBox();
            this.listViewPhotoDisplay = new System.Windows.Forms.ListView();
            this.buttonSearchPhotos = new System.Windows.Forms.Button();
            this.buttonOpenSelectedPhoto = new System.Windows.Forms.Button();
            this.imageListFromUser = new System.Windows.Forms.ImageList(this.components);
            this.checkedListBoxYearOfPhoto = new System.Windows.Forms.CheckedListBox();
            this.labelYearOfPhotos = new System.Windows.Forms.Label();
            this.labelUserInPhoto = new System.Windows.Forms.Label();
            this.labelHeadLine = new System.Windows.Forms.Label();
            this.labelYearError = new System.Windows.Forms.Label();
            this.labelSelectedPhotoError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxUserTaggedWith
            // 
            this.checkBoxUserTaggedWith.BackColor = System.Drawing.SystemColors.Menu;
            this.checkBoxUserTaggedWith.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBoxUserTaggedWith.FormattingEnabled = true;
            this.checkBoxUserTaggedWith.Location = new System.Drawing.Point(20, 130);
            this.checkBoxUserTaggedWith.Name = "checkBoxUserTaggedWith";
            this.checkBoxUserTaggedWith.Size = new System.Drawing.Size(298, 312);
            this.checkBoxUserTaggedWith.TabIndex = 10;
            // 
            // listViewPhotoDisplay
            // 
            this.listViewPhotoDisplay.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewPhotoDisplay.Location = new System.Drawing.Point(398, 19);
            this.listViewPhotoDisplay.MultiSelect = false;
            this.listViewPhotoDisplay.Name = "listViewPhotoDisplay";
            this.listViewPhotoDisplay.Size = new System.Drawing.Size(1091, 646);
            this.listViewPhotoDisplay.TabIndex = 13;
            this.listViewPhotoDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSearchPhotos
            // 
            this.buttonSearchPhotos.Location = new System.Drawing.Point(398, 762);
            this.buttonSearchPhotos.Name = "buttonSearchPhotos";
            this.buttonSearchPhotos.Size = new System.Drawing.Size(174, 59);
            this.buttonSearchPhotos.TabIndex = 14;
            this.buttonSearchPhotos.Text = "SearchPhotos";
            this.buttonSearchPhotos.UseVisualStyleBackColor = true;
            this.buttonSearchPhotos.Click += new System.EventHandler(this.buttonSearchPhotos_Click);
            // 
            // buttonOpenSelectedPhoto
            // 
            this.buttonOpenSelectedPhoto.Location = new System.Drawing.Point(1321, 762);
            this.buttonOpenSelectedPhoto.Name = "buttonOpenSelectedPhoto";
            this.buttonOpenSelectedPhoto.Size = new System.Drawing.Size(168, 59);
            this.buttonOpenSelectedPhoto.TabIndex = 15;
            this.buttonOpenSelectedPhoto.Text = "Select";
            this.buttonOpenSelectedPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenSelectedPhoto.Click += new System.EventHandler(this.buttonOpenSelectedPhoto_Click);
            // 
            // imageListFromUser
            // 
            this.imageListFromUser.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListFromUser.ImageSize = new System.Drawing.Size(192, 144);
            this.imageListFromUser.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // checkedListBoxYearOfPhoto
            // 
            this.checkedListBoxYearOfPhoto.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxYearOfPhoto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxYearOfPhoto.FormattingEnabled = true;
            this.checkedListBoxYearOfPhoto.Location = new System.Drawing.Point(20, 520);
            this.checkedListBoxYearOfPhoto.Name = "checkedListBoxYearOfPhoto";
            this.checkedListBoxYearOfPhoto.Size = new System.Drawing.Size(298, 234);
            this.checkedListBoxYearOfPhoto.TabIndex = 16;
            // 
            // labelYearOfPhotos
            // 
            this.labelYearOfPhotos.AutoSize = true;
            this.labelYearOfPhotos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelYearOfPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelYearOfPhotos.Location = new System.Drawing.Point(15, 473);
            this.labelYearOfPhotos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYearOfPhotos.Name = "labelYearOfPhotos";
            this.labelYearOfPhotos.Size = new System.Drawing.Size(326, 25);
            this.labelYearOfPhotos.TabIndex = 17;
            this.labelYearOfPhotos.Text = "Choose a year:                      ";
            // 
            // labelUserInPhoto
            // 
            this.labelUserInPhoto.AutoSize = true;
            this.labelUserInPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelUserInPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserInPhoto.Location = new System.Drawing.Point(15, 81);
            this.labelUserInPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserInPhoto.Name = "labelUserInPhoto";
            this.labelUserInPhoto.Size = new System.Drawing.Size(329, 25);
            this.labelUserInPhoto.TabIndex = 18;
            this.labelUserInPhoto.Text = "Choose friends in the photo\\s:";
            // 
            // labelHeadLine
            // 
            this.labelHeadLine.AutoSize = true;
            this.labelHeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadLine.ForeColor = System.Drawing.Color.White;
            this.labelHeadLine.Image = global::UI.Properties.Resources.Top;
            this.labelHeadLine.Location = new System.Drawing.Point(8, 27);
            this.labelHeadLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadLine.Name = "labelHeadLine";
            this.labelHeadLine.Size = new System.Drawing.Size(345, 32);
            this.labelHeadLine.TabIndex = 19;
            this.labelHeadLine.Text = "Filter Your Images Here!";
            // 
            // labelYearError
            // 
            this.labelYearError.AutoSize = true;
            this.labelYearError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelYearError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelYearError.Location = new System.Drawing.Point(22, 780);
            this.labelYearError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYearError.Name = "labelYearError";
            this.labelYearError.Size = new System.Drawing.Size(324, 25);
            this.labelYearError.TabIndex = 20;
            this.labelYearError.Text = "Please choose only one year.";
            // 
            // labelSelectedPhotoError
            // 
            this.labelSelectedPhotoError.AutoSize = true;
            this.labelSelectedPhotoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSelectedPhotoError.ForeColor = System.Drawing.Color.DarkRed;
            this.labelSelectedPhotoError.Location = new System.Drawing.Point(1035, 779);
            this.labelSelectedPhotoError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectedPhotoError.Name = "labelSelectedPhotoError";
            this.labelSelectedPhotoError.Size = new System.Drawing.Size(260, 25);
            this.labelSelectedPhotoError.TabIndex = 21;
            this.labelSelectedPhotoError.Text = "Please choose a photo.";
            // 
            // UserControlImageSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSelectedPhotoError);
            this.Controls.Add(this.labelYearError);
            this.Controls.Add(this.labelHeadLine);
            this.Controls.Add(this.labelUserInPhoto);
            this.Controls.Add(this.labelYearOfPhotos);
            this.Controls.Add(this.checkedListBoxYearOfPhoto);
            this.Controls.Add(this.buttonOpenSelectedPhoto);
            this.Controls.Add(this.buttonSearchPhotos);
            this.Controls.Add(this.listViewPhotoDisplay);
            this.Controls.Add(this.checkBoxUserTaggedWith);
            this.Name = "UserControlImageSearcher";
            this.Size = new System.Drawing.Size(1514, 838);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkBoxUserTaggedWith;
        private System.Windows.Forms.ListView listViewPhotoDisplay;
        private System.Windows.Forms.Button buttonSearchPhotos;
        private System.Windows.Forms.Button buttonOpenSelectedPhoto;
        private System.Windows.Forms.ImageList imageListFromUser;
        private System.Windows.Forms.CheckedListBox checkedListBoxYearOfPhoto;
        private System.Windows.Forms.Label labelYearOfPhotos;
        private System.Windows.Forms.Label labelUserInPhoto;
        private System.Windows.Forms.Label labelHeadLine;
        private System.Windows.Forms.Label labelYearError;
        private System.Windows.Forms.Label labelSelectedPhotoError;
    }
}
