using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            Console.WriteLine("Pressione 1 para consulta NATIVA ou 2 para consulta via ORM...");
            Console.WriteLine("Pressione (Esc) para sair. \n");

            do
            {
                cki = Console.ReadKey();
                Console.WriteLine("Pressionado " + ((char)cki.Key).ToString());

                if (cki.Key == ConsoleKey.D1)
                {
                    var connectionString = ConfigurationManager.ConnectionStrings["PgChecklist"].ConnectionString;
                    string queryString = "SELECT id_sist, cd_sist, ds_sist, ic_sit, nm_usu_incl, dh_incl, nm_usu_ult_alt, dh_ult_alt FROM dbo.sist;";
                    using (var connection = new NpgsqlConnection(connectionString))
                    {
                        var command = new NpgsqlCommand(queryString, connection);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(String.Format("{0}, {1}", reader[0], reader[1]));
                            }
                        }
                    }
                }
                else if (cki.Key == ConsoleKey.D2)
                {
                    PgContext db = new PgContext();

                    List<CipSystem> sistemas = db.Sistemas.ToList();

                    sistemas.ForEach(p => Console.WriteLine(p.Code));                    
                }

            } while (cki.Key != ConsoleKey.Escape);

            return;

        }
    }
}