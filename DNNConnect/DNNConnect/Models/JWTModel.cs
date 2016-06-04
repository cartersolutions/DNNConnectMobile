using System;

using Newtonsoft.Json;

namespace DNNConnect.Models
{
    public class JWTModel
    {
        public JWTModel()
        {
        }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("renewalToken")]
        public string RenewalToken { get; set; }
    }
}

