
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOB.Model.Interfaces;
using DOB.DBHelper;

namespace DOB.Model
{
    [Serializable]
    public class Pet : PersonDetails, IDatabaseOperation
    {
        public string PetBreed { get; set; }

        public Pet(string name, string petbreed, DateTime dob) : base(name, dob)
        {
            this.PetBreed = petbreed;
        }

        public Pet()
        {
        }
        public void Write(List<PersonDetails> pet)
        {
            List<PetDBHelper> list = new List<PetDBHelper>();
            foreach (var item in pet)
            {
                var petMember = (Pet)item;
                list.Add(new PetDBHelper
                {

                    Name = item.Name,
                    Dob = item.Dob,
                    Age = new DBHelper.Age(item.Age.Years),
                    PetBreed = petMember.PetBreed
                });
            }

            PetDBHelper petDB = new PetDBHelper();
            petDB.Write(list);
        }

        public void Read()
        {
            List<PetDBHelper> list = new List<PetDBHelper>();
            List<Pet> pet = new List<Pet>();

            foreach (var item in pet)
            {
                list.Add(new PetDBHelper
                {
                    Name = item.Name,
                    Dob = item.Dob,
                    Age = new DBHelper.Age(item.Age.Years),
                    PetBreed = item.PetBreed
                });
            }
            PetDBHelper petDB = new PetDBHelper();
            petDB.Read();
        }

    }
}
