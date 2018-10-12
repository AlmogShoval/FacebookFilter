using System;
using System.Collections.Generic;
using Facebook;

namespace Logic
{
    public static class PostReaction
    {
        public static void CommentOnPost(string i_Message, string i_PostID)
        {
            Dictionary<string, object> commentDicitonay = new Dictionary<string, object>
            {
                { "id", i_PostID },
                { "message", i_Message }
            };

            connectAndPost(commentDicitonay, "/comments");
        }

        public static void SharePost(string i_Message, string i_PostLink)
        {
            Dictionary<string, object> shareDicitonay = new Dictionary<string, object>
                {
                    { "message", i_Message },
                    { "link", i_PostLink },
                    { "picture", "postInfo.ImageUrl" },
                    { "story_tags", " " }
                };

            connectAndPost(shareDicitonay, "me/feed");
        }

        private static void connectAndPost(Dictionary<string, object> i_Parmeters, string i_Request)
        {
            try
            {
                FacebookClient fbUser = new FacebookClient(AppSettings.GetSettings().LastAccessToken);
                fbUser.Post(i_Request, i_Parmeters);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
            }
        }
    }
}
