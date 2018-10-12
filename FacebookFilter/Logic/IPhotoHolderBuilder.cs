using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public interface IPhotosHolderBuilder<T>
    {
        void CreateList(List<Photo> i_Photos);

        void AddPhotosToList(List<Photo> i_Photos);

        PhotosHolder<T> GetPhotosHolderFrom(List<Photo> i_Photos);
    }
}
