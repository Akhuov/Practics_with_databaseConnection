using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practics_with_databaseConnection
{
    static public class Servis
    {
        public static string connectionString = "Server = localhost;Port=5432;User Id=postgres;Password = password;Database=butcamp";
        

        public static void GetById(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var sqlQuerry = $"Select * from public.reseption where personid = {id}";
                var result = connection.QueryFirstOrDefault<PersonClient>(sqlQuerry);
                if (result != null)
                Console.WriteLine($"{result.PersonId} {result.FirstName} {result.LastName} ");
                else
                    Console.WriteLine($"Client not found");
            }
        }

        static public void AddNewClient()
        {
            try
            {
                // personid,  lastname,  firstname, phonenumber, qual,amount,  paid,  unpaid,  status,  indate,  outdate
                Console.WriteLine("[ID] [First Name] [Last Name] [PhoneNumber] [Quality] [amount] [paid]");
                string[] newClientInfo = Console.ReadLine().Split();
                var newClient = new PersonClient(int.Parse(newClientInfo[0]), newClientInfo[1], newClientInfo[2], newClientInfo[3], int.Parse(newClientInfo[4]), int.Parse(newClientInfo[5]), int.Parse(newClientInfo[6]), (int.Parse(newClientInfo[5])) - (int.Parse(newClientInfo[6])) , "NotReady",DateTime.Now.ToString("dd.mm.yy"),"");
                using (var con = new NpgsqlConnection(connectionString))
                {
                    var sqlQuery = "INSERT INTO public.reseption VALUES(@PersonId,@FirstName,@LastName,@PhoneNumber,@Quality,@Amount,@Paid,@Unpaid,@InDate,'',@Status)";
                    con.Execute(sqlQuery, newClient);
                }
            }
            catch
            {
                Console.WriteLine("Error!!");
            }
        }


        static public void DeleteAll()
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"DELETE From public.reseption";
                var s = con.QueryFirstOrDefault(sqlQuery);
                if (s != null)
                {
                    Console.WriteLine("Client Deleted by FirstName!");
                }
                else { Console.WriteLine("Client not found!"); }
            }
        }

        static public void DeleteById(int id)
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"DELETE From public.reseption WHERE personid = {id}";
                var s = con.QueryFirstOrDefault(sqlQuery);
                if (s != null)
                {
                    Console.WriteLine("Client Deleted by ID");
                }
                else { Console.WriteLine("Client not found!"); }

            }
        }

        static public void DeleteByName(string name)
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"DELETE From public.reseption WHERE firstname = '{name}'";
                var s = con.QueryFirstOrDefault(sqlQuery);
                if (s != null)
                {
                    Console.WriteLine("Client Deleted by FirstName!");
                }
                else { Console.WriteLine("Client not found!"); }
            }
        }

        static public void GetByName(string name)
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"SELECT * From public.reseption WHERE firstname = '{name}'";
                var clients = con.Query<PersonClient>(sqlQuery);
                foreach (var client in clients)
                {
                    Console.WriteLine($"{client.FirstName} {client.LastName} {client.PhoneNumber} {client.InDate}");
                }
            }
        }

        static public void UpdateStatusById(int id)
        {
            using (var con = new NpgsqlConnection(connectionString))
            {
                var sqlQuery = $"UPDATE public.reseption SET  status = 'Ready' WHERE personid = {id};";
                var client = con.Query<PersonClient>(sqlQuery);
                if(client != null)
                    Console.WriteLine("Status Updated!!");
                else
                    Console.WriteLine("Error!!");
            }
        }
    }
}
