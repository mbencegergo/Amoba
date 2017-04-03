using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Game {
    public class Response {

        public static string Username { get; set; }

        [JsonProperty(PropertyName="msg")]
        public string msg { get; set; }
    }
}
