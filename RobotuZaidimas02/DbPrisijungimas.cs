using System;
using System.Data.SqlClient;

namespace KonstravimasPrisijungimas
{
    class DbPrisijungimas
    {
        string connectionString =
                "Data Source=localhost;Initial Catalog=Robots;Integrated Security=true";


        public string queryString { get; set; }
        public DbPrisijungimas(string a)
        {
            queryString = a;
        }
        public int Gyvybe { get; set; }
        public int Kaina { get; set; }
        public int Id { get; set; }
        public string Dalis { get; set; }

        public void Gyvbe()
        {
            int gyvybe = 0;
            int kaina = 0;
            int id = 0;
            string dalis = null;

            using (SqlConnection connection =
                    new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        id = (int)reader[0];
                        dalis = (string)reader[1];
                        kaina = (int)reader[2];
                        //svoris = (int)reader[2];
                        

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }   
            Id = id;
            Dalis = dalis;
            Kaina = kaina;
            //Dalis = dalis;

        }

    }
}