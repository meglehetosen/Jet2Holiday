using System;
using System.Data.SqlClient;

namespace SqlLoginDebug
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var candidates = new[]
            {
                @"Data Source=localhost\SQLEXPRESS;Persist Security Info=True;User ID=Jet2HolidaySQLUser;Password=legyen5os@;Encrypt=True;TrustServerCertificate=True;",
                @"Data Source=.\SQLEXPRESS;Persist Security Info=True;User ID=Jet2HolidaySQLUser;Password=legyen5os@;Encrypt=True;TrustServerCertificate=True;",
                @"Data Source=(local)\SQLEXPRESS;Persist Security Info=True;User ID=Jet2HolidaySQLUser;Password=legyen5os@;Encrypt=True;TrustServerCertificate=True;",
                @"Data Source=localhost\SQLEXPRESS;Initial Catalog=master;Persist Security Info=True;User ID=Jet2HolidaySQLUser;Password=legyen5os@;Encrypt=True;TrustServerCertificate=True;",
                @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Persist Security Info=True;User ID=Jet2HolidaySQLUser;Password=legyen5os@;Encrypt=True;TrustServerCertificate=True;",
                @"Data Source=(local)\SQLEXPRESS;Initial Catalog=master;Persist Security Info=True;User ID=Jet2HolidaySQLUser;Password=legyen5os@;Encrypt=True;TrustServerCertificate=True;",
                @"Server=localhost\SQLEXPRESS;Database=master;User Id=Jet2HolidaySQLUser;Password=legyen5os@;Trusted_Connection=False;Encrypt=True;TrustServerCertificate=True;",
                @"Server=.\SQLEXPRESS;Database=master;User Id=Jet2HolidaySQLUser;Password=legyen5os@;Trusted_Connection=False;Encrypt=True;TrustServerCertificate=True;"
            };

            foreach (var cs in candidates)
            {
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine(cs);

                try
                {
                    using (var conn = new SqlConnection(cs))
                    {
                        conn.Open();

                        using (var cmd = new SqlCommand("SELECT @@SERVERNAME, DB_NAME()", conn))
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("SIKER");
                                Console.WriteLine("Server: " + Convert.ToString(reader[0]));
                                Console.WriteLine("DB    : " + Convert.ToString(reader[1]));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("HIBA");
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine();
            }

            Console.WriteLine("Vege.");
            Console.ReadKey();
        }
    }
}

