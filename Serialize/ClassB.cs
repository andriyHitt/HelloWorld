using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SerializeDemo
{
    internal class ClassB
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
        //[JsonIgnore]
        public DateTime SaveDate { get; set; }
        [JsonInclude]
        public string State;
        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Save date: {SaveDate}";
        }
    }
}
