using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace soymichelApp.adminApp.src.controllers
{

    public class FirebaseConfig
    {

        private static FirebaseConfig firebaseConfig;

        public static FirebaseConfig Instance { get {
                if (firebaseConfig == null)
                {
                    firebaseConfig = new FirebaseConfig();
                }
                return firebaseConfig;
            }
        }

        private FirebaseConfig() {
            FirebaseApp.Create(new AppOptions() {
                Credential = GoogleCredential.GetApplicationDefault()
            });
        }

        private FirestoreDb firestoreDb;
        public FirestoreDb Db {
            get {
                if (firestoreDb == null)
                {
                    firestoreDb = FirestoreDb.Create("mtraatabladaa");
                }
                return firestoreDb;
            }
        }

    }

}