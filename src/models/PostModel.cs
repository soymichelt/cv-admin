using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Google.Cloud.Firestore;

namespace soymichelApp.adminApp.src.models
{

    [FirestoreData]
    public class PostModel
    {

        public class Value
        {

            public string Id { get; set; }

            public string Caption { get; set; }

        }

        public readonly static List<Value> academicCategories = new List<Value>() {
            new Value() { Id = "0", Caption = "Todos", },
            new Value() { Id = "1", Caption = "Grados", },
            new Value() { Id = "2", Caption = "Certificados", },
            new Value() { Id = "3", Caption = "Cursos", },
        };

        public readonly static List<Value> projectCategories = new List<Value>() {
            new Value() { Id = "0", Caption = "Todos", },
            new Value() { Id = "1", Caption = "Empresariales", },
            new Value() { Id = "2", Caption = "Personales", },
        };

        public readonly static List<Value> postTypes = new List<Value>() {
            new Value() { Id = "studies", Caption = "Estudio", },
            new Value() { Id = "projects", Caption = "Proyecto", },
        };

        [FirestoreDocumentId()]
        public string PostId { get; set; }

        [FirestoreProperty("avatarURL")]
        public string AvatarURL { get; set; }

        [FirestoreProperty("createdDate")]
        public Timestamp CreatedDate { get; set; }

        [FirestoreProperty("data")]
        public object Data { get; set; }

        [FirestoreProperty("favsCount")]
        public int FavsCount { get; set; }
        
        [FirestoreProperty("modifiedDate")]
        public Timestamp ModifiedDate { get; set; }

        [FirestoreProperty("photoURL")]
        public string PhotoURL { get; set; }

        [FirestoreProperty("postType")]
        public string PostType { get; set; }

        [FirestoreProperty("sharesCount")]
        public int SharesCount { get; set; }

        [FirestoreProperty("title")]
        public string Title { get; set; }

    }

}
