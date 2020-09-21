namespace myWebApp42.Models
{
    using Newtonsoft.Json;
    public class AzureException
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "prio")]
        public int Prio { get; set; }

        [JsonProperty(PropertyName = "PartitionKey")]
        public string PartitionKey { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "code")]
        public int Code { get; set; }

        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        [JsonProperty(PropertyName = "context")]
        public string Context { get; set; }

        [JsonProperty(PropertyName = "returnCode")]
        public int ReturnCode { get; set; }

        [JsonProperty(PropertyName = "returnResult")]
        public string ReturnResult { get; set; }

        [JsonProperty(PropertyName = "returnDetails")]
        public string ReturnDetails { get; set; }

        [JsonProperty(PropertyName = "returnType")]
        public string ReturnType { get; set; }


    }
}
