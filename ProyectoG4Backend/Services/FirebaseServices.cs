namespace ProyectoG4Backend.Services;

public class FirebaseServices
{
    private readonly FirestoreDb firestoreDb;

    public FirebaseServices()
    {
        var credentialPath = Path.Combine(AppContext.BaseDirectory, "Config", "firebase-credentials.json");
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credentialPath);

        firestoreDb = firestoreDb.Create(projectId: "\nweb-759");
    }

    public CollectionReference GetCollection(string collectionName)
    {
        return firestoreDb.Collection(collectionName);
        
    }
}