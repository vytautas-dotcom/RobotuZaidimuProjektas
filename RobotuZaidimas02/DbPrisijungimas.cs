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
        public int Id { get; set; }
        public string Dalis { get; set; }
        public int Galia { get; set; }
        public int Kaina { get; set; }
        public int Svoris { get; set; }

        public void Gyvbe()
        {
            int id = 0;
            string dalis = null;
            int galia = 0;
            int kaina = 0;
            int svoris = 0;

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
                        galia = (int)reader[2];
                        kaina = (int)reader[3];
                        svoris = (int)reader[4];
                        

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
            Galia = galia;
            Kaina = kaina;
            Svoris = svoris;

        }

    }
}