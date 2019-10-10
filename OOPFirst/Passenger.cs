using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace OOPFirst
{   
    
    public enum AgeCategory : byte { SmallChild = 1, Child, Teen, Adult, Pensioner };

    [Serializable, XmlRoot("Passenger")]
    public class Passenger
    {   [XmlElement("firstname")]
        String firstName { get; set; }
        [XmlElement("lastName")]
        String lastName { get; set; }
        [XmlElement("secondName")]
        String secondName { get; set; }
        [XmlElement("pasportSeria")]
        short pasportSeria { get; set; }
        [XmlElement("pasportNum")]
        int pasportNum { get; set; }
        [XmlElement("sex")]
        bool sex { get; set; }
        [XmlElement("AgeCategory")]
        AgeCategory ageCategory { get; set; }
        [XmlElement("dateOfBirthDay")]
        DateTime dateOfBirthDay { get; set; }

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
