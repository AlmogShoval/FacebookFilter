using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic
{
     public class PhotoFilter
    {
        private static PhotoFilter instance;

        public static PhotoFilter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhotoFilter();
                }

                return instance;
            }
        }
    
        private List<Photo> m_FliteredPhotos;

        public bool b_FirstCheck { get; set; }

        private PhotoFilter()
        {
            this.m_FliteredPhotos = new List<Photo>();
            this.b_FirstCheck = true;
        }

        public List<Photo> GetFilteredPhotos()
        {
            return m_FliteredPhotos;
        }

        public void SetPhotosBy(List<Photo> i_PhotosToAdd)
        {
            if (this.b_FirstCheck == true)
            {
                m_FliteredPhotos.Clear();
                this.addFirstFilter(i_PhotosToAdd);
            }
            else
            {
                crossFilters(i_PhotosToAdd);
            }
        }

        private void addFirstFilter(List<Photo> i_PhotosOfUser)
        {
            foreach (Photo photo in i_PhotosOfUser)
            {
                if (!m_FliteredPhotos.Contains(photo))
                {
                    m_FliteredPhotos.Add(photo);
                }
            }

            this.b_FirstCheck = false;
        }

        private void crossFilters(List<Photo> i_PhotosToAdd)
        {
            List<Photo> newFliteredPhotos = new List<Photo>();
            foreach (Photo photo in m_FliteredPhotos)
            {
                if (i_PhotosToAdd.Contains(photo))
                {
                    newFliteredPhotos.Add(photo);
                }
            }

            m_FliteredPhotos = newFliteredPhotos;
        }
    }
}
