using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class ImageSearcherByUserName : ImageSearcherLogic
    {
        public ImageSearcherByUserName(User i_LoggedInUser) : base(i_LoggedInUser)
        {
            m_PhotosHolder = new PhotosHolderByUsersBuilder().GetPhotosHolderFrom(m_UserPhotos);
        }

        public override void FilterPhotos(CheckedListBox.CheckedItemCollection i_CheckedItems)
        {
            m_PhotosCheckedByUser = new List<Photo>();
            PhotoFilter.Instance.b_FirstCheck = true;

            foreach (string userName in m_PhotosHolder.m_PhotosByList.Keys)
            {
                if (i_CheckedItems.Contains(userName))
                {
                    PhotoFilter.Instance.SetPhotosBy(m_PhotosHolder.m_PhotosByList[userName]);
                }
            }

            m_PhotosCheckedByUser = PhotoFilter.Instance.GetFilteredPhotos();
        }
    }
}
