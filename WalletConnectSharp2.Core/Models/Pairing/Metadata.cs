using Newtonsoft.Json;

namespace WalletConnectSharp.Core.Models.Pairing
{
    /// <summary>
    /// A class that holds Metadata for either peer in a given Session. Includes things such
    /// as Name of peer, Description, urls and images. 
    /// </summary>
    public class Metadata
    {
        /// <summary>
        /// The name of this peer
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// The description for this peer
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        
        /// <summary>
        /// The URL of the software this peer represents
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        
        /// <summary>
        /// The URL of image icons of the software this peer represents
        /// </summary>
        [JsonProperty("icons")]
        public string[] Icons { get; set; }
    }
}
