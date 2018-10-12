using System.Collections.Generic;
using System.Threading;
using Facebook;

namespace Logic
{
    public class ProxyFaceBookClient : FacebookClient
    {
        public ProxyFaceBookClient(string accessToken) : base(accessToken)
        {
        }

        public override object Get(string request)
        {
            object baseResult = base.Get(request);

            List<WallPost> Posts = new List<WallPost>();

            JsonObject results = baseResult as JsonObject;
            JsonArray posts = (JsonArray)results[0];

            Thread[] threads = new Thread[posts.Count];
            int threadIndex = 0;

            foreach (JsonObject post in posts)
            {
                threads[threadIndex] = new Thread(() =>
                {
                    WallPost newPost = new WallPost(post);
                    lock (this)
                    {
                        Posts.Add(newPost);
                    }
                });

                threads[threadIndex].Start();
                threadIndex++;
            }

            for (int i = 0; i < posts.Count; i++)
            {
                threads[i].Join();
            }

            return Posts;
        }
    }
}