using Dapper;
using Npgsql;
using Practics_with_databaseConnection;
using System.Text.RegularExpressions;



//Servis.AddNewClient();
//Servis.DeleteById(3322);
//Servis.DeleteByName("Giyosiddin");
//Servis.GetByName("Maftuna");
//Servis.UpdateStatusById(1235);









/* <<<<--------------------------------------------------- ( (  1  ) ) --------------------------------------------------->>>> */


//var connectionS = "Server = localhost;Port=5432;User Id=postgres;Password = password;Database=butcamp";
//using(var con = new NpgsqlConnection(connectionS))
//{
//    string sql = "Select * from reseption";
//    var users = con.Query<PersonClient>(sql);
//    foreach (var user in users)
//    {
//        Console.WriteLine($"{user.PersonId} {user.FirstName} {user.LastName} {user.Amount} {user.Status}");
//    }
//    var newUser = new PersonClient()
//    {
//        PersonId = 1321,
//        FirstName = "Giyosiddin",
//        LastName = "Valiyev",
//        PhoneNumber = "+998997654321",
//        Quality = 5,
//        Amount = 300000,
//        Paid = 150000,
//        UnPaid = 150000,
//        Status = "NotReady",
//        InDate = "13.09.22",
//};

//var sqlQuery = "INSERT INTO public.reseption VALUES(@PersonId,@FirstName,@LastName,@PhoneNumber,@Quality,@Amount,@Paid,@Unpaid,@InDate,'',@Status)";
//con.Execute(sqlQuery, newUser);

//}


/* <<<<--------------------------------------------------- ( (  2  ) ) --------------------------------------------------->>>> */
//var con = new NpgsqlConnection(connectionS);
//con.Open();
//using var cmd = con.CreateCommand();
//cmd.Connection = con;
//var result = GetBySubject();
//Console.WriteLine();
//foreach (var user in result)
//{
//    Console.WriteLine($"{user.PersonId} {user.FirstName} {user.LastName} {user.Amount}");
//}
//IEnumerable<PersonClient> GetBySubject()
//{
//    cmd.CommandText = "Select * From reseption";
//    NpgsqlDataReader reader = cmd.ExecuteReader();
//    var result = new List<PersonClient>();
//    while (reader.Read())
//    {
//        result.Add(new PersonClient(Convert.ToInt32(reader[0]), reader[1] as string, reader[2] as string, reader[3] as string, Convert.ToInt32(reader[4]), Convert.ToInt32(reader[5]), Convert.ToInt32(reader[6]), Convert.ToInt32(reader[7]),reader[8] as string,reader[9] as string,reader[10] as string ));
//    }
//    return result;
//}
