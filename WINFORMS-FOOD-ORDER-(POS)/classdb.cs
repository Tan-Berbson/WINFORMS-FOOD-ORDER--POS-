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
            }
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
        private static void CASHIERSELLS(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS CASHIERSELLS (
                        id INTEGER ,
                       
                        MANAGERNAME TEXT NOT NULL,
                        CASHIERNAME TEXT NOT NULL,
                        CUSTOMERNAME TEXT NOT NULL,
                        ORDERID TEXT NOT NULL,
                        PAYMENTMETHOD TEXT NOT NULL,
                        ORDERTOTAL TEXT NOT NULL,
                        CUSTOMERMONEY TEXT NOT NULL,
                        CUSTOMERCHANGE TEXT NOT NULL

                        
                       
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
