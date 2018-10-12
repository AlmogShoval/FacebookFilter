using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class PhotosHolder<T>
    {
        public Dictionary<T, List<Photo>> m_PhotosByList;
    }
}
