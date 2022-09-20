using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DematicCodingQuestion.Models
{
    [XmlRoot("Maths")]
    public class Operations
    {
        [XmlElement("Operation ID")]

        public  Operator op { get; set; }

        [XmlElement("Value")]
        public List<double> Value { get; set; }

    }

    public enum Operator

    {

        Plus,

        Subtraction,

        Multiplication,

        Division

    }
}
