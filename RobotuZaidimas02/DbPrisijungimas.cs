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
        public int Svoris { get; set; }
        public string Dalis { get; set; }

        public void Gyvbe()
        {
            int gyvybe = 0;
            int kaina = 0;
            int svoris = 0;
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

                        gyvybe = (int)reader[0];
                        kaina = (int)reader[1];
                        svoris = (int)reader[2];
                        dalis = (string)reader[3];

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Gyvybe = gyvybe;
            Kaina = kaina;
            Svoris = svoris;
            Dalis = dalis;

        }

    }
}