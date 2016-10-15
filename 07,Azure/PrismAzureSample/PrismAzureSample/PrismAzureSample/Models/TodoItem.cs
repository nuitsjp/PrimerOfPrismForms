using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;

namespace PrismAzureSample.Models
{
    public class TodoItem
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "complete")]
        public bool Done { get; set; }

        [Version]
        public string Version { get; set; }
    }
}
