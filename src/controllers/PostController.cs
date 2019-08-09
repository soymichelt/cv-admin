using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using soymichelApp.adminApp.src.models;

namespace soymichelApp.adminApp.src.controllers
{

    public class PostController
    {

        public const string POST_COLLECTION = "posts";

        public async Task AddAsync(PostModel post)
        {

            DocumentReference postRef = await FirebaseConfig.Instance.Db
                .Collection(POST_COLLECTION)
                .AddAsync(post);

        }

        public async Task UpdateAsync(PostModel post)
        {

            Dictionary<string, object> postDictionary = new Dictionary<string, object>() {
                { "avatarURL", post.AvatarURL },
                { "data", post.Data },
                { "modifiedDate", Timestamp.GetCurrentTimestamp() },
                { "photoURL", post.PhotoURL },
                { "postType", post.PostType },
                { "title", post.Title },
            };

            await FirebaseConfig.Instance.Db
                .Collection(POST_COLLECTION)
                .Document(post.PostId)
                .UpdateAsync(postDictionary);

        }

        public async Task RemoveAsync(string postId)
        {

            await FirebaseConfig.Instance.Db
                .Collection(POST_COLLECTION)
                .Document(postId)
                .DeleteAsync();
            
        }

        public async Task<List<PostModel>> GetPosts()
        {

            Query postQuery = FirebaseConfig.Instance.Db
                .Collection(POST_COLLECTION);

            var posts = new List<PostModel>();

            foreach (DocumentSnapshot document in await postQuery.GetSnapshotAsync())
            {
                posts.Add(document.ConvertTo<PostModel>());
            }

            return posts;

        }

        public async Task<PostModel> GetPostById(string postId)
        {

            DocumentSnapshot postSnapshot = await FirebaseConfig.Instance.Db
                .Collection(POST_COLLECTION).Document(postId).GetSnapshotAsync();

            return postSnapshot.ConvertTo<PostModel>();
            
        }

    }

}