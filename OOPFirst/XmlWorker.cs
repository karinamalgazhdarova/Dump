using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOPFirst
{
    class XmlWorker
    {
  public static void createXMLForPassenger(Passenger pass, String filePath)
        {
     
            var xmlSerializer = new XmlSerializer(typeof(Passenger));
            var stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, pass);
            string xml = stringWriter.ToString();
            File.WriteAllText(filePath, xml);

        }


  public static void  readXMLForPassenger()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Passenger));

            StreamReader reader = new StreamReader("pass.xml");
            Passenger pass = (Passenger)serializer.Deserialize(reader);
            reader.Close();

            Console.WriteLine($"{pass.firstName} {pass.lastName} {pass.dateOfBirthDay}{pass.ageCategory}{pass.pasportNum}{pass.sex}");

        }

    }
}
