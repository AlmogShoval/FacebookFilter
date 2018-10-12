using System.Collections.Generic;

namespace Logic
{
    public interface IWallSortStrategy
    {
        List<WallPost> SortWall(List<WallPost> i_WallPosts);
    }
}
