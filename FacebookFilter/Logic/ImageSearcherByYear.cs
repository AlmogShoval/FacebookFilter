using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class ImageSearcherByYear : ImageSearcherLogic
    {
        public ImageSearcherByYear(User i_LoggedInUser) : base(i_LoggedInUser)
        {
            m_PhotosHolder = new PhotosHolderByYearsBuilder().GetPhotosHolderFrom(m_UserPhotos);
        }

        public override void FilterPhotos(CheckedListBox.CheckedItemCollection i_CheckedItems)
        {
            foreach (string year in m_PhotosHolder.m_PhotosByList.Keys)
            {
                {
                    if (i_CheckedItems.Contains(year))
                    {
                        PhotoFilter.Instance.SetPhotosBy(m_PhotosHolder.m_PhotosByList[year]);
                    }
                }
            }

            m_PhotosCheckedByUser = PhotoFilter.Instance.GetFilteredPhotos();
        }
    }
}
