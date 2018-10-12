using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class UserControlFilterWall : UserControl
    {
        private readonly ProxyFaceBookClient r_FbUser = new ProxyFaceBookClient(AppSettings.GetSettings().LastAccessToken);
        private int m_AllPostsAmount;
        private UserWall m_UserWallbyLikes;
        private UserWall m_UserWallbyDate;
        private int m_PostsAmountToDisplay;

        public UserControlFilterWall()
        {
            InitializeComponent();
            m_PostsAmountToDisplay = 10;          
        }

        public void fetchPosts()
        {
            try
            {
                List<WallPost> Posts = r_FbUser.Get("me/feed?fields=message,likes{name},comments{from},story,source,created_time,picture,from&limit=10000") as List<WallPost>;
                m_AllPostsAmount = Posts.Count;
                m_UserWallbyDate = new UserWall(Posts, new WallSortByDate());
                m_UserWallbyLikes = new UserWall(Posts, new WallSortByLikes());
                setFeed(m_UserWallbyDate);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }

        private void setFeed(UserWall i_UserWall)
        {
            int likeAmountToDisplay = int.Parse(comboBoxAmountOfLikesToFilter.SelectedItem.ToString());

            i_UserWall.Filter = wallPost => wallPost.LikeCount >= likeAmountToDisplay;
            
            IEnumerator<WallPost> userWallEnumerator = i_UserWall.GetEnumerator();

            flowLayoutPanel.Controls.Clear();

            int amountOfPostsIndex = 0;

            while (userWallEnumerator.MoveNext() && amountOfPostsIndex < m_PostsAmountToDisplay)
            {
                flowLayoutPanel.Controls.Add(new UserControlPost(userWallEnumerator.Current));
                amountOfPostsIndex++;
            }
        }
        
        private void comboBoxWallFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFeed();
        }

        private void comboBoxNumberToDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_PostsAmountToDisplay = comboBoxNumberToDisplay.SelectedItem.ToString() == "All" ? m_AllPostsAmount : int.Parse(comboBoxNumberToDisplay.SelectedItem.ToString());
            loadFeed();
        }

        private void loadFeed()
        {
            if (comboBoxWallFilter.SelectedIndex == 1)
            {
                setFeed(m_UserWallbyLikes);
            }
            else
            {
                setFeed(m_UserWallbyDate);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void comboBoxAmountOfLikesToFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFeed();
        }
    }
}
