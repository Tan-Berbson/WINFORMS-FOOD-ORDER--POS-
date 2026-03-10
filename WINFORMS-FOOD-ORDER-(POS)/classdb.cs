using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace WINFORMS_FOOD_ORDER__POS_
{
    internal class classdb
    {
        private static readonly string ConnectString = @"Data Source = WINDOWSFORMS-FOOD-ORDER-(POS).db";

        public static void Initialize()
        {
            using (var conn = new SqliteConnection(ConnectString))
            {
                conn.Open();
                ADMINACC(conn);
                PRODUCTS(conn);
                CASHIERACC(conn);
                CASHIERSELLS(conn);
                CASHIEREPORT(conn);
                ADDSON(conn);
                TESTDATA(conn);
            }
        }
        private static void TESTDATA(SqliteConnection conn)
        {
            string query = @"
    INSERT INTO CASHIEREPORT VALUES ('John','1200','Good','2026-01-10');
    INSERT INTO CASHIEREPORT VALUES ('John','1500','Good','2026-02-10');
    INSERT INTO CASHIEREPORT VALUES ('John','1800','Good','2026-03-10');
    INSERT INTO CASHIEREPORT VALUES ('John','2000','Good','2026-04-10');
    INSERT INTO CASHIEREPORT VALUES ('John','1700','Good','2026-05-10');
    INSERT INTO CASHIEREPORT VALUES ('John','2100','Good','2026-06-10');
    INSERT INTO CASHIEREPORT VALUES ('John','2400','Good','2026-07-10');
    INSERT INTO CASHIEREPORT VALUES ('John','2600','Good','2026-08-10');
    INSERT INTO CASHIEREPORT VALUES ('John','2200','Good','2026-09-10');
    INSERT INTO CASHIEREPORT VALUES ('John','3000','Good','2026-10-10');
    INSERT INTO CASHIEREPORT VALUES ('John','3500','Good','2026-11-10');
    INSERT INTO CASHIEREPORT VALUES ('John','4000','Good','2026-12-10');
    ";

            Execute(conn, query);
        }
        private static void ADMINACC(SqliteConnection conn)
         {
            string query = @"CREATE TABLE IF NOT EXISTS ADMINACC (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                USERNAME TEXT NOT NULL UNIQUE,
                                PASSWORD TEXT NOT NULL
                            );";
            Execute(conn, query);

        }
        private static void CASHIERACC(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS CASHIERACC (
                                id INTEGER PRIMARY KEY AUTOINCREMENT,
                                ADMINUSERNAME TEXT NOT NULL,
                                USERNAME TEXT NOT NULL UNIQUE,
                                PASSWORD TEXT NOT NULL
                            );";
            Execute(conn, query);

        }
        private static void PRODUCTS(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS PRODUCTS (
                        id INTEGER ,
                       
                        ADMINNAME TEXT NOT NULL,
                        PRODUCTIMAGE BLOB,
                        PRODUCTNAME TEXT NOT NULL,
                        PRODUCTPRICE TEXT NOT NULL
                       
                    );";
            Execute(conn, query);
        }
        private static void ADDSON(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS ADDSON (
                        id INTEGER ,
                       
                        ADMINNAME TEXT NOT NULL,
                        ADDSONTIMAGE BLOB,
                        ADDSONNAME TEXT NOT NULL,
                        ADDSONPRICE TEXT NOT NULL
                       
                    );";
            Execute(conn, query);
        }
        private static void CASHIERSELLS(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS CASHIERSELLS (
        CASHIERNAME TEXT NOT NULL,
        CUSTOMERNAME TEXT NOT NULL,
        ORDERID TEXT NOT NULL,
        PAYMENTMETHOD TEXT NOT NULL,
        ORDERTOTAL TEXT NOT NULL,
        CUSTOMERMONEY TEXT NOT NULL,
        CUSTOMERCHANGE TEXT NOT NULL,
        CREATEDATE TEXT NOT NULL
    );";

            Execute(conn, query);
        }
        private static void CASHIEREPORT(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS CASHIEREPORT (
                             CASHIERNAME TEXT NOT NULL,
                             TOTALSELLS TEXT NOT NULL,
                              EVALUATION TEXT NOT NULL,
                              CREATEDATE TEXT NOT NULL
                            
                         );";
            Execute(conn, query);
        }

        private static void Execute(SqliteConnection conn, string query)
        {
            using (var cmd = new SqliteCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }


    }
}
