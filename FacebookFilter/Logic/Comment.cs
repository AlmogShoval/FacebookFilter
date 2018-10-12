using Facebook;

namespace Logic
{
    public class Comment
    {
        public string Created_time { get; set; }

        public string Sender { get; set; }

        public string Message { get; set; }

        public string Id { get; set; }

        public bool UserLiked { get; set; }

        public string UserComment { get; set; }

        public Comment(JsonObject i_Post)
        {
            this.Created_time = string.Empty;
            UserComment = string.Empty;

            JsonObject From = parseJson<JsonObject>("from", i_Post);
            if (From != null)
            {
                Sender = parseJson<string>("name", From);
            }

            UserLiked = parseJson<bool>("user_likes", i_Post);
            Message = parseJson<string>("message", i_Post);
            Created_time = parseJson<string>("created_time", i_Post);
            Id = parseJson<string>("id", i_Post);
        }

        public void sendComment()
        {
            PostReaction.CommentOnPost(UserComment, Id);
        }

        private T parseJson<T>(string i_Value, JsonObject i_Json)
        {
            object jsonParse;
            i_Json.TryGetValue(i_Value, out jsonParse);

            return (T)jsonParse;
        }
    }
}
