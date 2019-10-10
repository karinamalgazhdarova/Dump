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
            //XmlSerializer serializer = new XmlSerializer(typeof(Passenger));
            //TextWriter writer = new StreamWriter(fileName);
            //serializer.Serialize(writer, pass);
            //writer.Close();

            
            var xmlSerializer = new XmlSerializer(typeof(Passenger));
            var stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, pass);
            string xml = stringWriter.ToString();
            File.WriteAllText(filePath, xml);


        }


  public static void  readXMLForPassenger()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Passenger));

            StreamReader reader = new StreamReader("pass.txt");
            Passenger pass = (Passenger)serializer.Deserialize(reader);
            reader.Close();

            
        }

    }
}
