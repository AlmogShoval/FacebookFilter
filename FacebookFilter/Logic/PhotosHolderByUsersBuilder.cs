using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class PhotosHolderByUsersBuilder : IPhotosHolderBuilder<string>
    {
        private PhotosHolder<string> m_photosHolderByUser = new PhotosHolder<string>();

        public void AddPhotosToList(List<Photo> i_Photos)
        {
            foreach (Photo photo in i_Photos)
            {
                FacebookObjectCollection<PhotoTag> photoTags = photo.Tags;

                if (photoTags != null)
                {
                    foreach (PhotoTag photoTag in photoTags)
                    {
                        m_photosHolderByUser.m_PhotosByList[photoTag.User.Name].Add(photo);
                    }
                }
            }
        }

        public void CreateList(List<Photo> i_Photos)
        {
            Dictionary<string, List<Photo>> photosByUserList = new Dictionary<string, List<Photo>>();

            foreach (Photo photo in i_Photos)
            {
                FacebookObjectCollection<PhotoTag> photoTags = photo.Tags;

                if (photoTags != null)
                {
                    foreach (PhotoTag photoTag in photoTags)
                    {
                        if (!photosByUserList.ContainsKey(photoTag.User.Name))
                        {
                            photosByUserList.Add(photoTag.User.Name, new List<Photo>());
                        }
                    }
                }
            }

            m_photosHolderByUser.m_PhotosByList = photosByUserList;
        }

        public PhotosHolder<string> GetPhotosHolderFrom(List<Photo> i_Photos)
        {
            CreateList(i_Photos);
            this.AddPhotosToList(i_Photos);

            return m_photosHolderByUser;
        }
    }
}
