namespace Azure.Monitor.Ingestion
{
    public partial class IngestionClient
    {
        protected IngestionClient() { }
        public IngestionClient(string endpoint, Azure.Core.TokenCredential credential, Azure.Monitor.Ingestion.IngestionClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class IngestionClientOptions : Azure.Core.ClientOptions
    {
        public IngestionClientOptions(Azure.Monitor.Ingestion.Generated.IngestionClientOptions.ServiceVersion version = Azure.Monitor.Ingestion.Generated.IngestionClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}