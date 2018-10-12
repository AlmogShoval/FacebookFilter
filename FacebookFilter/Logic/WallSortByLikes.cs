using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class WallSortByLikes : IWallSortStrategy
    {
        public List<WallPost> SortWall(List<WallPost> i_WallPosts)
        {
            return i_WallPosts.OrderByDescending(post => post.LikeCount).ToList<WallPost>();
        }
    }
}
