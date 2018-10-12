using System;
using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    public class UserWall : IEnumerable<WallPost>
    {
        private List<WallPost> m_Wall;

        public Func<WallPost, bool> Filter { get; set; }

        public UserWall(List<WallPost> i_Wall, IWallSortStrategy i_SortWallPosts)
        {
            m_Wall = i_SortWallPosts.SortWall(i_Wall);
            Filter = WallPost => true;
        }

        public IEnumerator<WallPost> GetEnumerator()
        {
            return new WallPostsIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class WallPostsIterator : IEnumerator<WallPost>
        {
            private UserWall m_UserWall;
            private int m_CurrentIdx = -1;
            private int m_Count = -1;

            public WallPostsIterator(UserWall i_UserWall)
            {
                m_UserWall = i_UserWall;
                m_Count = m_UserWall.m_Wall.Count;
            }

            public void Reset()
            {
                m_CurrentIdx = -1;
            }

            public bool MoveNext()
            {
                if (m_Count != m_UserWall.m_Wall.Count)
                {
                    throw new Exception("Collection can not be changed during iteration!");
                }

                if (m_CurrentIdx >= m_Count)
                {
                    throw new Exception("Already reached the end of the collection");
                }

                m_CurrentIdx++;
                
                if (m_CurrentIdx < m_UserWall.m_Wall.Count)
                {
                    if (!m_UserWall.Filter.Invoke(m_UserWall.m_Wall[m_CurrentIdx]))
                    {
                        MoveNext();
                    }
                }

                return m_CurrentIdx < m_UserWall.m_Wall.Count;
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public WallPost Current
            {
                get { return m_UserWall.m_Wall[m_CurrentIdx]; }
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
        }
    }
}
