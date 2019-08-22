using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DOB.DBHelper
{
    public class PersonDetailsDBHelper
    {
        public string Name { get; set; }

        public DateTime Dob { get; set; }

        public Age Age { get; set; }



        public static void Write(List<PersonDetailsDBHelper> listPerson)
        {
            SqlConnection connection = new SqlConnection("Data source=DEV31;Initial Catalog=DateOfBirth;User Id=sa;Password=!QAZ2wsx;");
            using (SqlCommand cmd = new SqlCommand("InsertIntoTablePersonDetails", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@PersonName", SqlDbType.VarChar);
                cmd.Parameters.Add("@PersonDob", SqlDbType.Date);
                cmd.Parameters.Add("@PersonAge", SqlDbType.Int);

                connection.Open();
                foreach (var item in listPerson)
                {
                    cmd.Parameters["@PersonName"].Value = item.Name;
                    cmd.Parameters["@PersonDob"].Value = item.Dob;
                    cmd.Parameters["@PersonAge"].Value = item.Age.Years;
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void Read()
        {
            SqlConnection connection = new SqlConnection("Data source=DEV31;Initial Catalog=DateOfBirth;User Id=sa;Password=!QAZ2wsx;");
            connection.Open();
            SqlCommand cmd = new SqlCommand("ReadFromTablePersonDetails", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("\nPersons' table has the following entries :\n");
                while (reader.Read())
                {
                    Console.WriteLine("Name : {0}\t Dob : {1}\t Age : {2} years\n", reader.GetString(1), reader.GetDateTime(2), reader.GetInt32(3));
                }
            }
            else
            {
                Console.WriteLine("\nPersons' Table is empty\n");
            }
            connection.Close();
        }

        
    }
    public class Age
    {
        public int Years { get; set; }
        public int Months { get; set; }
        public int Days { get; set; }

        public Age(int Years)
        {
            this.Years = Years;
        }
    }


}
