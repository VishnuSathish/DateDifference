using DOB.DBHelper;
using DOB.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace DOB.Model
{
    [XmlInclude(typeof(Pet))]
    [Serializable]
    public class PersonDetails : IDatabaseOperation
    {
        public string Name { get; set; }

        public DateTime Dob { get; set; }

        public Age Age { get; set; }

        public PersonDetails(string name, DateTime dob)
        {
            this.Name = name;
            this.Dob = dob;
            this.Age = new Age(dob);
        }

        public PersonDetails()
        {
        }

        public void Write(List<PersonDetails> person)
        {

            List<PersonDetailsDBHelper> lst = new List<PersonDetailsDBHelper>();
            foreach (var item in person)
            {
                lst.Add(new PersonDetailsDBHelper
                {
                    Name = item.Name,
                    Dob = item.Dob,
                    Age = new DBHelper.Age(item.Age.Years)
                });
            }

            PersonDetailsDBHelper.Write(lst);
        }

        public void Read()
        {
            List<PersonDetailsDBHelper> lst = new List<PersonDetailsDBHelper>();
            List<PersonDetails> person = new List<PersonDetails>();
            foreach (var item in person)
            {
                lst.Add(new PersonDetailsDBHelper
                {
                    Name = item.Name,
                    Dob = item.Dob,
                    Age = new DBHelper.Age(item.Age.Years)
                });
            }
            PersonDetailsDBHelper personDB = new PersonDetailsDBHelper();
            personDB.Read();

        }
    }
}
