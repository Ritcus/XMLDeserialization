using System.Xml.Serialization;

public enum Operator

{

    Addition,

    Subtraction,

    Multiplication,

    Division

}


[XmlRoot("Maths")]
public class Operation

{
    [XmlElement("Value")]
    public List<double> Value { get; set; }


    [XmlElement("Operation ID")]
    public Operator ID { get; set; }

}