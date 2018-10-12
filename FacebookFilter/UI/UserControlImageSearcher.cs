using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using Logic;

namespace UI
{
    public partial class UserControlImageSearcher : UserControl
    {
        private readonly List<Photo> r_PhotosDisplayed = new List<Photo>();
        private ImageSearcherLogic m_ImageSearcherByYear;
        private ImageSearcherLogic m_ImageSearcherByUserName;
        private User m_LoggedInUser;

        public UserControlImageSearcher(User i_LoggedUser)
        {
            InitializeComponent();
            labelYearError.Hide();
            labelSelectedPhotoError.Hide();
            m_LoggedInUser = i_LoggedUser;
            m_ImageSearcherByYear = new ImageSearcherByYear(i_LoggedUser);
            m_ImageSearcherByUserName = new ImageSearcherByUserName(i_LoggedUser);
            createControl();
        }

        private void buttonSearchPhotos_Click(object sender, EventArgs e)
        {
            listViewPhotoDisplay.Clear();
            imageListFromUser.Dispose();

            if (checkedListBoxYearOfPhoto.CheckedItems.Count > 1)
            {
                labelYearError.Show();
            }
            else
            {
                labelYearError.Hide();
                m_ImageSearcherByUserName.FilterPhotos(checkBoxUserTaggedWith.CheckedItems);
                m_ImageSearcherByYear.FilterPhotos(checkedListBoxYearOfPhoto.CheckedItems);
                setPhotosToDisplay(m_ImageSearcherByUserName.m_PhotosCheckedByUser);
            }
        }

        private void createControl()
        {
            setPhotosToDisplay(m_ImageSearcherByUserName.m_UserPhotos);
            setYearsList();
            setUsersList();
        }

        private void setPhotosToDisplay(List<Photo> i_Photolist)
        {
            r_PhotosDisplayed.Clear();

            List<Image> sy = new List<Image>();
            Thread[] threads = new Thread[i_Photolist.Count];
            int index = 0;

            foreach (Photo photo in i_Photolist)
            {
                threads[index] = new Thread(() =>
                {
                    Image newPhoto = photo.ImageNormal;
                    lock (this)
                    {
                        sy.Add(newPhoto);
                        r_PhotosDisplayed.Add(photo);
                    }
                });
                threads[index].Start();
                index++;
            }

            for (int i = 0; i < i_Photolist.Count; i++)
            {
                threads[i].Join();
            }

            imageListFromUser.Images.AddRange(sy.ToArray());
            listViewPhotoDisplay.View = View.LargeIcon;
            listViewPhotoDisplay.LargeImageList = imageListFromUser;

            for (int j = 0; j < this.imageListFromUser.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listViewPhotoDisplay.Items.Add(item);
            }
        }

        private void setYearsList()
        {
            // Create a list of years that has photos
            List<string> yearsOfPhotos = m_ImageSearcherByYear.m_PhotosHolder.m_PhotosByList.Keys.ToList();
            checkedListBoxYearOfPhoto.Items.Clear();

            foreach (string yearOfPhoto in yearsOfPhotos)
            {
                checkedListBoxYearOfPhoto.Items.Add(yearOfPhoto);
            }
        }

        private void setUsersList()
        {
            checkBoxUserTaggedWith.Items.Clear();
            foreach (string userName in m_ImageSearcherByUserName.m_PhotosHolder.m_PhotosByList.Keys)
            {
                checkBoxUserTaggedWith.Items.Add(userName);
            }
        }

        private void buttonOpenSelectedPhoto_Click(object sender, EventArgs e)
        {
            if (listViewPhotoDisplay.SelectedItems.Count == 0)
            {
                labelSelectedPhotoError.Show();
            }
            else
            {
                labelSelectedPhotoError.Hide();
                FormImageReaction newImageReaction = new FormImageReaction(r_PhotosDisplayed.ElementAt(listViewPhotoDisplay.SelectedIndices[0]));
                newImageReaction.Show();
            }
        }
    }
}
