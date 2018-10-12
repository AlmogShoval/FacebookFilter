using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class WallSortByDate : IWallSortStrategy
    {
        public List<WallPost> SortWall(List<WallPost> i_WallPosts)
        {
            return i_WallPosts.OrderByDescending(post => post.Time).ToList<WallPost>();
        }
    }
}
