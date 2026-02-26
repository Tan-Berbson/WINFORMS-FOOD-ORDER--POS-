using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Data;

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
            public bool UsernameExistsAdmin(string username)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM ADMINACC WHERE USERNAME = @UA";
                   
                    SqliteCommand cmd = new SqliteCommand(query, con);
                    cmd.Parameters.AddWithValue("@UA", username);

                    con.Open();
                    long resut = (long)cmd.ExecuteScalar();
                    return resut == 1;
                }
            }
            public bool UsernameExistsCashier(string username)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM CASHIERACC WHERE USERNAME = @UA";

                    SqliteCommand cmd = new SqliteCommand(query, con);
                    cmd.Parameters.AddWithValue("@UA", username);

                    con.Open();
                    long resut = (long)cmd.ExecuteScalar();
                    return resut == 1;
                }
            }

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
                if (UsernameExistsAdmin(username))
                    return false;
                if (UsernameExistsCashier(username))
                    return false;
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
            public bool logincashier(string username, string password)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM CASHIERACC WHERE USERNAME = @U AND PASSWORD = @P";
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
            public bool signupcashier(string adminusername, string username,string password) 
            {
                if (UsernameExistsAdmin(username))
                    return false;
                if (UsernameExistsCashier(username))
                    return false;
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "INSERT INTO CASHIERACC (ADMINUSERNAME, USERNAME, PASSWORD) VALUES (@AU,@U,@P)";
                    using (SqliteCommand cmd = new SqliteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AU", adminusername);
                        cmd.Parameters.AddWithValue("@U", username);
                        cmd.Parameters.AddWithValue("@P", password);
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            private int GetNextProductId(SqliteConnection con)
            {
                using (var cmd = new SqliteCommand(
                    "SELECT IFNULL(MAX(id), 0) + 1 FROM PRODUCTS", con))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            public int GetProductCountByAdmin(string adminname)
            {
                using (var con = db.GetConnection())
                {
                    con.Open();
                    using (var cmd = new SqliteCommand(
                        "SELECT COUNT(*) FROM PRODUCTS WHERE ADMINNAME = @A", con))
                    {
                        cmd.Parameters.AddWithValue("@A", adminname);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            public bool InsertProduct(string adminname, string imagePath, string productname, string productprice)
            {
                using (SqliteConnection connection = db.GetConnection())
                {
                    connection.Open();

                    

                    int nextId = GetNextProductId(connection);

                    string query =
                        "INSERT INTO PRODUCTS (id, ADMINNAME, PRODUCTIMAGE, PRODUCTNAME, PRODUCTPRICE) " +
                        "VALUES (@ID, @A, @IMG, @P, @PR)";

                    using (SqliteCommand cmd = new SqliteCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", nextId);
                        cmd.Parameters.AddWithValue("@A", adminname);
                        cmd.Parameters.AddWithValue("@IMG", File.ReadAllBytes(imagePath));
                        cmd.Parameters.AddWithValue("@P", productname);
                        cmd.Parameters.AddWithValue("@PR", productprice);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            public class produtlist
            {
                public int ProductID { get; set; }   // DB id (internal)
                public int DisplayNumber { get; set; } // UI number (1–10)
                public byte[] ProductImage { get; set; }
                public string ProductName { get; set; }
                public string Productprice { get; set; }
                public string ProductNumber => $"ProductNumber#{DisplayNumber}";

            }
            public List<produtlist> loadproducts(string manager)
            {
                List<produtlist> products = new List<produtlist>();

                using (SqliteConnection connection = db.GetConnection())
                {
                    string query =
                        "SELECT id, PRODUCTIMAGE, PRODUCTNAME, PRODUCTPRICE " +
                        "FROM PRODUCTS WHERE ADMINNAME = @A ORDER BY id";

                    SqliteCommand cmd = new SqliteCommand(query, connection);
                    cmd.Parameters.AddWithValue("@A", manager);

                    connection.Open();
                    SqliteDataReader reader = cmd.ExecuteReader();

                    int displayCounter = 1; // 🔥 START FROM 1

                    while (reader.Read())
                    {
                        products.Add(new produtlist
                        {
                            ProductID = Convert.ToInt32(reader["id"]), // DB id
                            DisplayNumber = displayCounter++,          // UI number
                            ProductImage = (byte[])reader["PRODUCTIMAGE"],
                            ProductName = reader["PRODUCTNAME"].ToString(),
                            Productprice = reader["PRODUCTPRICE"].ToString()
                        });
                    }
                }

                return products;

            }
            public SqliteDataReader loadProductsByAdmin(string adminname)
            {
                SqliteConnection con = db.GetConnection();
                con.Open();

                SqliteCommand cmd = con.CreateCommand();
                cmd.CommandText =
                    "SELECT id, PRODUCTIMAGE, PRODUCTNAME, PRODUCTPRICE " +
                    "FROM PRODUCTS " +
                    "WHERE ADMINNAME = @A " +
                    "ORDER BY id";

                cmd.Parameters.AddWithValue("@A", adminname);

                return cmd.ExecuteReader();
            }
            public string loadmanagername(string username)
            {
                using (SqliteConnection conn = db.GetConnection())
                {
                    SqliteCommand cmd = new SqliteCommand(
                        "SELECT ADMINUSERNAME FROM CASHIERACC WHERE USERNAME=@U", conn);

                    cmd.Parameters.AddWithValue("@U", username);
                    conn.Open();

                    return cmd.ExecuteScalar()?.ToString();
                }
            }

        }

    }
}
