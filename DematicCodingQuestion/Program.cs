// See https://aka.ms/new-console-template for more information

using DematicCodingQuestion.Interface;
using DematicCodingQuestion.Models;

using Newtonsoft.Json;

using System.Xml;
using System.Xml.Linq;


Console.WriteLine("Hello, World!");


     double Plus(List<double> Values)
    {
        return IRepository.Addition();
    }

     double Substraction(List<double> Values)
    {
        return _repository.Subtraction();
    }

     double Multiplications(List<double> Values)
    {
        return _repository.Multiplication();

    }

     double Division(List<double> Values)
    {
        return _repository.Division();

    }

    


    static void GetXmlString()
{
    Operations os = new Operations();
    //XmlDocument xmlDoc = new XmlDocument();
    //try
    //{
    //    xmlDoc.Load("C:\\Users\\adoni\\Desktop\\d2.xml");
    //}
    //catch (XmlException e)
    //{
    //    Console.WriteLine(e.Message);
    //}

    //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Operation));

    //List<Operation> result = (List<Operation>)xmlSerializer.Deserialize(xmlSerializer);
    //return result;
    //XDocument xdoc = XDocument.Load("C:\\Users\\adoni\\Desktop\\d2.xml");

    //var xml = new XmlSerializer(typeof(Operations));
    //using (var fs = new FileStream("test.xml", FileMode.Create))
    //{
    //    xml.Serialize(fs, xdoc);
    //}

    XDocument doc = XDocument.Load("C:\\Users\\adoni\\Desktop\\d2.xml");

    var results = doc.Descendants("Operation")
                .Select(x => new Operations() { op = (DematicCodingQuestion.Models.Operator)Enum.Parse(typeof(DematicCodingQuestion.Models.Operator), (string)x.Attribute("ID")), Value = x.Elements("Value").Select(x => Convert.ToDouble(x.Value)).ToList() }).ToList();
        //string[] specialCodes = doc.Descendants("Value").Select(n => n.Value).ToArray();

        //foreach(var v in results)
        //{
        //    Console.WriteLine(v.OperationId);
        //    foreach (var c in v.Value)
        //    {
        //        Console.WriteLine(c);
        //    }

        double fc = 0;
    foreach (var result in results)
    {
        switch (result.op)
        {
            case Operator.Plus:
                fc = calculationController.Plus(result.Value);
                break;
            case Operator.Subtraction:
                fc = calculationController.Substraction(result.Value);
                break;
            case Operator.Multiplication:
                fc = calculationController.Multiplications(result.Value);
                break;
            case Operator.Division:
                fc = calculationController.Plus(result.Value);
                break;
            default:
                Console.WriteLine("Not Available");
                break;
        }


    }

    Console.WriteLine(fc);



    //}



    //var items = (from r in xdoc.Root.Elements("Maths")
    //             select new Operations()
    //             {
    //                 OperationId = (string)r.Element("Operation"),
    //                 Value = (double)r.Element("Value")
    //             }).ToList();

    //XDocument xdoc = XDocument.Load("C:\\Users\\adoni\\Desktop\\d2.xml");

    //Operations op = new Operations();

    //List<string> values = xdoc.Descendants("Value").Select(x => x.Value).ToList();

    //using (var writer = xdoc.CreateWriter())
    //{
    //    // write xml into the writer
    //    var serializer = new DataContractSerializer(op.GetType());
    //    serializer.WriteObject(writer, op);
    //}

    //Console.WriteLine(xdoc.ToString());



    //return null;



    //using (FileStream fileStream = new FileStream("C:\\Users\\adoni\\Desktop\\d2.xml", FileMode.Open)) 
    //{
    //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Operations));
    //    Operations result = (Operations)xmlSerializer.Deserialize(fileStream);
    //    //List<Operation> res = (List<Operation>)xmlSerializer.Deserialize(fileStream);
    //    //foreach (var a in result.Value)
    //    //{
    //    //    Console.WriteLine(a);
    //    //    Console.WriteLine("Dsads");

    //    return null ;
    //}

    //XmlNodeList value = xmlDoc.GetElementsByTagName("Value");
    //foreach (XmlNode valueNode in value)
    //{
    //    .Add(valueNode.InnerText);
    //}
    // var serializer = new XmlSerializer(typeof(List<Operation>));
    //List<Operation> result = new List<Operation>();
    //foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
    //{
    //    result.Add(List< Operation > serializer.Deserialize(xmlDoc)); 
    //    sb.Append(char.ToUpper(node.Name[0]));
    //    sb.Append(node.Name.Substring(1));
    //    sb.Append(' ');
    //    sb.AppendLine();
    //}

    //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Operation));

    //List <Operation> result = (List<Operation>)xmlSerializer.Deserialize(xmlDoc);
    //return null;



    //StringBuilder sb = new StringBuilder();
    //foreach (XmlNode node in xmlDoc.DocumentElement.ChildNodes)
    //{
    //    sb.Append(char.ToUpper(node.Name[0]));
    //    sb.Append(node.Name.Substring(1));
    //    sb.Append(' ');
    //    sb.AppendLine();
    //}
    //return sb;
}

static Operations GetJsonString()
{
    using (StreamReader r = new StreamReader("C:\\Users\\adoni\\Desktop\\s.json"))
    {
        string json = r.ReadToEnd();
        Operations result = JsonConvert.DeserializeObject<Operations>(json);
        return result;
    }
}

//}

void WriteBookData(XmlWriter writer, string operationId, double finalValue )
{

    writer.WriteStartElement("Operation");
    writer.WriteAttributeString("ID",operationId);
    writer.WriteElementString("FinalValue", finalValue.ToString());
    writer.WriteEndElement();
}

void abc(string operationId, double finalValue)
{
    XmlWriterSettings settings = new XmlWriterSettings();
    settings.Indent = true;
    using (XmlWriter writer = XmlWriter.Create(@"Products.xml", settings))
    {

        writer.WriteStartDocument();
        writer.WriteComment("This file is generated by the program.");
        writer.WriteStartElement("Maths");
        WriteBookData(writer, operationId,finalValue);
        writer.WriteEndElement();
        writer.WriteEndDocument();
        writer.Flush();


    }
}

//foreach (var item in GetXmlString())
//{
//    //abc(item.FirstName, item.LastName, item.Title, item.Division, GetXmlString().Operations.Count);
//    Console.WriteLine(item);
//}

//abc(GetXmlString().Operations);

//foreach (var item in GetJsonString().Operations)
//{
//    //abc(item.FirstName, item.LastName, item.Title, item.Division, GetXmlString().Operations.Count);
//    Console.WriteLine(item.FirstName);
//}

//foreach(var a in GetXmlString())
//{
//    Console.WriteLine(a);
//}
GetXmlString();
//abc("Plus",3);



