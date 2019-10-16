using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace OOPFirst
{   
    
    public enum AgeCategory : byte { SmallChild = 1, Child, Teen, Adult, Pensioner };
    [DataContract]
    [Serializable, XmlRoot("Passenger")]
    public class Passenger

    {
        [DataMember]
        [XmlElement("firstname")]
       public String firstName { get; set; }
        [DataMember]
        [XmlElement("lastName")]
        public String lastName { get; set; }
        [DataMember]
        [XmlElement("secondName")]
        public String secondName { get; set; }
        [XmlElement("pasportSeria")]
        [DataMember]
        public short pasportSeria { get; set; }
        [DataMember]
        [XmlElement("pasportNum")]
        public int pasportNum { get; set; }
        [DataMember]
        [XmlElement("sex")]
        public bool sex { get; set; }
        [DataMember]
        [XmlElement("AgeCategory")]
        public AgeCategory ageCategory { get; set; }
        [DataMember]
        [XmlElement("dateOfBirthDay")]
        public DateTime dateOfBirthDay { get; set; }

        public Passenger(string firstName, string lastName, string secondName, short pasportSeria, int pasportNum, bool sex, AgeCategory ageCategory, DateTime dateOfBirthDay)
        {
            this.firstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.lastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.secondName = secondName ?? throw new ArgumentNullException(nameof(secondName));
            this.pasportSeria = pasportSeria;
            this.pasportNum = pasportNum;
            this.sex = sex;
            this.ageCategory = ageCategory;
            this.dateOfBirthDay = dateOfBirthDay;
        }

        public Passenger()
        {
        }
        public static Passenger createFromDataReader(SqlDataReader reader)
        {
            return new Passenger(reader.GetString(0),
                                                     reader.GetString(1),
                                                     reader.GetString(2),
                                                     reader.GetInt16(4),
                                                     reader.GetInt16(5),
                                                     reader.GetBoolean(6),
                                                     reader.GetFieldValue<AgeCategory>(7),
                                                     reader.GetDateTime(8));
        }
        

        public override string ToString()
        {
            return String.Format("firstName: {0} \n " +
                                 "lastName: {1} \n" +
                                 "secondName: {2} \n" +
                                 "pasportSeria: {3} \n" +
                                 "pasportNum: {4} \n" +
                                 "sex: {5} \n" +
                                 "ageCategory: {6} \n" +
                                 "dateOfBirthDay: {7} \n",
                                 this.firstName,
                                 this.lastName,
                                 this.secondName,
                                 this.pasportSeria,
                                 this.pasportNum,
                                 this.sex,
                                 this.ageCategory,
                                 this.dateOfBirthDay);
        }

        
    }
}
