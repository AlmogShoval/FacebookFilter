using System.Windows.Forms;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public abstract class ImageSearcherLogic
    {
        public List<Photo> m_PhotosCheckedByUser;
        public List<Photo> m_UserPhotos = new List<Photo>();
        public PhotosHolder<string> m_PhotosHolder;

        public ImageSearcherLogic(User i_LoggedInUser)
        {
            GetPhotosFromUser(i_LoggedInUser);
        }

        public void GetPhotosFromUser(User i_CurrentUser)
        {
            List<Photo> userPhotos = new List<Photo>();

            foreach (Album album in i_CurrentUser.Albums)
            {
                userPhotos.AddRange(album.Photos);
            }

            userPhotos.AddRange(i_CurrentUser.PhotosTaggedIn);

            m_UserPhotos = userPhotos;
        }

        public abstract void FilterPhotos(CheckedListBox.CheckedItemCollection i_CheckedItemsYearOfPhoto);
    }
}
