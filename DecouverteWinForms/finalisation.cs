using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Diagnostics;

namespace DecouverteWinForms
{
    class finalisation
    {
        public static void Methode()
        {
            // se connecter à la base de donnée
            try
            {
                int toto = 4;
                using (SqlConnection connection = new SqlConnection())
                {

                    //connection.ConnectionString = @"Server=localhost\SQLEXPRESS;Database=DbExample;Trusted_Connection=True;";
                    connection.ConnectionString = @"Server=51.178.46.82,1533;Initial Catalog=FormationCSharpSQL;Persist Security Info=False;User ID=FormationCSharpSQL;Password=FormationCSharp&SQL;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False;Connection Timeout=30;";


                    connection.Open();


                    // ExecuteScalar
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        Console.WriteLine("Quel id de client ?");
                        string id = Console.ReadLine();

                        command.CommandText = " SELECT FirstName, Name" +
                                                          " FROM Customers" +
                                                          " WHERE Id=" + id;


                        object retourExecScalar = command.ExecuteScalar();
                        if (retourExecScalar != null)
                        {
                            string firstNameRead = (string)retourExecScalar;
                            Console.WriteLine($"prenom lu : {retourExecScalar}");
                        }
                        else
                        {
                            Console.WriteLine("id client inconnu");
                        }
                    }

                    // ExecuteReader
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        Console.WriteLine("Jusqu'à quel id lister les clients?");
                        string id = Console.ReadLine();

                        command.CommandText = " SELECT Id, FirstName, Name" +
                                              " FROM Customers" +
                                              " WHERE Id<" + id;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int currentId = (int)reader["Id"];
                                string currentName = (string)reader["Name"];
                                string currentFirstName = (string)reader["FirstName"];
                                Console.WriteLine($"id {currentId} : {currentFirstName} {currentName}");
                            }
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
                        Console.WriteLine($"{updatesNumber} client MAJ");
                    }


                    // procédure stockée
                    using (SqlCommand command = new SqlCommand("StoredProcExample", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine("Erreur SQL");
                Console.WriteLine(e.Message);

            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur non SQL");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }


    public class ExampleClass
    {
        Stopwatch sw;

        public ExampleClass()
        {
            sw = Stopwatch.StartNew();
            Console.WriteLine("Instantiated object");
        }

        public void ShowDuration()
        {
            Console.WriteLine("This instance of {0} has been in existence for {1}",
                              this, sw.Elapsed);
        }

        ~ExampleClass()
        {
            Console.WriteLine("Finalizing object");
            sw.Stop();
            Console.WriteLine("This instance of {0} has been in existence for {1}",
                              this, sw.Elapsed);
        }
    }   
}

