using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace InfluxDB.Client.Domain
{
    /// <summary>
    /// The wrapper for "/api/v2/authorizations" response. 
    /// </summary>
    public class Authorizations : AbstractHasLinks
    {
        [JsonProperty("authorizations")]
        public List<Authorization> Auths { get; set; } = new List<Authorization>();

        public override string ToString()
        {
            return new StringBuilder(GetType().Name + "[")
                .Append("auths=" + Auths)
                .Append("]").ToString();
        }
    }
}