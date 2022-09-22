using System;
using System.Collections.Generic;

using System.Globalization;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace DematicCodingQuestion.Models
{
    public partial class Root
    {
        [JsonProperty("Maths")]
        [XmlElement("Maths")]
        public Maths Maths { get; set; }
    }

    public partial class Maths
    {
        [JsonProperty("Operation")]
        [XmlElement("Operation")]
        public MathsOperation Operation { get; set; }
    }

    public partial class MathsOperation
    {
        [JsonProperty("@ID")]
        [XmlElement("@ID")]
        public string Id { get; set; }

        [JsonProperty("Value")]
        [XmlElement("Value")]
        public List<double> Value { get; set; }

        [JsonProperty("Operation")]
        [XmlElement("Operation")]
        public OperationOperation Operation { get; set; }
    }

    public partial class OperationOperation
    {
        [JsonProperty("@ID")]
        [XmlElement("@ID")]
        public string Id { get; set; }

        [JsonProperty("Value")]
        [XmlElement("Value")]
        public List<double> Value { get; set; }
    }
}
