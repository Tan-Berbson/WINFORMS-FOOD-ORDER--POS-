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
                    using (SqliteCommand cmd = new SqliteCommand(query, con))
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
            public bool signupcashier(string adminusername, string username, string password)
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

            public class salesreport
            {

                public string CashierName { get; set; }
                public string CustomerName { get; set; }

                public string OrderID { get; set; }
                public string PaymentMethod { get; set; }
                public string OrderTotal { get; set; }
                public string CustomerMoney { get; set; }
                public string CustomerChange { get; set; }
            }
            public bool cashiertotalsell(string cashiername, string customername, string orderid,
 string paymentmethod, string ordertotal, string customermoney, string customerchange)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = @"INSERT INTO CASHIERSELLS 
        (CASHIERNAME, CUSTOMERNAME, ORDERID, PAYMENTMETHOD, ORDERTOTAL, CUSTOMERMONEY, CUSTOMERCHANGE, CREATEDATE) 
        VALUES (@CN,@CUN,@OID,@PM,@OT,@CM,@CC,@CD)";

                    SqliteCommand cmd = new SqliteCommand(query, con);

                    cmd.Parameters.AddWithValue("@CN", cashiername.Trim());
                    cmd.Parameters.AddWithValue("@CUN", customername.Trim());
                    cmd.Parameters.AddWithValue("@OID", orderid.Trim());
                    cmd.Parameters.AddWithValue("@PM", paymentmethod.Trim());
                    cmd.Parameters.AddWithValue("@OT", ordertotal.Trim());
                    cmd.Parameters.AddWithValue("@CM", customermoney.Trim());
                    cmd.Parameters.AddWithValue("@CC", customerchange.Trim());
                    cmd.Parameters.AddWithValue("@CD", DateTime.Now.ToString("yyyy-MM-dd"));

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            public List<salesreport> loadSalesReportBycashier(string cashiername)
            {
                List<salesreport> salesReports = new List<salesreport>();
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "SELECT CASHIERNAME,CUSTOMERNAME, ORDERID, PAYMENTMETHOD, ORDERTOTAL, CUSTOMERMONEY, CUSTOMERCHANGE FROM CASHIERSELLS WHERE CASHIERNAME = @CN";
                    SqliteCommand cmd = new SqliteCommand(query, con);
                    cmd.Parameters.AddWithValue("@CN", cashiername);

                    con.Open();
                    SqliteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        salesReports.Add(new salesreport
                        {
                            CashierName = reader["CASHIERNAME"].ToString(),
                            CustomerName = reader["CUSTOMERNAME"].ToString(),
                            OrderID = reader["ORDERID"].ToString(),
                            PaymentMethod = reader["PAYMENTMETHOD"].ToString(),
                            OrderTotal = reader["ORDERTOTAL"].ToString(),
                            CustomerMoney = reader["CUSTOMERMONEY"].ToString(),
                            CustomerChange = reader["CUSTOMERCHANGE"].ToString()
                        });
                    }
                    return salesReports;

                }

            }
            public void DeleteSales()
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    con.Open();

                    string query = "DELETE FROM CASHIERSELLS";

                    SqliteCommand cmd = new SqliteCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
            }
            public class cashieraccount
            {
                public string cashiername { get; set; }
                public string password { get; set; }
                public string totalsells { get; set; }
                public string evaluation { get; set; }
                public string reportdate { get; set; }
            }
            public bool insertcashierreport(string cashiername, string totalsells, string evaluation, string createdat)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "INSERT INTO CASHIEREPORT (CASHIERNAME , TOTALSELLS, EVALUATION, CREATEDATE) VALUES (@CN, @TS, @E,@CA)";
                    SqliteCommand cmd = new SqliteCommand(query, con);
                    cmd.Parameters.AddWithValue("@CN", cashiername);
                    cmd.Parameters.AddWithValue("@TS", totalsells);
                    cmd.Parameters.AddWithValue("@E", evaluation);
                    cmd.Parameters.AddWithValue("@CA", createdat);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            public List<cashieraccount> loadcashieraccount(string adminname)
            {
                List<cashieraccount> account = new List<cashieraccount>();
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "SELECT USERNAME, PASSWORD FROM CASHIERACC WHERE ADMINUSERNAME = @AD";
                    SqliteCommand cmd = new SqliteCommand(query, con);
                    cmd.Parameters.AddWithValue("@AD", adminname);

                    con.Open();
                    SqliteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        account.Add(new cashieraccount
                        {
                            cashiername = reader["USERNAME"].ToString(),
                            password = reader["PASSWORD"].ToString()

                        });

                    }
                    return account;

                }
            }
            public List<cashieraccount> loadcashierreport(string cashiername)
            {
                List<cashieraccount> account = new List<cashieraccount>();
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "SELECT CASHIERNAME, TOTALSELLS, EVALUATION, CREATEDATE FROM CASHIEREPORT WHERE CASHIERNAME = @CN";
                    SqliteCommand cmd = new SqliteCommand(query, con);
                    cmd.Parameters.AddWithValue("@CN", cashiername);
                    con.Open();
                    SqliteDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        account.Add(new cashieraccount
                        {
                            cashiername = reader["CASHIERNAME"].ToString(),
                            totalsells = reader["TOTALSELLS"].ToString(),
                            evaluation = reader["EVALUATION"].ToString(),
                            reportdate = reader["CREATEDATE"].ToString()
                        });
                    }
                    return account;
                }


            }
            // Sa auth class
            public DataTable GetSales(string filter, int year)
            {
                DataTable dt = new DataTable();
                using (SqliteConnection con = db.GetConnection())
                {
                    string query = "";

                    if (filter == "day")
                    {
                        query = @"SELECT CREATEDATE AS Period, TOTALSELLS AS TotalSales
                      FROM CASHIEREPORT
                      WHERE strftime('%Y', CREATEDATE) = @Y
                      ORDER BY CREATEDATE ASC";
                    }
                    else if (filter == "week")
                    {
                        query = @"SELECT strftime('%W', CREATEDATE) AS Period, SUM(CAST(TOTALSELLS AS REAL)) AS TotalSales
                      FROM CASHIEREPORT
                      WHERE strftime('%Y', CREATEDATE) = @Y
                      GROUP BY Period
                      ORDER BY Period ASC";
                    }
                    else if (filter == "month")
                    {
                        query = @"SELECT strftime('%m', CREATEDATE) AS Period, SUM(CAST(TOTALSELLS AS REAL)) AS TotalSales
                      FROM CASHIEREPORT
                      WHERE strftime('%Y', CREATEDATE) = @Y
                      GROUP BY Period
                      ORDER BY Period ASC";
                    }
                    else if (filter == "year")
                    {
                        query = @"SELECT strftime('%Y', CREATEDATE) AS Period, SUM(CAST(TOTALSELLS AS REAL)) AS TotalSales
                      FROM CASHIEREPORT
                      GROUP BY Period
                      ORDER BY Period ASC";
                    }

                    SqliteCommand cmd = new SqliteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Y", year.ToString());

                    con.Open();
                    dt.Load(cmd.ExecuteReader());
                }
                return dt;
            }
        }


    }
}
