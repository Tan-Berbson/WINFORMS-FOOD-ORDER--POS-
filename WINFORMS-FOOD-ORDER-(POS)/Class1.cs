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
            public bool DeleteProduct(int productId, string adminName)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    // Must match both the ID and the Admin Name for security
                    string query = "DELETE FROM PRODUCTS WHERE id = @ID AND ADMINNAME = @A";
                    using (SqliteCommand cmd = new SqliteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", productId);
                        cmd.Parameters.AddWithValue("@A", adminName);
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool UpdateProduct(int productId, string adminName, string name, string price, string imagePath = null)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    con.Open();
                    SqliteCommand cmd = new SqliteCommand();
                    cmd.Connection = con;

                    string query;
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        query = "UPDATE PRODUCTS SET PRODUCTNAME = @N, PRODUCTPRICE = @P, PRODUCTIMAGE = @IMG " +
                                "WHERE id = @ID AND ADMINNAME = @A";
                        cmd.Parameters.AddWithValue("@IMG", File.ReadAllBytes(imagePath));
                    }
                    else
                    {
                        query = "UPDATE PRODUCTS SET PRODUCTNAME = @N, PRODUCTPRICE = @P " +
                                "WHERE id = @ID AND ADMINNAME = @A";
                    }

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@N", name);
                    cmd.Parameters.AddWithValue("@P", price);
                    cmd.Parameters.AddWithValue("@ID", productId);
                    cmd.Parameters.AddWithValue("@A", adminName);

                    return cmd.ExecuteNonQuery() > 0;
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
            public DataTable weeksales()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("createdate", typeof(DateTime));
                dt.Columns.Add("totalsales", typeof(double));

                using (SqliteConnection con = db.GetConnection())
                {
                    con.Open();
                    string query = @"
            SELECT date(CREATEDATE) AS createdate,
                   SUM(CAST(TOTALSELLS AS REAL)) AS totalsales
            FROM CASHIEREPORT
            GROUP BY date(CREATEDATE)
            ORDER BY date(CREATEDATE)
        ";

                    using (SqliteCommand cmd = new SqliteCommand(query, con))
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime createdate = Convert.ToDateTime(reader["createdate"]);
                            double totalsales = reader["totalsales"] != DBNull.Value
                                                ? Convert.ToDouble(reader["totalsales"])
                                                : 0;
                            dt.Rows.Add(createdate, totalsales);
                        }
                    }
                }

                return dt;
            }
            private int GetNextaddsonId(SqliteConnection con)
            {
                using (var cmd = new SqliteCommand(
                    "SELECT IFNULL(MAX(id), 0) + 1 FROM ADDSON", con))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            public int GetaddsonCountByAdmin(string adminname)
            {
                using (var con = db.GetConnection())
                {
                    con.Open();
                    using (var cmd = new SqliteCommand(
                        "SELECT COUNT(*) FROM ADDSON WHERE ADMINNAME = @A", con))
                    {
                        cmd.Parameters.AddWithValue("@A", adminname);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            public bool Insertaddson(string adminname, string imagePath, string productname, string productprice)
            {
                using (SqliteConnection connection = db.GetConnection())
                {
                    connection.Open();



                    int nextId = GetNextaddsonId(connection);

                    string query =
                        "INSERT INTO ADDSON (id, ADMINNAME, ADDSONTIMAGE, ADDSONNAME, ADDSONPRICE) " +
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
            public class addsonlist
            {
                public int addsonID { get; set; }   // DB id (internal)
                public int DisplayNumber { get; set; } // UI number (1–10)
                public byte[] addsonImage { get; set; }
                public string addsonName { get; set; }
                public string addsonprice { get; set; }
                public string addsonNumber => $"ProductNumber#{DisplayNumber}";

            }
            public List<addsonlist> loadaddson(string manager)
            {
                List<addsonlist> products = new List<addsonlist>();

                using (SqliteConnection connection = db.GetConnection())
                {
                    string query =
                        "SELECT id, ADDSONTIMAGE, ADDSONNAME, ADDSONPRICE " +
                        "FROM ADDSON WHERE ADMINNAME = @A ORDER BY id";

                    SqliteCommand cmd = new SqliteCommand(query, connection);
                    cmd.Parameters.AddWithValue("@A", manager);

                    connection.Open();
                    SqliteDataReader reader = cmd.ExecuteReader();

                    int displayCounter = 1; // 🔥 START FROM 1

                    while (reader.Read())
                    {
                        products.Add(new addsonlist
                        {
                            addsonID = Convert.ToInt32(reader["id"]), // DB id
                            DisplayNumber = displayCounter++,          // UI number
                            addsonImage = (byte[])reader["ADDSONTIMAGE"],
                            addsonName = reader["ADDSONNAME"].ToString(),
                            addsonprice = reader["ADDSONPRICE"].ToString()
                        });
                    }
                }

                return products;

            }
            public SqliteDataReader loadaddsonByAdmin(string adminname)
            {
                SqliteConnection con = db.GetConnection();
                con.Open();

                SqliteCommand cmd = con.CreateCommand();
                cmd.CommandText =
                    "SELECT id, ADDSONTIMAGE, ADDSONNAME, ADDSONPRICE " +
                    "FROM ADDSON " +
                    "WHERE ADMINNAME = @A " +
                    "ORDER BY id";

                cmd.Parameters.AddWithValue("@A", adminname);

                return cmd.ExecuteReader();
            }
            public bool DeleteAddson(int addsonId, string adminName)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    // Must match both the ID and the Admin Name for security
                    string query = "DELETE FROM ADDSON WHERE id = @ID AND ADMINNAME = @A";
                    using (SqliteCommand cmd = new SqliteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", addsonId);
                        cmd.Parameters.AddWithValue("@A", adminName);
                        con.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            public bool UpdateAddson(int addsonId, string adminName, string name, string price, string imagePath = null)
            {
                using (SqliteConnection con = db.GetConnection())
                {
                    con.Open();
                    SqliteCommand cmd = new SqliteCommand();
                    cmd.Connection = con;

                    string query;
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        query = "UPDATE ADDSON SET ADDSONNAME = @N, ADDSONPRICE = @P, ADDSONIMAGE = @IMG " +
                                "WHERE id = @ID AND ADMINNAME = @A";
                        cmd.Parameters.AddWithValue("@IMG", File.ReadAllBytes(imagePath));
                    }
                    else
                    {
                        query = "UPDATE ADDSON SET ADDSONNAME = @N, ADDSONPRICE = @P " +
                                "WHERE id = @ID AND ADMINNAME = @A";
                    }

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@N", name);
                    cmd.Parameters.AddWithValue("@P", price);
                    cmd.Parameters.AddWithValue("@ID", addsonId);
                    cmd.Parameters.AddWithValue("@A", adminName);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            public DataTable GetAvailableYears()
            {
                DataTable dt = new DataTable();

                using (SqliteConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT DISTINCT strftime('%Y', CREATEDATE) AS SaleYear
                                 FROM CASHIEREPORT
                                 ORDER BY SaleYear DESC";

                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }

                return dt;
            }
            public DataTable GetMonthlySales(int year)
            {
                DataTable dt = new DataTable();

                using (SqliteConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"
               WITH months(m) AS (
SELECT 1 UNION SELECT 2 UNION SELECT 3 UNION SELECT 4
UNION SELECT 5 UNION SELECT 6 UNION SELECT 7 UNION SELECT 8
UNION SELECT 9 UNION SELECT 10 UNION SELECT 11 UNION SELECT 12
)

SELECT 
m AS MonthNumber,
IFNULL(SUM(CAST(TOTALSELLS AS REAL)),0) AS TotalSales

FROM months
LEFT JOIN CASHIEREPORT 
ON CAST(strftime('%m', CREATEDATE) AS INTEGER) = m
AND strftime('%Y', CREATEDATE) = @year

GROUP BY m
ORDER BY m
                ";

                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        

                        // TO THIS: ✅ pass as string to match strftime TEXT output
                        cmd.Parameters.AddWithValue("@year", year.ToString());

                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }

                return dt;
            }



        } // This brace ends 'pu

    }
}

