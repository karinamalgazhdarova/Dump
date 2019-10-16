//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Data;
//using System.Threading.Tasks;

//namespace OOPFirst
//{
//  public  class PassengerDAO

//    {
//        public List<Passenger> getAll()

//        {
//            List<Passenger> passengers = new List<Passenger>();

//            SqlConnection connection =
//                    new SqlConnection("Server=KARINA-PC\\SQLEXPRESS;Database=passenger;Trusted_Connection=true;");
//            connection.Open();

//            String query = "SELECT * FROM dbo.passengerairport";

//            SqlCommand command = new SqlCommand(query, connection);

//            SqlDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                passengers.Add(Passenger.createFromDataReader(reader));
         
//            }
//            connection.Close();
//            return passengers;
//        } 
   
//    }

// }