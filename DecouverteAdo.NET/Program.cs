using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Console;
using System.Configuration;
using System.Linq.Expressions;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DecouverteAdo.NET
{
    class Program
    {
        static void Main()
        {
            // se connecter à la base de donnée
            try
            {
                using SqlConnection connection = new SqlConnection
                {
                    //connection.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=DbExample;Trusted_Connection=True;";
                    ConnectionString = @"Server=51.178.46.82,1533;Initial Catalog=FormationCSharpSQL;Persist Security Info=False;User ID=FormationCSharpSQL;Password=FormationCSharp&SQL;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;"
                };

                connection.Open();


                // ExecuteScalar
                using (SqlCommand command = connection.CreateCommand())
                {
                    WriteLine("Quel id de client ?");
                    string id = ReadLine();

                    command.CommandText = " SELECT FirstName, Name" +
                                          " FROM Customers" +
                                          " WHERE Id=" + id;


                    object retourExecScalar = command.ExecuteScalar();
                    if (retourExecScalar != null)
                    {
                        string firstNameRead = (string)retourExecScalar;
                        WriteLine($"prenom lu : {retourExecScalar}");
                    }
                    else
                    {
                        WriteLine("id client inconnu");
                    }
                }

                // ExecuteReader
                using (SqlCommand command = connection.CreateCommand())
                {
                    WriteLine("Jusqu'à quel id lister les clients?");
                    string id = ReadLine();

                    command.CommandText = " SELECT Id, FirstName, Name" +
                                          " FROM Customers" +
                                          " WHERE Id<" + id;

                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int currentId = (int)reader["Id"];
                        string currentName = (string)reader["Name"];
                        string currentFirstName = (string)reader["FirstName"];
                        WriteLine($"id {currentId} : {currentFirstName} {currentName}");
                    }
                }

                // ExecuteNonQuery
                using (SqlCommand command = connection.CreateCommand())
                {
                    Console.WriteLine("Entrer le nom à ajouter : ");
                    var name = Console.ReadLine();
                    Console.WriteLine("Entrer le prénom à ajouter : ");
                    var firstname = Console.ReadLine();
                    Console.WriteLine("Entrer l'email à ajouter : ");
                    var email = Console.ReadLine();
                    Console.WriteLine("Entrer la date de naissance à ajouter : ");
                    var birthDay = Console.ReadLine();

                    command.CommandText =
                        $" INSERT INTO Customers (FirstName, Name, Email, BirthDay)" +
                        $" VALUES ('{firstname}','{name}', '{email}', '{birthDay}')";


                    //command.CommandText =
                    //    $" UPDATE Customers" +
                    //    $" SET FirstName = '{firstname}'" +
                    //    $", Name = '{name}'" +
                    //    $"WHERE id = 3 ";

                    int updatesNumber = command.ExecuteNonQuery();
                    WriteLine($"{updatesNumber} client MAJ");
                }


                // procédure stockée
                using (SqlCommand command = new SqlCommand("StoredProcExample", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.ExecuteNonQuery();
                }


            }
            catch (SqlException e)
            {
                WriteLine("Erreur SQL");
                WriteLine(e.Message);

            }
            catch (Exception e)
            {
                WriteLine("Erreur non SQL");
                WriteLine(e.Message);
            }
            finally
            {
                ReadLine();
            }
        }
    }
}
