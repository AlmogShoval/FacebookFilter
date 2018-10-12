using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class PhotosHolderByYearsBuilder : IPhotosHolderBuilder<string>
    {
        private PhotosHolder<string> m_photosHolderByYears = new PhotosHolder<string>();

        public void AddPhotosToList(List<Photo> i_Photos)
        {
            foreach (Photo photo in i_Photos)
            {
                // Create a list of photos by the year they were added
                m_photosHolderByYears.m_PhotosByList[photo.CreatedTime.GetValueOrDefault().Year.ToString()].Add(photo);
            }
        }

        public void CreateList(List<Photo> i_Photos)
        {
            Dictionary<string, List<Photo>> photosByYearList = new Dictionary<string, List<Photo>>();

            foreach (Photo photo in i_Photos)
            {
                // Create a list of years that has photos
                if (!photosByYearList.ContainsKey(photo.CreatedTime.GetValueOrDefault().Year.ToString()))
                {
                    photosByYearList.Add(photo.CreatedTime.GetValueOrDefault().Year.ToString(), new List<Photo>());
                }
            }

            m_photosHolderByYears.m_PhotosByList = photosByYearList;
        }

        public PhotosHolder<string> GetPhotosHolderFrom(List<Photo> i_Photos)
        {
            CreateList(i_Photos);
            this.AddPhotosToList(i_Photos);

            return m_photosHolderByYears;
        }
    }
}
