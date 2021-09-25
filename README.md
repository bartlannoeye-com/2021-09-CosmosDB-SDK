# Cosmos DB SDK upgrade changes how id serialization is handled
Cosmos DB .NET SDK v3 uses `Newtonsoft.Json` as serialization library while SDK v4 uses `System.Text.Json.Serialization`. This has an effect on the attributes you use to use another field as the `id` field.

Blog post: https://bartlannoeye.com/blog/cosmosdb-sdk-upgrade-wheres-my-id/