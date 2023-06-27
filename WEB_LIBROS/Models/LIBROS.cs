using Newtonsoft.Json;

namespace WEB_LIBROS.Models
{
    public class LIBROS
    {
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        [JsonProperty("totalItems", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalItems { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<LIBRO> Items { get; set; }

    }


}
