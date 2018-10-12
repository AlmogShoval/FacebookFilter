using System.Windows.Forms;
using Logic;

namespace UI
{
    public partial class UserControlPost : UserControl
    {
        public int LikeAmount { get; set; }

        private string PostID { get; set; }

        public UserControlPost(WallPost i_NewPost)
        {
            InitializeComponent();

            label_message.Text = i_NewPost.Message;
            LikeAmount = i_NewPost.LikeCount;
            label_likeAmount.Text = LikeAmount.ToString();
            labelSender.Text = i_NewPost.Sender;
            labelTime.Text = i_NewPost.Time;
            labelStory.Text = i_NewPost.Story;
            pictureBox_PostPic.ImageLocation = i_NewPost.PictureURL;
            pictureBoxSenderPhoto.ImageLocation = i_NewPost.SenderPictureURL;

            PostID = i_NewPost.Id;
        }

        private void buttonComment_Click(object sender, System.EventArgs e)
        {
            PostReaction.CommentOnPost(textBoxComment.Text, PostID);
            textBoxComment.Text = "Write a comment...";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            FormComments Comments = new FormComments(PostID);
            Comments.Show();
        }
    }
}
