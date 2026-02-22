using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace WINFORMS_FOOD_ORDER__POS_
{
    internal class Class1
    {
        public static class db
        {
            private static readonly string ConnectString = @"Data Source = WINDOWSFORMS-FOOD-ORDER-(POS).db";
            public static SqliteConnection GetConnection()
            {
                return new SqliteConnection(ConnectString);
            }
        }
        public class auth
        {
            public bool loginadmin(string username, string password)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM ADMINACC WHERE USERNAME = @U AND PASSWORD = @P";
                    using (SqliteCommand cmd = new SqliteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@U", username);
                        cmd.Parameters.AddWithValue("@P", password);
                        con.Open();
                        long resut = (long)cmd.ExecuteScalar();
                        return resut == 1;
                    }
                }
            }
            public bool signupadmin(string username, string password)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "INSERT INTO ADMINACC (USERNAME,PASSWORD) VALUES (@U,@P)";
                    using(SqliteCommand cmd = new SqliteCommand( query, con))
                    {
                        cmd.Parameters.AddWithValue("@U", username);
                        cmd.Parameters.AddWithValue("@P", password);
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
        }

    }
}
