using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using Facebook;

namespace UI
{
    public partial class FormComments : Form
    {
        private readonly FacebookClient r_FbUser = new FacebookClient(AppSettings.GetSettings().LastAccessToken);
        public List<Comment> m_CommentsList = new List<Comment>();

        public FormComments(string PostID)
        {
            InitializeComponent();

            object results = r_FbUser.Get(string.Format("{0}/comments?fields=like_count,from,id,message,user_likes,created_time", PostID));
           
            JsonObject jsonResults = results as JsonObject;

            JsonArray jsoncomments = (JsonArray)jsonResults[0];

            foreach (JsonObject comment in jsoncomments)
            {
                m_CommentsList.Add(new Comment(comment));
            }

            if (m_CommentsList != null)
            {
                try
                {
                    commentBindingSource.DataSource = m_CommentsList;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void buttonComment_Click(object sender, EventArgs e)
        {
            Comment comment = commentBindingSource.Current as Comment;
            PostReaction.CommentOnPost(comment.UserComment, comment.Id);
        }
    }
}
