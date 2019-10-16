using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace OOPFirst
{
    class Jsonworker
    {
        public static void savePassengerToFileAsJSON (Passenger passenger)
        {
            DataContractJsonSerializer serializer =
                new DataContractJsonSerializer(typeof(Passenger));

            MemoryStream memoryStream = new MemoryStream();
            serializer.WriteObject(memoryStream, passenger);

            memoryStream.Position = 0;
            StreamReader reader = new StreamReader(memoryStream);
            String jsonContent = reader.ReadToEnd();

            using (FileStream fileStream =
                new FileStream("JsonPassenger.json", FileMode.Create))
            {
                TextWriter textWriter = new StreamWriter(fileStream);
                textWriter.WriteLine(jsonContent);
                textWriter.Flush();
                textWriter.Close();
            }
        }

        public static Passenger getPassenerFromJSONFile()
        {
            TextReader reader = new StreamReader("JsonPassenger.json");
            string jsonContent = reader.ReadToEnd();

            DataContractJsonSerializer serializer =
                new DataContractJsonSerializer(typeof(Passenger));
            MemoryStream memoryStream =
                new MemoryStream(Encoding.Unicode.GetBytes(jsonContent));

            Passenger passenger = (Passenger)serializer.ReadObject(memoryStream);

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine(passenger);

            return passenger;

        }
    }
}
